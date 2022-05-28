using Real_Estate_Agent_Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persention
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void _delegate();
        private void guna2Panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            addkala adlaka = new addkala();
            guna2Panel6.Controls.Clear();
            adlaka.Size = new Size(837, 680);
            
            _delegate dg = new _delegate(() => { guna2Panel6.Controls.Add(adlaka); });
            Invoke(dg);

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            addfaktor addfaktor = new addfaktor();
            guna2Panel6.Controls.Clear();
            addfaktor.Size = new Size(837, 680);
            guna2Panel6.Controls.Add(addfaktor);
            
            
            //_delegate dg = new _delegate(() => { guna2Panel6.Controls.Add(addfaktor); });
            //Invoke(dg)

        }
    }
}
