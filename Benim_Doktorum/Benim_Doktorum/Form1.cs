using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Benim_Doktorum
{
    public partial class Form1 : Form
    {

        Kullanici_Girisi kullanici_girisi;
        Doktor_Girisi doktor_Girisi;


        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti =new SqlConnection("Data Source=DESKTOP-DCMV86R\\SQLEXPRESS;Initial Catalog=Benim_Doktorum;Integrated Security=True;Encrypt=False");

      

        //Kullanıcı kayıt ekranına gidiyor
        private void button3_Click(object sender, EventArgs e)
        {
            Kayit_Ekrani kayit_Ekrani = new Kayit_Ekrani();
            this.Hide();
            kayit_Ekrani.Show();
        }
        //Çıkış tuşu için

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Doktor kayıt ekranına gidiyor
        private void BtnDoktorKyt_Click(object sender, EventArgs e)
        {


            Doktor_Kayit_Ekrani doktor_kayit_ekrani = new Doktor_Kayit_Ekrani();
            this.Hide();
            doktor_kayit_ekrani.Show();

        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * From Tbl_Hasta where e_posta=@p1  and sifre=@p2",baglanti);

            komut.Parameters.AddWithValue("@p1",Txte_posta.Text);
            komut.Parameters.AddWithValue("@p2", Txt_sifre.Text);
            SqlDataReader dr=komut.ExecuteReader();

            if (dr.Read())
            {
                string isim = dr["isim"].ToString();
                int id = Convert.ToInt32(dr["id"]);
                string e_posta = dr["e_posta"].ToString();

                kullanici_girisi = new Kullanici_Girisi(isim,id,e_posta);
                this.Hide();
                kullanici_girisi.Show();
            }
            else
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girildi");
         baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktor where e_posta=@p1  and sifre=@p2", baglanti);

            komut.Parameters.AddWithValue("@p1", Txte_posta.Text);
            komut.Parameters.AddWithValue("@p2", Txt_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                string isim = dr["isim"].ToString();
                int id = Convert.ToInt32(dr["id"]);
                string e_posta = dr["e_posta"].ToString();

                Doktor_Girisi doktor_Girisi= new Doktor_Girisi(isim,id,e_posta);
                this.Hide();          
                doktor_Girisi.Show();
            }
            else
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girildi");
            baglanti.Close();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
