namespace projectUas
{
    partial class FormRatingDriver
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
            buttonSave = new Button();
            labelTitle = new Label();
            richTextBoxReview = new RichTextBox();
            trackBarRating = new TrackBar();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(37, 37, 37);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.White;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(340, 374);
            buttonSave.Margin = new Padding(0);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(91, 39);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.FromArgb(37, 37, 37);
            labelTitle.Cursor = Cursors.Hand;
            labelTitle.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.ImageAlign = ContentAlignment.MiddleLeft;
            labelTitle.Location = new Point(76, 34);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(267, 33);
            labelTitle.TabIndex = 34;
            labelTitle.Text = "Give Our Driver Rating";
            // 
            // richTextBoxReview
            // 
            richTextBoxReview.BackColor = Color.FromArgb(25, 25, 25);
            richTextBoxReview.BorderStyle = BorderStyle.None;
            richTextBoxReview.ForeColor = Color.White;
            richTextBoxReview.Location = new Point(12, 245);
            richTextBoxReview.Name = "richTextBoxReview";
            richTextBoxReview.Size = new Size(419, 112);
            richTextBoxReview.TabIndex = 35;
            richTextBoxReview.Text = "";
            // 
            // trackBarRating
            // 
            trackBarRating.LargeChange = 1;
            trackBarRating.Location = new Point(53, 105);
            trackBarRating.Name = "trackBarRating";
            trackBarRating.Size = new Size(339, 45);
            trackBarRating.TabIndex = 36;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.flat;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(201, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.sad;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(42, 143);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 45);
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.smile;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(356, 143);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 45);
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(12, 222);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.No;
            label14.Size = new Size(108, 20);
            label14.TabIndex = 40;
            label14.Text = "Your Reviews :";
            label14.TextAlign = ContentAlignment.TopRight;
            // 
            // FormRatingDriver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            ClientSize = new Size(450, 438);
            Controls.Add(label14);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(trackBarRating);
            Controls.Add(richTextBoxReview);
            Controls.Add(labelTitle);
            Controls.Add(buttonSave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRatingDriver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRatingDriver";
            ((System.ComponentModel.ISupportInitialize)trackBarRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        public Label labelTitle;
        private RichTextBox richTextBoxReview;
        private TrackBar trackBarRating;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label14;
    }
}