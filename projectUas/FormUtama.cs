using System.IO;
using System;
using System.Text;
using System.Data;
using System.Reflection;
using Class_Gass_livery;
using MySql.Data.MySqlClient;

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
        List<Shop> listToko = new List<Shop>();
        List<Class_Gass_livery.ItemKeranjang> listKeranjang = new List<Class_Gass_livery.ItemKeranjang>();
        int controlPanelWidthNormal = 67;
        int controlPanelWidthExpanded = 350;
        int groupBoxControlHeight = 514;
        int groupBoxControlWidth = 1002;
        int settingsConrolHeight = 75;
        Shop tokoSaya = null;
        string pathFotoTerpilih = "";
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
            try
            {
                listToko = Shop.Bacadata();

                comboPilihTenant.DataSource = listToko;
                comboPilihTenant.DisplayMember = "NamaToko";
                comboPilihTenant.ValueMember = "IdTenant";

                comboPilihMenu.Enabled = false;
                buttonTambah.Enabled = false;

                foreach (Shop s in listToko)
                {
                    if (s.User.ID_user == loginUser.ID_user)
                    {
                        tokoSaya = s;
                        break;
                    }
                }

                if (tokoSaya != null)
                {
                    UpdateTabelMenuSaya();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load toko: " + ex.Message);
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
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox == pictureBoxHomepageGassRide)
            {
                tabControlPage.SelectedTab = tabPageGassRide;
            }
            else if (pictureBox == pictureBoxHomepageGassKan)
            {
                tabControlPage.SelectedTab = tabPageGassKan;
            }
            else if (pictureBox == pictureBoxHomepageGassMon)
            {
                tabControlPage.SelectedTab = tabPageGassMon;
            }
        }
        #endregion

        #region Gass-Ride
        private void button3_Click(object sender, EventArgs e)
        {
            FormMapSelector map = new FormMapSelector();
            map.ShowDialog();
        }
        #endregion

        #region GASSKAN LOGIC
        private void comboPilihTenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPilihTenant.SelectedItem == null) return;

            Shop tokoTerpilih = (Shop)comboPilihTenant.SelectedItem;

            comboPilihMenu.DataSource = null;
            comboPilihMenu.DataSource = tokoTerpilih.MenuList;
            comboPilihMenu.DisplayMember = "Name";

            IsiGaleriMenu(tokoTerpilih.MenuList);

            comboPilihMenu.Enabled = true;
            buttonTambah.Enabled = true;

            listKeranjang.Clear();
            UpdateGridKeranjang();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (comboPilihMenu.SelectedItem == null)
            {
                MessageBox.Show("Pilih menu dulu!");
                return;
            }

            if (numJumlah.Value <= 0)
            {
                MessageBox.Show("Jumlah beli minimal 1!");
                return;
            }

            Class_Gass_livery.ItemKeranjang itemBaru = new Class_Gass_livery.ItemKeranjang();

            itemBaru.MenuDipilih = (Class_Gass_livery.Menu)comboPilihMenu.SelectedItem;
            itemBaru.Jumlah = (int)numJumlah.Value;

            listKeranjang.Add(itemBaru);

            UpdateGridKeranjang();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listKeranjang.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong!");
                return;
            }

            Shop toko = (Shop)comboPilihTenant.SelectedItem;

            string hasil = GassKan.Checkout(loginUser, toko, listKeranjang);

            if (hasil == "Berhasil")
            {
                MessageBox.Show("Pesanan Berhasil Disimpan!");
                listKeranjang.Clear();
                UpdateGridKeranjang();
                numJumlah.Value = 0;
            }
            else
            {
                MessageBox.Show("Gagal menyimpan pesanan: " + hasil);
            }
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            buttonSave_Click(sender, e);
        }

        private void IsiGaleriMenu(List<Class_Gass_livery.Menu> menus)
        {
            if (tableGaleriMenu == null) return;

            tableGaleriMenu.Controls.Clear();

            foreach (Class_Gass_livery.Menu m in menus)
            {
                Panel kartu = new Panel();
                kartu.Size = new Size(130, 180);
                kartu.BorderStyle = BorderStyle.FixedSingle;
                kartu.BackColor = Color.White;
                kartu.Margin = new Padding(10);

                PictureBox gambar = new PictureBox();
                gambar.Size = new Size(110, 110);
                gambar.Location = new Point(10, 10);
                gambar.SizeMode = PictureBoxSizeMode.Zoom;

                if (!string.IsNullOrEmpty(m.Photo) && File.Exists(m.Photo))
                    gambar.Image = Image.FromFile(m.Photo);
                else
                    gambar.BackColor = Color.LightGray;

                Label info = new Label();
                info.Text = $"{m.Name}\nRp {m.Harga.ToString("N0")}";
                info.Location = new Point(10, 125);
                info.AutoSize = true;
                info.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                kartu.Controls.Add(gambar);
                kartu.Controls.Add(info);

                tableGaleriMenu.Controls.Add(kartu);
            }
        }

        private void UpdateGridKeranjang()
        {
            if (dataGridView1 == null) return;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listKeranjang;

            if (dataGridView1.Columns["MenuDipilih"] != null)
            {
                dataGridView1.Columns["MenuDipilih"].Visible = false;
            }

            int totalHarga = 0;
            foreach (var item in listKeranjang)
            {
                totalHarga += (item.MenuDipilih.Harga * item.Jumlah);
            }

            if (labelTotal != null)
                labelTotal.Text = "Total: Rp " + totalHarga.ToString("N0");
        }
        private void UpdateTabelMenuSaya()
        {
            if (tokoSaya != null)
            {
                string sql = $"SELECT nama_menu, harga, stock, description FROM menu WHERE id_tenant = {tokoSaya.IdTenant}";
                MySqlDataReader data = ConnectDB.Select(sql);

                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(data);

                gridMenuSaya.DataSource = dt;
            }
        }

        #endregion

        private void btnBrowseFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Pilih Gambar (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                picFotoMenu.Image = Image.FromFile(opf.FileName);
                pathFotoTerpilih = opf.FileName;
            }
        }

        private void btnSimpanMenu_Click(object sender, EventArgs e)
        {
            if (tokoSaya == null)
            {
                MessageBox.Show("Anda belum terdaftar sebagai Tenant/Merchant!");
                return;
            }

            if (txtNamaMenu.Text == "" || numHargaMenu.Value == 0 || pathFotoTerpilih == "")
            {
                MessageBox.Show("Nama, Harga, dan Foto wajib diisi!");
                return;
            }

            try
            {
                string namaFileBaru = $"Menu_{DateTime.Now.ToString("yyyyMMddHHmmss")}.jpg";
                string folderTujuan = "photo/menu/";
                string pathTujuanLengkap = Path.Combine(folderTujuan, namaFileBaru);

                if (!Directory.Exists(folderTujuan)) Directory.CreateDirectory(folderTujuan);

                File.Copy(pathFotoTerpilih, pathTujuanLengkap, true);

                int idMenuBaru = new Random().Next(1000, 99999);

                Class_Gass_livery.Menu menuBaru = new Class_Gass_livery.Menu(
                    idMenuBaru,
                    tokoSaya.IdTenant,
                    txtNamaMenu.Text,
                    (int)numStokMenu.Value,
                    pathTujuanLengkap,
                    (int)numHargaMenu.Value,
                    txtDeskripsiMenu.Text
                );

                menuBaru.Rating = 0;

                Class_Gass_livery.Menu.TambahMenu(menuBaru);

                MessageBox.Show("Menu Berhasil Ditambahkan!");

                txtNamaMenu.Clear();
                txtDeskripsiMenu.Clear();
                numHargaMenu.Value = 0;
                numStokMenu.Value = 0;
                picFotoMenu.Image = null;
                pathFotoTerpilih = "";

                UpdateTabelMenuSaya();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal simpan menu: " + ex.Message);
            }
        }
    }
}