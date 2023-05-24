namespace HayvanatBahcesiProjesii
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEkle = new Button();
            btnSİL = new Button();
            lstHayvanOzellikleri = new ListBox();
            cmbHayvanlar = new ComboBox();
            lblHayvanSecimi = new Label();
            label1 = new Label();
            TXTyAS = new TextBox();
            label2 = new Label();
            HayvanBilgileri = new GroupBox();
            rbDisi = new RadioButton();
            rbErkek = new RadioButton();
            btnGuncelle = new Button();
            HayvanBilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(423, 447);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(101, 40);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSİL
            // 
            btnSİL.Enabled = false;
            btnSİL.Location = new Point(637, 447);
            btnSİL.Name = "btnSİL";
            btnSİL.Size = new Size(104, 40);
            btnSİL.TabIndex = 1;
            btnSİL.Text = "SİL";
            btnSİL.UseVisualStyleBackColor = true;
            btnSİL.Click += btnSİL_Click;
            // 
            // lstHayvanOzellikleri
            // 
            lstHayvanOzellikleri.BackColor = Color.MistyRose;
            lstHayvanOzellikleri.FormattingEnabled = true;
            lstHayvanOzellikleri.HorizontalScrollbar = true;
            lstHayvanOzellikleri.ItemHeight = 15;
            lstHayvanOzellikleri.Location = new Point(433, 27);
            lstHayvanOzellikleri.Name = "lstHayvanOzellikleri";
            lstHayvanOzellikleri.Size = new Size(320, 409);
            lstHayvanOzellikleri.TabIndex = 2;
            lstHayvanOzellikleri.SelectedIndexChanged += lstHayvanOzellikleri_SelectedIndexChanged;
            // 
            // cmbHayvanlar
            // 
            cmbHayvanlar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHayvanlar.FormattingEnabled = true;
            cmbHayvanlar.Location = new Point(1, 84);
            cmbHayvanlar.Name = "cmbHayvanlar";
            cmbHayvanlar.Size = new Size(154, 23);
            cmbHayvanlar.TabIndex = 3;
            // 
            // lblHayvanSecimi
            // 
            lblHayvanSecimi.AutoSize = true;
            lblHayvanSecimi.Location = new Point(1, 53);
            lblHayvanSecimi.Name = "lblHayvanSecimi";
            lblHayvanSecimi.Size = new Size(89, 15);
            lblHayvanSecimi.TabIndex = 5;
            lblHayvanSecimi.Text = "Hayvan Seçiniz:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 53);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 6;
            label1.Text = "Yaşını Giriniz:";
            // 
            // TXTyAS
            // 
            TXTyAS.Location = new Point(208, 84);
            TXTyAS.Name = "TXTyAS";
            TXTyAS.Size = new Size(100, 23);
            TXTyAS.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 129);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 8;
            label2.Text = "Cinsiyet:";
            // 
            // HayvanBilgileri
            // 
            HayvanBilgileri.Controls.Add(rbDisi);
            HayvanBilgileri.Controls.Add(rbErkek);
            HayvanBilgileri.Controls.Add(cmbHayvanlar);
            HayvanBilgileri.Controls.Add(label2);
            HayvanBilgileri.Controls.Add(lblHayvanSecimi);
            HayvanBilgileri.Controls.Add(TXTyAS);
            HayvanBilgileri.Controls.Add(label1);
            HayvanBilgileri.Location = new Point(12, 27);
            HayvanBilgileri.Name = "HayvanBilgileri";
            HayvanBilgileri.Size = new Size(358, 460);
            HayvanBilgileri.TabIndex = 9;
            HayvanBilgileri.TabStop = false;
            HayvanBilgileri.Text = "HayvanBilgileri";
            // 
            // rbDisi
            // 
            rbDisi.AutoSize = true;
            rbDisi.Location = new Point(229, 125);
            rbDisi.Name = "rbDisi";
            rbDisi.Size = new Size(44, 19);
            rbDisi.TabIndex = 10;
            rbDisi.Text = "Dişi";
            rbDisi.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Checked = true;
            rbErkek.Location = new Point(135, 127);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(53, 19);
            rbErkek.TabIndex = 9;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(530, 447);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(101, 40);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 521);
            Controls.Add(btnGuncelle);
            Controls.Add(HayvanBilgileri);
            Controls.Add(lstHayvanOzellikleri);
            Controls.Add(btnSİL);
            Controls.Add(btnEkle);
            Name = "Form1";
            Text = "Form1";
            HayvanBilgileri.ResumeLayout(false);
            HayvanBilgileri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEkle;
        private Button btnSİL;
        private ListBox lstHayvanOzellikleri;
        private ComboBox cmbHayvanlar;
        private Label lblHayvanSecimi;
        private Label label1;
        private TextBox TXTyAS;
        private Label label2;
        private GroupBox HayvanBilgileri;
        private Button btnGuncelle;
        private RadioButton rbDisi;
        private RadioButton rbErkek;
    }
}