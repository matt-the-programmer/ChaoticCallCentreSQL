namespace ChaoticCallCentreGloriousEdition
{
    partial class frmMain
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.gbxComments = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboTelco = new System.Windows.Forms.ComboBox();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblTelco = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 45);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(13, 15);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(319, 133);
            this.txtComments.TabIndex = 32;
            // 
            // gbxComments
            // 
            this.gbxComments.Controls.Add(this.groupBox2);
            this.gbxComments.Controls.Add(this.txtComments);
            this.gbxComments.Location = new System.Drawing.Point(15, 153);
            this.gbxComments.Name = "gbxComments";
            this.gbxComments.Size = new System.Drawing.Size(332, 158);
            this.gbxComments.TabIndex = 37;
            this.gbxComments.TabStop = false;
            this.gbxComments.Text = "Comments";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(338, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cboTelco
            // 
            this.cboTelco.FormattingEnabled = true;
            this.cboTelco.Items.AddRange(new object[] {
            "Privacy Policy ",
            "Code of Ethics"});
            this.cboTelco.Location = new System.Drawing.Point(113, 69);
            this.cboTelco.Name = "cboTelco";
            this.cboTelco.Size = new System.Drawing.Size(121, 21);
            this.cboTelco.TabIndex = 41;
            // 
            // nudRating
            // 
            this.nudRating.Location = new System.Drawing.Point(113, 105);
            this.nudRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(120, 20);
            this.nudRating.TabIndex = 40;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 38;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(9, 105);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(45, 13);
            this.lblRating.TabIndex = 36;
            this.lblRating.Text = "Severity";
            // 
            // lblTelco
            // 
            this.lblTelco.AutoSize = true;
            this.lblTelco.Location = new System.Drawing.Point(9, 69);
            this.lblTelco.Name = "lblTelco";
            this.lblTelco.Size = new System.Drawing.Size(56, 13);
            this.lblTelco.TabIndex = 35;
            this.lblTelco.Text = "Greivance";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Name";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(142, 309);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 43);
            this.btnLoad.TabIndex = 43;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Feel Free to Enter Name As Anonymous";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxComments);
            this.Controls.Add(this.cboTelco);
            this.Controls.Add(this.nudRating);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblTelco);
            this.Controls.Add(this.lblName);
            this.Name = "frmMain";
            this.Text = "Privacy and Ethics Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbxComments.ResumeLayout(false);
            this.gbxComments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.GroupBox gbxComments;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboTelco;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblTelco;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
    }
}

