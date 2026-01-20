namespace projectUas
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlLogin = new TabControl();
            tabPageLogin = new TabPage();
            label3 = new Label();
            buttonLoginCreateAccount = new Button();
            buttonLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            textBoxLoginPassword = new TextBox();
            textBoxLoginUsername = new TextBox();
            pictureBox1 = new PictureBox();
            tabPageSignUp = new TabPage();
            label20 = new Label();
            dateTimePickerBirthday = new DateTimePicker();
            labelUserID = new Label();
            labelSignUpAdress = new Label();
            buttonSignUpAddress = new Button();
            label19 = new Label();
            buttonSignUpBack = new Button();
            buttonSignUpNext = new Button();
            label11 = new Label();
            groupBox2 = new GroupBox();
            radioButtonSignUpIDunno = new RadioButton();
            radioButtonSignUpMale = new RadioButton();
            radioButtonSignUpFemale = new RadioButton();
            buttonSignUpPP = new Button();
            pictureBoxSignUp = new PictureBox();
            label10 = new Label();
            textBoxSignUpEmail = new TextBox();
            label9 = new Label();
            textBoxSignUpFullname = new TextBox();
            label7 = new Label();
            textBoxSignUpValidatePassword = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxSignUpPassword = new TextBox();
            textBoxSignUpUsername = new TextBox();
            tabPageSelectRole = new TabPage();
            buttonSelectRoleBack = new Button();
            buttonSelectRoleNext = new Button();
            checkBoxSelectRoleMerchant = new CheckBox();
            checkBoxSelectRoleDriver = new CheckBox();
            label13 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            tabPageDriverSetup = new TabPage();
            numericUpDownNoPlatTengah = new NumericUpDown();
            comboBoxNoPlatDepan = new ComboBox();
            comboBoxVehicleType = new ComboBox();
            label15 = new Label();
            buttonCreateDriverBack = new Button();
            buttonCreateDriverNext = new Button();
            dateTimePickerYearProduce = new DateTimePicker();
            label17 = new Label();
            label16 = new Label();
            textBoxNoPlatBlakang = new TextBox();
            label14 = new Label();
            tabPageMerchant = new TabPage();
            button7 = new Button();
            label21 = new Label();
            label22 = new Label();
            textBox9 = new TextBox();
            buttonSetShopProfile = new Button();
            pictureBoxShopProfile = new PictureBox();
            buttonAddShopBack = new Button();
            buttonAddShopNext = new Button();
            label18 = new Label();
            tabPageFinishSetup = new TabPage();
            buttonFinishSetup = new Button();
            buttonFinishBack = new Button();
            pictureBox3 = new PictureBox();
            label12 = new Label();
            tabControlLogin.SuspendLayout();
            tabPageLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPageSignUp.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSignUp).BeginInit();
            tabPageSelectRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tabPageDriverSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNoPlatTengah).BeginInit();
            tabPageMerchant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShopProfile).BeginInit();
            tabPageFinishSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // tabControlLogin
            // 
            tabControlLogin.Alignment = TabAlignment.Bottom;
            tabControlLogin.Controls.Add(tabPageLogin);
            tabControlLogin.Controls.Add(tabPageSignUp);
            tabControlLogin.Controls.Add(tabPageSelectRole);
            tabControlLogin.Controls.Add(tabPageDriverSetup);
            tabControlLogin.Controls.Add(tabPageMerchant);
            tabControlLogin.Controls.Add(tabPageFinishSetup);
            tabControlLogin.Location = new Point(-5, -5);
            tabControlLogin.Name = "tabControlLogin";
            tabControlLogin.SelectedIndex = 0;
            tabControlLogin.Size = new Size(672, 559);
            tabControlLogin.TabIndex = 0;
            // 
            // tabPageLogin
            // 
            tabPageLogin.BackColor = Color.FromArgb(25, 25, 25);
            tabPageLogin.Controls.Add(label3);
            tabPageLogin.Controls.Add(buttonLoginCreateAccount);
            tabPageLogin.Controls.Add(buttonLogin);
            tabPageLogin.Controls.Add(label2);
            tabPageLogin.Controls.Add(label1);
            tabPageLogin.Controls.Add(textBoxLoginPassword);
            tabPageLogin.Controls.Add(textBoxLoginUsername);
            tabPageLogin.Controls.Add(pictureBox1);
            tabPageLogin.Location = new Point(4, 4);
            tabPageLogin.Name = "tabPageLogin";
            tabPageLogin.Padding = new Padding(3);
            tabPageLogin.Size = new Size(664, 531);
            tabPageLogin.TabIndex = 0;
            tabPageLogin.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(307, 387);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(28, 20);
            label3.TabIndex = 25;
            label3.Text = "Or";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // buttonLoginCreateAccount
            // 
            buttonLoginCreateAccount.BackColor = Color.FromArgb(25, 25, 25);
            buttonLoginCreateAccount.FlatStyle = FlatStyle.Flat;
            buttonLoginCreateAccount.Location = new Point(241, 410);
            buttonLoginCreateAccount.Name = "buttonLoginCreateAccount";
            buttonLoginCreateAccount.Size = new Size(157, 42);
            buttonLoginCreateAccount.TabIndex = 24;
            buttonLoginCreateAccount.Text = "Create Account";
            buttonLoginCreateAccount.UseVisualStyleBackColor = false;
            buttonLoginCreateAccount.Click += buttonLoginCreateAccount_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(38, 38, 38);
            buttonLogin.Location = new Point(241, 342);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(157, 42);
            buttonLogin.TabIndex = 23;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(282, 265);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(74, 20);
            label2.TabIndex = 22;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(282, 205);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(77, 20);
            label1.TabIndex = 21;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.BackColor = Color.FromArgb(25, 25, 25);
            textBoxLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxLoginPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLoginPassword.ForeColor = Color.White;
            textBoxLoginPassword.Location = new Point(190, 288);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.Size = new Size(250, 33);
            textBoxLoginPassword.TabIndex = 2;
            textBoxLoginPassword.TextAlign = HorizontalAlignment.Center;
            textBoxLoginPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLoginUsername
            // 
            textBoxLoginUsername.BackColor = Color.FromArgb(25, 25, 25);
            textBoxLoginUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxLoginUsername.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLoginUsername.ForeColor = Color.White;
            textBoxLoginUsername.Location = new Point(191, 228);
            textBoxLoginUsername.Name = "textBoxLoginUsername";
            textBoxLoginUsername.Size = new Size(250, 34);
            textBoxLoginUsername.TabIndex = 1;
            textBoxLoginUsername.Tag = "";
            textBoxLoginUsername.TextAlign = HorizontalAlignment.Center;
            textBoxLoginUsername.WordWrap = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.gassLivery;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(244, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPageSignUp
            // 
            tabPageSignUp.BackColor = Color.FromArgb(25, 25, 25);
            tabPageSignUp.Controls.Add(label20);
            tabPageSignUp.Controls.Add(dateTimePickerBirthday);
            tabPageSignUp.Controls.Add(labelUserID);
            tabPageSignUp.Controls.Add(labelSignUpAdress);
            tabPageSignUp.Controls.Add(buttonSignUpAddress);
            tabPageSignUp.Controls.Add(label19);
            tabPageSignUp.Controls.Add(buttonSignUpBack);
            tabPageSignUp.Controls.Add(buttonSignUpNext);
            tabPageSignUp.Controls.Add(label11);
            tabPageSignUp.Controls.Add(groupBox2);
            tabPageSignUp.Controls.Add(buttonSignUpPP);
            tabPageSignUp.Controls.Add(pictureBoxSignUp);
            tabPageSignUp.Controls.Add(label10);
            tabPageSignUp.Controls.Add(textBoxSignUpEmail);
            tabPageSignUp.Controls.Add(label9);
            tabPageSignUp.Controls.Add(textBoxSignUpFullname);
            tabPageSignUp.Controls.Add(label7);
            tabPageSignUp.Controls.Add(textBoxSignUpValidatePassword);
            tabPageSignUp.Controls.Add(label6);
            tabPageSignUp.Controls.Add(label4);
            tabPageSignUp.Controls.Add(label5);
            tabPageSignUp.Controls.Add(textBoxSignUpPassword);
            tabPageSignUp.Controls.Add(textBoxSignUpUsername);
            tabPageSignUp.Location = new Point(4, 4);
            tabPageSignUp.Name = "tabPageSignUp";
            tabPageSignUp.Padding = new Padding(3);
            tabPageSignUp.Size = new Size(664, 531);
            tabPageSignUp.TabIndex = 1;
            tabPageSignUp.Text = "SignUp";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(43, 426);
            label20.Name = "label20";
            label20.RightToLeft = RightToLeft.No;
            label20.Size = new Size(106, 20);
            label20.TabIndex = 49;
            label20.Text = "Your Birthday";
            label20.TextAlign = ContentAlignment.TopRight;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.CustomFormat = "";
            dateTimePickerBirthday.Format = DateTimePickerFormat.Short;
            dateTimePickerBirthday.Location = new Point(42, 451);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(250, 23);
            dateTimePickerBirthday.TabIndex = 48;
            // 
            // labelUserID
            // 
            labelUserID.AutoSize = true;
            labelUserID.BackColor = Color.FromArgb(25, 25, 25);
            labelUserID.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserID.ForeColor = Color.Gray;
            labelUserID.Location = new Point(44, 56);
            labelUserID.Name = "labelUserID";
            labelUserID.RightToLeft = RightToLeft.No;
            labelUserID.Size = new Size(31, 20);
            labelUserID.TabIndex = 47;
            labelUserID.Text = "#...";
            labelUserID.TextAlign = ContentAlignment.TopRight;
            // 
            // labelSignUpAdress
            // 
            labelSignUpAdress.BackColor = Color.FromArgb(25, 25, 25);
            labelSignUpAdress.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSignUpAdress.ForeColor = Color.White;
            labelSignUpAdress.Location = new Point(419, 281);
            labelSignUpAdress.Name = "labelSignUpAdress";
            labelSignUpAdress.RightToLeft = RightToLeft.No;
            labelSignUpAdress.Size = new Size(132, 20);
            labelSignUpAdress.TabIndex = 46;
            labelSignUpAdress.Text = "...";
            labelSignUpAdress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSignUpAddress
            // 
            buttonSignUpAddress.BackColor = Color.FromArgb(37, 37, 37);
            buttonSignUpAddress.FlatStyle = FlatStyle.Flat;
            buttonSignUpAddress.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSignUpAddress.ForeColor = Color.White;
            buttonSignUpAddress.Image = Properties.Resources.add_location;
            buttonSignUpAddress.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSignUpAddress.Location = new Point(493, 213);
            buttonSignUpAddress.Name = "buttonSignUpAddress";
            buttonSignUpAddress.Size = new Size(110, 42);
            buttonSignUpAddress.TabIndex = 45;
            buttonSignUpAddress.Text = "Browse";
            buttonSignUpAddress.TextAlign = ContentAlignment.MiddleRight;
            buttonSignUpAddress.UseVisualStyleBackColor = false;
            buttonSignUpAddress.Click += buttonSignUpAddress_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.FromArgb(25, 25, 25);
            label19.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(345, 224);
            label19.Name = "label19";
            label19.RightToLeft = RightToLeft.No;
            label19.Size = new Size(132, 20);
            label19.TabIndex = 44;
            label19.Text = "Add your address";
            label19.TextAlign = ContentAlignment.TopRight;
            // 
            // buttonSignUpBack
            // 
            buttonSignUpBack.BackColor = Color.FromArgb(25, 25, 25);
            buttonSignUpBack.FlatStyle = FlatStyle.Flat;
            buttonSignUpBack.Image = Properties.Resources.alt_arrow_left;
            buttonSignUpBack.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSignUpBack.Location = new Point(398, 458);
            buttonSignUpBack.Name = "buttonSignUpBack";
            buttonSignUpBack.Size = new Size(100, 42);
            buttonSignUpBack.TabIndex = 43;
            buttonSignUpBack.Text = "Back";
            buttonSignUpBack.TextAlign = ContentAlignment.MiddleRight;
            buttonSignUpBack.UseVisualStyleBackColor = false;
            buttonSignUpBack.Click += buttonSignUpBack_Click;
            // 
            // buttonSignUpNext
            // 
            buttonSignUpNext.BackColor = Color.FromArgb(38, 38, 38);
            buttonSignUpNext.Image = Properties.Resources.alt_arrow_right;
            buttonSignUpNext.ImageAlign = ContentAlignment.MiddleRight;
            buttonSignUpNext.Location = new Point(515, 459);
            buttonSignUpNext.Name = "buttonSignUpNext";
            buttonSignUpNext.Size = new Size(98, 42);
            buttonSignUpNext.TabIndex = 42;
            buttonSignUpNext.Text = "Next";
            buttonSignUpNext.TextAlign = ContentAlignment.MiddleLeft;
            buttonSignUpNext.UseVisualStyleBackColor = false;
            buttonSignUpNext.Click += buttonSignUpNext_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(43, 373);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(36, 20);
            label11.TabIndex = 39;
            label11.Text = "Sex";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonSignUpIDunno);
            groupBox2.Controls.Add(radioButtonSignUpMale);
            groupBox2.Controls.Add(radioButtonSignUpFemale);
            groupBox2.Location = new Point(43, 387);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 37);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            // 
            // radioButtonSignUpIDunno
            // 
            radioButtonSignUpIDunno.AutoSize = true;
            radioButtonSignUpIDunno.Location = new Point(132, 12);
            radioButtonSignUpIDunno.Name = "radioButtonSignUpIDunno";
            radioButtonSignUpIDunno.Size = new Size(104, 19);
            radioButtonSignUpIDunno.TabIndex = 35;
            radioButtonSignUpIDunno.Text = "I don't know :'(";
            radioButtonSignUpIDunno.UseVisualStyleBackColor = true;
            // 
            // radioButtonSignUpMale
            // 
            radioButtonSignUpMale.AutoSize = true;
            radioButtonSignUpMale.Checked = true;
            radioButtonSignUpMale.Location = new Point(4, 12);
            radioButtonSignUpMale.Name = "radioButtonSignUpMale";
            radioButtonSignUpMale.Size = new Size(51, 19);
            radioButtonSignUpMale.TabIndex = 33;
            radioButtonSignUpMale.TabStop = true;
            radioButtonSignUpMale.Text = "Male";
            radioButtonSignUpMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonSignUpFemale
            // 
            radioButtonSignUpFemale.AutoSize = true;
            radioButtonSignUpFemale.Location = new Point(63, 12);
            radioButtonSignUpFemale.Name = "radioButtonSignUpFemale";
            radioButtonSignUpFemale.Size = new Size(63, 19);
            radioButtonSignUpFemale.TabIndex = 34;
            radioButtonSignUpFemale.Text = "Female";
            radioButtonSignUpFemale.UseVisualStyleBackColor = true;
            // 
            // buttonSignUpPP
            // 
            buttonSignUpPP.BackColor = Color.FromArgb(38, 38, 38);
            buttonSignUpPP.Location = new Point(428, 155);
            buttonSignUpPP.Name = "buttonSignUpPP";
            buttonSignUpPP.Size = new Size(123, 30);
            buttonSignUpPP.TabIndex = 38;
            buttonSignUpPP.Text = "Select Profile picture";
            buttonSignUpPP.UseVisualStyleBackColor = false;
            // 
            // pictureBoxSignUp
            // 
            pictureBoxSignUp.BackgroundImage = Properties.Resources.account;
            pictureBoxSignUp.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxSignUp.Location = new Point(439, 49);
            pictureBoxSignUp.Name = "pictureBoxSignUp";
            pictureBoxSignUp.Size = new Size(100, 100);
            pictureBoxSignUp.TabIndex = 37;
            pictureBoxSignUp.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(25, 25, 25);
            label10.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(43, 195);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(51, 20);
            label10.TabIndex = 36;
            label10.Text = "E-mail";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // textBoxSignUpEmail
            // 
            textBoxSignUpEmail.BackColor = Color.FromArgb(25, 25, 25);
            textBoxSignUpEmail.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSignUpEmail.ForeColor = Color.White;
            textBoxSignUpEmail.Location = new Point(43, 218);
            textBoxSignUpEmail.Name = "textBoxSignUpEmail";
            textBoxSignUpEmail.Size = new Size(250, 34);
            textBoxSignUpEmail.TabIndex = 35;
            textBoxSignUpEmail.Tag = "";
            textBoxSignUpEmail.TextAlign = HorizontalAlignment.Center;
            textBoxSignUpEmail.WordWrap = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(25, 25, 25);
            label9.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(43, 137);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(77, 20);
            label9.TabIndex = 34;
            label9.Text = "Full Name";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // textBoxSignUpFullname
            // 
            textBoxSignUpFullname.BackColor = Color.FromArgb(25, 25, 25);
            textBoxSignUpFullname.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSignUpFullname.ForeColor = Color.White;
            textBoxSignUpFullname.Location = new Point(43, 160);
            textBoxSignUpFullname.Name = "textBoxSignUpFullname";
            textBoxSignUpFullname.Size = new Size(250, 34);
            textBoxSignUpFullname.TabIndex = 33;
            textBoxSignUpFullname.Tag = "";
            textBoxSignUpFullname.TextAlign = HorizontalAlignment.Center;
            textBoxSignUpFullname.WordWrap = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(25, 25, 25);
            label7.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(43, 17);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(118, 38);
            label7.TabIndex = 29;
            label7.Text = "Sign Up";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // textBoxSignUpValidatePassword
            // 
            textBoxSignUpValidatePassword.BackColor = Color.FromArgb(25, 25, 25);
            textBoxSignUpValidatePassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSignUpValidatePassword.ForeColor = Color.White;
            textBoxSignUpValidatePassword.Location = new Point(43, 337);
            textBoxSignUpValidatePassword.Name = "textBoxSignUpValidatePassword";
            textBoxSignUpValidatePassword.Size = new Size(250, 33);
            textBoxSignUpValidatePassword.TabIndex = 28;
            textBoxSignUpValidatePassword.TextAlign = HorizontalAlignment.Center;
            textBoxSignUpValidatePassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(43, 314);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(132, 20);
            label6.TabIndex = 27;
            label6.Text = "Re-type Password";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(43, 255);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(74, 20);
            label4.TabIndex = 26;
            label4.Text = "Password";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(25, 25, 25);
            label5.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(43, 77);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(77, 20);
            label5.TabIndex = 25;
            label5.Text = "Username";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // textBoxSignUpPassword
            // 
            textBoxSignUpPassword.BackColor = Color.FromArgb(25, 25, 25);
            textBoxSignUpPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSignUpPassword.ForeColor = Color.White;
            textBoxSignUpPassword.Location = new Point(43, 278);
            textBoxSignUpPassword.Name = "textBoxSignUpPassword";
            textBoxSignUpPassword.Size = new Size(250, 33);
            textBoxSignUpPassword.TabIndex = 24;
            textBoxSignUpPassword.TextAlign = HorizontalAlignment.Center;
            textBoxSignUpPassword.UseSystemPasswordChar = true;
            // 
            // textBoxSignUpUsername
            // 
            textBoxSignUpUsername.BackColor = Color.FromArgb(25, 25, 25);
            textBoxSignUpUsername.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSignUpUsername.ForeColor = Color.White;
            textBoxSignUpUsername.Location = new Point(43, 100);
            textBoxSignUpUsername.Name = "textBoxSignUpUsername";
            textBoxSignUpUsername.Size = new Size(250, 34);
            textBoxSignUpUsername.TabIndex = 23;
            textBoxSignUpUsername.Tag = "";
            textBoxSignUpUsername.TextAlign = HorizontalAlignment.Center;
            textBoxSignUpUsername.WordWrap = false;
            // 
            // tabPageSelectRole
            // 
            tabPageSelectRole.BackColor = Color.FromArgb(25, 25, 25);
            tabPageSelectRole.Controls.Add(buttonSelectRoleBack);
            tabPageSelectRole.Controls.Add(buttonSelectRoleNext);
            tabPageSelectRole.Controls.Add(checkBoxSelectRoleMerchant);
            tabPageSelectRole.Controls.Add(checkBoxSelectRoleDriver);
            tabPageSelectRole.Controls.Add(label13);
            tabPageSelectRole.Controls.Add(pictureBox6);
            tabPageSelectRole.Controls.Add(pictureBox5);
            tabPageSelectRole.Controls.Add(label8);
            tabPageSelectRole.Location = new Point(4, 4);
            tabPageSelectRole.Name = "tabPageSelectRole";
            tabPageSelectRole.Padding = new Padding(3);
            tabPageSelectRole.Size = new Size(664, 531);
            tabPageSelectRole.TabIndex = 4;
            tabPageSelectRole.Text = "SelectRole";
            // 
            // buttonSelectRoleBack
            // 
            buttonSelectRoleBack.BackColor = Color.FromArgb(25, 25, 25);
            buttonSelectRoleBack.FlatStyle = FlatStyle.Flat;
            buttonSelectRoleBack.Image = Properties.Resources.alt_arrow_left;
            buttonSelectRoleBack.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSelectRoleBack.Location = new Point(52, 453);
            buttonSelectRoleBack.Name = "buttonSelectRoleBack";
            buttonSelectRoleBack.Size = new Size(100, 42);
            buttonSelectRoleBack.TabIndex = 47;
            buttonSelectRoleBack.Text = "Back";
            buttonSelectRoleBack.TextAlign = ContentAlignment.MiddleRight;
            buttonSelectRoleBack.UseVisualStyleBackColor = false;
            buttonSelectRoleBack.Click += buttonAnotherSignUpBack_Click;
            // 
            // buttonSelectRoleNext
            // 
            buttonSelectRoleNext.BackColor = Color.FromArgb(38, 38, 38);
            buttonSelectRoleNext.Image = Properties.Resources.alt_arrow_right;
            buttonSelectRoleNext.ImageAlign = ContentAlignment.MiddleRight;
            buttonSelectRoleNext.Location = new Point(514, 453);
            buttonSelectRoleNext.Name = "buttonSelectRoleNext";
            buttonSelectRoleNext.Size = new Size(98, 42);
            buttonSelectRoleNext.TabIndex = 46;
            buttonSelectRoleNext.Text = "Next";
            buttonSelectRoleNext.TextAlign = ContentAlignment.MiddleLeft;
            buttonSelectRoleNext.UseVisualStyleBackColor = false;
            buttonSelectRoleNext.Click += buttonSelectRoleNext_Click;
            // 
            // checkBoxSelectRoleMerchant
            // 
            checkBoxSelectRoleMerchant.CheckAlign = ContentAlignment.BottomCenter;
            checkBoxSelectRoleMerchant.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxSelectRoleMerchant.Location = new Point(418, 270);
            checkBoxSelectRoleMerchant.Name = "checkBoxSelectRoleMerchant";
            checkBoxSelectRoleMerchant.Size = new Size(121, 52);
            checkBoxSelectRoleMerchant.TabIndex = 45;
            checkBoxSelectRoleMerchant.Text = "Merchant";
            checkBoxSelectRoleMerchant.TextAlign = ContentAlignment.TopCenter;
            checkBoxSelectRoleMerchant.UseVisualStyleBackColor = true;
            // 
            // checkBoxSelectRoleDriver
            // 
            checkBoxSelectRoleDriver.CheckAlign = ContentAlignment.BottomCenter;
            checkBoxSelectRoleDriver.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxSelectRoleDriver.Location = new Point(133, 270);
            checkBoxSelectRoleDriver.Name = "checkBoxSelectRoleDriver";
            checkBoxSelectRoleDriver.Size = new Size(89, 52);
            checkBoxSelectRoleDriver.TabIndex = 44;
            checkBoxSelectRoleDriver.Text = "Driver";
            checkBoxSelectRoleDriver.TextAlign = ContentAlignment.TopCenter;
            checkBoxSelectRoleDriver.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(25, 25, 25);
            label13.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(188, 98);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.No;
            label13.Size = new Size(290, 59);
            label13.TabIndex = 41;
            label13.Text = "You can skip this page if you just wanna be a regullar user, or you can add your role later in the Settings menu\r\n";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.shop;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(429, 167);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 100);
            pictureBox6.TabIndex = 40;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.bike;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(127, 167);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 100);
            pictureBox5.TabIndex = 39;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(25, 25, 25);
            label8.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(209, 60);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(235, 38);
            label8.TabIndex = 30;
            label8.Text = "Select Your Role";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // tabPageDriverSetup
            // 
            tabPageDriverSetup.BackColor = Color.FromArgb(25, 25, 25);
            tabPageDriverSetup.Controls.Add(numericUpDownNoPlatTengah);
            tabPageDriverSetup.Controls.Add(comboBoxNoPlatDepan);
            tabPageDriverSetup.Controls.Add(comboBoxVehicleType);
            tabPageDriverSetup.Controls.Add(label15);
            tabPageDriverSetup.Controls.Add(buttonCreateDriverBack);
            tabPageDriverSetup.Controls.Add(buttonCreateDriverNext);
            tabPageDriverSetup.Controls.Add(dateTimePickerYearProduce);
            tabPageDriverSetup.Controls.Add(label17);
            tabPageDriverSetup.Controls.Add(label16);
            tabPageDriverSetup.Controls.Add(textBoxNoPlatBlakang);
            tabPageDriverSetup.Controls.Add(label14);
            tabPageDriverSetup.Location = new Point(4, 4);
            tabPageDriverSetup.Name = "tabPageDriverSetup";
            tabPageDriverSetup.Padding = new Padding(3);
            tabPageDriverSetup.Size = new Size(664, 531);
            tabPageDriverSetup.TabIndex = 2;
            tabPageDriverSetup.Text = "Driver";
            // 
            // numericUpDownNoPlatTengah
            // 
            numericUpDownNoPlatTengah.Location = new Point(269, 122);
            numericUpDownNoPlatTengah.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDownNoPlatTengah.Name = "numericUpDownNoPlatTengah";
            numericUpDownNoPlatTengah.Size = new Size(63, 23);
            numericUpDownNoPlatTengah.TabIndex = 53;
            // 
            // comboBoxNoPlatDepan
            // 
            comboBoxNoPlatDepan.BackColor = Color.White;
            comboBoxNoPlatDepan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNoPlatDepan.FormattingEnabled = true;
            comboBoxNoPlatDepan.Items.AddRange(new object[] { "A", "B", "D", "E", "F", "T", "Z", "G", "H", "K", "R", "AA", "AD", "AB", "L", "M", "N", "P", "S", "W", "AE", "AG", "DK", "DR", "EA", "DH", "EB", "ED", "KB", "DA", "KH", "KT", "KU", "BL", "BB", "BK", "BA", "BM", "BH", "BD", "BP", "BG", "BN", "BE", "DB", "DL", "DM", "DN", "DT", "DD", "DP", "DW", "DC", "DE", "DG", "PA", "PB" });
            comboBoxNoPlatDepan.Location = new Point(202, 122);
            comboBoxNoPlatDepan.Name = "comboBoxNoPlatDepan";
            comboBoxNoPlatDepan.Size = new Size(56, 23);
            comboBoxNoPlatDepan.TabIndex = 52;
            // 
            // comboBoxVehicleType
            // 
            comboBoxVehicleType.BackColor = Color.White;
            comboBoxVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVehicleType.FormattingEnabled = true;
            comboBoxVehicleType.Items.AddRange(new object[] { "Car", "Motorcycle" });
            comboBoxVehicleType.Location = new Point(202, 205);
            comboBoxVehicleType.Name = "comboBoxVehicleType";
            comboBoxVehicleType.Size = new Size(124, 23);
            comboBoxVehicleType.TabIndex = 51;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(25, 25, 25);
            label15.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(45, 199);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.No;
            label15.Size = new Size(144, 29);
            label15.TabIndex = 50;
            label15.Text = "Vehicle type :";
            label15.TextAlign = ContentAlignment.TopRight;
            // 
            // buttonCreateDriverBack
            // 
            buttonCreateDriverBack.BackColor = Color.FromArgb(25, 25, 25);
            buttonCreateDriverBack.FlatStyle = FlatStyle.Flat;
            buttonCreateDriverBack.Image = Properties.Resources.alt_arrow_left;
            buttonCreateDriverBack.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCreateDriverBack.Location = new Point(52, 453);
            buttonCreateDriverBack.Name = "buttonCreateDriverBack";
            buttonCreateDriverBack.Size = new Size(100, 42);
            buttonCreateDriverBack.TabIndex = 49;
            buttonCreateDriverBack.Text = "Back";
            buttonCreateDriverBack.TextAlign = ContentAlignment.MiddleRight;
            buttonCreateDriverBack.UseVisualStyleBackColor = false;
            buttonCreateDriverBack.Click += buttonAnotherSignUpBack_Click;
            // 
            // buttonCreateDriverNext
            // 
            buttonCreateDriverNext.BackColor = Color.FromArgb(38, 38, 38);
            buttonCreateDriverNext.Image = Properties.Resources.alt_arrow_right;
            buttonCreateDriverNext.ImageAlign = ContentAlignment.MiddleRight;
            buttonCreateDriverNext.Location = new Point(514, 453);
            buttonCreateDriverNext.Name = "buttonCreateDriverNext";
            buttonCreateDriverNext.Size = new Size(98, 42);
            buttonCreateDriverNext.TabIndex = 48;
            buttonCreateDriverNext.Text = "Next";
            buttonCreateDriverNext.TextAlign = ContentAlignment.MiddleLeft;
            buttonCreateDriverNext.UseVisualStyleBackColor = false;
            buttonCreateDriverNext.Click += buttonCreateDriverNext_Click;
            // 
            // dateTimePickerYearProduce
            // 
            dateTimePickerYearProduce.CustomFormat = "";
            dateTimePickerYearProduce.Format = DateTimePickerFormat.Short;
            dateTimePickerYearProduce.Location = new Point(202, 164);
            dateTimePickerYearProduce.Name = "dateTimePickerYearProduce";
            dateTimePickerYearProduce.Size = new Size(124, 23);
            dateTimePickerYearProduce.TabIndex = 37;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(25, 25, 25);
            label17.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(37, 157);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.No;
            label17.Size = new Size(154, 29);
            label17.TabIndex = 36;
            label17.Text = "Year produce :";
            label17.TextAlign = ContentAlignment.TopRight;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(25, 25, 25);
            label16.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(37, 117);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.No;
            label16.Size = new Size(152, 29);
            label16.TabIndex = 35;
            label16.Text = "License plate :";
            label16.TextAlign = ContentAlignment.TopRight;
            // 
            // textBoxNoPlatBlakang
            // 
            textBoxNoPlatBlakang.BackColor = Color.FromArgb(25, 25, 25);
            textBoxNoPlatBlakang.BorderStyle = BorderStyle.FixedSingle;
            textBoxNoPlatBlakang.Location = new Point(341, 123);
            textBoxNoPlatBlakang.Name = "textBoxNoPlatBlakang";
            textBoxNoPlatBlakang.Size = new Size(50, 23);
            textBoxNoPlatBlakang.TabIndex = 34;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(25, 25, 25);
            label14.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(37, 44);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.No;
            label14.Size = new Size(354, 38);
            label14.TabIndex = 31;
            label14.Text = "Make your driver account";
            label14.TextAlign = ContentAlignment.TopRight;
            // 
            // tabPageMerchant
            // 
            tabPageMerchant.BackColor = Color.FromArgb(25, 25, 25);
            tabPageMerchant.Controls.Add(button7);
            tabPageMerchant.Controls.Add(label21);
            tabPageMerchant.Controls.Add(label22);
            tabPageMerchant.Controls.Add(textBox9);
            tabPageMerchant.Controls.Add(buttonSetShopProfile);
            tabPageMerchant.Controls.Add(pictureBoxShopProfile);
            tabPageMerchant.Controls.Add(buttonAddShopBack);
            tabPageMerchant.Controls.Add(buttonAddShopNext);
            tabPageMerchant.Controls.Add(label18);
            tabPageMerchant.Location = new Point(4, 4);
            tabPageMerchant.Name = "tabPageMerchant";
            tabPageMerchant.Padding = new Padding(3);
            tabPageMerchant.Size = new Size(664, 531);
            tabPageMerchant.TabIndex = 5;
            tabPageMerchant.Text = "Merchant";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(37, 37, 37);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Image = Properties.Resources.add_location;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(425, 185);
            button7.Name = "button7";
            button7.Size = new Size(110, 42);
            button7.TabIndex = 57;
            button7.Text = "Browse";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.FromArgb(25, 25, 25);
            label21.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.White;
            label21.Location = new Point(247, 197);
            label21.Name = "label21";
            label21.RightToLeft = RightToLeft.No;
            label21.Size = new Size(132, 20);
            label21.TabIndex = 56;
            label21.Text = "Add your address";
            label21.TextAlign = ContentAlignment.TopRight;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.FromArgb(25, 25, 25);
            label22.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.White;
            label22.Location = new Point(249, 106);
            label22.Name = "label22";
            label22.RightToLeft = RightToLeft.No;
            label22.Size = new Size(86, 20);
            label22.TabIndex = 55;
            label22.Text = "Shop Name";
            label22.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(25, 25, 25);
            textBox9.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.ForeColor = Color.White;
            textBox9.Location = new Point(249, 129);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(286, 34);
            textBox9.TabIndex = 54;
            textBox9.Tag = "";
            textBox9.TextAlign = HorizontalAlignment.Center;
            textBox9.WordWrap = false;
            // 
            // buttonSetShopProfile
            // 
            buttonSetShopProfile.BackColor = Color.FromArgb(38, 38, 38);
            buttonSetShopProfile.Location = new Point(42, 212);
            buttonSetShopProfile.Name = "buttonSetShopProfile";
            buttonSetShopProfile.Size = new Size(123, 30);
            buttonSetShopProfile.TabIndex = 53;
            buttonSetShopProfile.Text = "Select Profile picture";
            buttonSetShopProfile.UseVisualStyleBackColor = false;
            buttonSetShopProfile.Click += buttonSetShopProfile_Click;
            // 
            // pictureBoxShopProfile
            // 
            pictureBoxShopProfile.BackgroundImage = Properties.Resources.account;
            pictureBoxShopProfile.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxShopProfile.Location = new Point(53, 106);
            pictureBoxShopProfile.Name = "pictureBoxShopProfile";
            pictureBoxShopProfile.Size = new Size(100, 100);
            pictureBoxShopProfile.TabIndex = 52;
            pictureBoxShopProfile.TabStop = false;
            // 
            // buttonAddShopBack
            // 
            buttonAddShopBack.BackColor = Color.FromArgb(25, 25, 25);
            buttonAddShopBack.FlatStyle = FlatStyle.Flat;
            buttonAddShopBack.Image = Properties.Resources.alt_arrow_left;
            buttonAddShopBack.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddShopBack.Location = new Point(52, 453);
            buttonAddShopBack.Name = "buttonAddShopBack";
            buttonAddShopBack.Size = new Size(100, 42);
            buttonAddShopBack.TabIndex = 51;
            buttonAddShopBack.Text = "Back";
            buttonAddShopBack.TextAlign = ContentAlignment.MiddleRight;
            buttonAddShopBack.UseVisualStyleBackColor = false;
            buttonAddShopBack.Click += buttonAnotherSignUpBack_Click;
            // 
            // buttonAddShopNext
            // 
            buttonAddShopNext.BackColor = Color.FromArgb(38, 38, 38);
            buttonAddShopNext.Image = Properties.Resources.alt_arrow_right;
            buttonAddShopNext.ImageAlign = ContentAlignment.MiddleRight;
            buttonAddShopNext.Location = new Point(514, 453);
            buttonAddShopNext.Name = "buttonAddShopNext";
            buttonAddShopNext.Size = new Size(98, 42);
            buttonAddShopNext.TabIndex = 50;
            buttonAddShopNext.Text = "Next";
            buttonAddShopNext.TextAlign = ContentAlignment.MiddleLeft;
            buttonAddShopNext.UseVisualStyleBackColor = false;
            buttonAddShopNext.Click += buttonAddShopNext_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(25, 25, 25);
            label18.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(37, 44);
            label18.Name = "label18";
            label18.RightToLeft = RightToLeft.No;
            label18.Size = new Size(305, 38);
            label18.TabIndex = 32;
            label18.Text = "Add your shop details";
            label18.TextAlign = ContentAlignment.TopRight;
            // 
            // tabPageFinishSetup
            // 
            tabPageFinishSetup.BackColor = Color.FromArgb(25, 25, 25);
            tabPageFinishSetup.Controls.Add(buttonFinishSetup);
            tabPageFinishSetup.Controls.Add(buttonFinishBack);
            tabPageFinishSetup.Controls.Add(pictureBox3);
            tabPageFinishSetup.Controls.Add(label12);
            tabPageFinishSetup.Location = new Point(4, 4);
            tabPageFinishSetup.Name = "tabPageFinishSetup";
            tabPageFinishSetup.Padding = new Padding(3);
            tabPageFinishSetup.Size = new Size(664, 531);
            tabPageFinishSetup.TabIndex = 3;
            tabPageFinishSetup.Text = "Finish Setup";
            // 
            // buttonFinishSetup
            // 
            buttonFinishSetup.BackColor = Color.FromArgb(38, 38, 38);
            buttonFinishSetup.Location = new Point(386, 370);
            buttonFinishSetup.Name = "buttonFinishSetup";
            buttonFinishSetup.Size = new Size(157, 42);
            buttonFinishSetup.TabIndex = 45;
            buttonFinishSetup.Text = "Finish Setup";
            buttonFinishSetup.UseVisualStyleBackColor = false;
            buttonFinishSetup.Click += buttonFinishSetup_Click;
            // 
            // buttonFinishBack
            // 
            buttonFinishBack.BackColor = Color.FromArgb(25, 25, 25);
            buttonFinishBack.Image = Properties.Resources.alt_arrow_left;
            buttonFinishBack.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFinishBack.Location = new Point(108, 370);
            buttonFinishBack.Name = "buttonFinishBack";
            buttonFinishBack.Size = new Size(100, 42);
            buttonFinishBack.TabIndex = 44;
            buttonFinishBack.Text = "Back";
            buttonFinishBack.TextAlign = ContentAlignment.MiddleRight;
            buttonFinishBack.UseVisualStyleBackColor = false;
            buttonFinishBack.Click += buttonAnotherSignUpBack_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.account;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(272, 119);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // label12
            // 
            label12.BackColor = Color.FromArgb(25, 25, 25);
            label12.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(108, 222);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(435, 128);
            label12.TabIndex = 31;
            label12.Text = "Hi <name> (๑'ᵕ'๑)⸝*\r\nYour account setup has been completed";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(25, 25, 25);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(662, 530);
            Controls.Add(tabControlLogin);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            tabControlLogin.ResumeLayout(false);
            tabPageLogin.ResumeLayout(false);
            tabPageLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPageSignUp.ResumeLayout(false);
            tabPageSignUp.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSignUp).EndInit();
            tabPageSelectRole.ResumeLayout(false);
            tabPageSelectRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tabPageDriverSetup.ResumeLayout(false);
            tabPageDriverSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNoPlatTengah).EndInit();
            tabPageMerchant.ResumeLayout(false);
            tabPageMerchant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShopProfile).EndInit();
            tabPageFinishSetup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlLogin;
        private TabPage tabPageLogin;
        private TabPage tabPageSignUp;
        private PictureBox pictureBox1;
        private TabPage tabPageDriverSetup;
        private TextBox textBoxLoginPassword;
        private TextBox textBoxLoginUsername;
        private Label label2;
        private Label label1;
        private Button buttonLogin;
        private Label label3;
        private Button buttonLoginCreateAccount;
        private Label label4;
        private Label label5;
        private TextBox textBoxSignUpPassword;
        private TextBox textBoxSignUpUsername;
        private Label label6;
        private Label label7;
        private TextBox textBoxSignUpValidatePassword;
        private Button buttonSignUpPP;
        private PictureBox pictureBoxSignUp;
        private Label label10;
        private TextBox textBoxSignUpEmail;
        private Label label9;
        private TextBox textBoxSignUpFullname;
        private Label label11;
        private GroupBox groupBox2;
        private RadioButton radioButtonSignUpIDunno;
        private RadioButton radioButtonSignUpMale;
        private RadioButton radioButtonSignUpFemale;
        private Button buttonSignUpBack;
        private Button buttonSignUpNext;
        private TabPage tabPageFinishSetup;
        private Label label12;
        private Button buttonFinishSetup;
        private Button buttonFinishBack;
        private PictureBox pictureBox3;
        private TabPage tabPageSelectRole;
        private Label label8;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label label13;
        private CheckBox checkBoxSelectRoleDriver;
        private CheckBox checkBoxSelectRoleMerchant;
        private Button buttonSelectRoleBack;
        private Button buttonSelectRoleNext;
        private Label label14;
        private Label label16;
        private DateTimePicker dateTimePickerYearProduce;
        private Label label17;
        private Button buttonCreateDriverBack;
        private Button buttonCreateDriverNext;
        private TabPage tabPageMerchant;
        private Label label18;
        private Label label19;
        private Button buttonSignUpAddress;
        private Label labelSignUpAdress;
        private Button buttonAddShopBack;
        private Button buttonAddShopNext;
        private Button button7;
        private Label label21;
        private Label label22;
        private TextBox textBox9;
        private Button buttonSetShopProfile;
        private PictureBox pictureBoxShopProfile;
        private Label label15;
        private ComboBox comboBoxVehicleType;
        private NumericUpDown numericUpDownNoPlatTengah;
        private ComboBox comboBoxNoPlatDepan;
        private TextBox textBoxNoPlatBlakang;
        private Label labelUserID;
        private Label label20;
        private DateTimePicker dateTimePickerBirthday;
    }
}