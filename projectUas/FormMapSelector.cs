//Tambahkan kedua library dibawah ini untuk dapat mengakases web view 
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using projectUas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace projectUas
{
    public partial class FormMapSelector : Form
    {
        public string Location = "";
        public FormMapSelector()
        {
            InitializeComponent();
        }

        private void FormMapSelector_Load(object sender, EventArgs e)
        {
            IServiceCollection serviceView = new ServiceCollection();
            serviceView.AddWindowsFormsBlazorWebView();

            serviceView.AddBlazorWebViewDeveloperTools();
            blazorWebViewMapSelector.Services = serviceView.BuildServiceProvider();

            blazorWebViewMapSelector.HostPage = "wwwroot/maps.html";
            blazorWebViewMapSelector.Services = serviceView.BuildServiceProvider();
        }

        [JSInvokable]
        public static void ReceiveLocation(string jsonLocation)
        {
           // MessageBox.Show("Data dari JS: " + jsonLocation, "Puntennn pakett.....");

            if (ActiveForm is FormMapSelector)
            {
                FormMapSelector thisForm = (FormMapSelector)ActiveForm;
                thisForm.Location = jsonLocation;
            }
        }

        private void buttonSaveLoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
