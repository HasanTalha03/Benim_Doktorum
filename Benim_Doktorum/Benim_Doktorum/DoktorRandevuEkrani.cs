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

namespace Benim_Doktorum
{

   
    public partial class DoktorRandevuEkrani : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DCMV86R\\SQLEXPRESS;Initial Catalog=Benim_Doktorum;Integrated Security=True;Encrypt=False");
      
        private int hasta_id;
        private String doktor_isim;
        private int doktor_id;
        private String doktor_e_postasi;

        public DoktorRandevuEkrani(String isim, int id, String e_posta)
        {
            this.doktor_isim = isim;
            this.doktor_id = id;
            this.doktor_e_postasi = e_posta;

            InitializeComponent();
        }

        private void DoktorRandevuEkrani_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand(
                 "SELECT Tbl_Hasta.id AS hasta_id, Tbl_Hasta.isim AS hasta_isim, Tbl_Hasta.soy_isim AS hasta_soy_isim, " +
                 "Tbl_Doktor.isim AS doktor_isim, Tbl_Doktor.soy_isim AS doktor_soy_isim, " +
                 "Tbl_Uzmanlik.uzmanlik AS doktor_uzmanlik, Tbl_Randevu.randevu_tarihi, Tbl_Randevu.saat " +
                 "FROM Tbl_Randevu " +
                 "INNER JOIN Tbl_Hasta ON Tbl_Randevu.hasta_id = Tbl_Hasta.id " +
                 "INNER JOIN Tbl_Doktor ON Tbl_Randevu.doktor_id = Tbl_Doktor.id " +
                 "INNER JOIN Tbl_Uzmanlik ON Tbl_Doktor.uzmanlik = Tbl_Uzmanlik.id " +
                       "WHERE Tbl_Doktor.e_posta = @e_posta", baglanti);
            komut.Parameters.AddWithValue("@e_posta", doktor_e_postasi);
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
                hasta_id = Convert.ToInt32(reader["hasta_id"]);

                // Boşluk bırakmak için:
                string randevuBilgisi = $"{hastaIsim}     {hastaSoyisim}       -        {doktorIsim} {doktorSoyisim}              -              {doktorUzmanlik}    |          {randevuTarihi.ToShortDateString()}          {saat}";
                listBox1.Items.Add(randevuBilgisi);

            }

            // Bağlantıyı kapat
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doktor_Girisi giris = new Doktor_Girisi(doktor_isim, doktor_id, doktor_e_postasi);
            this.Hide();
            giris.Show();
        }

        private void BtnRandevuBaslat_Click(object sender, EventArgs e)
        {
            TxtUrl.Visible = true;
            BtnUrlKaydet.Visible = true;



        https://meet.google.com/new
           


                // Google Meet yeni toplantı URL'sini aç
                string meetUrl = "https://meet.google.com/new";
                Process.Start(new ProcessStartInfo
                {
                    FileName = meetUrl,
                    UseShellExecute = true // Varsayılan tarayıcıda aç
                });
            if (isButtonClicked)
            {
                MessageBox.Show("Randevunuz başlatıldı ve hastaya randevu url si gönderildi");

            }
            else
            {
                MessageBox.Show("Lütfen Hastaya Url yi Gönderiniz");
            }

        }
            
        private bool isButtonClicked = false;
        private void BtnUrlKaydet_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Url (doktor_id,hasta_id,url) VALUES (@p1,@p2,@p3)  ",baglanti);

            baglanti.Open();

            komut.Parameters.AddWithValue("@p1",doktor_id);
            komut.Parameters.AddWithValue("@p2", hasta_id);
            komut.Parameters.AddWithValue("@p3",TxtUrl.Text);
            komut.ExecuteNonQuery();

            MessageBox.Show("Hastaya Url Ulaştırıldı");
            baglanti.Close();



          isButtonClicked = true;
            Application.Exit();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
