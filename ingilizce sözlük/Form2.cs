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

namespace ingilizce_sözlük
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con =new SqlConnection ("server= .; initial catalog =dbSözlük; integrated security = sspi");

        private void button1_Click(object sender, EventArgs e)
        { string turkce = txtTurkce.Text;
          string ingilizce =txtİngilizce.Text;
            SqlCommand komut = new SqlCommand("insert into kelimeler values( '"+ turkce+"','"+ingilizce+"')", con);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Yeni  kayıt yapıldı","Kayıt ekranı");

            txtTurkce.Text = "";
            txtİngilizce.Text = "";
        }
    }
}
