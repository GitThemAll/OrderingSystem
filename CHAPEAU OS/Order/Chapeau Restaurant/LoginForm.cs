using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace Chapeau_Restaurant
{
    public partial class LoginForm : Form
    {
        ChapeauForm chapeauMonitor;
        User_Services user_Services = new User_Services();

        public LoginForm(ChapeauForm monitor)
        {
            InitializeComponent();
            chapeauMonitor = monitor;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                string username = TextboxIsFilled(Username_txtbx.Text);
                string password = TextboxIsFilled(Password_txtbx.Text);
                User user = user_Services.GetUserByUserName(username, chapeauMonitor.currentUser.jobType);

                if (user.Password == password)
                {
                    chapeauMonitor.Show();
                    Hide();
            }
                else
                    MessageBox.Show("Email and password do not match");
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string TextboxIsFilled(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new Exception("a field is empty please fill in all information");
            return text;
        }

        private void Username_txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Login_btn.PerformClick();
            }
        }

        private void Password_txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Login_btn.PerformClick();
            }
        }
    }
}
