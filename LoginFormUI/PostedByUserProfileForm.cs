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
    public partial class PostedByUserProfileForm : Form
    {
        TwatterPostViewerForm postViewer;
        FriendsMenuForm friendsMenu;
        LoginDataAccess db = new LoginDataAccess();
        UserModel _userWhoPosted;
        UserModel _currentUser;
        public PostedByUserProfileForm()
        {
            InitializeComponent();
        }

        public async void FillForm(string currentUserId, UserModel userWhoPosted, object sender)
        {
            _userWhoPosted = userWhoPosted;
            _currentUser = db.GetUserFromId(currentUserId);

            friendsMenu = sender as FriendsMenuForm;

            removeFriendButton.Enabled = true;
            removeFriendButton.Visible = true;
            addFriendButton.Enabled = false;
            addFriendButton.Visible = false;


            usernameLabel.Text = userWhoPosted.Username;
            numberOfFriendsValue.Text = userWhoPosted.Friends.Count.ToString() ?? "0";
            var twaatsByUser = await db.GetAllTwaatsByUserId(userWhoPosted.Id);
            numberOfTwatterPostsValue.Text = twaatsByUser.Count.ToString();
        }

        public async void FillForm(string currentUserId, UserModel userWhoPosted, bool areFriends, object sender)
        {
            _userWhoPosted = userWhoPosted;
            _currentUser = db.GetUserFromId(currentUserId);

            postViewer = sender as TwatterPostViewerForm;
            if (userWhoPosted.Id == _currentUser.Id)
            {
                addFriendButton.Enabled = false;
            }
            else
            {
                if (areFriends)
                {
                    removeFriendButton.Enabled = true;
                    removeFriendButton.Visible = true;
                    addFriendButton.Enabled = false;
                    addFriendButton.Visible = false;
                }
            }
            

            usernameLabel.Text = userWhoPosted.Username;
            numberOfFriendsValue.Text = userWhoPosted.Friends.Count.ToString() ?? "0";
            var twaatsByUser = await db.GetAllTwaatsByUserId(userWhoPosted.Id);
            numberOfTwatterPostsValue.Text = twaatsByUser.Count.ToString();
        }

        private void PostedByUserProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (postViewer != null)
            {
                postViewer.Show();
            }

            if (friendsMenu != null)
            {
                friendsMenu.Show();
            }
            
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addFriendButton_Click(object sender, EventArgs e)
        {
            _currentUser.Friends.Add(_userWhoPosted.Id);
            db.UpdateUser(_currentUser);

            MessageBox.Show($"{_userWhoPosted.Username} was added to your friends list.");

            removeFriendButton.Enabled = true;
            removeFriendButton.Visible = true;
            addFriendButton.Enabled = false;
            addFriendButton.Visible = false;
        }

        private void removeFriendButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you wish to delete {_userWhoPosted.Username} from your friends list?",
                "Verify", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _currentUser.Friends.Remove(_userWhoPosted.Id);
                db.UpdateUser(_currentUser);

                removeFriendButton.Enabled = false;
                removeFriendButton.Visible = false;
                addFriendButton.Enabled = true;
                addFriendButton.Visible = true;
            }
        }
    }
}
