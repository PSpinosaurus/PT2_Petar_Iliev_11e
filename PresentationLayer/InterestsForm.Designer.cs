using System.Xml;

namespace PresentationLayer
{
    partial class InterestsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InterestsDataGridView = new System.Windows.Forms.DataGridView();
            NameLabel = new System.Windows.Forms.Label();
            nameBox = new System.Windows.Forms.TextBox();
            selectedUsersListBox = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            categoryComboBox = new System.Windows.Forms.ComboBox();
            allUsersListBox = new System.Windows.Forms.ListBox();
            label4 = new System.Windows.Forms.Label();
            addUserButton = new System.Windows.Forms.Button();
            removeUserButton = new System.Windows.Forms.Button();
            createButton = new System.Windows.Forms.Button();
            updateButton = new System.Windows.Forms.Button();
            deleteButton = new System.Windows.Forms.Button();
            closeButton = new System.Windows.Forms.Button();
            clearButton = new System.Windows.Forms.Button();
            createCategory_button = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            categoryName_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)InterestsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // InterestsDataGridView
            // 
            InterestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InterestsDataGridView.Location = new System.Drawing.Point(425, 12);
            InterestsDataGridView.Name = "InterestsDataGridView";
            InterestsDataGridView.RowHeadersWidth = 51;
            InterestsDataGridView.RowTemplate.Height = 29;
            InterestsDataGridView.Size = new System.Drawing.Size(600, 295);
            InterestsDataGridView.TabIndex = 0;
            InterestsDataGridView.CellClick += InterestsDataGridView_CellClick;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(47, 76);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(49, 20);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name";
            // 
            // nameBox
            // 
            nameBox.Location = new System.Drawing.Point(152, 73);
            nameBox.Name = "nameBox";
            nameBox.Size = new System.Drawing.Size(150, 27);
            nameBox.TabIndex = 2;
            // 
            // selectedUsersListBox
            // 
            selectedUsersListBox.FormattingEnabled = true;
            selectedUsersListBox.ItemHeight = 20;
            selectedUsersListBox.Location = new System.Drawing.Point(152, 224);
            selectedUsersListBox.Name = "selectedUsersListBox";
            selectedUsersListBox.Size = new System.Drawing.Size(150, 104);
            selectedUsersListBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 254);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 20);
            label1.TabIndex = 4;
            label1.Text = "Selected users";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(32, 146);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(152, 151);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 20);
            label3.TabIndex = 6;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new System.Drawing.Point(152, 143);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new System.Drawing.Size(150, 28);
            categoryComboBox.TabIndex = 7;
            // 
            // allUsersListBox
            // 
            allUsersListBox.FormattingEnabled = true;
            allUsersListBox.ItemHeight = 20;
            allUsersListBox.Location = new System.Drawing.Point(152, 385);
            allUsersListBox.Name = "allUsersListBox";
            allUsersListBox.Size = new System.Drawing.Size(150, 104);
            allUsersListBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(32, 418);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 20);
            label4.TabIndex = 9;
            label4.Text = "All users";
            // 
            // addUserButton
            // 
            addUserButton.Location = new System.Drawing.Point(308, 400);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new System.Drawing.Size(94, 61);
            addUserButton.TabIndex = 10;
            addUserButton.Text = "Add selected";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // removeUserButton
            // 
            removeUserButton.Location = new System.Drawing.Point(308, 238);
            removeUserButton.Name = "removeUserButton";
            removeUserButton.Size = new System.Drawing.Size(94, 53);
            removeUserButton.TabIndex = 11;
            removeUserButton.Text = "Remove selected";
            removeUserButton.UseVisualStyleBackColor = true;
            removeUserButton.Click += removeUserButton_Click;
            // 
            // createButton
            // 
            createButton.Location = new System.Drawing.Point(800, 333);
            createButton.Name = "createButton";
            createButton.Size = new System.Drawing.Size(94, 29);
            createButton.TabIndex = 12;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new System.Drawing.Point(800, 400);
            updateButton.Name = "updateButton";
            updateButton.Size = new System.Drawing.Size(94, 29);
            updateButton.TabIndex = 13;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new System.Drawing.Point(800, 473);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(94, 29);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new System.Drawing.Point(931, 473);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(94, 29);
            closeButton.TabIndex = 15;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new System.Drawing.Point(931, 333);
            clearButton.Name = "clearButton";
            clearButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            clearButton.Size = new System.Drawing.Size(94, 29);
            clearButton.TabIndex = 16;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // createCategory_button
            // 
            createCategory_button.Location = new System.Drawing.Point(498, 432);
            createCategory_button.Name = "createCategory_button";
            createCategory_button.Size = new System.Drawing.Size(184, 29);
            createCategory_button.TabIndex = 17;
            createCategory_button.Text = "Create new Category";
            createCategory_button.UseVisualStyleBackColor = true;
            createCategory_button.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(532, 353);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(110, 20);
            label5.TabIndex = 18;
            label5.Text = "Category name";
            // 
            // categoryName_textbox
            // 
            categoryName_textbox.Location = new System.Drawing.Point(521, 385);
            categoryName_textbox.Name = "categoryName_textbox";
            categoryName_textbox.Size = new System.Drawing.Size(136, 27);
            categoryName_textbox.TabIndex = 19;
            // 
            // InterestsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1049, 528);
            Controls.Add(categoryName_textbox);
            Controls.Add(label5);
            Controls.Add(createCategory_button);
            Controls.Add(clearButton);
            Controls.Add(closeButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(createButton);
            Controls.Add(removeUserButton);
            Controls.Add(addUserButton);
            Controls.Add(label4);
            Controls.Add(allUsersListBox);
            Controls.Add(categoryComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(selectedUsersListBox);
            Controls.Add(nameBox);
            Controls.Add(NameLabel);
            Controls.Add(InterestsDataGridView);
            Name = "InterestsForm";
            Text = "InterestsForm";
            Load += InterestsForm_Load;
            ((System.ComponentModel.ISupportInitialize)InterestsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView InterestsDataGridView;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ListBox selectedUsersListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ListBox allUsersListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button removeUserButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button createCategory_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox categoryName_textbox;
    }
}