using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEE;
using BLL;
using Microsoft.Office.Interop.Excel;
namespace myproject
{
    public partial class addproduct : UserControl
    {
        int Id_kala;
        public addproduct()
        {
            InitializeComponent();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addproduct_Load(object sender, EventArgs e)
        {
            //var blk = new blkala();
            //var listdada = blk.Read_all();
            //dgkala.DataSource = listdada;
            //foreach (DataGridViewColumn i in dgkala.Columns)
            //{
            //    switch (i.Name)
            //    {
            //        case "Name":
            //            i.HeaderText = "نام کالا";
                        
            //            i.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //            i.HeaderCell.SortGlyphDirection = SortOrder.Descending;
            //            break;
            //        case "price":
            //            i.HeaderText = "قیمت کالا";
            //            i.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            //            i.HeaderCell.SortGlyphDirection = SortOrder.Descending;
            //            break;
            //        case "tedad":
            //            i.HeaderText = "تعداد";
            //            i.Width = 150;
            //            i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //            break;
            //        default:
            //            i.Visible = false;
            //            break;

            //    };
            //}
        }

        private void dgkala_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_kala =int.Parse( dgkala.CurrentRow.Cells[0].Value.ToString());
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (txtname.Text=="" | txtprice.Text=="" | txttedad.Text=="")
            {
                MessageBox.Show("لطفا اطلاعات را به درستی وارد کنید");
            }
            
        }
    }
}
