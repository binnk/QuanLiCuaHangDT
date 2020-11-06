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
    public partial class SellForm : Form
    {
        public SellForm()
        {
            InitializeComponent();
        }


        #region MyRegion

        private void addItem()
        {
            UC_Item listItems = new UC_Item();
            flpItems.Controls.Add(listItems);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            addItem();
        }
        #endregion



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void tbThemSP_Enter(object sender, EventArgs e)
        {
            if (tbThemSP.Text == "Thêm sản phẩm vào đơn")
            {
                tbThemSP.Text = "";
            }
        }

        private void tbThemSP_Leave(object sender, EventArgs e)
        {
            if (tbThemSP.Text == "")
            {
                tbThemSP.Text = "Thêm sản phẩm vào đơn";
            }
        }




        
        private void icExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


     
    }
}
