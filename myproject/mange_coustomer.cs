using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace myproject
{
    public partial class manger_product : UserControl
    {
        public manger_product()
        {
            InitializeComponent();
        }
        public blmoshtari blc = new blmoshtari();
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void manger_product_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            var blk = new blmoshtari();
            var list = blk.Read_all();
        }
    }
}
