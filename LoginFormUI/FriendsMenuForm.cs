using LoginFormDataAccess.DataAccess;
using LoginFormDataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormUI
{
    public partial class FriendsMenuForm : Form
    {
        LoginDataAccess db = new LoginDataAccess();
        UserProfileForm userProfileForm = new UserProfileForm();
        UserModel currentUser;
        public FriendsMenuForm()
        {
            InitializeComponent();
        }

        public void FillForm(string userId, object sender)
        {
            currentUser = db.GetUserFromId(userId);

            userProfileForm = sender as UserProfileForm;
            userLoggedInLabel.Text = currentUser.Username;

            foreach (var friend in currentUser.Friends)
            {
                friendsListBox.Items.Add(db.GetUserFromId(friend).Username);
            }
        }

        private void friendsMenuFriendProfileButton_Click(object sender, EventArgs e)
        {
            var userWhosProfileToShow = db.GetUserFromId(currentUser.Friends[friendsListBox.SelectedIndex]);
            var userProfile = new PostedByUserProfileForm();

            userProfile.FillForm(currentUser.Id, userWhosProfileToShow, this);
            this.Hide();
            userProfile.Show();
        }

        private void friendsMenuMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FriendsMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            userProfileForm.Show();
        }
    }
}
