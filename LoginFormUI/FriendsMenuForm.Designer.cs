namespace LoginFormUI
{
    partial class FriendsMenuForm
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
            this.friendsMenuFriendProfileButton = new System.Windows.Forms.Button();
            this.friendsMenuMainMenuButton = new System.Windows.Forms.Button();
            this.friendsMenuSearchButton = new System.Windows.Forms.Button();
            this.userMenuNewTwaatButton = new System.Windows.Forms.Button();
            this.friendsMenuLabel = new System.Windows.Forms.Label();
            this.userLoggedInLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.hideOfflineFriendsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // friendsMenuFriendProfileButton
            // 
            this.friendsMenuFriendProfileButton.Location = new System.Drawing.Point(68, 273);
            this.friendsMenuFriendProfileButton.Name = "friendsMenuFriendProfileButton";
            this.friendsMenuFriendProfileButton.Size = new System.Drawing.Size(130, 43);
            this.friendsMenuFriendProfileButton.TabIndex = 15;
            this.friendsMenuFriendProfileButton.Text = "Profile";
            this.friendsMenuFriendProfileButton.UseVisualStyleBackColor = true;
            this.friendsMenuFriendProfileButton.Click += new System.EventHandler(this.friendsMenuFriendProfileButton_Click);
            // 
            // friendsMenuMainMenuButton
            // 
            this.friendsMenuMainMenuButton.Location = new System.Drawing.Point(68, 433);
            this.friendsMenuMainMenuButton.Name = "friendsMenuMainMenuButton";
            this.friendsMenuMainMenuButton.Size = new System.Drawing.Size(130, 43);
            this.friendsMenuMainMenuButton.TabIndex = 14;
            this.friendsMenuMainMenuButton.Text = "Main Menu";
            this.friendsMenuMainMenuButton.UseVisualStyleBackColor = true;
            this.friendsMenuMainMenuButton.Click += new System.EventHandler(this.friendsMenuMainMenuButton_Click);
            // 
            // friendsMenuSearchButton
            // 
            this.friendsMenuSearchButton.Location = new System.Drawing.Point(68, 375);
            this.friendsMenuSearchButton.Name = "friendsMenuSearchButton";
            this.friendsMenuSearchButton.Size = new System.Drawing.Size(130, 43);
            this.friendsMenuSearchButton.TabIndex = 13;
            this.friendsMenuSearchButton.Text = "User search";
            this.friendsMenuSearchButton.UseVisualStyleBackColor = true;
            // 
            // userMenuNewTwaatButton
            // 
            this.userMenuNewTwaatButton.Location = new System.Drawing.Point(68, 214);
            this.userMenuNewTwaatButton.Name = "userMenuNewTwaatButton";
            this.userMenuNewTwaatButton.Size = new System.Drawing.Size(130, 43);
            this.userMenuNewTwaatButton.TabIndex = 12;
            this.userMenuNewTwaatButton.Text = "Message";
            this.userMenuNewTwaatButton.UseVisualStyleBackColor = true;
            // 
            // friendsMenuLabel
            // 
            this.friendsMenuLabel.AutoSize = true;
            this.friendsMenuLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.friendsMenuLabel.Location = new System.Drawing.Point(54, 157);
            this.friendsMenuLabel.Name = "friendsMenuLabel";
            this.friendsMenuLabel.Size = new System.Drawing.Size(161, 32);
            this.friendsMenuLabel.TabIndex = 11;
            this.friendsMenuLabel.Text = "Friends Menu";
            // 
            // userLoggedInLabel
            // 
            this.userLoggedInLabel.AutoSize = true;
            this.userLoggedInLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLoggedInLabel.Location = new System.Drawing.Point(273, 42);
            this.userLoggedInLabel.Name = "userLoggedInLabel";
            this.userLoggedInLabel.Size = new System.Drawing.Size(102, 37);
            this.userLoggedInLabel.TabIndex = 17;
            this.userLoggedInLabel.Text = "<user>";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.Black;
            this.headerLabel.Location = new System.Drawing.Point(42, 34);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(227, 47);
            this.headerLabel.TabIndex = 16;
            this.headerLabel.Text = "Logged in as:";
            // 
            // friendsListBox
            // 
            this.friendsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.friendsListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 25;
            this.friendsListBox.Location = new System.Drawing.Point(273, 199);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(267, 277);
            this.friendsListBox.TabIndex = 18;
            // 
            // hideOfflineFriendsCheckBox
            // 
            this.hideOfflineFriendsCheckBox.AutoSize = true;
            this.hideOfflineFriendsCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hideOfflineFriendsCheckBox.Location = new System.Drawing.Point(385, 482);
            this.hideOfflineFriendsCheckBox.Name = "hideOfflineFriendsCheckBox";
            this.hideOfflineFriendsCheckBox.Size = new System.Drawing.Size(138, 21);
            this.hideOfflineFriendsCheckBox.TabIndex = 19;
            this.hideOfflineFriendsCheckBox.Text = "Hide offline friends";
            this.hideOfflineFriendsCheckBox.UseVisualStyleBackColor = true;
            // 
            // FriendsMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 566);
            this.Controls.Add(this.hideOfflineFriendsCheckBox);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.userLoggedInLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.friendsMenuFriendProfileButton);
            this.Controls.Add(this.friendsMenuMainMenuButton);
            this.Controls.Add(this.friendsMenuSearchButton);
            this.Controls.Add(this.userMenuNewTwaatButton);
            this.Controls.Add(this.friendsMenuLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FriendsMenuForm";
            this.Text = "Friends Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FriendsMenuForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button friendsMenuFriendProfileButton;
        private System.Windows.Forms.Button friendsMenuMainMenuButton;
        private System.Windows.Forms.Button friendsMenuSearchButton;
        private System.Windows.Forms.Button userMenuNewTwaatButton;
        private System.Windows.Forms.Label friendsMenuLabel;
        private System.Windows.Forms.Label userLoggedInLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.CheckBox hideOfflineFriendsCheckBox;
    }
}