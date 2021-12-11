namespace LoginFormUI
{
    partial class UserProfileForm
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
            this.userLoggedInLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.userProfileMenuLabel = new System.Windows.Forms.Label();
            this.userMenuNewTwaatButton = new System.Windows.Forms.Button();
            this.userMenuSettingsButton = new System.Windows.Forms.Button();
            this.userMenuLogoutButton = new System.Windows.Forms.Button();
            this.userMenuFriendsButton = new System.Windows.Forms.Button();
            this.postedTwaatsListBox = new System.Windows.Forms.ListBox();
            this.getTwaatsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLoggedInLabel
            // 
            this.userLoggedInLabel.AutoSize = true;
            this.userLoggedInLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLoggedInLabel.Location = new System.Drawing.Point(273, 41);
            this.userLoggedInLabel.Name = "userLoggedInLabel";
            this.userLoggedInLabel.Size = new System.Drawing.Size(102, 37);
            this.userLoggedInLabel.TabIndex = 5;
            this.userLoggedInLabel.Text = "<user>";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.Black;
            this.headerLabel.Location = new System.Drawing.Point(42, 33);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(227, 47);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "Logged in as:";
            // 
            // userProfileMenuLabel
            // 
            this.userProfileMenuLabel.AutoSize = true;
            this.userProfileMenuLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userProfileMenuLabel.Location = new System.Drawing.Point(42, 148);
            this.userProfileMenuLabel.Name = "userProfileMenuLabel";
            this.userProfileMenuLabel.Size = new System.Drawing.Size(131, 32);
            this.userProfileMenuLabel.TabIndex = 6;
            this.userProfileMenuLabel.Text = "User Menu";
            // 
            // userMenuNewTwaatButton
            // 
            this.userMenuNewTwaatButton.Location = new System.Drawing.Point(66, 211);
            this.userMenuNewTwaatButton.Name = "userMenuNewTwaatButton";
            this.userMenuNewTwaatButton.Size = new System.Drawing.Size(130, 43);
            this.userMenuNewTwaatButton.TabIndex = 7;
            this.userMenuNewTwaatButton.Text = "New Twaat";
            this.userMenuNewTwaatButton.UseVisualStyleBackColor = true;
            this.userMenuNewTwaatButton.Click += new System.EventHandler(this.userMenuNewTwaatButton_Click);
            // 
            // userMenuSettingsButton
            // 
            this.userMenuSettingsButton.Location = new System.Drawing.Point(66, 331);
            this.userMenuSettingsButton.Name = "userMenuSettingsButton";
            this.userMenuSettingsButton.Size = new System.Drawing.Size(130, 43);
            this.userMenuSettingsButton.TabIndex = 8;
            this.userMenuSettingsButton.Text = "Settings";
            this.userMenuSettingsButton.UseVisualStyleBackColor = true;
            this.userMenuSettingsButton.Click += new System.EventHandler(this.userMenuSettingsButton_Click);
            // 
            // userMenuLogoutButton
            // 
            this.userMenuLogoutButton.Location = new System.Drawing.Point(66, 432);
            this.userMenuLogoutButton.Name = "userMenuLogoutButton";
            this.userMenuLogoutButton.Size = new System.Drawing.Size(130, 43);
            this.userMenuLogoutButton.TabIndex = 9;
            this.userMenuLogoutButton.Text = "Logout";
            this.userMenuLogoutButton.UseVisualStyleBackColor = true;
            this.userMenuLogoutButton.Click += new System.EventHandler(this.userMenuLogoutButton_Click);
            // 
            // userMenuFriendsButton
            // 
            this.userMenuFriendsButton.Location = new System.Drawing.Point(66, 270);
            this.userMenuFriendsButton.Name = "userMenuFriendsButton";
            this.userMenuFriendsButton.Size = new System.Drawing.Size(130, 43);
            this.userMenuFriendsButton.TabIndex = 10;
            this.userMenuFriendsButton.Text = "Friends";
            this.userMenuFriendsButton.UseVisualStyleBackColor = true;
            // 
            // postedTwaatsListBox
            // 
            this.postedTwaatsListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postedTwaatsListBox.FormattingEnabled = true;
            this.postedTwaatsListBox.ItemHeight = 25;
            this.postedTwaatsListBox.Location = new System.Drawing.Point(273, 148);
            this.postedTwaatsListBox.Name = "postedTwaatsListBox";
            this.postedTwaatsListBox.Size = new System.Drawing.Size(385, 354);
            this.postedTwaatsListBox.TabIndex = 11;
            // 
            // getTwaatsButton
            // 
            this.getTwaatsButton.Location = new System.Drawing.Point(458, 94);
            this.getTwaatsButton.Name = "getTwaatsButton";
            this.getTwaatsButton.Size = new System.Drawing.Size(133, 36);
            this.getTwaatsButton.TabIndex = 12;
            this.getTwaatsButton.Text = "Get Twaats";
            this.getTwaatsButton.UseVisualStyleBackColor = true;
            this.getTwaatsButton.Click += new System.EventHandler(this.getTwaatsButton_Click);
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 589);
            this.Controls.Add(this.getTwaatsButton);
            this.Controls.Add(this.postedTwaatsListBox);
            this.Controls.Add(this.userMenuFriendsButton);
            this.Controls.Add(this.userMenuLogoutButton);
            this.Controls.Add(this.userMenuSettingsButton);
            this.Controls.Add(this.userMenuNewTwaatButton);
            this.Controls.Add(this.userProfileMenuLabel);
            this.Controls.Add(this.userLoggedInLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UserProfileForm";
            this.Text = "User Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserProfileForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLoggedInLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label userProfileMenuLabel;
        private System.Windows.Forms.Button userMenuNewTwaatButton;
        private System.Windows.Forms.Button userMenuSettingsButton;
        private System.Windows.Forms.Button userMenuLogoutButton;
        private System.Windows.Forms.Button userMenuFriendsButton;
        private System.Windows.Forms.ListBox postedTwaatsListBox;
        private System.Windows.Forms.Button getTwaatsButton;
    }
}