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
            mapSelector = new WebBrowser();
            labelHomepageNama = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // mapSelector
            // 
            mapSelector.Location = new Point(28, 170);
            mapSelector.Name = "mapSelector";
            mapSelector.Size = new Size(402, 295);
            mapSelector.TabIndex = 0;
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
            // textBox1
            // 
            textBox1.Location = new Point(28, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 23);
            textBox1.TabIndex = 4;
            // 
            // FormMapSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(462, 547);
            Controls.Add(textBox1);
            Controls.Add(labelHomepageNama);
            Controls.Add(mapSelector);
            Name = "FormMapSelector";
            Text = "FormMapSelector";
            Load += FormMapSelector_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private WebBrowser mapSelector;
        private Label labelHomepageNama;
        private TextBox textBox1;
    }
}