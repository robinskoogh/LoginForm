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
            this.showTwaatsButton = new System.Windows.Forms.Button();
            this.userMenuFilterSearchLabel = new System.Windows.Forms.Label();
            this.hideMyTwaatsCheckBox = new System.Windows.Forms.CheckBox();
            this.showAllTwaatsRadioButton = new System.Windows.Forms.RadioButton();
            this.showTwaatsByFriendsRadioButton = new System.Windows.Forms.RadioButton();
            this.showMyTwaatsOnlyRadioButton = new System.Windows.Forms.RadioButton();
            this.viewFullTwatterPostButton = new System.Windows.Forms.Button();
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
            this.userProfileMenuLabel.Location = new System.Drawing.Point(66, 154);
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
            this.userMenuLogoutButton.Location = new System.Drawing.Point(66, 430);
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
            this.userMenuFriendsButton.Click += new System.EventHandler(this.userMenuFriendsButton_Click);
            // 
            // postedTwaatsListBox
            // 
            this.postedTwaatsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postedTwaatsListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postedTwaatsListBox.FormattingEnabled = true;
            this.postedTwaatsListBox.ItemHeight = 25;
            this.postedTwaatsListBox.Location = new System.Drawing.Point(273, 196);
            this.postedTwaatsListBox.Name = "postedTwaatsListBox";
            this.postedTwaatsListBox.Size = new System.Drawing.Size(385, 277);
            this.postedTwaatsListBox.TabIndex = 11;
            // 
            // showTwaatsButton
            // 
            this.showTwaatsButton.Location = new System.Drawing.Point(273, 154);
            this.showTwaatsButton.Name = "showTwaatsButton";
            this.showTwaatsButton.Size = new System.Drawing.Size(142, 36);
            this.showTwaatsButton.TabIndex = 12;
            this.showTwaatsButton.Text = "Show Twaats";
            this.showTwaatsButton.UseVisualStyleBackColor = true;
            this.showTwaatsButton.Click += new System.EventHandler(this.getTwaatsButton_Click);
            // 
            // userMenuFilterSearchLabel
            // 
            this.userMenuFilterSearchLabel.AutoSize = true;
            this.userMenuFilterSearchLabel.Location = new System.Drawing.Point(490, 56);
            this.userMenuFilterSearchLabel.Name = "userMenuFilterSearchLabel";
            this.userMenuFilterSearchLabel.Size = new System.Drawing.Size(124, 30);
            this.userMenuFilterSearchLabel.TabIndex = 14;
            this.userMenuFilterSearchLabel.Text = "Filter search";
            // 
            // hideMyTwaatsCheckBox
            // 
            this.hideMyTwaatsCheckBox.AutoSize = true;
            this.hideMyTwaatsCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hideMyTwaatsCheckBox.Location = new System.Drawing.Point(498, 170);
            this.hideMyTwaatsCheckBox.Name = "hideMyTwaatsCheckBox";
            this.hideMyTwaatsCheckBox.Size = new System.Drawing.Size(116, 21);
            this.hideMyTwaatsCheckBox.TabIndex = 15;
            this.hideMyTwaatsCheckBox.Text = "Hide my twaats";
            this.hideMyTwaatsCheckBox.UseVisualStyleBackColor = true;
            this.hideMyTwaatsCheckBox.CheckedChanged += new System.EventHandler(this.hideMyTwaatsCheckBox_CheckedChanged);
            // 
            // showAllTwaatsRadioButton
            // 
            this.showAllTwaatsRadioButton.AutoSize = true;
            this.showAllTwaatsRadioButton.Checked = true;
            this.showAllTwaatsRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showAllTwaatsRadioButton.Location = new System.Drawing.Point(498, 89);
            this.showAllTwaatsRadioButton.Name = "showAllTwaatsRadioButton";
            this.showAllTwaatsRadioButton.Size = new System.Drawing.Size(74, 21);
            this.showAllTwaatsRadioButton.TabIndex = 17;
            this.showAllTwaatsRadioButton.TabStop = true;
            this.showAllTwaatsRadioButton.Text = "Show all";
            this.showAllTwaatsRadioButton.UseVisualStyleBackColor = true;
            this.showAllTwaatsRadioButton.CheckedChanged += new System.EventHandler(this.showAllTwaatsRadioButton_CheckedChanged);
            // 
            // showTwaatsByFriendsRadioButton
            // 
            this.showTwaatsByFriendsRadioButton.AutoSize = true;
            this.showTwaatsByFriendsRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showTwaatsByFriendsRadioButton.Location = new System.Drawing.Point(498, 116);
            this.showTwaatsByFriendsRadioButton.Name = "showTwaatsByFriendsRadioButton";
            this.showTwaatsByFriendsRadioButton.Size = new System.Drawing.Size(160, 21);
            this.showTwaatsByFriendsRadioButton.TabIndex = 18;
            this.showTwaatsByFriendsRadioButton.Text = "Show twaats by friends";
            this.showTwaatsByFriendsRadioButton.UseVisualStyleBackColor = true;
            this.showTwaatsByFriendsRadioButton.CheckedChanged += new System.EventHandler(this.showTwaatsByFriendsRadioButton_CheckedChanged);
            // 
            // showMyTwaatsOnlyRadioButton
            // 
            this.showMyTwaatsOnlyRadioButton.AutoSize = true;
            this.showMyTwaatsOnlyRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showMyTwaatsOnlyRadioButton.Location = new System.Drawing.Point(498, 143);
            this.showMyTwaatsOnlyRadioButton.Name = "showMyTwaatsOnlyRadioButton";
            this.showMyTwaatsOnlyRadioButton.Size = new System.Drawing.Size(147, 21);
            this.showMyTwaatsOnlyRadioButton.TabIndex = 19;
            this.showMyTwaatsOnlyRadioButton.Text = "Show my twaats only";
            this.showMyTwaatsOnlyRadioButton.UseVisualStyleBackColor = true;
            this.showMyTwaatsOnlyRadioButton.CheckedChanged += new System.EventHandler(this.showMyTwaatsOnlyRadioButton_CheckedChanged);
            // 
            // viewFullTwatterPostButton
            // 
            this.viewFullTwatterPostButton.Location = new System.Drawing.Point(384, 489);
            this.viewFullTwatterPostButton.Name = "viewFullTwatterPostButton";
            this.viewFullTwatterPostButton.Size = new System.Drawing.Size(175, 46);
            this.viewFullTwatterPostButton.TabIndex = 20;
            this.viewFullTwatterPostButton.Text = "View Full Twaat";
            this.viewFullTwatterPostButton.UseVisualStyleBackColor = true;
            this.viewFullTwatterPostButton.Click += new System.EventHandler(this.viewFullTwatterPostButton_Click);
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 589);
            this.Controls.Add(this.viewFullTwatterPostButton);
            this.Controls.Add(this.showMyTwaatsOnlyRadioButton);
            this.Controls.Add(this.showTwaatsByFriendsRadioButton);
            this.Controls.Add(this.showAllTwaatsRadioButton);
            this.Controls.Add(this.hideMyTwaatsCheckBox);
            this.Controls.Add(this.userMenuFilterSearchLabel);
            this.Controls.Add(this.showTwaatsButton);
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
        private System.Windows.Forms.Button showTwaatsButton;
        private System.Windows.Forms.Label userMenuFilterSearchLabel;
        private System.Windows.Forms.CheckBox hideMyTwaatsCheckBox;
        private System.Windows.Forms.RadioButton showAllTwaatsRadioButton;
        private System.Windows.Forms.RadioButton showTwaatsByFriendsRadioButton;
        private System.Windows.Forms.RadioButton showMyTwaatsOnlyRadioButton;
        private System.Windows.Forms.Button viewFullTwatterPostButton;
    }
}