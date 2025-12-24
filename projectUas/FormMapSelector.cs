using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace projectUas
{
    public partial class FormMapSelector : Form
    {
        public FormMapSelector()
        {
            InitializeComponent();
        }

        private void FormMapSelector_Load(object sender, EventArgs e)
        {
            Assembly ass = Assembly.GetExecutingAssembly();
            Stream path = ass.GetManifestResourceStream("http://google.com");
            mapSelector.DocumentStream = path;
        }
    }
}
