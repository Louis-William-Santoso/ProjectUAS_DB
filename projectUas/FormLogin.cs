using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Class_Gass_livery;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Formatters;
using projectUas.Properties;

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
            if (!Directory.Exists("photo")) ;
            {
                Directory.CreateDirectory("photo/user");
                Directory.CreateDirectory("photo/driver");
                Directory.CreateDirectory("photo/shop");
                Directory.CreateDirectory("photo/menu");
            }
        }

        #region Login
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string uName = textBoxLoginUsername.Text;
                string uPasswd = textBoxLoginPassword.Text;

                User user = (User.Bacadata($"select * from users where username='{uName}' and password='{uPasswd}';"))[0];
                if (user != null)
                {
                    FormUtama fUtama = (FormUtama)this.Owner;
                    fUtama.loginUser = user;
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                if (ex is IndexOutOfRangeException) MessageBox.Show("Username or Password was wrong!!");
                else { MessageBox.Show(ex.Message); }
            }
        }
        #endregion

        #region Create Account
        # region Fields
        private int id_user;
        private string username;
        private string password;
        private string email;
        private string fullName;
        private sbyte gender;
        private string phoneNumber;
        private string address;
        private DateTime birthDay;
        private string photoUser;
        private int idDriver;
        private int pendapatan = 0;
        private float rating = 0;
        private string description;
        private string statusDriver = "";
        private string idKendaraan;
        private DateTime tahunProduksi;
        private string jenis;
        List<Kendaraan> listKendaraan = new List<Kendaraan>();
        private int idTenant;
        private string namaToko;
        private string alamatToko;
        private string photoShop;
        private float ratingShop;
        private List<Class_Gass_livery.Menu> menuList = new List<Class_Gass_livery.Menu>();
        #endregion

        #region Sign Up
        private void buttonLoginCreateAccount_Click(object sender, EventArgs e)
        {
            id_user = User.CreateID();
            labelUserID.Text = $"#{id_user}";
            tabControlLogin.SelectedTab = tabPageSignUp;
        }
        private void buttonSignUpNext_Click(object sender, EventArgs e)
        {
            if (textBoxSignUpPassword.Text == textBoxSignUpValidatePassword.Text)
            {
                username = textBoxLoginUsername.Text;
                fullName = textBoxSignUpFullname.Text;
                email = textBoxSignUpEmail.Text;
                password = textBoxLoginPassword.Text;

                if (radioButtonSignUpMale.Checked) gender = 0;
                else if (radioButtonSignUpFemale.Checked) gender = 1;
                else gender = 2;



                tabControlLogin.SelectedTab = tabPageSelectRole;
            }
            else { MessageBox.Show("Password Not Match", "Info"); }
        }
        private void buttonSignUpAddress_Click(object sender, EventArgs e)
        {
            FormMapSelector map = new FormMapSelector();
            map.Owner = this;
            map.ShowDialog();
        }
        #endregion

        #region Select Role
        private void buttonSelectRoleNext_Click(object sender, EventArgs e)
        {
            if (checkBoxSelectRoleDriver.Checked)
            {
                tabControlLogin.SelectedTab = tabPageDriverSetup;
            }
            else if (checkBoxSelectRoleMerchant.Checked)
            {
                tabControlLogin.SelectedTab = tabPageMerchant;
            }
            else
            {
                tabControlLogin.SelectedTab = tabPageFinishSetup;
            }
        }
        private void buttonFinishSetup_Click(object sender, EventArgs e)
        {
            User newUser = new User( id_user, username, email, fullName, 
                                     gender, phoneNumber, address, birthDay, photoUser);

            Driver newDriver = new Driver(newUser, idDriver, pendapatan, 
                                          listKendaraan, description, statusDriver);

            Shop newShop = new Shop(idTenant, newUser, namaToko,
                                    alamatToko, menuList, photoShop );

            if (checkBoxSelectRoleDriver.Checked && checkBoxSelectRoleMerchant.Checked)
            {
                Driver.MasukData(newDriver);
                Shop.MasukData(newShop);
            }
            else if (checkBoxSelectRoleMerchant.Checked)
            {
                Shop.MasukData(newShop);
            }
            else if (checkBoxSelectRoleDriver.Checked)
            {
                Driver.MasukData(newDriver);
            }
            else User.MasukData(newUser);
            
            tabControlLogin.SelectedTab = tabPageLogin;
        }
        #endregion

        #region Driver
        private void buttonCreateDriverNext_Click(object sender, EventArgs e)
        {
            idKendaraan = $"{comboBoxNoPlatDepan.Text}{numericUpDownNoPlatTengah.Value}{textBoxNoPlatBlakang.Text}";
            tahunProduksi = dateTimePickerYearProduce.Value;
            jenis = comboBoxVehicleType.ValueMember;

            if (checkBoxSelectRoleMerchant.Checked) tabControlLogin.SelectedTab = tabPageMerchant;
            else tabControlLogin.SelectedTab = tabPageFinishSetup;
        }
        #endregion

        #region Shop
        private void buttonAddShopNext_Click(object sender, EventArgs e)
        {

            tabControlLogin.SelectedTab = tabPageFinishSetup;
        }
        #endregion

        #region Back Button
        private void buttonSignUpBack_Click(object sender, EventArgs e)
        {
            tabControlLogin.SelectedTab = tabPageLogin;
        }
        private void buttonAnotherSignUpBack_Click(object sender, EventArgs e)
        {
            tabControlLogin.SelectedTab = tabPageSignUp;
        }
        #endregion

        #endregion


        private void buttonSetShopProfile_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFile = new OpenFileDialog();
            //openFile.Filter = "Image Files (*.PNG; *.JPG; *.WEBP)|*.PNG; *.JPG; *.WEBP";
            //if (openFile.ShowDialog() == DialogResult.OK) {
            //    FileStream stream = new FileStream("photo/shop/", FileMode.Create, FileAccess.Write);
            //    stream.Write(openFile.)
            //}

        }

    }
}
