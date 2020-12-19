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
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();
            loadProduct();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle = 0x02000000;
                return handleParam;
            }
        }

        public void loadProduct()
        {
            UC_ItemViewProduct uc = new UC_ItemViewProduct();
            UC_ItemViewProduct u1 = new UC_ItemViewProduct();
            UC_ItemViewProduct u2 = new UC_ItemViewProduct();
            UC_ItemViewProduct u3 = new UC_ItemViewProduct();
            UC_ItemViewProduct u4 = new UC_ItemViewProduct();

            this.flowLayoutPanel1.Controls.Add(uc);
            this.flowLayoutPanel1.Controls.Add(u1);
            this.flowLayoutPanel1.Controls.Add(u2);
            this.flowLayoutPanel1.Controls.Add(u3);
            this.flowLayoutPanel1.Controls.Add(u4);

        }

    }
}
