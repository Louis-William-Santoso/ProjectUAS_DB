using Class_Gass_livery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace projectUas
{
    public partial class FormRatingDriver : Form
    {
        public FormRatingDriver()
        {
            InitializeComponent();
        }
        public float rating;
        public string review;
        public string confirm;
        private void buttonSave_Click(object sender, EventArgs e)
        {
            rating = trackBarRating.Value;
            review = richTextBoxReview.Text;
            confirm = "Yes";
            this.Close();
        }
    }
}
