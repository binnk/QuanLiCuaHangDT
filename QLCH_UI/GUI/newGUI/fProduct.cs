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
    public partial class fProduct : Form
    {
        public fProduct()
        {
            
            InitializeComponent();
            this.flowLayoutPanel1.Controls.Add(new UC_ItemProduct());
            this.flowLayoutPanel1.Controls.Add(new UC_ItemProduct());
            this.flowLayoutPanel1.Controls.Add(new UC_ItemProduct());
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
    }
}
