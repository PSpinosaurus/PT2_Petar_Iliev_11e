namespace PresentationLayer
{
    partial class UsersForm
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
            close_button = new System.Windows.Forms.Button();
            deleteUser_button = new System.Windows.Forms.Button();
            updateUser_button = new System.Windows.Forms.Button();
            clear_button = new System.Windows.Forms.Button();
            createUser_button = new System.Windows.Forms.Button();
            usersDataGrid = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            firstName_textBox = new System.Windows.Forms.TextBox();
            lastName_textBox = new System.Windows.Forms.TextBox();
            username_textBox = new System.Windows.Forms.TextBox();
            password_textBox = new System.Windows.Forms.TextBox();
            email_textBox = new System.Windows.Forms.TextBox();
            age_numBox = new System.Windows.Forms.NumericUpDown();
            interests_listBox = new System.Windows.Forms.ListBox();
            seePassword_checkBox = new System.Windows.Forms.CheckBox();
            friends_listBox = new System.Windows.Forms.ListBox();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            allusersListBox = new System.Windows.Forms.ListBox();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            allInterests_listBox = new System.Windows.Forms.ListBox();
            RemoveInterestBttn = new System.Windows.Forms.Button();
            AddInterestBttn = new System.Windows.Forms.Button();
            RemoveFriendBttn = new System.Windows.Forms.Button();
            addFriendBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)usersDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)age_numBox).BeginInit();
            SuspendLayout();
            // 
            // close_button
            // 
            close_button.Location = new System.Drawing.Point(872, 486);
            close_button.Name = "close_button";
            close_button.Size = new System.Drawing.Size(94, 29);
            close_button.TabIndex = 0;
            close_button.Text = "Close";
            close_button.UseVisualStyleBackColor = true;
            close_button.Click += close_button_Click;
            // 
            // deleteUser_button
            // 
            deleteUser_button.Location = new System.Drawing.Point(758, 486);
            deleteUser_button.Name = "deleteUser_button";
            deleteUser_button.Size = new System.Drawing.Size(94, 29);
            deleteUser_button.TabIndex = 2;
            deleteUser_button.Text = "Delete";
            deleteUser_button.UseVisualStyleBackColor = true;
            deleteUser_button.Click += deleteUser_button_Click;
            // 
            // updateUser_button
            // 
            updateUser_button.Location = new System.Drawing.Point(758, 406);
            updateUser_button.Name = "updateUser_button";
            updateUser_button.Size = new System.Drawing.Size(94, 29);
            updateUser_button.TabIndex = 3;
            updateUser_button.Text = "Update";
            updateUser_button.UseVisualStyleBackColor = true;
            updateUser_button.Click += updateUser_button_Click;
            // 
            // clear_button
            // 
            clear_button.Location = new System.Drawing.Point(872, 324);
            clear_button.Name = "clear_button";
            clear_button.Size = new System.Drawing.Size(94, 29);
            clear_button.TabIndex = 4;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // createUser_button
            // 
            createUser_button.Location = new System.Drawing.Point(758, 324);
            createUser_button.Name = "createUser_button";
            createUser_button.Size = new System.Drawing.Size(94, 29);
            createUser_button.TabIndex = 5;
            createUser_button.Text = "Create";
            createUser_button.UseVisualStyleBackColor = true;
            createUser_button.Click += createUser_button_Click;
            // 
            // usersDataGrid
            // 
            usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGrid.Location = new System.Drawing.Point(358, 14);
            usersDataGrid.Name = "usersDataGrid";
            usersDataGrid.RowHeadersWidth = 51;
            usersDataGrid.RowTemplate.Height = 29;
            usersDataGrid.Size = new System.Drawing.Size(608, 282);
            usersDataGrid.TabIndex = 6;
            usersDataGrid.CellClick += usersDataGrid_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 20);
            label1.TabIndex = 7;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 95);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 20);
            label2.TabIndex = 8;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(20, 140);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 20);
            label3.TabIndex = 9;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(13, 183);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(75, 20);
            label4.TabIndex = 10;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(13, 228);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 20);
            label5.TabIndex = 11;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(20, 272);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(46, 20);
            label6.TabIndex = 12;
            label6.Text = "Email";
            // 
            // firstName_textBox
            // 
            firstName_textBox.Location = new System.Drawing.Point(115, 47);
            firstName_textBox.Name = "firstName_textBox";
            firstName_textBox.Size = new System.Drawing.Size(150, 27);
            firstName_textBox.TabIndex = 13;
            // 
            // lastName_textBox
            // 
            lastName_textBox.Location = new System.Drawing.Point(115, 95);
            lastName_textBox.Name = "lastName_textBox";
            lastName_textBox.Size = new System.Drawing.Size(150, 27);
            lastName_textBox.TabIndex = 14;
            // 
            // username_textBox
            // 
            username_textBox.Location = new System.Drawing.Point(115, 183);
            username_textBox.Name = "username_textBox";
            username_textBox.Size = new System.Drawing.Size(150, 27);
            username_textBox.TabIndex = 16;
            // 
            // password_textBox
            // 
            password_textBox.Location = new System.Drawing.Point(115, 225);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new System.Drawing.Size(150, 27);
            password_textBox.TabIndex = 17;
            // 
            // email_textBox
            // 
            email_textBox.Location = new System.Drawing.Point(115, 269);
            email_textBox.Name = "email_textBox";
            email_textBox.Size = new System.Drawing.Size(150, 27);
            email_textBox.TabIndex = 18;
            // 
            // age_numBox
            // 
            age_numBox.Location = new System.Drawing.Point(115, 140);
            age_numBox.Name = "age_numBox";
            age_numBox.Size = new System.Drawing.Size(150, 27);
            age_numBox.TabIndex = 19;
            // 
            // interests_listBox
            // 
            interests_listBox.FormattingEnabled = true;
            interests_listBox.ItemHeight = 20;
            interests_listBox.Location = new System.Drawing.Point(20, 351);
            interests_listBox.Name = "interests_listBox";
            interests_listBox.Size = new System.Drawing.Size(150, 144);
            interests_listBox.TabIndex = 21;
            // 
            // seePassword_checkBox
            // 
            seePassword_checkBox.AutoSize = true;
            seePassword_checkBox.Location = new System.Drawing.Point(271, 231);
            seePassword_checkBox.Name = "seePassword_checkBox";
            seePassword_checkBox.Size = new System.Drawing.Size(18, 17);
            seePassword_checkBox.TabIndex = 22;
            seePassword_checkBox.UseVisualStyleBackColor = true;
            seePassword_checkBox.CheckedChanged += seePassword_checkBox_CheckedChanged;
            seePassword_checkBox.MouseLeave += seePassword_checkBox_MouseLeave;
            seePassword_checkBox.MouseHover += seePassword_checkBox_MouseHover;
            // 
            // friends_listBox
            // 
            friends_listBox.FormattingEnabled = true;
            friends_listBox.ItemHeight = 20;
            friends_listBox.Location = new System.Drawing.Point(398, 351);
            friends_listBox.Name = "friends_listBox";
            friends_listBox.Size = new System.Drawing.Size(150, 144);
            friends_listBox.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(428, 328);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(79, 20);
            label7.TabIndex = 24;
            label7.Text = "Friends list";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(42, 328);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(87, 20);
            label8.TabIndex = 25;
            label8.Text = "Interests list";
            // 
            // allusersListBox
            // 
            allusersListBox.FormattingEnabled = true;
            allusersListBox.ItemHeight = 20;
            allusersListBox.Location = new System.Drawing.Point(578, 351);
            allusersListBox.Name = "allusersListBox";
            allusersListBox.Size = new System.Drawing.Size(150, 144);
            allusersListBox.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(605, 328);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(87, 20);
            label9.TabIndex = 27;
            label9.Text = "All users list";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(225, 328);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(109, 20);
            label10.TabIndex = 28;
            label10.Text = "All interests list";
            // 
            // allInterests_listBox
            // 
            allInterests_listBox.FormattingEnabled = true;
            allInterests_listBox.ItemHeight = 20;
            allInterests_listBox.Location = new System.Drawing.Point(207, 351);
            allInterests_listBox.Name = "allInterests_listBox";
            allInterests_listBox.Size = new System.Drawing.Size(150, 144);
            allInterests_listBox.TabIndex = 29;
            // 
            // RemoveInterestBttn
            // 
            RemoveInterestBttn.Location = new System.Drawing.Point(20, 501);
            RemoveInterestBttn.Name = "RemoveInterestBttn";
            RemoveInterestBttn.Size = new System.Drawing.Size(150, 29);
            RemoveInterestBttn.TabIndex = 30;
            RemoveInterestBttn.Text = "Remove selected";
            RemoveInterestBttn.UseVisualStyleBackColor = true;
            RemoveInterestBttn.Click += RemoveInterestBttn_Click;
            // 
            // AddInterestBttn
            // 
            AddInterestBttn.Location = new System.Drawing.Point(207, 501);
            AddInterestBttn.Name = "AddInterestBttn";
            AddInterestBttn.Size = new System.Drawing.Size(150, 29);
            AddInterestBttn.TabIndex = 31;
            AddInterestBttn.Text = "Add selected";
            AddInterestBttn.UseVisualStyleBackColor = true;
            AddInterestBttn.Click += AddInterestBttn_Click;
            // 
            // RemoveFriendBttn
            // 
            RemoveFriendBttn.Location = new System.Drawing.Point(398, 501);
            RemoveFriendBttn.Name = "RemoveFriendBttn";
            RemoveFriendBttn.Size = new System.Drawing.Size(150, 29);
            RemoveFriendBttn.TabIndex = 32;
            RemoveFriendBttn.Text = "Remove selected";
            RemoveFriendBttn.UseVisualStyleBackColor = true;
            RemoveFriendBttn.Click += RemoveFriendBttn_Click;
            // 
            // addFriendBttn
            // 
            addFriendBttn.Location = new System.Drawing.Point(578, 501);
            addFriendBttn.Name = "addFriendBttn";
            addFriendBttn.Size = new System.Drawing.Size(150, 29);
            addFriendBttn.TabIndex = 33;
            addFriendBttn.Text = "Add selected";
            addFriendBttn.UseVisualStyleBackColor = true;
            addFriendBttn.Click += addFriendBttn_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(987, 546);
            Controls.Add(addFriendBttn);
            Controls.Add(RemoveFriendBttn);
            Controls.Add(AddInterestBttn);
            Controls.Add(RemoveInterestBttn);
            Controls.Add(allInterests_listBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(allusersListBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(friends_listBox);
            Controls.Add(seePassword_checkBox);
            Controls.Add(interests_listBox);
            Controls.Add(age_numBox);
            Controls.Add(email_textBox);
            Controls.Add(password_textBox);
            Controls.Add(username_textBox);
            Controls.Add(lastName_textBox);
            Controls.Add(firstName_textBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usersDataGrid);
            Controls.Add(createUser_button);
            Controls.Add(clear_button);
            Controls.Add(updateUser_button);
            Controls.Add(deleteUser_button);
            Controls.Add(close_button);
            Name = "UsersForm";
            Text = "UsersForm";
            Load += UsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)usersDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)age_numBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button deleteUser_button;
        private System.Windows.Forms.Button updateUser_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button createUser_button;
        private System.Windows.Forms.DataGridView usersDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstName_textBox;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.NumericUpDown age_numBox;
        private System.Windows.Forms.ListBox interests_listBox;
        private System.Windows.Forms.CheckBox seePassword_checkBox;
        private System.Windows.Forms.ListBox friends_listBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox allusersListBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox allInterests_listBox;
        private System.Windows.Forms.Button RemoveInterestBttn;
        private System.Windows.Forms.Button AddInterestBttn;
        private System.Windows.Forms.Button RemoveFriendBttn;
        private System.Windows.Forms.Button addFriendBttn;
    }
}