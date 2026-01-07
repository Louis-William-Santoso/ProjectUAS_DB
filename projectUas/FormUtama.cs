using System.IO;
using System;
using System.Text;
using System.Reflection;
using Class_Gass_livery;
namespace projectUas
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        //Declaration
        int controlPanelWidthNormal = 67;
        int controlPanelWidthExpanded = 350;
        int groupBoxControlHeight = 514;
        int groupBoxControlWidth = 1002;
        int settingsConrolHeight = 75;

        private void FormUtama_Load(object sender, EventArgs e)
        {
            try
            {
                ConnectDB Connection = new ConnectDB(server.Default.DbServer, server.Default.DbName, server.Default.DbUsername, server.Default.DbPassword);

                FormLogin login = new FormLogin();
                login.ShowDialog();
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
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

            if (temp.Size.Height > settingsConrolHeight)
            {
                temp.Size = new Size(panelWidth, settingsConrolHeight);
            }
            else
            {
                temp.Size = new Size(panelWidth, 300);
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

    }
}
