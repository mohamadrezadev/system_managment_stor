using myproject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr
{
    public partial class formprocess : Form
    {
        
        public static formprocess sForm = null;
        public static formprocess Instance()
        {
            if (sForm == null) { sForm = new formprocess(); }

            return sForm;
        }
        public formprocess()
        {
            InitializeComponent();
        }


        private void formprocess_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
