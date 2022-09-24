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

namespace Kendim_Yaptim_Veri_Tabanlı_Grafik_Sistemi
{
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglan= new SqlConnection("Data Source=DESKTOP-273PO1F;Initial Catalog=DBSECİMPROJE;Integrated Security=True");
        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            // comboboxa veri yükleme
            baglan.Open();
            SqlCommand komut = new SqlCommand("select ILCEAD from TBLILCE",baglan);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbilce.Items.Add(dr[0].ToString());
            }
            baglan.Close();
            // grafiğin yüklenmesi
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("select sum(APARTI),SUM(BPARTI),SUM(CPARTI),SUM(DPARTI),SUM(EPARTI) from TBLILCE",baglan);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A partisi", dr1[0].ToString());
                chart1.Series["Partiler"].Points.AddXY("B partisi", dr1[1].ToString());
                chart1.Series["Partiler"].Points.AddXY("C partisi", dr1[2].ToString());
                chart1.Series["Partiler"].Points.AddXY("D partisi", dr1[3].ToString());
                chart1.Series["Partiler"].Points.AddXY("E partisi", dr1[4].ToString());
            }
            baglan.Close();


        }

        private void Cmbilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            // İlçe Seçince Progress barın çalışması
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from TBLILCE where ILCEAD=@P1", baglan);
            komut.Parameters.AddWithValue("@P1", Cmbilce.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                PrgA.Value = int.Parse(dr[2].ToString());
                PrgB.Value = int.Parse(dr[3].ToString());
                PrgC.Value = int.Parse(dr[4].ToString());
                PrgD.Value = int.Parse(dr[5].ToString());
                PrgE.Value = int.Parse(dr[6].ToString());
            }
            baglan.Close();
            // Sağdaki Labelleri Güncelleme
            LblA.Text = PrgA.Value.ToString();
            LblB.Text = PrgB.Value.ToString();
            LblC.Text = PrgC.Value.ToString();
            LblD.Text = PrgD.Value.ToString();
            LblE.Text = PrgE.Value.ToString();

        }
    }
}
