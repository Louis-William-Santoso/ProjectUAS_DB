using projectUas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
//Tambahkan kedua library dibawah ini untuk dapat mengakases web view 
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

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
            ServiceCollection serviceView = new ServiceCollection();
            serviceView.AddWindowsFormsBlazorWebView();

            blazorWebViewMapSelector.HostPage = "wwwroot/maps.html";
            blazorWebViewMapSelector.Services = serviceView.BuildServiceProvider();
        }
    }
}
