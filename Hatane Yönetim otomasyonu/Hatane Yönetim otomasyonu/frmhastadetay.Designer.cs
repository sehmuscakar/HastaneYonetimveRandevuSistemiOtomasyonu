
namespace Hatane_Yönetim_otomasyonu
{
    partial class frmhastadetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkbilgidüzenle = new System.Windows.Forms.LinkLabel();
            this.btnrandevual = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.rchtxtsikayet = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgi";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladsoyad.Location = new System.Drawing.Point(254, 84);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(129, 36);
            this.lbladsoyad.TabIndex = 9;
            this.lbladsoyad.Text = "Null Null";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.Location = new System.Drawing.Point(254, 38);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(202, 36);
            this.lbltc.TabIndex = 8;
            this.lbltc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(85, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "TC Kimlik No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lnkbilgidüzenle);
            this.groupBox2.Controls.Add(this.btnrandevual);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbdoktor);
            this.groupBox2.Controls.Add(this.rchtxtsikayet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbbrans);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(24, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 459);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(185, 40);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(379, 34);
            this.txtid.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(131, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "İd:";
            // 
            // lnkbilgidüzenle
            // 
            this.lnkbilgidüzenle.AutoSize = true;
            this.lnkbilgidüzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkbilgidüzenle.Location = new System.Drawing.Point(6, 408);
            this.lnkbilgidüzenle.Name = "lnkbilgidüzenle";
            this.lnkbilgidüzenle.Size = new System.Drawing.Size(208, 29);
            this.lnkbilgidüzenle.TabIndex = 5;
            this.lnkbilgidüzenle.TabStop = true;
            this.lnkbilgidüzenle.Text = "Bilgilerini Düzenle";
            this.lnkbilgidüzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkbilgidüzenle_LinkClicked);
            // 
            // btnrandevual
            // 
            this.btnrandevual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnrandevual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrandevual.Location = new System.Drawing.Point(259, 355);
            this.btnrandevual.Name = "btnrandevual";
            this.btnrandevual.Size = new System.Drawing.Size(180, 44);
            this.btnrandevual.TabIndex = 3;
            this.btnrandevual.Text = "Randevu Al:";
            this.btnrandevual.UseVisualStyleBackColor = false;
            this.btnrandevual.Click += new System.EventHandler(this.btnrandevual_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hasta Şikayeti:";
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(185, 126);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(379, 37);
            this.cmbdoktor.TabIndex = 3;
            this.cmbdoktor.SelectedIndexChanged += new System.EventHandler(this.cmbdoktor_SelectedIndexChanged);
            // 
            // rchtxtsikayet
            // 
            this.rchtxtsikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchtxtsikayet.Location = new System.Drawing.Point(185, 168);
            this.rchtxtsikayet.Name = "rchtxtsikayet";
            this.rchtxtsikayet.Size = new System.Drawing.Size(379, 162);
            this.rchtxtsikayet.TabIndex = 2;
            this.rchtxtsikayet.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(89, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Doktor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(89, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Branş:";
            // 
            // cmbbrans
            // 
            this.cmbbrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(185, 80);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(379, 37);
            this.cmbbrans.TabIndex = 0;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(639, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1016, 624);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1010, 591);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // frmhastadetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1657, 635);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmhastadetay";
            this.Text = "Hasta Detay";
            this.Load += new System.EventHandler(this.frmhastadetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lnkbilgidüzenle;
        private System.Windows.Forms.Button btnrandevual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbdoktor;
        private System.Windows.Forms.RichTextBox rchtxtsikayet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
    }
}