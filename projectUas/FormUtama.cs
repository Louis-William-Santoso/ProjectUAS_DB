namespace projectUas
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        int controlPanelWidthNormal = 67;
        int controlPanelWidthExpanded = 300;
        int groupBoxControlHeight = 514;
        int groupBoxControlWidth = 1002;

        private void FormUtama_Load(object sender, EventArgs e)
        {

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

        private void labelAccountButton_Click(object sender, EventArgs e)
        {
            tabControlPage.SelectedTab = tabPageAccount;
            panelControl.Size = new Size(controlPanelWidthNormal, this.Size.Height - 35);
        }

        private void labelHistoryButton_Click(object sender, EventArgs e)
        {
            tabControlPage.SelectedTab = tabPageHistory;
            panelControl.Size = new Size(controlPanelWidthNormal, this.Size.Height - 35);
        }
        #endregion
    }
}
