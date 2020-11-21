using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_UI
{
    public partial class ImportProducts : Form
    {
        public ImportProducts()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*|*.png|*|*.jpg|*|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName.ToString();
                Image img = new Bitmap(filePath);
                pictureBox1.Image = img;
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
