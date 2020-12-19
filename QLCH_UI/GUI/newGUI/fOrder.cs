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
    public partial class fOrder : Form
    {
        public fOrder()
        {
            InitializeComponent();
            this.flowLayoutPanel1.Controls.Add(new UC_ItemOrder());
            this.flowLayoutPanel1.Controls.Add(new UC_ItemOrder());
            this.flowLayoutPanel1.Controls.Add(new UC_ItemOrder());
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
