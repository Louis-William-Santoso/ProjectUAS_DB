using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Class_Gass_livery;

namespace projectUas
{
    public partial class FormAddMenu : Form
    {
        public Shop shop;
        public FormAddMenu()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string namamenu = textBoxNamaMenu.Text;
            int harga = (int)numericUpDownHarga.Value;
            int stock = (int)numericUpDownStock.Value;

            Class_Gass_livery.Menu menuBaru = new Class_Gass_livery.Menu
            (
                Class_Gass_livery.Menu.CreateID(),
                shop,
                namamenu,
                stock,
                "",
                harga,
                ""
            );
            Class_Gass_livery.Menu.MasukData(menuBaru);
            MessageBox.Show("Menu berhasil ditambahkan.", "Info");
            this.Close();
        }
    }
}
