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
using Newtonsoft.Json.Bson;
using ServiceLayer;

namespace PresentationLayer
{
    public partial class UsersForm : Form
    {
        private User selectedUser;
        private DbManager<User, int> dbManager = new DbManager<User, int>(ContextGenerator.GetUsersContext());
        private DbManager<Interest, int> interestsManager = new DbManager<Interest, int>(ContextGenerator.GetInterestsContext());
        private List<User> friends = new List<User>();
        private List<Interest> interests = new List<Interest>();

        public UsersForm()
        {
            InitializeComponent();
            this.age_numBox.Minimum = 0;
            this.password_textBox.PasswordChar = '*';
            this.usersDataGrid.ReadOnly = true;
            LoadUsers();

            this.friends_listBox.DisplayMember = "FirstName";
            this.interests_listBox.DisplayMember = "Name";
            this.allusersListBox.DisplayMember = "FirstName";
            this.allInterests_listBox.DisplayMember = "Name";

            LoadFriends();
            LoadInterests();
            LoadAllUsers();
            LoadAllInterests();
        }

        #region Events
        private void UsersForm_Load(object sender, EventArgs e)
        {

        }

        private void usersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                MessageBox.Show("Please select and item from the table.");
            }
            else
            {
                selectedUser = usersDataGrid.Rows[e.RowIndex].DataBoundItem as User;
                FillBoxes();
            }
        }

        private void createUser_button_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = this.firstName_textBox.Text;
                string lastname = this.lastName_textBox.Text;
                int age = Convert.ToInt32(this.age_numBox.Value);
                string username = this.username_textBox.Text;
                string password = this.password_textBox.Text;
                string email = this.email_textBox.Text;

                if (ValidationManager.IsValidString(firstname)
                    && ValidationManager.IsValidString(lastname)
                    && ValidationManager.IsValidString(username)
                    && ValidationManager.IsValidString(password)
                    && ValidationManager.IsValidString(email))
                {
                    User user = new User(firstname, lastname, age, username, password, email);
                    List<User> friends = friends_listBox.Items.Cast<User>().ToList();
                    List<Interest> interests = interests_listBox.Items.Cast<Interest>().ToList();
                    user.Friends = friends;
                    user.Interests = interests;

                    dbManager.Create(user);
                    MessageBox.Show("User created successfully.", ".", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadUsers();
                    LoadAllUsers();
                    ClearBoxes();
                    firstName_textBox.Focus();
                    selectedUser = null;
                }
                else
                {
                    MessageBox.Show("You must enter values in all the textboxes", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void updateUser_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationManager.IsValidString(this.firstName_textBox.Text)
                    && ValidationManager.IsValidString(this.lastName_textBox.Text)
                    && ValidationManager.IsValidString(this.username_textBox.Text)
                    && ValidationManager.IsValidString(this.password_textBox.Text)
                    && ValidationManager.IsValidString(this.email_textBox.Text)
                    && selectedUser != null)
                {
                    selectedUser.FirstName = this.firstName_textBox.Text;
                    selectedUser.LastName = this.lastName_textBox.Text;
                    selectedUser.Age = Convert.ToInt32(this.age_numBox.Value);
                    selectedUser.UserName = this.username_textBox.Text;
                    selectedUser.Password = this.password_textBox.Text;
                    selectedUser.Email = this.email_textBox.Text;

                    selectedUser.Friends = friends_listBox.Items.Cast<User>().ToList();
                    selectedUser.Interests = interests_listBox.Items.Cast<Interest>().ToList();

                    dbManager.Update(selectedUser);
                    MessageBox.Show("User updated successfully.", ".", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadUsers();
                    LoadAllUsers();
                    selectedUser = null;
                    ClearBoxes();
                    firstName_textBox.Focus();
                }
                else
                {
                    MessageBox.Show("You must enter values in all the textboxes", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void deleteUser_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUser == null)
                {
                    MessageBox.Show("You must select a user to be deleted!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dbManager.Delete(selectedUser.Id);
                    MessageBox.Show("User deleted successfully!", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearBoxes();
                    selectedUser = null;
                    LoadUsers();
                    LoadAllUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            selectedUser = null;
            ClearBoxes();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void seePassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.seePassword_checkBox.Checked)
            {
                this.password_textBox.PasswordChar = '\0';
            }
            else
            {
                this.password_textBox.PasswordChar = '*';
            }
        }

        private void seePassword_checkBox_MouseHover(object sender, EventArgs e)
        {
            this.seePassword_checkBox.Text = "See the password.";
        }

        private void seePassword_checkBox_MouseLeave(object sender, EventArgs e)
        {
            this.seePassword_checkBox.Text = null;
        }

        private void RemoveInterestBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.interests_listBox.SelectedItem != null)
                {
                    interests.Remove(interests_listBox.SelectedItem as Interest);
                    LoadInterests();
                }
                else
                {
                    MessageBox.Show("You must select an interest to be removed!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void RemoveFriendBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.friends_listBox.SelectedItem != null)
                {
                    friends.Remove(friends_listBox.SelectedItem as User);
                    LoadFriends();
                }
                else
                {
                    MessageBox.Show("You must select a friend to be removed!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void AddInterestBttn_Click(object sender, EventArgs e)
        {
            try
            {
                Interest interest = allInterests_listBox.SelectedItem as Interest;
                if (interest != null && !interests.Contains(interest))
                {
                    interests.Add(interest);
                    LoadInterests();
                }
                else
                {
                    MessageBox.Show("You must select an interest that you dont already have!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void addFriendBttn_Click(object sender, EventArgs e)
        {
            try
            {
                User friend = allusersListBox.SelectedItem as User;
                if (friend != null && !friends.Contains(friend))
                {
                    friends.Add(friend);
                    LoadFriends();
                }
                else
                {
                    MessageBox.Show("You must select a friend that you dont already have!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion

        #region Helper Methods

        public void ClearBoxes()
        {
            this.firstName_textBox.Clear();
            this.lastName_textBox.Clear();
            this.age_numBox.Value = 0;
            this.username_textBox.Clear();
            this.password_textBox.Clear();
            this.email_textBox.Clear();
            this.seePassword_checkBox.Checked = false;

            friends.Clear();
            interests.Clear();
            LoadFriends();
            LoadInterests();
        }

        public void FillBoxes()
        {
            this.firstName_textBox.Text = selectedUser.FirstName;
            this.lastName_textBox.Text = selectedUser.LastName;
            this.age_numBox.Value = selectedUser.Age;
            this.username_textBox.Text = selectedUser.UserName;
            this.password_textBox.Text = selectedUser.Password;
            this.email_textBox.Text = selectedUser.Email;
            this.seePassword_checkBox.Checked = false;

            friends.Clear();
            interests.Clear();
            selectedUser.Friends.ForEach(f => friends.Add(f));
            selectedUser.Interests.ForEach(i => interests.Add(i));
            LoadFriends();
            LoadInterests();
        }

        private void LoadUsers()
        {
            this.usersDataGrid.DataSource = dbManager.ReadAll(true);
        }

        private void LoadFriends()
        {
            this.friends_listBox.DataSource = friends;
            ((CurrencyManager)this.friends_listBox.BindingContext[friends_listBox.DataSource]).Refresh();
        }

        private void LoadInterests()
        {
            this.interests_listBox.DataSource = interests;
            ((CurrencyManager)this.interests_listBox.BindingContext[interests_listBox.DataSource]).Refresh();
        }

        private void LoadAllUsers()
        {
            this.allusersListBox.DataSource = dbManager.ReadAll(true);
        }

        private void LoadAllInterests()
        {
            this.allInterests_listBox.DataSource = interestsManager.ReadAll(true);
        }
        #endregion
    }
}
