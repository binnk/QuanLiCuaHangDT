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
    public partial class fUpdateInfo : Form
    {
        public fUpdateInfo()
        {
            InitializeComponent();
            load();
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
        public void load()
        {
            UC_UI_DS_Item item = new UC_UI_DS_Item();
            UC_UI_DS_Item item1 = new UC_UI_DS_Item();
            UC_UI_DS_Item item2 = new UC_UI_DS_Item();
            UC_UI_DS_Item item3 = new UC_UI_DS_Item();
            this.fpn_ItemsLinhKien.Controls.Add(item);
            this.fpn_ItemsLinhKien.Controls.Add(item1);
            this.fpn_ItemsLinhKien.Controls.Add(item2);
            this.fpn_ItemsLinhKien.Controls.Add(item3);


        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
