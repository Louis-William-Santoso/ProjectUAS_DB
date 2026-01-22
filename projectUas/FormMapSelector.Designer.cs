using Microsoft.AspNetCore.Components.WebView.WindowsForms;

namespace projectUas
{
    partial class FormMapSelector
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
            labelHomepageNama = new Label();
            blazorWebViewMapSelector = new BlazorWebView();
            buttonSaveLoc = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // labelHomepageNama
            // 
            labelHomepageNama.AutoSize = true;
            labelHomepageNama.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHomepageNama.ForeColor = Color.White;
            labelHomepageNama.Location = new Point(28, 34);
            labelHomepageNama.Name = "labelHomepageNama";
            labelHomepageNama.Size = new Size(258, 45);
            labelHomepageNama.TabIndex = 3;
            labelHomepageNama.Text = "Select Address";
            // 
            // blazorWebViewMapSelector
            // 
            blazorWebViewMapSelector.Location = new Point(38, 158);
            blazorWebViewMapSelector.Name = "blazorWebViewMapSelector";
            blazorWebViewMapSelector.Size = new Size(544, 306);
            blazorWebViewMapSelector.TabIndex = 5;
            blazorWebViewMapSelector.Text = "blazorWebView1";
            // 
            // buttonSaveLoc
            // 
            buttonSaveLoc.Location = new Point(434, 509);
            buttonSaveLoc.Name = "buttonSaveLoc";
            buttonSaveLoc.Size = new Size(123, 38);
            buttonSaveLoc.TabIndex = 8;
            buttonSaveLoc.Text = "Save";
            buttonSaveLoc.UseVisualStyleBackColor = true;
            buttonSaveLoc.Click += buttonSaveLoc_Click;
            // 
            // button1
            // 
            button1.Location = new Point(434, 86);
            button1.Name = "button1";
            button1.Size = new Size(123, 38);
            button1.TabIndex = 7;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(39, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(351, 23);
            comboBox1.TabIndex = 6;
            // 
            // FormMapSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(617, 580);
            ControlBox = false;
            Controls.Add(buttonSaveLoc);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(blazorWebViewMapSelector);
            Controls.Add(labelHomepageNama);
            Name = "FormMapSelector";
            Text = "FormMapSelector";
            Load += FormMapSelector_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHomepageNama;
        private BlazorWebView blazorWebViewMapSelector;
        private Button buttonSaveLoc;
        private Button button1;
        private ComboBox comboBox1;
    }
}