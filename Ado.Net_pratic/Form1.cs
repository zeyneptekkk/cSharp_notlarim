using Ado.Net_pratic.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.Net_pratic
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Ado.Net;User ID=sa;Password=1");
        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
          dataGridViewKayitlar.DataSource = kayitlarıGetir();
        }
        public List<Musteri> kayitlarıGetir()
        {
            List<Musteri> musteriList= new List<Musteri>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from musterii", con);
            SqlDataReader dr=cmd.ExecuteReader();

            while (dr.Read())
            {
                Musteri musteri = new Musteri();
                musteri.id=int.Parse(dr["id"].ToString());
                musteri.isim = dr["isim"].ToString();
                musteri.emailAdres = dr["emailAdres"].ToString();
                musteri.telefonno = dr["telefonno"].ToString() ;
                musteri.soyisim = dr["soyisim"].ToString();
                musteriList.Add(musteri);
            }
            con.Close();
            return musteriList;
        }
        public int kayitEkle()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into musterii(isim,soyisim,emailAdres,telefonno) values(@isim,@soyisim,@emailadres,@telefonno)", con);
            cmd.Parameters.AddWithValue("@isim", txt_isim.Text);
            cmd.Parameters.AddWithValue("@soyisim", txt_soyisim.Text);
            cmd.Parameters.AddWithValue("@emailAdres", txt_emailAdres.Text);
            cmd.Parameters.AddWithValue("@telefonno", maskedTextBox1.Text);
            int donendeger = cmd.ExecuteNonQuery();
            con.Close();
            if (donendeger == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int kayitGüncelle()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update musterii set emailAdres=@emailAdres where id=@id", con);
            cmd.Parameters.AddWithValue("@emailAdres",txt_emailAdres.Text);
            cmd.Parameters.AddWithValue("@id", int.Parse(txt_id.Text));
            int donendeger= cmd.ExecuteNonQuery();
            con.Close() ;
            if(donendeger == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
               
        }
        public int kayitSil()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from musterii where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txt_id.Text));
            int donendeger = cmd.ExecuteNonQuery();
            con.Close();
            if (donendeger == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
           
        }

        private void dataGridViewKayitlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {

                }

        private void button4_Click(object sender, EventArgs e)
        {
           int sonuc= kayitEkle();
            if (sonuc == 1)
            {
                MessageBox.Show("Kayıt Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               dataGridViewKayitlar.DataSource = kayitlarıGetir();
            }
            else
            {
                MessageBox.Show("Kayıt Eklenirken bir sorun oluştu","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
        {
            int sonuc=kayitGüncelle();
            if (sonuc == 1)
            {
                MessageBox.Show("Kayıt Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewKayitlar.DataSource = kayitlarıGetir();
            }
            else
            {
                MessageBox.Show("Kayıt Güncellenirken bir sorun oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           int sonuc= kayitSil();
            if (sonuc == 1)
            {
                MessageBox.Show("Kayıt Silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewKayitlar.DataSource = kayitlarıGetir();
            }
            else
            {
                MessageBox.Show("KayıtSilinirken bir sorun oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
