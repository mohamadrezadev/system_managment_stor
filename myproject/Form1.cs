using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace myproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void _delegate();

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            manger_product manger_Product = new manger_product();
            gunaLinePanel1.Controls.Clear();
            Thread trd = new Thread(() => {
            }
           );


            _delegate dg = new _delegate(() => { gunaLinePanel1.Controls.Add(manger_Product); });
            Invoke(dg);
            trd.Start();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            clsProgress cPro = new clsProgress();
            cPro.startProgress();
            addproduct adp = new addproduct();
            gunaLinePanel1.Controls.Clear();
            Thread trd = new Thread(() => {
            }
            );


            _delegate dg = new _delegate(() => { gunaLinePanel1.Controls.Add(adp); });
            Invoke(dg);
            trd.Start();

            cPro.stopProgress();
           

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            manage_faktor manage_Faktor = new manage_faktor();
            gunaLinePanel1.Controls.Clear();
            Thread trd = new Thread(() => {
            }
           );


            _delegate dg = new _delegate(() => { gunaLinePanel1.Controls.Add(manage_Faktor); });
            Invoke(dg);
            trd.Start();
           
            
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            UserControl1 us = new UserControl1();
            
            gunaLinePanel1.Controls.Clear();
            gunaLinePanel1.Controls.Add(us);
            
        }

        private void FormsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
