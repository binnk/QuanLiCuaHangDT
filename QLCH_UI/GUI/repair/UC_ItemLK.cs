using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_UI
{
    public partial class UC_UI_DS_Item : UserControl
    {
        private fUpdateInfo _parent;
        public UC_UI_DS_Item(fUpdateInfo parent)
        {
            _parent = parent;
            InitializeComponent();
        }
        public string malk { get; set; }
        public string tenlk { get; set; }
        public double gia { get; set; }
        public void Set_LK()
        {
            lb_malk.Text = malk;
            lb_tenlk.Text = tenlk;
        }

        private void icBtnXoa_Click(object sender, EventArgs e)
        {
            this._parent.Delete_item(gia);
            this.Parent.Controls.Remove(this);
        }
    }
}
