namespace LoginFormUI
{
    partial class PostedByUserProfileForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.numberOfFriendsLabel = new System.Windows.Forms.Label();
            this.addFriendButton = new System.Windows.Forms.Button();
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.removeFriendButton = new System.Windows.Forms.Button();
            this.numberOfFriendsValue = new System.Windows.Forms.Label();
            this.numberOfTwatterPostsValue = new System.Windows.Forms.Label();
            this.numberOfTwatterPostsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(167, 53);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(80, 30);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "<user>";
            // 
            // numberOfFriendsLabel
            // 
            this.numberOfFriendsLabel.AutoSize = true;
            this.numberOfFriendsLabel.Location = new System.Drawing.Point(167, 103);
            this.numberOfFriendsLabel.Name = "numberOfFriendsLabel";
            this.numberOfFriendsLabel.Size = new System.Drawing.Size(90, 30);
            this.numberOfFriendsLabel.TabIndex = 1;
            this.numberOfFriendsLabel.Text = "Friends: ";
            // 
            // addFriendButton
            // 
            this.addFriendButton.Location = new System.Drawing.Point(144, 192);
            this.addFriendButton.Name = "addFriendButton";
            this.addFriendButton.Size = new System.Drawing.Size(166, 44);
            this.addFriendButton.TabIndex = 3;
            this.addFriendButton.Text = "Add friend";
            this.addFriendButton.UseVisualStyleBackColor = true;
            this.addFriendButton.Click += new System.EventHandler(this.addFriendButton_Click);
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.Location = new System.Drawing.Point(144, 262);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(166, 44);
            this.closeWindowButton.TabIndex = 4;
            this.closeWindowButton.Text = "Close";
            this.closeWindowButton.UseVisualStyleBackColor = true;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // removeFriendButton
            // 
            this.removeFriendButton.Enabled = false;
            this.removeFriendButton.Location = new System.Drawing.Point(144, 192);
            this.removeFriendButton.Name = "removeFriendButton";
            this.removeFriendButton.Size = new System.Drawing.Size(166, 44);
            this.removeFriendButton.TabIndex = 5;
            this.removeFriendButton.Text = "Remove friend";
            this.removeFriendButton.UseVisualStyleBackColor = true;
            this.removeFriendButton.Visible = false;
            this.removeFriendButton.Click += new System.EventHandler(this.removeFriendButton_Click);
            // 
            // numberOfFriendsValue
            // 
            this.numberOfFriendsValue.AutoSize = true;
            this.numberOfFriendsValue.Location = new System.Drawing.Point(263, 103);
            this.numberOfFriendsValue.Name = "numberOfFriendsValue";
            this.numberOfFriendsValue.Size = new System.Drawing.Size(24, 30);
            this.numberOfFriendsValue.TabIndex = 7;
            this.numberOfFriendsValue.Text = "0";
            // 
            // numberOfTwatterPostsValue
            // 
            this.numberOfTwatterPostsValue.AutoSize = true;
            this.numberOfTwatterPostsValue.Location = new System.Drawing.Point(263, 133);
            this.numberOfTwatterPostsValue.Name = "numberOfTwatterPostsValue";
            this.numberOfTwatterPostsValue.Size = new System.Drawing.Size(24, 30);
            this.numberOfTwatterPostsValue.TabIndex = 9;
            this.numberOfTwatterPostsValue.Text = "0";
            // 
            // numberOfTwatterPostsLabel
            // 
            this.numberOfTwatterPostsLabel.AutoSize = true;
            this.numberOfTwatterPostsLabel.Location = new System.Drawing.Point(167, 133);
            this.numberOfTwatterPostsLabel.Name = "numberOfTwatterPostsLabel";
            this.numberOfTwatterPostsLabel.Size = new System.Drawing.Size(78, 30);
            this.numberOfTwatterPostsLabel.TabIndex = 8;
            this.numberOfTwatterPostsLabel.Text = "Posts:  ";
            // 
            // PostedByUserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 365);
            this.Controls.Add(this.numberOfTwatterPostsValue);
            this.Controls.Add(this.numberOfTwatterPostsLabel);
            this.Controls.Add(this.numberOfFriendsValue);
            this.Controls.Add(this.removeFriendButton);
            this.Controls.Add(this.closeWindowButton);
            this.Controls.Add(this.addFriendButton);
            this.Controls.Add(this.numberOfFriendsLabel);
            this.Controls.Add(this.usernameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "PostedByUserProfileForm";
            this.Text = "User Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PostedByUserProfileForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label numberOfFriendsLabel;
        private System.Windows.Forms.Button addFriendButton;
        private System.Windows.Forms.Button closeWindowButton;
        private System.Windows.Forms.Button removeFriendButton;
        private System.Windows.Forms.Label numberOfFriendsValue;
        private System.Windows.Forms.Label numberOfTwatterPostsValue;
        private System.Windows.Forms.Label numberOfTwatterPostsLabel;
    }
}