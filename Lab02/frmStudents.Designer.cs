namespace Lab02
{
    partial class frmStudents
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
            lstStudents = new ListBox();
            txtName = new TextBox();
            btnAdd = new Button();
            lblDelete = new Label();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 30;
            lstStudents.Location = new Point(105, 84);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(210, 334);
            lstStudents.Sorted = true;
            lstStudents.TabIndex = 0;
            lstStudents.Click += lstStudents_Click;
            lstStudents.DoubleClick += lstStudents_DoubleClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(447, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(251, 35);
            txtName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(447, 153);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(175, 40);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add an item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDelete.Location = new Point(447, 334);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(251, 30);
            lblDelete.TabIndex = 3;
            lblDelete.Text = "[Double-click to delete.]";
            lblDelete.DoubleClick += lblDelete_DoubleClick;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = SystemColors.InactiveCaption;
            lblMessage.BorderStyle = BorderStyle.Fixed3D;
            lblMessage.Location = new Point(105, 492);
            lblMessage.MinimumSize = new Size(750, 200);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(750, 200);
            lblMessage.TabIndex = 4;
            // 
            // frmStudents
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 750);
            Controls.Add(lblMessage);
            Controls.Add(lblDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(lstStudents);
            Name = "frmStudents";
            Text = "Students";
            Load += frmStudents_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstStudents;
        private TextBox txtName;
        private Button btnAdd;
        private Label lblDelete;
        private Label lblMessage;
    }
}