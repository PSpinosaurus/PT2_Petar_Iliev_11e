using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using ServiceLayer;

namespace PresentationLayer
{
    public partial class InterestsForm : Form
    {
        private Interest selectedInterest;
        private DbManager<Interest, int> interestManager = new DbManager<Interest, int>(ContextGenerator.GetInterestsContext());
        private DbManager<User, int> userManager = new DbManager<User, int>(ContextGenerator.GetUsersContext());
        private DbManager<Category, int> categoryManager = new DbManager<Category, int>(ContextGenerator.GetCategoryContext());
        private List<User> selectedInterestUsers = new List<User>();

        public InterestsForm()
        {
            InitializeComponent();
            LoadInterests();
            LoadUsers();
            LoadCategories();
            this.InterestsDataGridView.ReadOnly = true;
            this.allUsersListBox.DisplayMember = "UserName";
            this.selectedUsersListBox.DisplayMember = "UserName";
            this.categoryComboBox.DisplayMember = "Name";  // combo box readonly
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #region Events
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationManager.IsValidString(this.nameBox.Text))
                {
                    string name = this.nameBox.Text;
                    Category category = this.categoryComboBox.SelectedItem as Category;

                    List<User> users = this.selectedUsersListBox.Items.Cast<User>().ToList();

                    Interest interest = new Interest(name);
                    interest.Category = category;
                    interest.Users = users;

                    interestManager.Create(interest);
                    MessageBox.Show("Interest created!", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearBoxes();
                    selectedInterest = null;
                    this.nameBox.Focus();
                    LoadInterests();
                }
                else
                {
                    MessageBox.Show("Check that you filled all the boxes correctly!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationManager.IsValidString(this.nameBox.Text) && selectedInterest != null)
                {
                    selectedInterest.Name = this.nameBox.Text;
                    Category category = this.categoryComboBox.SelectedItem as Category;

                    List<User> users = this.selectedUsersListBox.Items.Cast<User>().ToList();

                    selectedInterest.Category = category;
                    selectedInterest.Users = users;

                    interestManager.Update(selectedInterest);
                    MessageBox.Show("Interest updated!", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearBoxes();
                    selectedInterest = null;
                    this.nameBox.Focus();
                    LoadInterests();
                }
                else
                {
                    MessageBox.Show("Check that you filled all the boxes correctly!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedInterest != null)
                {
                    interestManager.Delete(selectedInterest.Id);
                    MessageBox.Show("Interest deleted!", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearBoxes();
                    selectedInterest = null;
                    LoadInterests();
                }
                else
                {
                    MessageBox.Show("Select an interest to be deleted!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void InterestsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                MessageBox.Show("You must click in the table!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                selectedInterest = this.InterestsDataGridView.Rows[e.RowIndex].DataBoundItem as Interest;
                FillBoxes();
            }
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            this.selectedInterestUsers.Remove(this.selectedUsersListBox.SelectedItem as User);
            LoadSelectedUsers();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            this.selectedInterestUsers.Add(this.allUsersListBox.SelectedItem as User);
            LoadSelectedUsers();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            selectedInterest = null;
            ClearBoxes();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Helper Methods
        private void ClearBoxes()
        {
            this.nameBox.Clear();
            this.categoryComboBox.SelectedIndex = -1;
            this.selectedInterestUsers = new List<User>();
            this.categoryName_textbox.Clear();
            LoadSelectedUsers();
        }

        private void FillBoxes()
        {
            this.nameBox.Text = selectedInterest.Name;
            this.categoryComboBox.SelectedValue = selectedInterest.Category.Id;
            this.selectedInterestUsers = selectedInterest.Users;
            LoadSelectedUsers();
        }

        private void LoadSelectedUsers()
        {
            this.selectedUsersListBox.DataSource = this.selectedInterestUsers;
            ((CurrencyManager)this.selectedUsersListBox.BindingContext[this.selectedUsersListBox.DataSource]).Refresh();
        }

        private void LoadInterests()
        {
            this.InterestsDataGridView.DataSource = interestManager.ReadAll(true);
        }

        private void LoadUsers()
        {
            this.allUsersListBox.DataSource = userManager.ReadAll(true);
        }

        private void LoadCategories()
        {
            this.categoryComboBox.DataSource = categoryManager.ReadAll(true);
            ((CurrencyManager)this.categoryComboBox.BindingContext[this.categoryComboBox.DataSource]).Refresh();
        }
        #endregion


        private void InterestsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationManager.IsValidString(this.categoryName_textbox.Text))
                {
                    string name = this.categoryName_textbox.Text;
                    Category category = new Category(name);
                    categoryManager.Create(category);
                    MessageBox.Show("Category created!", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.categoryName_textbox.Text = null;
                }
                else
                {
                    MessageBox.Show("Type in the category name!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
