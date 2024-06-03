using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizce_sözlük
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();

        }
    }
}
