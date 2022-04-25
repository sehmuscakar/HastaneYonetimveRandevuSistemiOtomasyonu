
namespace Hatane_Yönetim_otomasyonu
{
    partial class frmhastakayıt
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
            this.txtad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.combxcinsiyet = new System.Windows.Forms.ComboBox();
            this.btnkayıtyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(203, 29);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(251, 41);
            this.txtad.TabIndex = 1;
            // 
            // msktc
            // 
            this.msktc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktc.Location = new System.Drawing.Point(203, 123);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(251, 41);
            this.msktc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(113, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(120, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(89, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(68, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(75, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefon:";
            // 
            // msktelefon
            // 
            this.msktelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktelefon.Location = new System.Drawing.Point(203, 170);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(251, 41);
            this.msktelefon.TabIndex = 4;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Location = new System.Drawing.Point(203, 76);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(251, 41);
            this.txtsoyad.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(203, 217);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(251, 41);
            this.txtsifre.TabIndex = 5;
            // 
            // combxcinsiyet
            // 
            this.combxcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combxcinsiyet.FormattingEnabled = true;
            this.combxcinsiyet.ItemHeight = 36;
            this.combxcinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.combxcinsiyet.Location = new System.Drawing.Point(203, 262);
            this.combxcinsiyet.Name = "combxcinsiyet";
            this.combxcinsiyet.Size = new System.Drawing.Size(251, 44);
            this.combxcinsiyet.TabIndex = 6;
            // 
            // btnkayıtyap
            // 
            this.btnkayıtyap.BackColor = System.Drawing.Color.Red;
            this.btnkayıtyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayıtyap.Location = new System.Drawing.Point(219, 312);
            this.btnkayıtyap.Name = "btnkayıtyap";
            this.btnkayıtyap.Size = new System.Drawing.Size(211, 49);
            this.btnkayıtyap.TabIndex = 17;
            this.btnkayıtyap.Text = "Kayıt Yap";
            this.btnkayıtyap.UseVisualStyleBackColor = false;
            this.btnkayıtyap.Click += new System.EventHandler(this.btnkayıtyap_Click);
            // 
            // frmhastakayıt
            // 
            this.AcceptButton = this.btnkayıtyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(464, 362);
            this.Controls.Add(this.btnkayıtyap);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmhastakayıt";
            this.Text = "HASTA KAYIT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.ComboBox combxcinsiyet;
        private System.Windows.Forms.Button btnkayıtyap;
    }
}