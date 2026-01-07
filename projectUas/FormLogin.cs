using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectUas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        #region Login
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Create Account

        #region Sign Up
        private void buttonLoginCreateAccount_Click(object sender, EventArgs e)
        {
            tabControlLogin.SelectedTab = tabPageSignUp;
        }
        private void buttonSignUpNext_Click(object sender, EventArgs e)
        {
            tabControlLogin.SelectedTab = tabPageSelectRole;
        }
        private void buttonSelectRoleNext_Click(object sender, EventArgs e)
        {

        }
        private void buttonFinishSetup_Click(object sender, EventArgs e)
        {
            tabControlLogin.SelectedTab = tabPageLogin;
        }
        #endregion

        #region Driver

        #endregion

        #region Back Button
        private void buttonSignUpBack_Click(object sender, EventArgs e)
        {
            tabControlLogin.SelectedTab = tabPageLogin;
        }

        private void buttonFinishBack_Click(object sender, EventArgs e)
        {
            tabControlLogin.SelectedTab = tabPageSignUp;
        }
        #endregion

        #endregion

       
    }
}
