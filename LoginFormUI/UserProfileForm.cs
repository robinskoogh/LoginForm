using LoginFormDataAccess.DataAccess;
using LoginFormDataAccess.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormUI
{
    public partial class UserProfileForm : Form
    {
        LoginDataAccess db = new LoginDataAccess();
        List<TwaatModel> allTwaats = new List<TwaatModel>();
        UserModel currentUser;
        UserLoginForm userLoginForm = new UserLoginForm();
        List<TwaatModel> twaatsToPost = new List<TwaatModel>();

        public UserProfileForm()
        {
            InitializeComponent();
            GetTwaats();
            OccupyTwaatList();
            postedTwaatsListBox.SelectionMode = SelectionMode.One;
        }

        public void SetUser(object sender, string userId)
        {
            currentUser = db.GetUserFromId(userId);
            userLoginForm = sender as UserLoginForm;
            userLoggedInLabel.Text = currentUser.Username;
        }

        public async void GetTwaats()
        {
            allTwaats = await db.GetAllTwaats();
        }

        public void OccupyTwaatList()
        {
            postedTwaatsListBox.Items.Clear();
             
            if (showTwaatsByFriendsRadioButton.Checked)
            {
                // Not implemented
            }
            else if (showMyTwaatsOnlyRadioButton.Checked)
            {
                twaatsToPost = allTwaats.FindAll(u => u.UserId == currentUser.Id).ToList();
            }
            else if (showAllTwaatsRadioButton.Checked)
            {
                twaatsToPost = allTwaats.ToList();
            }

            if (!showMyTwaatsOnlyRadioButton.Checked && hideMyTwaatsCheckBox.Checked)
            {
                twaatsToPost.RemoveAll(u => u.UserId == currentUser.Id);
            }

            int numberOfTwaatsToShow;

            if (twaatsToPost.Count > 10)
            {
                numberOfTwaatsToShow = 10;
            }
            else
            {
                numberOfTwaatsToShow = twaatsToPost.Count;
            }

            for (int i = 0; i < numberOfTwaatsToShow; i++)
            {
                postedTwaatsListBox.Items.Add($"{twaatsToPost[i].TimeOfPosting.ToString("H:mm")} | " +
                    $"[{db.GetUserFromId(twaatsToPost[i].UserId).Username}]: {twaatsToPost[i].Content}");
            }
        }

        private void getTwaatsButton_Click(object sender, EventArgs e)
        {
            OccupyTwaatList();
        }

        private void userMenuSettingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userSettings = new ChangeUserInformationForm();
            userSettings.SetUser(this, currentUser.Id);
            userSettings.FillUserInformation(currentUser);
            userSettings.Show();
        }

        private void UserProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            userLoginForm.Show();
        }

        private void userMenuLogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userMenuNewTwaatButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newTwaatForm =  new CreateNewTwaatForm();
            newTwaatForm.SetUser(this, currentUser.Id);
            newTwaatForm.Show();
        }

        private void userMenuFriendsButton_Click(object sender, EventArgs e)
        {
            var friendsMenu = new FriendsMenuForm();
            friendsMenu.FillForm(currentUser.Id, this);

            this.Hide();
            friendsMenu.Show();
        }

        private void hideMyTwaatsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OccupyTwaatList();
        }

        private void showMyTwaatsOnlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            hideMyTwaatsCheckBox.Enabled = showMyTwaatsOnlyRadioButton.Checked ? false : true;
            OccupyTwaatList();
        }

        private void showTwaatsByFriendsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OccupyTwaatList();
        }

        private void showAllTwaatsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OccupyTwaatList();
        }

        private void viewFullTwatterPostButton_Click(object sender, EventArgs e)
        {
            if (postedTwaatsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a twatter post first.");
            }
            else
            {
                int twatterPostIndex = postedTwaatsListBox.SelectedIndex;
                this.Hide();
                var twatterPostViewer = new TwatterPostViewerForm();
                twatterPostViewer.SetUser(this, currentUser.Id);
                twatterPostViewer.GetTwatterPost(twaatsToPost[twatterPostIndex]);
                twatterPostViewer.Show();
            }
            

        }
    }
}
