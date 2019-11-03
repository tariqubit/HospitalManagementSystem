namespace HMSDiss
{
    partial class PatientDiagnoses
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
            this.btnPReset = new System.Windows.Forms.Button();
            this.listPat = new System.Windows.Forms.ListBox();
            this.btnPdelete = new System.Windows.Forms.Button();
            this.btnPupdate = new System.Windows.Forms.Button();
            this.btnPinsert = new System.Windows.Forms.Button();
            this.txtPaddre = new System.Windows.Forms.TextBox();
            this.txtPtell = new System.Windows.Forms.TextBox();
            this.txtPgendar = new System.Windows.Forms.TextBox();
            this.txtPFname = new System.Windows.Forms.TextBox();
            this.txtPpatname = new System.Windows.Forms.TextBox();
            this.txtPpatid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGPat = new System.Windows.Forms.DataGridView();
            this.txtPdocid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGPat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPReset
            // 
            this.btnPReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPReset.Location = new System.Drawing.Point(759, 261);
            this.btnPReset.Name = "btnPReset";
            this.btnPReset.Size = new System.Drawing.Size(90, 38);
            this.btnPReset.TabIndex = 35;
            this.btnPReset.Text = "Reset";
            this.btnPReset.UseVisualStyleBackColor = true;
            this.btnPReset.Click += new System.EventHandler(this.btnPReset_Click);
            // 
            // listPat
            // 
            this.listPat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listPat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPat.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPat.FormattingEnabled = true;
            this.listPat.ItemHeight = 17;
            this.listPat.Location = new System.Drawing.Point(11, 53);
            this.listPat.Name = "listPat";
            this.listPat.Size = new System.Drawing.Size(186, 238);
            this.listPat.TabIndex = 34;
            this.listPat.Click += new System.EventHandler(this.listPat_Click);
            // 
            // btnPdelete
            // 
            this.btnPdelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPdelete.Location = new System.Drawing.Point(666, 261);
            this.btnPdelete.Name = "btnPdelete";
            this.btnPdelete.Size = new System.Drawing.Size(90, 38);
            this.btnPdelete.TabIndex = 33;
            this.btnPdelete.Text = "Delete";
            this.btnPdelete.UseVisualStyleBackColor = true;
            this.btnPdelete.Click += new System.EventHandler(this.btnPdelete_Click);
            // 
            // btnPupdate
            // 
            this.btnPupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPupdate.Location = new System.Drawing.Point(573, 261);
            this.btnPupdate.Name = "btnPupdate";
            this.btnPupdate.Size = new System.Drawing.Size(90, 38);
            this.btnPupdate.TabIndex = 32;
            this.btnPupdate.Text = "Update";
            this.btnPupdate.UseVisualStyleBackColor = true;
            this.btnPupdate.Click += new System.EventHandler(this.btnPupdate_Click);
            // 
            // btnPinsert
            // 
            this.btnPinsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPinsert.Location = new System.Drawing.Point(480, 261);
            this.btnPinsert.Name = "btnPinsert";
            this.btnPinsert.Size = new System.Drawing.Size(90, 38);
            this.btnPinsert.TabIndex = 31;
            this.btnPinsert.Text = "Insert";
            this.btnPinsert.UseVisualStyleBackColor = true;
            this.btnPinsert.Click += new System.EventHandler(this.btnPinsert_Click);
            // 
            // txtPaddre
            // 
            this.txtPaddre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPaddre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPaddre.Location = new System.Drawing.Point(302, 189);
            this.txtPaddre.Multiline = true;
            this.txtPaddre.Name = "txtPaddre";
            this.txtPaddre.Size = new System.Drawing.Size(174, 45);
            this.txtPaddre.TabIndex = 30;
            // 
            // txtPtell
            // 
            this.txtPtell.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPtell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPtell.Location = new System.Drawing.Point(302, 160);
            this.txtPtell.Name = "txtPtell";
            this.txtPtell.Size = new System.Drawing.Size(174, 20);
            this.txtPtell.TabIndex = 29;
            // 
            // txtPgendar
            // 
            this.txtPgendar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPgendar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPgendar.Location = new System.Drawing.Point(302, 131);
            this.txtPgendar.Name = "txtPgendar";
            this.txtPgendar.Size = new System.Drawing.Size(174, 20);
            this.txtPgendar.TabIndex = 28;
            // 
            // txtPFname
            // 
            this.txtPFname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPFname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPFname.Location = new System.Drawing.Point(302, 102);
            this.txtPFname.Name = "txtPFname";
            this.txtPFname.Size = new System.Drawing.Size(174, 20);
            this.txtPFname.TabIndex = 27;
            // 
            // txtPpatname
            // 
            this.txtPpatname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPpatname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPpatname.Location = new System.Drawing.Point(302, 72);
            this.txtPpatname.Name = "txtPpatname";
            this.txtPpatname.Size = new System.Drawing.Size(174, 20);
            this.txtPpatname.TabIndex = 26;
            // 
            // txtPpatid
            // 
            this.txtPpatid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPpatid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPpatid.Location = new System.Drawing.Point(302, 42);
            this.txtPpatid.Name = "txtPpatid";
            this.txtPpatid.Size = new System.Drawing.Size(174, 20);
            this.txtPpatid.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(212, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tell #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(212, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(212, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Gendar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(212, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Father Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(212, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Patient Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(212, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Patient ID";
            // 
            // DGPat
            // 
            this.DGPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPat.Location = new System.Drawing.Point(1, 301);
            this.DGPat.Name = "DGPat";
            this.DGPat.Size = new System.Drawing.Size(852, 117);
            this.DGPat.TabIndex = 18;
            // 
            // txtPdocid
            // 
            this.txtPdocid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPdocid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPdocid.Location = new System.Drawing.Point(302, 240);
            this.txtPdocid.Name = "txtPdocid";
            this.txtPdocid.Size = new System.Drawing.Size(174, 20);
            this.txtPdocid.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlText;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(212, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "Doctor ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMSDiss.Properties.Resources.Patient_Forms_Large_Icon_Red_01;
            this.pictureBox1.Location = new System.Drawing.Point(551, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // PatientDiagnoses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPdocid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPReset);
            this.Controls.Add(this.listPat);
            this.Controls.Add(this.btnPdelete);
            this.Controls.Add(this.btnPupdate);
            this.Controls.Add(this.btnPinsert);
            this.Controls.Add(this.txtPaddre);
            this.Controls.Add(this.txtPtell);
            this.Controls.Add(this.txtPgendar);
            this.Controls.Add(this.txtPFname);
            this.Controls.Add(this.txtPpatname);
            this.Controls.Add(this.txtPpatid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGPat);
            this.Name = "PatientDiagnoses";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Patient ";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.PatientDiagnoses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGPat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPReset;
        private System.Windows.Forms.ListBox listPat;
        private System.Windows.Forms.Button btnPdelete;
        private System.Windows.Forms.Button btnPupdate;
        private System.Windows.Forms.Button btnPinsert;
        private System.Windows.Forms.TextBox txtPaddre;
        private System.Windows.Forms.TextBox txtPtell;
        private System.Windows.Forms.TextBox txtPgendar;
        private System.Windows.Forms.TextBox txtPFname;
        private System.Windows.Forms.TextBox txtPpatname;
        private System.Windows.Forms.TextBox txtPpatid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGPat;
        private System.Windows.Forms.TextBox txtPdocid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}