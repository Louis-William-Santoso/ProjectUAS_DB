namespace projectUas
{
    partial class FormUtama
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlPage = new TabControl();
            tabPageHomepage = new TabPage();
            label4 = new Label();
            labelHomepageNama = new Label();
            pictureBoxHomepageProfile = new PictureBox();
            tabPageAccount = new TabPage();
            tabPageHistory = new TabPage();
            panelControl = new Panel();
            labelHistoryButton = new Label();
            labelAccountButton = new Label();
            labelHomepageButton = new Label();
            buttonMenu = new PictureBox();
            tabControlPage.SuspendLayout();
            tabPageHomepage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomepageProfile).BeginInit();
            panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).BeginInit();
            SuspendLayout();
            // 
            // tabControlPage
            // 
            tabControlPage.Alignment = TabAlignment.Bottom;
            tabControlPage.Controls.Add(tabPageHomepage);
            tabControlPage.Controls.Add(tabPageAccount);
            tabControlPage.Controls.Add(tabPageHistory);
            tabControlPage.Location = new Point(61, -4);
            tabControlPage.Multiline = true;
            tabControlPage.Name = "tabControlPage";
            tabControlPage.SelectedIndex = 0;
            tabControlPage.Size = new Size(1189, 651);
            tabControlPage.TabIndex = 0;
            // 
            // tabPageHomepage
            // 
            tabPageHomepage.BackColor = Color.FromArgb(25, 25, 25);
            tabPageHomepage.Controls.Add(label4);
            tabPageHomepage.Controls.Add(labelHomepageNama);
            tabPageHomepage.Controls.Add(pictureBoxHomepageProfile);
            tabPageHomepage.Location = new Point(4, 4);
            tabPageHomepage.Name = "tabPageHomepage";
            tabPageHomepage.Padding = new Padding(3);
            tabPageHomepage.Size = new Size(1181, 623);
            tabPageHomepage.TabIndex = 0;
            tabPageHomepage.Text = "Homepage";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(168, 116);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 3;
            label4.Text = "How are you today?";
            // 
            // labelHomepageNama
            // 
            labelHomepageNama.AutoSize = true;
            labelHomepageNama.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHomepageNama.ForeColor = Color.White;
            labelHomepageNama.Location = new Point(159, 75);
            labelHomepageNama.Name = "labelHomepageNama";
            labelHomepageNama.Size = new Size(203, 45);
            labelHomepageNama.TabIndex = 2;
            labelHomepageNama.Text = "Hi! <Nama>";
            // 
            // pictureBoxHomepageProfile
            // 
            pictureBoxHomepageProfile.BackgroundImage = Properties.Resources.account;
            pictureBoxHomepageProfile.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxHomepageProfile.Location = new Point(43, 47);
            pictureBoxHomepageProfile.Name = "pictureBoxHomepageProfile";
            pictureBoxHomepageProfile.Size = new Size(110, 103);
            pictureBoxHomepageProfile.TabIndex = 1;
            pictureBoxHomepageProfile.TabStop = false;
            // 
            // tabPageAccount
            // 
            tabPageAccount.BackColor = Color.FromArgb(25, 25, 25);
            tabPageAccount.Location = new Point(4, 4);
            tabPageAccount.Name = "tabPageAccount";
            tabPageAccount.Padding = new Padding(3);
            tabPageAccount.Size = new Size(1005, 515);
            tabPageAccount.TabIndex = 1;
            tabPageAccount.Text = "Account";
            // 
            // tabPageHistory
            // 
            tabPageHistory.BackColor = Color.FromArgb(25, 25, 25);
            tabPageHistory.Location = new Point(4, 4);
            tabPageHistory.Name = "tabPageHistory";
            tabPageHistory.Padding = new Padding(3);
            tabPageHistory.Size = new Size(1005, 515);
            tabPageHistory.TabIndex = 2;
            tabPageHistory.Text = "History";
            // 
            // panelControl
            // 
            panelControl.BackColor = Color.FromArgb(38, 38, 38);
            panelControl.Controls.Add(labelHistoryButton);
            panelControl.Controls.Add(labelAccountButton);
            panelControl.Controls.Add(labelHomepageButton);
            panelControl.Controls.Add(buttonMenu);
            panelControl.Location = new Point(0, -1);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(67, 624);
            panelControl.TabIndex = 1;
            // 
            // labelHistoryButton
            // 
            labelHistoryButton.AutoSize = true;
            labelHistoryButton.BackColor = Color.FromArgb(38, 38, 38);
            labelHistoryButton.Cursor = Cursors.Hand;
            labelHistoryButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHistoryButton.ForeColor = Color.White;
            labelHistoryButton.Image = Properties.Resources.history;
            labelHistoryButton.ImageAlign = ContentAlignment.MiddleLeft;
            labelHistoryButton.Location = new Point(74, 174);
            labelHistoryButton.Name = "labelHistoryButton";
            labelHistoryButton.Size = new Size(168, 38);
            labelHistoryButton.TabIndex = 3;
            labelHistoryButton.Text = "       History";
            labelHistoryButton.Click += labelHistoryButton_Click;
            // 
            // labelAccountButton
            // 
            labelAccountButton.AutoSize = true;
            labelAccountButton.BackColor = Color.FromArgb(38, 38, 38);
            labelAccountButton.Cursor = Cursors.Hand;
            labelAccountButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAccountButton.ForeColor = Color.White;
            labelAccountButton.Image = Properties.Resources.account;
            labelAccountButton.ImageAlign = ContentAlignment.MiddleLeft;
            labelAccountButton.Location = new Point(74, 240);
            labelAccountButton.Name = "labelAccountButton";
            labelAccountButton.Size = new Size(176, 38);
            labelAccountButton.TabIndex = 2;
            labelAccountButton.Text = "       Account";
            labelAccountButton.Click += labelAccountButton_Click;
            // 
            // labelHomepageButton
            // 
            labelHomepageButton.AutoSize = true;
            labelHomepageButton.BackColor = Color.FromArgb(38, 38, 38);
            labelHomepageButton.Cursor = Cursors.Hand;
            labelHomepageButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHomepageButton.ForeColor = Color.White;
            labelHomepageButton.Image = Properties.Resources.home;
            labelHomepageButton.ImageAlign = ContentAlignment.MiddleLeft;
            labelHomepageButton.Location = new Point(74, 103);
            labelHomepageButton.Name = "labelHomepageButton";
            labelHomepageButton.Size = new Size(201, 38);
            labelHomepageButton.TabIndex = 1;
            labelHomepageButton.Text = "       Homepage";
            labelHomepageButton.Click += labelHomepageButton_Click;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = Color.Transparent;
            buttonMenu.BackgroundImage = Properties.Resources.menuStrip;
            buttonMenu.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMenu.Cursor = Cursors.Hand;
            buttonMenu.Location = new Point(7, 9);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(53, 43);
            buttonMenu.TabIndex = 0;
            buttonMenu.TabStop = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // FormUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(1245, 646);
            Controls.Add(panelControl);
            Controls.Add(tabControlPage);
            Name = "FormUtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUtama";
            Load += FormUtama_Load;
            Resize += FormUtama_Resize;
            tabControlPage.ResumeLayout(false);
            tabPageHomepage.ResumeLayout(false);
            tabPageHomepage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomepageProfile).EndInit();
            panelControl.ResumeLayout(false);
            panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPage;
        private TabPage tabPageHomepage;
        private TabPage tabPageAccount;
        private Panel panelControl;
        private PictureBox buttonMenu;
        private Label labelHomepageButton;
        private Label labelAccountButton;
        private Label labelHistoryButton;
        private Label label4;
        private Label labelHomepageNama;
        private PictureBox pictureBoxHomepageProfile;
        private TabPage tabPageHistory;
    }
}
