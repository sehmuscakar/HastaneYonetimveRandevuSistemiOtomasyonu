
namespace Hatane_Yönetim_otomasyonu
{
    partial class frmbilgidüzenle
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
            this.btnbilgigüncelle = new System.Windows.Forms.Button();
            this.combxcinsiyet = new System.Windows.Forms.ComboBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbilgigüncelle
            // 
            this.btnbilgigüncelle.BackColor = System.Drawing.Color.Red;
            this.btnbilgigüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbilgigüncelle.Location = new System.Drawing.Point(123, 321);
            this.btnbilgigüncelle.Name = "btnbilgigüncelle";
            this.btnbilgigüncelle.Size = new System.Drawing.Size(247, 62);
            this.btnbilgigüncelle.TabIndex = 30;
            this.btnbilgigüncelle.Text = "Güncelle";
            this.btnbilgigüncelle.UseVisualStyleBackColor = false;
            this.btnbilgigüncelle.Click += new System.EventHandler(this.btnbilgigüncelle_Click);
            // 
            // combxcinsiyet
            // 
            this.combxcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combxcinsiyet.FormattingEnabled = true;
            this.combxcinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.combxcinsiyet.Location = new System.Drawing.Point(207, 256);
            this.combxcinsiyet.Name = "combxcinsiyet";
            this.combxcinsiyet.Size = new System.Drawing.Size(247, 44);
            this.combxcinsiyet.TabIndex = 6;
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(207, 206);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(247, 41);
            this.txtsifre.TabIndex = 5;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Location = new System.Drawing.Point(207, 62);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(247, 41);
            this.txtsoyad.TabIndex = 2;
            // 
            // msktelefon
            // 
            this.msktelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktelefon.Location = new System.Drawing.Point(207, 156);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(247, 41);
            this.msktelefon.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(79, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 36);
            this.label6.TabIndex = 25;
            this.label6.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(72, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 36);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(93, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 36);
            this.label4.TabIndex = 23;
            this.label4.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(140, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ad:";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(207, 12);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(247, 41);
            this.txtad.TabIndex = 1;
            // 
            // msktc
            // 
            this.msktc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktc.Location = new System.Drawing.Point(207, 109);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(247, 41);
            this.msktc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(117, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "TC Kimlik No:";
            // 
            // frmbilgidüzenle
            // 
            this.AcceptButton = this.btnbilgigüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(957, 463);
            this.Controls.Add(this.btnbilgigüncelle);
            this.Controls.Add(this.combxcinsiyet);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmbilgidüzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.frmbilgidüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbilgigüncelle;
        private System.Windows.Forms.ComboBox combxcinsiyet;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}