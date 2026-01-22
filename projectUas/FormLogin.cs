using Class_Gass_livery;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Formatters;
using projectUas.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
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
                string uPasswd = User.PasswdMaker(textBoxLoginPassword.Text);

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
        private string username = "<uname>";
        private string password;
        private string email;
        private string fullName;
        private sbyte gender;
        private string phoneNumber;
        public string userAddress;
        private DateTime birthDay;
        private string photoUser="tess";
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
        public string alamatToko;
        private string photoShop="tesss";
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
            List<User> listUser = User.Bacadata();
            if (textBoxSignUpPassword.Text == textBoxSignUpValidatePassword.Text)
            {
                username = textBoxSignUpUsername.Text;
                fullName = textBoxSignUpFullname.Text;
                email = textBoxSignUpEmail.Text;
                password = textBoxSignUpPassword.Text;

                
                labelFinishSetup.Text = $"Hi {username} (๑'ᵕ'๑)⸝*\r\nYour account setup has been completed";
                
                if (radioButtonSignUpMale.Checked) gender = 0;
                else if (radioButtonSignUpFemale.Checked) gender = 1;
                else gender = 2;

                bool namaSama = false;
                for(int i = 0; i<listUser.Count; i++)
                {
                    if (listUser[i].Username == username || listUser[i].Email == email)
                    {
                        namaSama = true;
                        break;
                    }
                }
                
                if (namaSama) { MessageBox.Show("Username or email already existed!!"); }
                else if (textBoxLoginUsername.Text != string.Empty) { MessageBox.Show("Username already existed!!"); }
                else tabControlLogin.SelectedTab = tabPageSelectRole;
            }
            else { MessageBox.Show("Password Not Match", "Info"); }
        }
        private void buttonSignUpAddress_Click(object sender, EventArgs e)
        {
            FormMapSelector map = new FormMapSelector();
            map.Owner = this;
            map.ShowDialog();
            userAddress = map.Location;
            Address address = JsonSerializer.Deserialize<Address>(userAddress);
            labelSignUpAdress.Text = $"Lat :{Math.Round(address.Latitude, 3)}, Long: {Math.Round(address.Longitude, 3)}";
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
            User newUser = new User(id_user, username, email, fullName,
                                     gender, phoneNumber, userAddress, birthDay, photoUser);
            newUser.Password = password;
            Driver newDriver = new Driver(newUser, idDriver, pendapatan,
                                          listKendaraan, description, statusDriver);

            Shop newShop = new Shop(idTenant, newUser, namaToko,
                                    alamatToko, menuList, photoShop);

            if (checkBoxSelectRoleDriver.Checked && checkBoxSelectRoleMerchant.Checked)
            {
                Driver.MasukData(newDriver);
                Shop.MasukData(newShop);
            }
            else if (checkBoxSelectRoleMerchant.Checked)
            {
                User.MasukData(newUser);
                Shop.MasukData(newShop);
            }
            else if (checkBoxSelectRoleDriver.Checked)
            {
                //Driver.MasukData(newDriver);
                Driver.Masukdata(newDriver);
            }
            else User.MasukData(newUser);

            MessageBox.Show(newDriver.Password);

            tabControlLogin.SelectedTab = tabPageLogin;
        }
        #endregion

        #region Driver
        private void buttonCreateDriverNext_Click(object sender, EventArgs e)
        {
            idKendaraan = $"{comboBoxNoPlatDepan.Text}{numericUpDownNoPlatTengah.Value}{textBoxNoPlatBlakang.Text}";
            tahunProduksi = dateTimePickerYearProduce.Value;
            jenis = comboBoxVehicleType.ValueMember;
            idDriver = id_user;
            if (checkBoxSelectRoleMerchant.Checked) tabControlLogin.SelectedTab = tabPageMerchant;
            else tabControlLogin.SelectedTab = tabPageFinishSetup;
        }
        #endregion

        #region Shop
        private void buttonSelectShopAddress_Click(object sender, EventArgs e)
        {
            FormMapSelector maps = new FormMapSelector();
            maps.Owner = this;
            maps.ShowDialog();
            alamatToko = maps.Location;

            Address addr = JsonSerializer.Deserialize<Address>(alamatToko);
            labelShopAddress.Text = $"Lat:{Math.Round(addr.Latitude),3},Long:{Math.Round(addr.Longitude,3)}";
        }
        private void buttonAddShopNext_Click(object sender, EventArgs e)
        {
            namaToko = textBoxShopName.Text;
            idTenant = Shop.CreateID();
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
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files (*.PNG; *.JPG; *.WEBP)|*.PNG; *.JPG; *.WEBP";
            //if (openFile.ShowDialog() == DialogResult.OK)
            //{
            //    FileStream stream = new FileStream("photo/shop/", FileMode.Create, FileAccess.Write);
            //    stream.Write(openFile.)
            //}

        }

        
    }
}
