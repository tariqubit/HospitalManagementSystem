namespace HMSDiss
{
    partial class Bills
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
            this.txtBpatid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBReset = new System.Windows.Forms.Button();
            this.listBills = new System.Windows.Forms.ListBox();
            this.btnBdelete = new System.Windows.Forms.Button();
            this.btnBupdate = new System.Windows.Forms.Button();
            this.btnBinsert = new System.Windows.Forms.Button();
            this.txtBamount = new System.Windows.Forms.TextBox();
            this.txtBdocname = new System.Windows.Forms.TextBox();
            this.txtBpatname = new System.Windows.Forms.TextBox();
            this.txtBbillNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGBills = new System.Windows.Forms.DataGridView();
            this.dtpbill = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBpatid
            // 
            this.txtBpatid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBpatid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBpatid.Location = new System.Drawing.Point(321, 218);
            this.txtBpatid.Name = "txtBpatid";
            this.txtBpatid.Size = new System.Drawing.Size(200, 20);
            this.txtBpatid.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlText;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(223, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 56;
            this.label7.Text = "Patient ID";
            // 
            // btnBReset
            // 
            this.btnBReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBReset.Location = new System.Drawing.Point(753, 260);
            this.btnBReset.Name = "btnBReset";
            this.btnBReset.Size = new System.Drawing.Size(96, 34);
            this.btnBReset.TabIndex = 55;
            this.btnBReset.Text = "Reset";
            this.btnBReset.UseVisualStyleBackColor = true;
            this.btnBReset.Click += new System.EventHandler(this.btnBReset_Click);
            // 
            // listBills
            // 
            this.listBills.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBills.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBills.FormattingEnabled = true;
            this.listBills.ItemHeight = 17;
            this.listBills.Location = new System.Drawing.Point(11, 73);
            this.listBills.Name = "listBills";
            this.listBills.Size = new System.Drawing.Size(193, 221);
            this.listBills.TabIndex = 54;
            this.listBills.Click += new System.EventHandler(this.listBills_Click);
            // 
            // btnBdelete
            // 
            this.btnBdelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBdelete.Location = new System.Drawing.Point(651, 260);
            this.btnBdelete.Name = "btnBdelete";
            this.btnBdelete.Size = new System.Drawing.Size(96, 34);
            this.btnBdelete.TabIndex = 53;
            this.btnBdelete.Text = "Delete";
            this.btnBdelete.UseVisualStyleBackColor = true;
            this.btnBdelete.Click += new System.EventHandler(this.btnBdelete_Click);
            // 
            // btnBupdate
            // 
            this.btnBupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBupdate.Location = new System.Drawing.Point(549, 260);
            this.btnBupdate.Name = "btnBupdate";
            this.btnBupdate.Size = new System.Drawing.Size(96, 34);
            this.btnBupdate.TabIndex = 52;
            this.btnBupdate.Text = "Update";
            this.btnBupdate.UseVisualStyleBackColor = true;
            this.btnBupdate.Click += new System.EventHandler(this.btnBupdate_Click);
            // 
            // btnBinsert
            // 
            this.btnBinsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBinsert.Location = new System.Drawing.Point(447, 260);
            this.btnBinsert.Name = "btnBinsert";
            this.btnBinsert.Size = new System.Drawing.Size(96, 34);
            this.btnBinsert.TabIndex = 51;
            this.btnBinsert.Text = "Insert";
            this.btnBinsert.UseVisualStyleBackColor = true;
            this.btnBinsert.Click += new System.EventHandler(this.btnBinsert_Click);
            // 
            // txtBamount
            // 
            this.txtBamount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBamount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBamount.Location = new System.Drawing.Point(321, 186);
            this.txtBamount.Name = "txtBamount";
            this.txtBamount.Size = new System.Drawing.Size(200, 20);
            this.txtBamount.TabIndex = 49;
            // 
            // txtBdocname
            // 
            this.txtBdocname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBdocname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBdocname.Location = new System.Drawing.Point(321, 128);
            this.txtBdocname.Name = "txtBdocname";
            this.txtBdocname.Size = new System.Drawing.Size(200, 20);
            this.txtBdocname.TabIndex = 47;
            // 
            // txtBpatname
            // 
            this.txtBpatname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBpatname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBpatname.Location = new System.Drawing.Point(321, 98);
            this.txtBpatname.Name = "txtBpatname";
            this.txtBpatname.Size = new System.Drawing.Size(200, 20);
            this.txtBpatname.TabIndex = 46;
            // 
            // txtBbillNo
            // 
            this.txtBbillNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBbillNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBbillNo.Location = new System.Drawing.Point(321, 68);
            this.txtBbillNo.Name = "txtBbillNo";
            this.txtBbillNo.Size = new System.Drawing.Size(200, 20);
            this.txtBbillNo.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(223, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Amount ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(223, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Date Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(223, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Doctor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(223, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Patient Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(223, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Bill No";
            // 
            // DGBills
            // 
            this.DGBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBills.Location = new System.Drawing.Point(0, 304);
            this.DGBills.Name = "DGBills";
            this.DGBills.Size = new System.Drawing.Size(858, 113);
            this.DGBills.TabIndex = 38;
            // 
            // dtpbill
            // 
            this.dtpbill.Location = new System.Drawing.Point(321, 159);
            this.dtpbill.Name = "dtpbill";
            this.dtpbill.Size = new System.Drawing.Size(200, 20);
            this.dtpbill.TabIndex = 58;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMSDiss.Properties.Resources.checkIcon;
            this.pictureBox1.Location = new System.Drawing.Point(587, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 138);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpbill);
            this.Controls.Add(this.txtBpatid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBReset);
            this.Controls.Add(this.listBills);
            this.Controls.Add(this.btnBdelete);
            this.Controls.Add(this.btnBupdate);
            this.Controls.Add(this.btnBinsert);
            this.Controls.Add(this.txtBamount);
            this.Controls.Add(this.txtBdocname);
            this.Controls.Add(this.txtBpatname);
            this.Controls.Add(this.txtBbillNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGBills);
            this.Name = "Bills";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Bills";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Bills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBpatid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBReset;
        private System.Windows.Forms.ListBox listBills;
        private System.Windows.Forms.Button btnBdelete;
        private System.Windows.Forms.Button btnBupdate;
        private System.Windows.Forms.Button btnBinsert;
        private System.Windows.Forms.TextBox txtBamount;
        private System.Windows.Forms.TextBox txtBdocname;
        private System.Windows.Forms.TextBox txtBpatname;
        private System.Windows.Forms.TextBox txtBbillNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGBills;
        private System.Windows.Forms.DateTimePicker dtpbill;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}