using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Otobüs
{

    public partial class işlemseç : Form
    {
        
        public işlemseç()
        {
            InitializeComponent();
        }
       


        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=biletkayitlari.accdb");
        int sayac = 0;
        satılanbiletler bilet = new satılanbiletler();
        private void verigöster()
        {
            //VERİ TABANINDAN OTOBÜS TÜRÜNE GÖRE LİSTWİEV LERE ATAMA
            #region
            
            try
            {
                  
                baglan.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "Select * From bilet";
                OleDbDataReader oku = komut.ExecuteReader();//executer geleni döduruyo bıze
               
                
                
                    while (oku.Read())
                    {

                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["RezNo"].ToString();
                        ekle.SubItems.Add(oku["İsim"].ToString());
                        ekle.SubItems.Add(oku["Soyisim"].ToString());
                        ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                        ekle.SubItems.Add(oku["Telefon"].ToString());
                        ekle.SubItems.Add(oku["Biniş"].ToString());
                        ekle.SubItems.Add(oku["İniş"].ToString());
                        ekle.SubItems.Add(oku["Tarih"].ToString());
                        ekle.SubItems.Add(oku["Saat"].ToString());
                        ekle.SubItems.Add(oku["Fiyat"].ToString());
                         ekle.SubItems.Add(oku["KoltukNo"].ToString());
                    if (oku["Otobüs_Türü"].ToString() == "METRO")
                        bilet.listViewMETRO.Items.Add(ekle);
                    else if (oku["Otobüs_Türü"].ToString() == "PAMUKKALE")
                        bilet.listViewPAMUKKALE.Items.Add(ekle);
                    else if (oku["Otobüs_Türü"].ToString() == "ES")
                        bilet.listViewES.Items.Add(ekle);
                    else if (oku["Otobüs_Türü"].ToString() == "KAMİLKOÇ")
                        bilet.listViewKAMİLKOÇ.Items.Add(ekle);
                   

                }


                
              
                
               
            }
            catch (Exception e)
            {
                MessageBox.Show("Veri Tabanı Bağlantısında Hata Oluştu" + e.Message);
            }
            finally
            {
                baglan.Close();
            }
            #endregion

        }


        private void button1_Click(object sender, EventArgs e)
        {
          
            Form1 aç = new Form1();
            this.Hide();
            aç.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanıcıgirişi aç = new kullanıcıgirişi();
            this.Hide();
            aç.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            verigöster();
            bilet.ShowDialog();
            
            
        }

        private void işlemseç_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //EKRANDAKİ KAYAN YAZILAR
            #region
            string tut = this.Text;
            tut = tut.Substring(1, tut.Length - 1) + tut.Substring(0, 1);
            this.Text = tut;
            string tut2 = this.label32.Text;
            tut2 = tut2.Substring(1, tut2.Length - 1) + tut2.Substring(0, 1);
            this.label32.Text = tut2;
            #endregion
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //EKRANDAKI YILDIZLAR
        #region
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac % 2 == 0)
            {
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Blue;
                label4.ForeColor = Color.Gray;
                label5.ForeColor = Color.Orange;
                label6.ForeColor = Color.AliceBlue;
                label7.ForeColor = Color.YellowGreen;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.Crimson;
                label10.ForeColor = Color.AntiqueWhite;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Pink;
                label13.ForeColor = Color.Purple;
                label14.ForeColor = Color.Firebrick;
                label15.ForeColor = Color.Red;
                label16.ForeColor = Color.Yellow;
                label17.ForeColor = Color.YellowGreen;
                label18.ForeColor = Color.White;
                label19.ForeColor = Color.YellowGreen;
                label20.ForeColor = Color.Firebrick;
                label21.ForeColor = Color.GreenYellow;
                label22.ForeColor = Color.YellowGreen;
                label23.ForeColor = Color.YellowGreen;
                label24.ForeColor = Color.Blue;
                label25.ForeColor = Color.Pink;
                label26.ForeColor = Color.Orange;
                label27.ForeColor = Color.Salmon;
                label28.ForeColor = Color.SeaGreen;
                label29.ForeColor = Color.SkyBlue;
                label30.ForeColor = Color.Silver;
                label31.ForeColor = Color.Red;
            }
            else
            {
                label1.ForeColor = Color.Yellow;
                label2.ForeColor = Color.Orange;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.YellowGreen;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Red;
                label8.ForeColor = Color.Crimson;
                label9.ForeColor = Color.Silver;
                label10.ForeColor = Color.SaddleBrown;
                label11.ForeColor = Color.AliceBlue;
                label12.ForeColor = Color.Silver;
                label13.ForeColor = Color.Pink;
                label14.ForeColor = Color.Blue;
                label15.ForeColor = Color.Purple;
                label16.ForeColor = Color.BlanchedAlmond;
                label17.ForeColor = Color.AliceBlue;
                label18.ForeColor = Color.BlanchedAlmond;
                label19.ForeColor = Color.GreenYellow;
                label20.ForeColor = Color.SlateBlue;
                label21.ForeColor = Color.GreenYellow;
                label22.ForeColor = Color.Gray;
                label23.ForeColor = Color.Aqua;
                label24.ForeColor = Color.Pink;
                label25.ForeColor = Color.Blue;
                label26.ForeColor = Color.AntiqueWhite;
                label27.ForeColor = Color.Lavender;
                label28.ForeColor = Color.Aqua;
                label29.ForeColor = Color.Red;
                label30.ForeColor = Color.White;
                label31.ForeColor = Color.Black;


            }
        }

        #endregion

        
    }
}
