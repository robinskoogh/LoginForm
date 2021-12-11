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

        public UserProfileForm()
        {
            InitializeComponent();
            GetTwaats();
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

        private void OccupyTwaatList()
        {
            int numberOfTwaatsToShow;

            if (allTwaats.Count > 10)
            {
                numberOfTwaatsToShow = 10;
            }
            else
            {
                numberOfTwaatsToShow = allTwaats.Count;
            }

            for (int i = 0; i < numberOfTwaatsToShow; i++)
            {
                postedTwaatsListBox.Items.Add($"{allTwaats[i].TimeOfPosting.ToString("yy-mm-dd")} | " +
                    $"{db.GetUserFromId(allTwaats[i].UserId).Username}: {allTwaats[i].Content}");
            }
        }

        private void getTwaatsButton_Click(object sender, EventArgs e)
        {
            postedTwaatsListBox.Items.Clear();
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
    }
}
