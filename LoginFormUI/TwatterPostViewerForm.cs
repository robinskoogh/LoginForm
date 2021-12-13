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
    public partial class TwatterPostViewerForm : Form
    {
        LoginDataAccess db = new LoginDataAccess();
        UserProfileForm userForm;
        UserModel currentUser;
        TwaatModel currentTwaatModel;


        public TwatterPostViewerForm()
        {
            InitializeComponent();
        }

        public void SetUser(object sender, string userId)
        {
            currentUser = db.GetUserFromId(userId);
            userForm = sender as UserProfileForm;
            fullTwatterPostContentRichTextBox.MaxLength = 140;
        }

        private void UpdatePostEditedTime()
        {
            postEditedDateTimeValueLabel.Text = $"This post was last edited {currentTwaatModel.LastEdited}";
            postEditedDateTimeValueLabel.Visible = true;
        }

        public void GetTwatterPost(TwaatModel twaatModel)
        {
            postedByUserLinkLabelValue.Text = db.GetUserFromId(twaatModel.UserId).Username;
            dateOfTwatterPostValue.Text = twaatModel.TimeOfPosting.ToString();
            twatterPostIdValue.Text = twaatModel.Id;
            fullTwatterPostContentRichTextBox.Text = twaatModel.Content;
            currentTwaatModel = twaatModel;

            if (currentUser.Id == twaatModel.UserId)
            {
                editTwatterPostButton.Enabled = true;
                editTwatterPostButton.Visible = true;
                fullTwatterPostContentRichTextBox.ReadOnly = false;
            }

            if (twaatModel.PostHasBeenEdited)
            {
                UpdatePostEditedTime();
            }
        }

        private void TwatterPostViewerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            userForm.GetTwaats();
            userForm.OccupyTwaatList();
            userForm.Show();
        }

        private void closeTwatterPostViewerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTwatterPostButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want\nto edit this post?",
                "Edit Twatter Post", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                currentTwaatModel.PostHasBeenEdited = true;
                currentTwaatModel.Content = fullTwatterPostContentRichTextBox.Text;
                currentTwaatModel.LastEdited = DateTime.Now;

                db.EditTwatterPost(currentTwaatModel);
                UpdatePostEditedTime();
            }
        }

        private void postedByUserLinkLabelValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var userWhoPosted = db.GetUserFromId(currentTwaatModel.UserId);
            var userProfile = new PostedByUserProfileForm();
            var usersAreFriends = currentUser.Friends.Contains(currentTwaatModel.UserId) ? true : false;

            userProfile.FillForm(currentUser.Id, userWhoPosted, usersAreFriends, this);
            this.Hide();
            userProfile.Show();
            
        }
    }
}
