namespace LoginFormUI
{
    partial class CreateNewUserForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.newUsernameLabel = new System.Windows.Forms.Label();
            this.newUsernameValue = new System.Windows.Forms.TextBox();
            this.newPasswordValue = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newFirstNameValue = new System.Windows.Forms.TextBox();
            this.newFirstNameLabel = new System.Windows.Forms.Label();
            this.newLastNameValue = new System.Windows.Forms.TextBox();
            this.newLastNameLabel = new System.Windows.Forms.Label();
            this.newEmailValue = new System.Windows.Forms.TextBox();
            this.newEmailLabel = new System.Windows.Forms.Label();
            this.createNewUserButton = new System.Windows.Forms.Button();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.Black;
            this.headerLabel.Location = new System.Drawing.Point(136, 51);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(168, 47);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "New User";
            // 
            // newUsernameLabel
            // 
            this.newUsernameLabel.AutoSize = true;
            this.newUsernameLabel.Location = new System.Drawing.Point(74, 133);
            this.newUsernameLabel.Name = "newUsernameLabel";
            this.newUsernameLabel.Size = new System.Drawing.Size(106, 30);
            this.newUsernameLabel.TabIndex = 2;
            this.newUsernameLabel.Text = "Username";
            // 
            // newUsernameValue
            // 
            this.newUsernameValue.Location = new System.Drawing.Point(199, 130);
            this.newUsernameValue.Name = "newUsernameValue";
            this.newUsernameValue.Size = new System.Drawing.Size(167, 35);
            this.newUsernameValue.TabIndex = 3;
            // 
            // newPasswordValue
            // 
            this.newPasswordValue.Location = new System.Drawing.Point(199, 180);
            this.newPasswordValue.Name = "newPasswordValue";
            this.newPasswordValue.PasswordChar = '*';
            this.newPasswordValue.Size = new System.Drawing.Size(167, 35);
            this.newPasswordValue.TabIndex = 5;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(74, 183);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(99, 30);
            this.newPasswordLabel.TabIndex = 4;
            this.newPasswordLabel.Text = "Password";
            // 
            // newFirstNameValue
            // 
            this.newFirstNameValue.Location = new System.Drawing.Point(199, 252);
            this.newFirstNameValue.Name = "newFirstNameValue";
            this.newFirstNameValue.Size = new System.Drawing.Size(167, 35);
            this.newFirstNameValue.TabIndex = 7;
            // 
            // newFirstNameLabel
            // 
            this.newFirstNameLabel.AutoSize = true;
            this.newFirstNameLabel.Location = new System.Drawing.Point(74, 255);
            this.newFirstNameLabel.Name = "newFirstNameLabel";
            this.newFirstNameLabel.Size = new System.Drawing.Size(113, 30);
            this.newFirstNameLabel.TabIndex = 6;
            this.newFirstNameLabel.Text = "First Name";
            // 
            // newLastNameValue
            // 
            this.newLastNameValue.Location = new System.Drawing.Point(199, 302);
            this.newLastNameValue.Name = "newLastNameValue";
            this.newLastNameValue.Size = new System.Drawing.Size(167, 35);
            this.newLastNameValue.TabIndex = 9;
            // 
            // newLastNameLabel
            // 
            this.newLastNameLabel.AutoSize = true;
            this.newLastNameLabel.Location = new System.Drawing.Point(74, 305);
            this.newLastNameLabel.Name = "newLastNameLabel";
            this.newLastNameLabel.Size = new System.Drawing.Size(112, 30);
            this.newLastNameLabel.TabIndex = 8;
            this.newLastNameLabel.Text = "Last Name";
            // 
            // newEmailValue
            // 
            this.newEmailValue.Location = new System.Drawing.Point(199, 352);
            this.newEmailValue.Name = "newEmailValue";
            this.newEmailValue.Size = new System.Drawing.Size(167, 35);
            this.newEmailValue.TabIndex = 11;
            // 
            // newEmailLabel
            // 
            this.newEmailLabel.AutoSize = true;
            this.newEmailLabel.Location = new System.Drawing.Point(74, 355);
            this.newEmailLabel.Name = "newEmailLabel";
            this.newEmailLabel.Size = new System.Drawing.Size(63, 30);
            this.newEmailLabel.TabIndex = 10;
            this.newEmailLabel.Text = "Email";
            // 
            // createNewUserButton
            // 
            this.createNewUserButton.Location = new System.Drawing.Point(126, 423);
            this.createNewUserButton.Name = "createNewUserButton";
            this.createNewUserButton.Size = new System.Drawing.Size(189, 50);
            this.createNewUserButton.TabIndex = 12;
            this.createNewUserButton.Text = "Create New User";
            this.createNewUserButton.UseVisualStyleBackColor = true;
            this.createNewUserButton.Click += new System.EventHandler(this.createNewUserButton_Click);
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showPasswordCheckBox.Location = new System.Drawing.Point(199, 221);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(118, 21);
            this.showPasswordCheckBox.TabIndex = 13;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // CreateNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 539);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.createNewUserButton);
            this.Controls.Add(this.newEmailValue);
            this.Controls.Add(this.newEmailLabel);
            this.Controls.Add(this.newLastNameValue);
            this.Controls.Add(this.newLastNameLabel);
            this.Controls.Add(this.newFirstNameValue);
            this.Controls.Add(this.newFirstNameLabel);
            this.Controls.Add(this.newPasswordValue);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.newUsernameValue);
            this.Controls.Add(this.newUsernameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateNewUserForm";
            this.Text = "Create New User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateNewUserForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label newUsernameLabel;
        private System.Windows.Forms.TextBox newUsernameValue;
        private System.Windows.Forms.TextBox newPasswordValue;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox newFirstNameValue;
        private System.Windows.Forms.Label newFirstNameLabel;
        private System.Windows.Forms.TextBox newLastNameValue;
        private System.Windows.Forms.Label newLastNameLabel;
        private System.Windows.Forms.TextBox newEmailValue;
        private System.Windows.Forms.Label newEmailLabel;
        private System.Windows.Forms.Button createNewUserButton;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
    }
}