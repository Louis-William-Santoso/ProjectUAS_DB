namespace projectUas
{
    partial class FormAddMenu
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
            textBoxNamaMenu = new TextBox();
            labelNamaMenu = new Label();
            label1 = new Label();
            label2 = new Label();
            numericUpDownStock = new NumericUpDown();
            numericUpDownHarga = new NumericUpDown();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHarga).BeginInit();
            SuspendLayout();
            // 
            // textBoxNamaMenu
            // 
            textBoxNamaMenu.BackColor = Color.FromArgb(37, 37, 37);
            textBoxNamaMenu.BorderStyle = BorderStyle.FixedSingle;
            textBoxNamaMenu.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNamaMenu.ForeColor = Color.White;
            textBoxNamaMenu.Location = new Point(187, 41);
            textBoxNamaMenu.Name = "textBoxNamaMenu";
            textBoxNamaMenu.Size = new Size(250, 34);
            textBoxNamaMenu.TabIndex = 2;
            textBoxNamaMenu.Tag = "";
            textBoxNamaMenu.TextAlign = HorizontalAlignment.Center;
            textBoxNamaMenu.WordWrap = false;
            // 
            // labelNamaMenu
            // 
            labelNamaMenu.AutoSize = true;
            labelNamaMenu.BackColor = Color.FromArgb(37, 37, 37);
            labelNamaMenu.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNamaMenu.ForeColor = Color.White;
            labelNamaMenu.Location = new Point(29, 47);
            labelNamaMenu.Name = "labelNamaMenu";
            labelNamaMenu.RightToLeft = RightToLeft.No;
            labelNamaMenu.Size = new Size(97, 20);
            labelNamaMenu.TabIndex = 45;
            labelNamaMenu.Text = "Menu Name :";
            labelNamaMenu.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(37, 37, 37);
            label1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 106);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(59, 20);
            label1.TabIndex = 46;
            label1.Text = "Stock :";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(37, 37, 37);
            label2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 157);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(60, 20);
            label2.TabIndex = 47;
            label2.Text = "Harga :";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(187, 108);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(120, 23);
            numericUpDownStock.TabIndex = 48;
            // 
            // numericUpDownHarga
            // 
            numericUpDownHarga.Location = new Point(187, 154);
            numericUpDownHarga.Name = "numericUpDownHarga";
            numericUpDownHarga.Size = new Size(120, 23);
            numericUpDownHarga.TabIndex = 49;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(362, 239);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 50;
            buttonSave.Text = "save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormAddMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            ClientSize = new Size(477, 293);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownHarga);
            Controls.Add(numericUpDownStock);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelNamaMenu);
            Controls.Add(textBoxNamaMenu);
            Name = "FormAddMenu";
            Text = "FormAddMenu";
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHarga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNamaMenu;
        private Label labelNamaMenu;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownStock;
        private NumericUpDown numericUpDownHarga;
        private Button buttonSave;
    }
}