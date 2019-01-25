namespace XOX_Games
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnbotakarsi = new System.Windows.Forms.RadioButton();
            this.rbtnIkiKisilik = new System.Windows.Forms.RadioButton();
            this.rbtnLan = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLanBasla = new System.Windows.Forms.Button();
            this.rbtnYeniServer = new System.Windows.Forms.RadioButton();
            this.rbtnAgaKatil = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Created By Bekir Furkan Zadegil -- Cennet Gizem Söylemez";
            // 
            // rbtnbotakarsi
            // 
            this.rbtnbotakarsi.AutoSize = true;
            this.rbtnbotakarsi.Location = new System.Drawing.Point(40, 28);
            this.rbtnbotakarsi.Name = "rbtnbotakarsi";
            this.rbtnbotakarsi.Size = new System.Drawing.Size(101, 17);
            this.rbtnbotakarsi.TabIndex = 1;
            this.rbtnbotakarsi.Text = "Bilgisayara Karşı";
            this.rbtnbotakarsi.UseVisualStyleBackColor = true;
            this.rbtnbotakarsi.CheckedChanged += new System.EventHandler(this.rbtnbotakarsi_CheckedChanged);
            // 
            // rbtnIkiKisilik
            // 
            this.rbtnIkiKisilik.AutoSize = true;
            this.rbtnIkiKisilik.Location = new System.Drawing.Point(40, 51);
            this.rbtnIkiKisilik.Name = "rbtnIkiKisilik";
            this.rbtnIkiKisilik.Size = new System.Drawing.Size(65, 17);
            this.rbtnIkiKisilik.TabIndex = 1;
            this.rbtnIkiKisilik.Text = "İki Kişilik";
            this.rbtnIkiKisilik.UseVisualStyleBackColor = true;
            this.rbtnIkiKisilik.CheckedChanged += new System.EventHandler(this.rbtnIkiKisilik_CheckedChanged);
            // 
            // rbtnLan
            // 
            this.rbtnLan.AutoSize = true;
            this.rbtnLan.Location = new System.Drawing.Point(40, 74);
            this.rbtnLan.Name = "rbtnLan";
            this.rbtnLan.Size = new System.Drawing.Size(74, 17);
            this.rbtnLan.TabIndex = 1;
            this.rbtnLan.Text = "LAN Oyun";
            this.rbtnLan.UseVisualStyleBackColor = true;
            this.rbtnLan.CheckedChanged += new System.EventHandler(this.rbtnLan_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(94, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(94, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(119, 71);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "1. Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "2. Kullanıcı Adı";
            // 
            // btnLanBasla
            // 
            this.btnLanBasla.Location = new System.Drawing.Point(48, 65);
            this.btnLanBasla.Name = "btnLanBasla";
            this.btnLanBasla.Size = new System.Drawing.Size(112, 23);
            this.btnLanBasla.TabIndex = 5;
            this.btnLanBasla.Text = "Başla";
            this.btnLanBasla.UseVisualStyleBackColor = true;
            this.btnLanBasla.Click += new System.EventHandler(this.btnLanBasla_Click);
            // 
            // rbtnYeniServer
            // 
            this.rbtnYeniServer.AutoSize = true;
            this.rbtnYeniServer.Location = new System.Drawing.Point(48, 19);
            this.rbtnYeniServer.Name = "rbtnYeniServer";
            this.rbtnYeniServer.Size = new System.Drawing.Size(99, 17);
            this.rbtnYeniServer.TabIndex = 6;
            this.rbtnYeniServer.Text = "Yeni Server Kur";
            this.rbtnYeniServer.UseVisualStyleBackColor = true;
            // 
            // rbtnAgaKatil
            // 
            this.rbtnAgaKatil.AutoSize = true;
            this.rbtnAgaKatil.Location = new System.Drawing.Point(48, 42);
            this.rbtnAgaKatil.Name = "rbtnAgaKatil";
            this.rbtnAgaKatil.Size = new System.Drawing.Size(67, 17);
            this.rbtnAgaKatil.TabIndex = 6;
            this.rbtnAgaKatil.Text = "Ağa Katıl";
            this.rbtnAgaKatil.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnbotakarsi);
            this.groupBox1.Controls.Add(this.rbtnIkiKisilik);
            this.groupBox1.Controls.Add(this.rbtnLan);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oyun Ayarları";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.btnBasla);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(246, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Ayarları";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnYeniServer);
            this.groupBox3.Controls.Add(this.btnLanBasla);
            this.groupBox3.Controls.Add(this.rbtnAgaKatil);
            this.groupBox3.Location = new System.Drawing.Point(12, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lan Ayarları";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 282);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "XOX Games ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnbotakarsi;
        private System.Windows.Forms.RadioButton rbtnIkiKisilik;
        private System.Windows.Forms.RadioButton rbtnLan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLanBasla;
        private System.Windows.Forms.RadioButton rbtnYeniServer;
        private System.Windows.Forms.RadioButton rbtnAgaKatil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

