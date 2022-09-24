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
    public partial class FrmGiris : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-273PO1F;Initial Catalog=DBSECİMPROJE;Integrated Security=True");
        
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGrafik frmGrafik = new FrmGrafik();
            frmGrafik.Show();
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@P1,@P2,@P3,@P4,@P5,@P6)",baglan);
            komut.Parameters.AddWithValue("@P1",Txtilce.Text);
            komut.Parameters.AddWithValue("@P2",TxtA.Text);
            komut.Parameters.AddWithValue("@P3",TxtB.Text);
            komut.Parameters.AddWithValue("@P4",TxtC.Text);
            komut.Parameters.AddWithValue("@P5",TxtD.Text);
            komut.Parameters.AddWithValue("@P6",TxtE.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veriler Kaydedildi");
        }
    }
}
