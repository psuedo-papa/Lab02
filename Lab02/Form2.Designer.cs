namespace Lab02
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            txtName = new TextBox();
            groupBox1 = new GroupBox();
            rdoSunny = new RadioButton();
            rdoSnowy = new RadioButton();
            rdoRainy = new RadioButton();
            rdoCloudy = new RadioButton();
            lblMessage = new Label();
            picCloudy = new PictureBox();
            picRainy = new PictureBox();
            picSnowy = new PictureBox();
            picSunny = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCloudy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRainy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSnowy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSunny).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 60);
            label1.Name = "label1";
            label1.Size = new Size(218, 30);
            label1.TabIndex = 0;
            label1.Text = "Enter your name here:";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(310, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(342, 35);
            txtName.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoSunny);
            groupBox1.Controls.Add(rdoSnowy);
            groupBox1.Controls.Add(rdoRainy);
            groupBox1.Controls.Add(rdoCloudy);
            groupBox1.Location = new Point(75, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 304);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose";
            // 
            // rdoSunny
            // 
            rdoSunny.AutoSize = true;
            rdoSunny.Location = new Point(30, 260);
            rdoSunny.Name = "rdoSunny";
            rdoSunny.Size = new Size(95, 34);
            rdoSunny.TabIndex = 4;
            rdoSunny.TabStop = true;
            rdoSunny.Text = "S&unny";
            rdoSunny.UseVisualStyleBackColor = true;
            rdoSunny.CheckedChanged += rdoSunny_CheckedChanged;
            // 
            // rdoSnowy
            // 
            rdoSnowy.AutoSize = true;
            rdoSnowy.Location = new Point(30, 190);
            rdoSnowy.Name = "rdoSnowy";
            rdoSnowy.Size = new Size(98, 34);
            rdoSnowy.TabIndex = 3;
            rdoSnowy.TabStop = true;
            rdoSnowy.Text = "&Snowy";
            rdoSnowy.UseVisualStyleBackColor = true;
            rdoSnowy.CheckedChanged += rdoSnowy_CheckedChanged;
            // 
            // rdoRainy
            // 
            rdoRainy.AutoSize = true;
            rdoRainy.Location = new Point(30, 120);
            rdoRainy.Name = "rdoRainy";
            rdoRainy.Size = new Size(89, 34);
            rdoRainy.TabIndex = 2;
            rdoRainy.TabStop = true;
            rdoRainy.Text = "&Rainy";
            rdoRainy.UseVisualStyleBackColor = true;
            rdoRainy.CheckedChanged += rdoRainy_CheckedChanged;
            // 
            // rdoCloudy
            // 
            rdoCloudy.AutoSize = true;
            rdoCloudy.Location = new Point(30, 50);
            rdoCloudy.Name = "rdoCloudy";
            rdoCloudy.Size = new Size(102, 34);
            rdoCloudy.TabIndex = 1;
            rdoCloudy.TabStop = true;
            rdoCloudy.Text = "&Cloudy";
            rdoCloudy.UseVisualStyleBackColor = true;
            rdoCloudy.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BorderStyle = BorderStyle.Fixed3D;
            lblMessage.Location = new Point(75, 522);
            lblMessage.MinimumSize = new Size(750, 100);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(750, 100);
            lblMessage.TabIndex = 3;
            // 
            // picCloudy
            // 
            picCloudy.Image = (Image)resources.GetObject("picCloudy.Image");
            picCloudy.Location = new Point(422, 199);
            picCloudy.Name = "picCloudy";
            picCloudy.Size = new Size(120, 120);
            picCloudy.SizeMode = PictureBoxSizeMode.Zoom;
            picCloudy.TabIndex = 4;
            picCloudy.TabStop = false;
            // 
            // picRainy
            // 
            picRainy.Image = (Image)resources.GetObject("picRainy.Image");
            picRainy.Location = new Point(571, 199);
            picRainy.Name = "picRainy";
            picRainy.Size = new Size(120, 120);
            picRainy.SizeMode = PictureBoxSizeMode.Zoom;
            picRainy.TabIndex = 5;
            picRainy.TabStop = false;
            // 
            // picSnowy
            // 
            picSnowy.Image = (Image)resources.GetObject("picSnowy.Image");
            picSnowy.Location = new Point(422, 350);
            picSnowy.Name = "picSnowy";
            picSnowy.Size = new Size(120, 120);
            picSnowy.SizeMode = PictureBoxSizeMode.Zoom;
            picSnowy.TabIndex = 6;
            picSnowy.TabStop = false;
            // 
            // picSunny
            // 
            picSunny.Image = (Image)resources.GetObject("picSunny.Image");
            picSunny.Location = new Point(571, 350);
            picSunny.Name = "picSunny";
            picSunny.Size = new Size(120, 120);
            picSunny.SizeMode = PictureBoxSizeMode.Zoom;
            picSunny.TabIndex = 7;
            picSunny.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 674);
            Controls.Add(picSunny);
            Controls.Add(picSnowy);
            Controls.Add(picRainy);
            Controls.Add(picCloudy);
            Controls.Add(lblMessage);
            Controls.Add(groupBox1);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Weather Report";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCloudy).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRainy).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSnowy).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSunny).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private GroupBox groupBox1;
        private RadioButton rdoSunny;
        private RadioButton rdoSnowy;
        private RadioButton rdoRainy;
        private RadioButton rdoCloudy;
        private Label lblMessage;
        private PictureBox picCloudy;
        private PictureBox picRainy;
        private PictureBox picSnowy;
        private PictureBox picSunny;
    }
}