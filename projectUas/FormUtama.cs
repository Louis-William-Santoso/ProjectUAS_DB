using Class_Gass_livery;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;
namespace projectUas
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        #region Declaration
        public User loginUser;
        public List<Shop> listShop;
        public List<Shop> userShop = new List<Shop>();
        string idTransaksi;
        int controlPanelWidthNormal = 67;
        int controlPanelWidthExpanded = 350;
        Transaksi transaksiUser;
        int groupBoxControlHeight = 514;
        int groupBoxControlWidth = 1002;
        int settingsConrolHeight = 75;
        #endregion


        private void FormUtama_Load(object sender, EventArgs e)
        {
            try
            {
                ConnectDB Connection = new ConnectDB(server.Default.DbServer, server.Default.DbName, server.Default.DbUsername, server.Default.DbPassword);

                if (ConnectDB.ConnectionStatus(Connection))
                {
                    FormLogin login = new FormLogin();
                    login.Owner = this;
                    login.ShowDialog();

                    if (loginUser == null) throw new Exception("data user kosong");

                    labelHomepageNama.Text = $"Hi {loginUser.Username}";

                    listShop = Shop.Bacadata();
                    List<Shop> tempList = new List<Shop>();
                    bool userPunyaToko = false;
                    for (int i = 0; i < listShop.Count; i++)
                    {
                        if (listShop[i].User.ID_user == loginUser.ID_user)
                        {
                            tempList.Add(listShop[i]);
                            userPunyaToko = true;
                        }
                    }
                    if (userPunyaToko == false) { label20.Hide(); pictureBoxHomepageMyShop.Hide(); }
                    else { userShop = tempList; }
                }
                else
                {
                    MessageBox.Show("Server connection is broken");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }


        private void FormUtama_Resize(object sender, EventArgs e)
        {
            panelControl.Size = new Size(controlPanelWidthNormal, this.Size.Height - 35);
            tabControlPage.Size = new Size(this.Size.Width - 35, this.Size.Height);
        }

        #region Panel Control
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (panelControl.Size.Width == controlPanelWidthNormal)
            {
                panelControl.Size = new Size(controlPanelWidthExpanded, this.Size.Height - 35);
            }
            else
            {
                panelControl.Size = new Size(controlPanelWidthNormal, this.Size.Height - 35);
            }
        }

        private void labelHomepageButton_Click(object sender, EventArgs e)
        {
            tabControlPage.SelectedTab = tabPageHomepage;
            panelControl.Size = new Size(controlPanelWidthNormal, this.Size.Height - 35);
        }

        private void labelSettingsButton_Click(object sender, EventArgs e)
        {
            //ui elements
            labelSettingUsername.Text = loginUser.Username;
            labelSettingFullName.Text = loginUser.FullName;
            labelSettingsIDUserProfile.Text = $"#{loginUser.ID_user}";

            tabControlPage.SelectedTab = tabPageSettings;
            panelControl.Size = new Size(controlPanelWidthNormal, this.Size.Height - 35);
        }

        private void labelHistoryButton_Click(object sender, EventArgs e)
        {
            tabControlPage.SelectedTab = tabPageHistory;
            panelControl.Size = new Size(controlPanelWidthNormal, this.Size.Height - 35);
        }
        #endregion

        #region Settings Page
        private void PanelSetting_Click(object sender, EventArgs e)
        {
            int panelWidth = 1000;
            Panel temp = new Panel();


            if (sender is Panel) temp = (Panel)sender;
            else if (sender is Label)
            {
                Label lab = (Label)sender;
                temp = (Panel)lab.Parent;
            }
            if (temp.Name == "labelSettingPanelAdress" || temp.Name == "panelSettingAdress")
            {
                if (temp.Size.Height > settingsConrolHeight)
                {
                    temp.Size = new Size(panelWidth, settingsConrolHeight);
                }
                else
                {
                    temp.Size = new Size(panelWidth, 200);
                }
            }
            else
            {
                if (temp.Size.Height > settingsConrolHeight)
                {
                    temp.Size = new Size(panelWidth, settingsConrolHeight);
                }
                else
                {
                    temp.Size = new Size(panelWidth, 300);
                }
            }
        }

        private void TexboxInputFirstTime(object sender, EventArgs e)
        {
            //sender
        }
        #endregion

        #region Homepage
        public void Picture_click(object sender, EventArgs e)
        {
            idTransaksi = Transaksi.CreateID(loginUser);
            labelGassRideIdTransaksi.Text = idTransaksi;
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox == pictureBoxHomepageGassRide)
            {
                tabControlPage.SelectedTab = tabPageGassRide;

                labelGassRideUsername.Text = loginUser.Username;
                labelGassRideIdTransaksi.Text = $"#{idTransaksi.ToString()}";
                comboBoxGassRideDriver.DataSource = Driver.BacaData();
                comboBoxGassRideDriver.DisplayMember = "Username";

                if (loginUser.Gender == 0) checkBoxGassRideRequestDriver.Hide(); label7.Hide();
            }
            else if (pictureBox == pictureBoxHomepageGassKan)
            {
                tabControlPage.SelectedTab = tabPageGassKan;
            }
            else if (pictureBox == pictureBoxHomepageGassMon)
            {
                tabControlPage.SelectedTab = tabPageGassMon;
            }
            else if (pictureBox == pictureBoxHomepageMyShop)
            {
                tabControlPage.SelectedTab = tabPageTenant;
                comboBoxShopSelectShop.DataSource = userShop;
                comboBoxShopSelectShop.DisplayMember = "NamaToko";
                dataGridViewDataShopMenu.DataSource = ((Shop)comboBoxShopSelectShop.SelectedItem).MenuList;
            }
        }
        #endregion

        #region Gass-Ride
        private int gassRideJarak = 0;
        private int gassRideOngkir = 0;
        private int gassRideEkstra = 0;
        private sbyte gassRideDriverWanita = 0;
        private sbyte gassRideKendaraanbaru = 0;
        private Address gassRideAddressAwal;
        private Address gassRideAddressAkhir;
        private void buttonGassRideTargetLocationSearch_Click(object sender, EventArgs e)
        {
            FormMapSelector map = new FormMapSelector();
            map.ShowDialog();
            gassRideAddressAkhir = JsonSerializer.Deserialize<Address>(map.Location);
            labelGassRideTargetLocation.Text = Address.GetStringAddress(gassRideAddressAkhir);
            labelGassRideNotaTujuan.Text = Address.GetStringAddress(gassRideAddressAkhir);

            if (gassRideAddressAwal != null)
            {
                gassRideJarak = (int)Transaksi.HitungJarak(gassRideAddressAwal, gassRideAddressAkhir);
                labelGassRideJarak.Text = $"{gassRideJarak} KM";
            }

        }
        private void buttonGassRideMyLocationSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FormMapSelector map = new FormMapSelector();
                map.ShowDialog();
                gassRideAddressAwal = JsonSerializer.Deserialize<Address>(map.Location);
                labelGassRideMyLocation.Text = Address.GetStringAddress(gassRideAddressAwal);
                labelGassRideNotaTitikAsal.Text = Address.GetStringAddress(gassRideAddressAwal);

                if (gassRideAddressAkhir != null)
                {
                    gassRideJarak = (int)Transaksi.HitungJarak(gassRideAddressAwal, gassRideAddressAkhir);
                    labelGassRideJarak.Text = $"{gassRideJarak} KM";
                }
            }
            catch (Exception er) { MessageBox.Show(er.Message); }
        }
        private void HitungTotalGassRide(object sender, EventArgs e)
        {
            int jamSekarang = DateTime.Now.Hour;
            if (sender == numericUpDownGassRideHour)
            {
                jamSekarang = (int)numericUpDownGassRideHour.Value;
                if ((jamSekarang >= 6 && jamSekarang <= 8) ||
                   (jamSekarang >= 16 && jamSekarang <= 18))
                {
                    gassRideOngkir = (gassRideJarak * 2000);
                }
                else gassRideOngkir = (gassRideJarak * 1000);
            }

            if (sender == checkBoxGassRideMotorBaru)
            {
                if (checkBoxGassRideMotorBaru.Checked)
                {
                    gassRideEkstra += 5000;
                    gassRideKendaraanbaru = 1;
                }
                else gassRideEkstra -= 5000; gassRideKendaraanbaru = 0;
            }
            else if (sender == checkBoxGassRideRequestDriver)
            {
                if (checkBoxGassRideRequestDriver.Checked)
                {
                    gassRideEkstra += 1500;
                    gassRideDriverWanita = 1;
                }
                else gassRideEkstra -= 1500; gassRideDriverWanita = 0;
            }
            else if (sender == labelGassRideJarak)
            {
                if ((jamSekarang >= 6 && jamSekarang <= 8) ||
                   (jamSekarang >= 16 && jamSekarang <= 18))
                {
                    gassRideOngkir = (gassRideJarak * 2000);
                }
                else gassRideOngkir = (gassRideJarak * 1000);
            }

            labelGassRideExtra.Text = $"Rp.{gassRideEkstra}";
            labelGassRideOngkir.Text = $"Rp.{gassRideOngkir}";
            labelGassRideTotalBayar.Text = $"Rp.{gassRideEkstra + gassRideOngkir}";
        }

        private void buttonGassRideCancel_Click(object sender, EventArgs e)
        {
            checkBoxGassRideMotorBaru.Checked = false;
            checkBoxGassRideRequestDriver.Checked = false;

            gassRideJarak = 0;
            gassRideOngkir = 0;
            gassRideEkstra = 0;
            gassRideAddressAwal = null;
            gassRideAddressAkhir = null;

            labelGassRideNotaTitikAsal.Text = "<Asal>";
            labelGassRideNotaTujuan.Text = "<Tujuan>";
            labelGassRideMyLocation.Text = "......";
            labelGassRideTargetLocation.Text = "......";
            labelGassRideJarak.Text = "0KM";
            labelGassRideExtra.Text = "Rp.0";
            labelGassRideOngkir.Text = "Rp.0";
            labelGassRideTotalBayar.Text = "Rp.0";

            tabControlPage.SelectedTab = tabPageHomepage;
        }
        private void buttonGassRideSave_Click(object sender, EventArgs e)
        {
            FormRatingDriver rd = new FormRatingDriver();
            rd.Owner = this;
            rd.ShowDialog();

            Transaksi transaksi = new Transaksi(
                idTransaksi,
                loginUser,
                (Driver)comboBoxGassRideDriver.SelectedItem,
                DateTime.Now,
                rd.rating,
                JsonSerializer.Serialize(gassRideAddressAkhir),
                JsonSerializer.Serialize(gassRideAddressAwal),
                gassRideJarak
            );
            transaksi.Verifikasi = rd.confirm;
            GassRide gassRide = new GassRide(transaksi,
                GassRide.CreateID(),
                (gassRideEkstra + gassRideOngkir),
                gassRideDriverWanita,
                gassRideKendaraanbaru
            );
            try
            {
                GassRide.MasukData(gassRide);
                MessageBox.Show("Data saved!!");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }
        #endregion

        #region Tenant

        #endregion

        #region Gass-Kan
        #endregion
    }
}
