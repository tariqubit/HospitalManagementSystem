namespace HMSDiss
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
            this.btnPDReset = new System.Windows.Forms.Button();
            this.listPatDiag = new System.Windows.Forms.ListBox();
            this.btnPDdelete = new System.Windows.Forms.Button();
            this.btnPDupdate = new System.Windows.Forms.Button();
            this.btnPDinsert = new System.Windows.Forms.Button();
            this.txtPDpatid = new System.Windows.Forms.TextBox();
            this.txtPDdiagDetails = new System.Windows.Forms.TextBox();
            this.txtPDdiagno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGPatDiag = new System.Windows.Forms.DataGridView();
            this.dtppd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPDremark = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGPatDiag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPDReset
            // 
            this.btnPDReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPDReset.Location = new System.Drawing.Point(755, 257);
            this.btnPDReset.Name = "btnPDReset";
            this.btnPDReset.Size = new System.Drawing.Size(87, 34);
            this.btnPDReset.TabIndex = 55;
            this.btnPDReset.Text = "Reset";
            this.btnPDReset.UseVisualStyleBackColor = true;
            this.btnPDReset.Click += new System.EventHandler(this.btnPDReset_Click);
            // 
            // listPatDiag
            // 
            this.listPatDiag.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listPatDiag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPatDiag.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPatDiag.FormattingEnabled = true;
            this.listPatDiag.ItemHeight = 17;
            this.listPatDiag.Location = new System.Drawing.Point(7, 70);
            this.listPatDiag.Name = "listPatDiag";
            this.listPatDiag.Size = new System.Drawing.Size(184, 221);
            this.listPatDiag.TabIndex = 54;
            this.listPatDiag.Click += new System.EventHandler(this.listPatDiag_Click);
            this.listPatDiag.SelectedIndexChanged += new System.EventHandler(this.listPatDiag_SelectedIndexChanged);
            // 
            // btnPDdelete
            // 
            this.btnPDdelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPDdelete.Location = new System.Drawing.Point(662, 257);
            this.btnPDdelete.Name = "btnPDdelete";
            this.btnPDdelete.Size = new System.Drawing.Size(87, 34);
            this.btnPDdelete.TabIndex = 53;
            this.btnPDdelete.Text = "Delete";
            this.btnPDdelete.UseVisualStyleBackColor = true;
            this.btnPDdelete.Click += new System.EventHandler(this.btnPDdelete_Click);
            // 
            // btnPDupdate
            // 
            this.btnPDupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPDupdate.Location = new System.Drawing.Point(569, 257);
            this.btnPDupdate.Name = "btnPDupdate";
            this.btnPDupdate.Size = new System.Drawing.Size(87, 34);
            this.btnPDupdate.TabIndex = 52;
            this.btnPDupdate.Text = "Update";
            this.btnPDupdate.UseVisualStyleBackColor = true;
            this.btnPDupdate.Click += new System.EventHandler(this.btnPDupdate_Click);
            // 
            // btnPDinsert
            // 
            this.btnPDinsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPDinsert.Location = new System.Drawing.Point(476, 257);
            this.btnPDinsert.Name = "btnPDinsert";
            this.btnPDinsert.Size = new System.Drawing.Size(87, 34);
            this.btnPDinsert.TabIndex = 51;
            this.btnPDinsert.Text = "Insert";
            this.btnPDinsert.UseVisualStyleBackColor = true;
            this.btnPDinsert.Click += new System.EventHandler(this.btnPDinsert_Click);
            // 
            // txtPDpatid
            // 
            this.txtPDpatid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPDpatid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPDpatid.Location = new System.Drawing.Point(331, 227);
            this.txtPDpatid.Name = "txtPDpatid";
            this.txtPDpatid.Size = new System.Drawing.Size(200, 20);
            this.txtPDpatid.TabIndex = 48;
            // 
            // txtPDdiagDetails
            // 
            this.txtPDdiagDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPDdiagDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPDdiagDetails.Location = new System.Drawing.Point(331, 108);
            this.txtPDdiagDetails.Multiline = true;
            this.txtPDdiagDetails.Name = "txtPDdiagDetails";
            this.txtPDdiagDetails.Size = new System.Drawing.Size(200, 51);
            this.txtPDdiagDetails.TabIndex = 46;
            // 
            // txtPDdiagno
            // 
            this.txtPDdiagno.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPDdiagno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPDdiagno.Location = new System.Drawing.Point(331, 78);
            this.txtPDdiagno.Name = "txtPDdiagno";
            this.txtPDdiagno.Size = new System.Drawing.Size(200, 20);
            this.txtPDdiagno.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(215, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(215, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 40;
            this.label2.Text = "Diagnosis Details\r\n ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(215, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Diagnosis No";
            // 
            // DGPatDiag
            // 
            this.DGPatDiag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPatDiag.Location = new System.Drawing.Point(-2, 301);
            this.DGPatDiag.Name = "DGPatDiag";
            this.DGPatDiag.Size = new System.Drawing.Size(856, 116);
            this.DGPatDiag.TabIndex = 38;
            // 
            // dtppd
            // 
            this.dtppd.Location = new System.Drawing.Point(331, 199);
            this.dtppd.Name = "dtppd";
            this.dtppd.Size = new System.Drawing.Size(200, 20);
            this.dtppd.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(215, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 57;
            this.label5.Text = "Diagnosis Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(215, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "Remarks";
            // 
            // txtPDremark
            // 
            this.txtPDremark.Location = new System.Drawing.Point(331, 171);
            this.txtPDremark.Name = "txtPDremark";
            this.txtPDremark.Size = new System.Drawing.Size(200, 20);
            this.txtPDremark.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMSDiss.Properties.Resources.hert;
            this.pictureBox1.Location = new System.Drawing.Point(612, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 416);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPDremark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtppd);
            this.Controls.Add(this.btnPDReset);
            this.Controls.Add(this.listPatDiag);
            this.Controls.Add(this.btnPDdelete);
            this.Controls.Add(this.btnPDupdate);
            this.Controls.Add(this.btnPDinsert);
            this.Controls.Add(this.txtPDpatid);
            this.Controls.Add(this.txtPDdiagDetails);
            this.Controls.Add(this.txtPDdiagno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGPatDiag);
            this.Name = "Form2";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Patient Diagnoses";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGPatDiag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPDReset;
        private System.Windows.Forms.ListBox listPatDiag;
        private System.Windows.Forms.Button btnPDdelete;
        private System.Windows.Forms.Button btnPDupdate;
        private System.Windows.Forms.Button btnPDinsert;
        private System.Windows.Forms.TextBox txtPDpatid;
        private System.Windows.Forms.TextBox txtPDdiagDetails;
        private System.Windows.Forms.TextBox txtPDdiagno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGPatDiag;
        private System.Windows.Forms.DateTimePicker dtppd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPDremark;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}