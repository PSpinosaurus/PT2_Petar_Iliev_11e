namespace PresentationLayer
{
    partial class MainForm
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
            users_button = new System.Windows.Forms.Button();
            interests_button = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // users_button
            // 
            users_button.Location = new System.Drawing.Point(435, 208);
            users_button.Name = "users_button";
            users_button.Size = new System.Drawing.Size(94, 29);
            users_button.TabIndex = 0;
            users_button.Text = "Users";
            users_button.UseVisualStyleBackColor = true;
            users_button.Click += users_button_Click;
            // 
            // interests_button
            // 
            interests_button.Location = new System.Drawing.Point(180, 208);
            interests_button.Name = "interests_button";
            interests_button.Size = new System.Drawing.Size(94, 29);
            interests_button.TabIndex = 1;
            interests_button.Text = "Interests";
            interests_button.UseVisualStyleBackColor = true;
            interests_button.Click += interests_button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(interests_button);
            Controls.Add(users_button);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button users_button;
        private System.Windows.Forms.Button interests_button;
    }
}