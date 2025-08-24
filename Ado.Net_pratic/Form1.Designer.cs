namespace Ado.Net_pratic
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridViewKayitlar = new System.Windows.Forms.DataGridView();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.lbl_emailAdres = new System.Windows.Forms.Label();
            this.txt_emailAdres = new System.Windows.Forms.TextBox();
            this.lbl_telefeonno = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_kayitGuncelle = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKayitlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKayitlar
            // 
            this.dataGridViewKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKayitlar.Location = new System.Drawing.Point(4, 3);
            this.dataGridViewKayitlar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewKayitlar.Name = "dataGridViewKayitlar";
            this.dataGridViewKayitlar.RowHeadersWidth = 51;
            this.dataGridViewKayitlar.RowTemplate.Height = 24;
            this.dataGridViewKayitlar.Size = new System.Drawing.Size(1015, 230);
            this.dataGridViewKayitlar.TabIndex = 0;
            this.dataGridViewKayitlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKayitlar_CellContentClick);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(1, 274);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 18);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "İsim:";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(175, 274);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(188, 24);
            this.txt_isim.TabIndex = 2;
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Location = new System.Drawing.Point(1, 325);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(73, 18);
            this.lbl_soyisim.TabIndex = 1;
            this.lbl_soyisim.Text = "Soyisim:";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(175, 325);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(188, 24);
            this.txt_soyisim.TabIndex = 2;
            // 
            // lbl_emailAdres
            // 
            this.lbl_emailAdres.AutoSize = true;
            this.lbl_emailAdres.Location = new System.Drawing.Point(1, 379);
            this.lbl_emailAdres.Name = "lbl_emailAdres";
            this.lbl_emailAdres.Size = new System.Drawing.Size(103, 18);
            this.lbl_emailAdres.TabIndex = 1;
            this.lbl_emailAdres.Text = "Email Adres:";
            // 
            // txt_emailAdres
            // 
            this.txt_emailAdres.Location = new System.Drawing.Point(175, 379);
            this.txt_emailAdres.Name = "txt_emailAdres";
            this.txt_emailAdres.Size = new System.Drawing.Size(188, 24);
            this.txt_emailAdres.TabIndex = 2;
            // 
            // lbl_telefeonno
            // 
            this.lbl_telefeonno.AutoSize = true;
            this.lbl_telefeonno.Location = new System.Drawing.Point(1, 432);
            this.lbl_telefeonno.Name = "lbl_telefeonno";
            this.lbl_telefeonno.Size = new System.Drawing.Size(96, 18);
            this.lbl_telefeonno.TabIndex = 1;
            this.lbl_telefeonno.Text = "Telefon No:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(645, 241);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(29, 18);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(693, 239);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(86, 24);
            this.txt_id.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(664, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Kayıt Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_kayitGuncelle
            // 
            this.btn_kayitGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kayitGuncelle.Location = new System.Drawing.Point(534, 367);
            this.btn_kayitGuncelle.Name = "btn_kayitGuncelle";
            this.btn_kayitGuncelle.Size = new System.Drawing.Size(133, 30);
            this.btn_kayitGuncelle.TabIndex = 7;
            this.btn_kayitGuncelle.Text = "Kayıt Güncelle";
            this.btn_kayitGuncelle.UseVisualStyleBackColor = false;
            this.btn_kayitGuncelle.Click += new System.EventHandler(this.btn_kayitGuncelle_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(434, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "Kayıt Ekle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(175, 427);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(188, 24);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 624);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_kayitGuncelle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_telefeonno);
            this.Controls.Add(this.txt_emailAdres);
            this.Controls.Add(this.lbl_emailAdres);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.lbl_soyisim);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.dataGridViewKayitlar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKayitlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKayitlar;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label lbl_emailAdres;
        private System.Windows.Forms.TextBox txt_emailAdres;
        private System.Windows.Forms.Label lbl_telefeonno;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_kayitGuncelle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}
