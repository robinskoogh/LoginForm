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
    public partial class CreateNewUserForm : Form
    {
        LoginDataAccess db = new LoginDataAccess();

        public CreateNewUserForm()
        {
            InitializeComponent();
        }

        private void CreateNewUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Show();
        }

        private void createNewUserButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm().isValid)
            {
                var newUser = new UserModel();
                newUser.Username = newUsernameValue.Text;
                newUser.Password = newPasswordValue.Text;
                newUser.FirstName = newFirstNameValue.Text;
                newUser.LastName = newLastNameValue.Text;
                newUser.Email = newEmailValue.Text;

                db.CreateUser(newUser);

                this.Close();
            }
            else
            {
                MessageBox.Show($"Invalid form.\nThe following inputs were incorrect:\n{ValidateForm().message}");
            }
        }

        /// <summary>
        /// Simple validation of the inputs. 
        /// Outputs where there were errors if there were any.
        /// </summary>
        /// <returns></returns>
        private (bool isValid, string message) ValidateForm()
        {
            bool output = true;
            string outputMessage = "";

            if (newUsernameValue.Text.Length <= 3 || newUsernameValue.Text.Contains(" "))
            {
                output = false;
                outputMessage += "Username\n";
            }

            if (newPasswordValue.Text.Length < 6)
            {
                output = false;
                outputMessage += "Password\n";
            }

            if (newFirstNameValue.Text == "")
            {
                output = false;
                outputMessage += "First Name\n";
            }
            
            if (newLastNameValue.Text == "")
            {
                output = false;
                outputMessage += "Last Name\n";
            }

            if (newEmailValue.Text == "" || !newEmailValue.Text.Contains('@'))
            {
                output = false;
                outputMessage += "Email";
            }

            return (output, outputMessage);
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newPasswordValue.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
        }
    }
}
