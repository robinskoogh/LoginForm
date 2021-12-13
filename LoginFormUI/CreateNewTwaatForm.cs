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
    public partial class CreateNewTwaatForm : Form
    {
        LoginDataAccess db = new LoginDataAccess();
        private UserModel currentUser;
        private UserProfileForm userForm;
        int twaatContentMaxLength = 140;

        public CreateNewTwaatForm()
        {
            InitializeComponent();
            twaatContentRichTextBox.MaxLength = twaatContentMaxLength;
        }

        public void SetUser(object sender, string userId)
        {
            currentUser = db.GetUserFromId(userId);
            userForm = sender as UserProfileForm;
        }

        private void PostTwaatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            userForm.OccupyTwaatList();
            userForm.Show();
        }

        private void twaatContentRichTextBox_TextChanged(object sender, EventArgs e)
        {
            int twaatCharCounter = twaatContentRichTextBox.Text.Length;
            twaatCharCounterLabel.Text = $"{twaatContentMaxLength - twaatCharCounter}/140";
        }

        private void clearTwaatTextButton_Click(object sender, EventArgs e)
        {
            twaatContentRichTextBox.Clear();
        }

        private void postTwaatButton_Click(object sender, EventArgs e)
        {
            if (twaatContentRichTextBox.Text == "")
            {
                MessageBox.Show("Please write something first");
            }
            else
            {
                var newTwaat = new TwaatModel(twaatContentRichTextBox.Text);
                newTwaat.UserId = currentUser.Id;
                newTwaat.Content = twaatContentRichTextBox.Text;
                newTwaat.TimeOfPosting = DateTime.Now;

                db.CreateTwaat(newTwaat);

                userForm.GetTwaats();
                MessageBox.Show("Twaat posted!");
                twaatContentRichTextBox.Clear();
            }
        }
    }
}
