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
            idTransaksi = Transaksi.CreateID();
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox == pictureBoxHomepageGassRide)
            {
                tabControlPage.SelectedTab = tabPageGassRide;
                labelGassRideUsername.Text = loginUser.Username;
                labelGassRideIdTransaksi.Text = $"#{idTransaksi.ToString()}";
                comboBoxGassRideDriver.DataSource = Driver.BacaData();
                comboBoxGassRideDriver.DisplayMember = "Username";
            }
            else if (pictureBox == pictureBoxHomepageGassKan)
            {
                tabControlPage.SelectedTab = tabPageGassKan;

                // Setup UI Awal
                labelGassKanUsername.Text = loginUser.Username; // Pastikan label ini ada di Designer
                                                                // labelGassKanIdTransaksi.Text = $"#{idTransaksi}"; // Uncomment jika ada label ID

                // Load Data Tenant ke ComboBox
                List<Shop> listShop = Shop.Bacadata();
                comboBoxGassKanTenant.DataSource = listShop;
                comboBoxGassKanTenant.DisplayMember = "NamaToko"; // Sesuai property di Class Shop
                comboBoxGassKanTenant.ValueMember = "IdTenant";
            }
            else if (pictureBox == pictureBoxHomepageGassMon)
            {
                tabControlPage.SelectedTab = tabPageGassMon;
            }
        }
        #endregion

        #region Gass-Ride
        private int gassRideJarak = 0;
        private int gassRideOngkir = 0;
        private int gassRideEkstra = 0;
        private float gassRideRatingDriver = 0;
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
                if (checkBoxGassRideMotorBaru.Checked) gassRideEkstra += 5000;
                else gassRideEkstra -= 5000;
            }
            else if (sender == checkBoxGassRideRequestDriver)
            {
                if (checkBoxGassRideRequestDriver.Checked) gassRideEkstra += 1500;
                else gassRideEkstra -= 1500;
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

        #endregion

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
            //Transaksi transaksi = new Transaksi(
            //    (string)$"{loginUser.Username.Substring(0, 3)}{Transaksi.CreateID()}",
            //    loginUser,
            //    comboBoxGassRideDriver.SelectedItem,
            //    DateTime.Now,
            //    gassRideRatingDriver,
            //    gassRideAddressAkhir.ToString()

            //    );

        }
        #region Gass-Kan
        // Variabel untuk Gass-Kan
        private Address gassKanAddressUser; // Lokasi User (Tujuan)
        private Address gassKanAddressShop; // Lokasi Toko (Asal)
        private Shop gassKanSelectedShop;   // Toko yang dipilih
        private Class_Gass_livery.Menu gassKanSelectedMenu; // Menu yang dipilih
        private int gassKanJarak = 0;
        private int gassKanOngkir = 0;
        private int gassKanHargaMenu = 0;
        private int gassKanTotal = 0;

        #endregion

        private void comboBoxGassKanTenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGassKanTenant.SelectedItem != null)
            {

                gassKanSelectedShop = (Shop)comboBoxGassKanTenant.SelectedItem;

                try
                {

                    gassKanAddressShop = JsonSerializer.Deserialize<Address>(gassKanSelectedShop.Alamat);


                    labelGassKanNotaTujuan.Text = Address.GetStringAddress(gassKanAddressShop);
                }
                catch
                {
                    labelGassKanNotaTujuan.Text = "Lokasi Error";
                }


                comboBoxGassKanMenu.DataSource = gassKanSelectedShop.MenuList;
                comboBoxGassKanMenu.DisplayMember = "Name";
                comboBoxGassKanMenu.ValueMember = "IdMenu";
                TampilkanMenuTefilter();

                labelGassKanExtra.Text = "Rp.0";
                gassKanHargaMenu = 0;


                HitungTotalGassKan();
            }
        }

        private void comboBoxGassKanMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGassKanMenu.SelectedItem != null)
            {
                gassKanSelectedMenu = (Class_Gass_livery.Menu)comboBoxGassKanMenu.SelectedItem;


                gassKanHargaMenu = gassKanSelectedMenu.Harga;
                labelGassKanExtra.Text = $"Rp.{gassKanHargaMenu}";

                HitungTotalGassKan();
            }
        }

        private void buttonGassKanMyLocationSearch_Click(object sender, EventArgs e)
        {
            FormMapSelector map = new FormMapSelector();
            map.Owner = this;
            map.ShowDialog();

            if (!string.IsNullOrEmpty(map.Location))
            {
                try
                {

                    gassKanAddressUser = JsonSerializer.Deserialize<Address>(map.Location);


                    labelGassKanNotaAsal.Text = Address.GetStringAddress(gassKanAddressUser);


                    HitungTotalGassKan();
                }
                catch
                {
                    MessageBox.Show("Gagal mengambil lokasi.");
                }
            }
        }
        private void HitungTotalGassKan()
        {

            if (gassKanAddressShop != null && gassKanAddressUser != null)
            {

                gassKanJarak = (int)Transaksi.HitungJarak(gassKanAddressShop, gassKanAddressUser);


                labelGassKanJarak.Text = $"{gassKanJarak} KM";


                int jamSekarang = DateTime.Now.Hour;
                int tarifPerKm = 750;


                if ((jamSekarang >= 11 && jamSekarang < 13) ||
                    (jamSekarang >= 17 && jamSekarang < 19))
                {
                    tarifPerKm = 1500;
                }

                gassKanOngkir = gassKanJarak * tarifPerKm;


                labelGassKanOngkir.Text = $"Rp.{gassKanOngkir}";
            }
            else
            {

                gassKanJarak = 0;
                gassKanOngkir = 0;
                labelGassKanJarak.Text = "0 KM";
                labelGassKanOngkir.Text = "Rp.0";
            }


            gassKanTotal = gassKanOngkir + gassKanHargaMenu;


            labelGassKanBiaya.Text = $"Rp.{gassKanTotal}";
        }

        private void buttonGassKanCancel_Click(object sender, EventArgs e)
        {

            gassKanAddressUser = null;
            gassKanAddressShop = null;
            gassKanSelectedShop = null;
            gassKanSelectedMenu = null;
            gassKanJarak = 0;
            gassKanOngkir = 0;
            gassKanHargaMenu = 0;
            gassKanTotal = 0;


            labelGassKanNotaAsal.Text = "<Asal>";
            labelGassKanNotaTujuan.Text = "<Tujuan>";
            labelGassKanJarak.Text = "0 KM";
            labelGassKanOngkir.Text = "Rp.0";
            labelGassKanExtra.Text = "Rp.0";
            labelGassKanBiaya.Text = "Rp.0";

            tabControlPage.SelectedTab = tabPageHomepage;
        }

        private void buttonGassKanSave_Click(object sender, EventArgs e)
        {
            if (gassKanSelectedShop == null || gassKanSelectedMenu == null || gassKanAddressUser == null)
            {
                MessageBox.Show("Mohon lengkapi data pesanan.");
                return;
            }

            try
            {

                List<Driver> listDriver = Driver.BacaData();
                Driver assignedDriver = (listDriver.Count > 0) ? listDriver[0] : null;

                if (assignedDriver == null)
                {
                    MessageBox.Show("Tidak ada driver tersedia.");
                    return;
                }


                Transaksi transBaru = new Transaksi(
                    idTransaksi,
                    loginUser,
                    assignedDriver,
                    DateTime.Now,
                    0,
                    Address.GetStringAddress(gassKanAddressShop),
                    Address.GetStringAddress(gassKanAddressUser),
                    gassKanJarak
                );
                transBaru.Verifikasi = "Pending";


                List<Class_Gass_livery.Menu> listMenu = new List<Class_Gass_livery.Menu> { gassKanSelectedMenu };
                List<Shop> listShop = new List<Shop> { gassKanSelectedShop };


                int newIdGassKan = GassKan.CreateID();


                GassKan pesananBaru = new GassKan(
                    transBaru,
                    loginUser,
                    assignedDriver,
                    1,
                    0,
                    listShop,
                    listMenu
                );


                pesananBaru.Id_gasskan = newIdGassKan;

                GassKan.MasukData(pesananBaru);

                MessageBox.Show("Pesanan berhasil disimpan!");


                buttonGassKanCancel_Click(sender, e);
                idTransaksi = Transaksi.CreateID();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void TampilkanMenuTefilter()
        {
            if (gassKanSelectedShop == null) return;

            List<Class_Gass_livery.Menu> sourceMenu;


            if (checkBoxMenuHalal.Checked)
            {

                sourceMenu = new List<Class_Gass_livery.Menu>();
                foreach (var m in gassKanSelectedShop.MenuList)
                {
                    if (m.IsHalal == true)
                    {
                        sourceMenu.Add(m);
                    }
                }
            }
            else
            {

                sourceMenu = gassKanSelectedShop.MenuList;
            }


            comboBoxGassKanMenu.DataSource = null;
            comboBoxGassKanMenu.DataSource = sourceMenu;
            comboBoxGassKanMenu.DisplayMember = "Name";
            comboBoxGassKanMenu.ValueMember = "IdMenu";
        }

        private void checkBoxMenuHalal_CheckedChanged(object sender, EventArgs e)
        {
            TampilkanMenuTefilter();

           
            labelGassKanExtra.Text = "Rp.0";
            gassKanHargaMenu = 0;
            HitungTotalGassKan();
        }
    }
}
