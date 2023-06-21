
namespace Sinema_Bilet_Otomasyonu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmxfilmtürü = new System.Windows.Forms.ComboBox();
            this.txtsüre = new System.Windows.Forms.TextBox();
            this.txtyapimyılı = new System.Windows.Forms.TextBox();
            this.txtyönetmen = new System.Windows.Forms.TextBox();
            this.txtfilmadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.afissec = new System.Windows.Forms.Button();
            this.filmekle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(587, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 241);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // cmxfilmtürü
            // 
            this.cmxfilmtürü.FormattingEnabled = true;
            this.cmxfilmtürü.Items.AddRange(new object[] {
            "Aksiyon",
            "Belgesel",
            "Gerilim ",
            "Dram",
            "Komedi"});
            this.cmxfilmtürü.Location = new System.Drawing.Point(422, 102);
            this.cmxfilmtürü.Name = "cmxfilmtürü";
            this.cmxfilmtürü.Size = new System.Drawing.Size(143, 24);
            this.cmxfilmtürü.TabIndex = 24;
            // 
            // txtsüre
            // 
            this.txtsüre.Location = new System.Drawing.Point(422, 139);
            this.txtsüre.Name = "txtsüre";
            this.txtsüre.Size = new System.Drawing.Size(143, 22);
            this.txtsüre.TabIndex = 23;
            // 
            // txtyapimyılı
            // 
            this.txtyapimyılı.Location = new System.Drawing.Point(422, 176);
            this.txtyapimyılı.Name = "txtyapimyılı";
            this.txtyapimyılı.Size = new System.Drawing.Size(143, 22);
            this.txtyapimyılı.TabIndex = 22;
            // 
            // txtyönetmen
            // 
            this.txtyönetmen.Location = new System.Drawing.Point(422, 62);
            this.txtyönetmen.Name = "txtyönetmen";
            this.txtyönetmen.Size = new System.Drawing.Size(141, 22);
            this.txtyönetmen.TabIndex = 21;
            // 
            // txtfilmadi
            // 
            this.txtfilmadi.Location = new System.Drawing.Point(422, 25);
            this.txtfilmadi.Name = "txtfilmadi";
            this.txtfilmadi.Size = new System.Drawing.Size(141, 22);
            this.txtfilmadi.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "YAPIM YILI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "SÜRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "FİLM TÜRÜ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "YÖNETMEN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "FİLM ADI:";
            // 
            // afissec
            // 
            this.afissec.BackColor = System.Drawing.Color.Red;
            this.afissec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.afissec.Location = new System.Drawing.Point(619, 22);
            this.afissec.Name = "afissec";
            this.afissec.Size = new System.Drawing.Size(114, 41);
            this.afissec.TabIndex = 14;
            this.afissec.Text = "AFİŞ SEÇ";
            this.afissec.UseVisualStyleBackColor = false;
            this.afissec.Click += new System.EventHandler(this.afissec_Click);
            // 
            // filmekle
            // 
            this.filmekle.BackColor = System.Drawing.Color.Red;
            this.filmekle.ForeColor = System.Drawing.SystemColors.Control;
            this.filmekle.Location = new System.Drawing.Point(476, 270);
            this.filmekle.Name = "filmekle";
            this.filmekle.Size = new System.Drawing.Size(87, 52);
            this.filmekle.TabIndex = 13;
            this.filmekle.Text = "FİLM EKLE";
            this.filmekle.UseVisualStyleBackColor = false;
            this.filmekle.Click += new System.EventHandler(this.filmekle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 213);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 22);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "TARİH:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmxfilmtürü);
            this.Controls.Add(this.txtsüre);
            this.Controls.Add(this.txtyapimyılı);
            this.Controls.Add(this.txtyönetmen);
            this.Controls.Add(this.txtfilmadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.afissec);
            this.Controls.Add(this.filmekle);
            this.Name = "Form1";
            this.Text = "Film Ekleme Sayfası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmxfilmtürü;
        private System.Windows.Forms.TextBox txtsüre;
        private System.Windows.Forms.TextBox txtyapimyılı;
        private System.Windows.Forms.TextBox txtyönetmen;
        private System.Windows.Forms.TextBox txtfilmadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button afissec;
        private System.Windows.Forms.Button filmekle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
    }
}