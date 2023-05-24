namespace HayvanatBahcesi
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
            txtAd = new TextBox();
            txtTur = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lstHayvanlar = new ListBox();
            BtnGuncelle = new Button();
            BtnSil = new Button();
            cmbHayvanlar = new ComboBox();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(329, 117);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(98, 39);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(129, 87);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 1;
            // 
            // txtTur
            // 
            txtTur.Location = new Point(129, 145);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(100, 23);
            txtTur.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 90);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 3;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 153);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 4;
            label2.Text = "Tür";
            // 
            // lstHayvanlar
            // 
            lstHayvanlar.FormattingEnabled = true;
            lstHayvanlar.ItemHeight = 15;
            lstHayvanlar.Location = new Point(467, 60);
            lstHayvanlar.Name = "lstHayvanlar";
            lstHayvanlar.Size = new Size(221, 184);
            lstHayvanlar.TabIndex = 5;
            lstHayvanlar.SelectedIndexChanged += lstHayvanlar_SelectedIndexChanged;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(467, 261);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(87, 36);
            BtnGuncelle.TabIndex = 6;
            BtnGuncelle.Text = "GÜNCELLE";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnSil
            // 
            BtnSil.Location = new Point(601, 261);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(87, 36);
            BtnSil.TabIndex = 7;
            BtnSil.Text = "SİL";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // cmbHayvanlar
            // 
            cmbHayvanlar.FormattingEnabled = true;
            cmbHayvanlar.Location = new Point(129, 43);
            cmbHayvanlar.Name = "cmbHayvanlar";
            cmbHayvanlar.Size = new Size(121, 23);
            cmbHayvanlar.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 374);
            Controls.Add(cmbHayvanlar);
            Controls.Add(BtnSil);
            Controls.Add(BtnGuncelle);
            Controls.Add(lstHayvanlar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTur);
            Controls.Add(txtAd);
            Controls.Add(btnEkle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private TextBox txtAd;
        private TextBox txtTur;
        private Label label1;
        private Label label2;
        private ListBox lstHayvanlar;
        private Button BtnGuncelle;
        private Button BtnSil;
        private ComboBox cmbHayvanlar;
    }
}