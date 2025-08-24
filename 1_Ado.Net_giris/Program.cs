using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ado.Net_giris
{
    internal class Program
    {
        static SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Ado.Net;User ID=sa;password=1");
        static void Main(string[] args)
        {
            //kayitlariGetir();
            //kayitEkle("süleyman", "123", "admin");
            //kayıtGüncelle(6, "meryem");
            kayitSil(3);
        }
        public static void kayitSil(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete loginTable where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            int donendeger=cmd.ExecuteNonQuery();
            if (donendeger == 1)
            {
                Console.WriteLine("kayıt başarıyla silindi");

            }
            else
            {
                Console.WriteLine("kayıt silinemedi");
            }

                con.Close();

        }
        public static void kayıtGüncelle(int id,string kullaniciAdi)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update loginTable set kullaniciAdi=@kulad where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);
            int donendeger=cmd.ExecuteNonQuery();
            if (donendeger == 1)
            {
                Console.WriteLine("katıt güncellendi");
            }
            else
            {
                Console.WriteLine("kayıt güncellenirken bir sorun oluştu");
            }
                con.Close();
        }
        public static void kayitEkle(string kullaniciAdi,string sifre,string yetki)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into loginTable (kullaniciAdi,sifre,yetki) values(@kulad,@sifre,@yetki)",con);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            cmd.Parameters.AddWithValue("@yetki", yetki);
            int donenDeger=cmd.ExecuteNonQuery();
            if (donenDeger == 1)
            {
                Console.WriteLine("kayıt eklenmiştir");
            }
            else
            {
                Console.WriteLine("Kayıt eklenirken bir sorun oluştu");
            }
            Console.ReadLine();
            con.Close();
        }

        public static void kayitlariGetir()
        {
            List<musteri> musteriList = new List<musteri>();

            
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from loginTable", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                musteri m = new musteri();
                m.id = int.Parse(dr["id"].ToString());
                m.kullaniciAdi = dr["kullaniciAdi"].ToString();
                m.yetki = dr["yetki"].ToString();
                m.sifre = dr["sifre"].ToString();
                musteriList.Add(m);
            }
            con.Close();

            foreach (musteri m in musteriList)
            {
                Console.WriteLine("id: " + m.id + " Kullanıcı adı: " + m.kullaniciAdi + " Sifre: " + m.sifre + " Yetki: " + m.yetki);
            }
            Console.ReadLine();
        }
    }
}
