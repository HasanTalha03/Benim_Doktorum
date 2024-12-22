using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
namespace Benim_Doktorum
{
    public partial class FrmRandevularım : Form
    {

        private String kullaniciisim;
        private int kullaniciID;
       private String e_postasi;

        public FrmRandevularım(string isim,int id,string e_posta)
        {

            kullaniciisim = isim;
            this.kullaniciID= id;
            this.e_postasi= e_posta;
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DCMV86R\\SQLEXPRESS;Initial Catalog=Benim_Doktorum;Integrated Security=True;Encrypt=False");


        private void FrmRandevularım_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand(
                 "SELECT Tbl_Hasta.isim AS hasta_isim, Tbl_Hasta.soy_isim AS hasta_soy_isim, " +
                 "Tbl_Doktor.isim AS doktor_isim, Tbl_Doktor.soy_isim AS doktor_soy_isim, " +
                 "Tbl_Uzmanlik.uzmanlik AS doktor_uzmanlik, Tbl_Randevu.randevu_tarihi, Tbl_Randevu.saat " +
                 "FROM Tbl_Randevu " +
                 "INNER JOIN Tbl_Hasta ON Tbl_Randevu.hasta_id = Tbl_Hasta.id " +
                 "INNER JOIN Tbl_Doktor ON Tbl_Randevu.doktor_id = Tbl_Doktor.id " +
                 "INNER JOIN Tbl_Uzmanlik ON Tbl_Doktor.uzmanlik = Tbl_Uzmanlik.id " +
                 "WHERE Tbl_Hasta.e_posta = @e_posta", baglanti);
            komut.Parameters.AddWithValue("@e_posta", e_postasi);
            baglanti.Open();
            SqlDataReader reader = komut.ExecuteReader();

            // ListBox'ı temizleyelim
            listBox1.Items.Clear();

            // Verileri ListBox'a ekleyelim
            while (reader.Read())
            {
                string hastaIsim = reader["hasta_isim"].ToString();
                string hastaSoyisim = reader["hasta_soy_isim"].ToString();
                string doktorIsim = reader["doktor_isim"].ToString();
                string doktorSoyisim = reader["doktor_soy_isim"].ToString();  // Doktor soyadı eklendi
                string doktorUzmanlik = reader["doktor_uzmanlik"].ToString();  // Doktor uzmanlık eklendi
                DateTime randevuTarihi = Convert.ToDateTime(reader["randevu_tarihi"]);
                string saat = reader["saat"].ToString();


                // Boşluk bırakmak için:
                string randevuBilgisi = $"{hastaIsim}     {hastaSoyisim}       -        {doktorIsim} {doktorSoyisim}              -              {doktorUzmanlik}    |          {randevuTarihi.ToShortDateString()}          {saat}";
                listBox1.Items.Add(randevuBilgisi);

            }

            // Bağlantıyı kapat
            baglanti.Close();




        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Kullanici_Girisi kullanici = new Kullanici_Girisi(kullaniciisim,kullaniciID,e_postasi);
            this.Hide();
            kullanici.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {



            // Toplantı linkini bir string olarak tanımlayın
            string meetUrl = TxtUrlAl.Text;

            // Toplantı linki boş mu kontrol et
            if (string.IsNullOrEmpty(meetUrl))
            {
                MessageBox.Show("Toplantı linki bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // URL'yi tarayıcıda aç
            Process.Start(new ProcessStartInfo
            {
                FileName = meetUrl,
                UseShellExecute = true // Varsayılan tarayıcıda aç
            });



        }

        private void BtnRandevuGrn_Click(object sender, EventArgs e)
        {
           
            SqlCommand komut = new SqlCommand("SELECT url FROM Tbl_Url WHERE hasta_id = @kullanici_id", baglanti);

            try
            {
                komut.Parameters.AddWithValue("@kullanici_id", kullaniciID);
                baglanti.Open();

                SqlDataReader reader = komut.ExecuteReader();
                TxtUrlAl.Text = "";

                while (reader.Read())
                {
                    TxtUrlAl.Text += reader["url"].ToString() + Environment.NewLine;
                }

                reader.Close(); // Reader'ı manuel olarak kapatmalısınız
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı manuel olarak kapatmalısınız
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }

                // Komutu da serbest bırakmalısınız
                komut.Dispose();
            }

        }
    }
}
