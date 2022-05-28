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
using BEE;
namespace Real_Estate_Agent_Dashboard
{
    public partial class addkala : UserControl
    {
        public addkala()
        {
            InitializeComponent();
        }
        private int id_kala;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }
        private void updatedatagrid() 
        {
            #region datagridload
            dgkala.DataSource = null;
            var blk = new blkala();
            var listdada = blk.Read_all();
            dgkala.DataSource = listdada;
            foreach (DataGridViewColumn i in dgkala.Columns)
            {
                switch (i.Name)
                {
                    case "Name":
                        i.HeaderText = "نام کالا";

                        i.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        i.HeaderCell.SortGlyphDirection = SortOrder.Descending;
                        i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                    case "price":
                        i.HeaderText = "قیمت کالا";
                        i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        i.HeaderCell.SortGlyphDirection = SortOrder.Descending;
                        break;
                    case "tedad":
                        i.HeaderText = "تعداد";
                        i.Width = 150;
                        i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                    default:
                        i.Visible = false;
                        break;

                };
            }
            #endregion
        }

        private void addkala_Load(object sender, EventArgs e)
        {
            updatedatagrid();
        }

        private void gunaTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dgkala_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgkala_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            circularProgress1.Visible = true;
            circularProgress1.Start();
            if (txtname.Text == "")
            {
                txtname.Focus();
            }
            else if (txtpric.Text == "") { txtpric.Focus(); }
            else if (txtcount.Text == "") txtcount.Focus();

            else
            {
                var blk = new blkala();
                var kala = new kala();
                kala.Name = txtname.Text;
                kala.price =float.Parse( txtpric.Text);
                kala.tedad = int.Parse(txtcount.Text);
                var ms=blk.Create(kala);
                MessageBox.Show(ms);
                updatedatagrid();
            }
            circularProgress1.Visible = false;
            circularProgress1.Stop();
        }

        private void txtpric_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtpric.Text, "[^0-9]"))
            {
                txtpric.Focus();
                txtpric.Text = txtpric.Text.Remove(txtpric.Text.Length - 1);
            }
        }

        private void txtcount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtcount.Text, "[^0-9]"))
            {
                txtcount.Focus();
                txtcount.Text = txtcount.Text.Remove(txtcount.Text.Length - 1);
            }
        }

        private void dgkala_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_kala = int.Parse(dgkala.Rows[e.RowIndex].Cells["id"].Value.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void gunaGroupBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var blk = new blkala();
               var kala1= blk.search_by_id(id_kala);
                if (kala1!=null)
                {
                    txtname.Text = kala1.Name;
                    txtpric.Text = kala1.price.ToString();
                    txtcount.Text = kala1.tedad.ToString();
                    guna2Button10.Text = "ویرایش";
                    if (txtname.Text == "") txtname.Focus();
                    else if (txtpric.Text == "") txtpric.Focus();
                    else if (txtcount.Text == "") txtcount.Focus();
                    else
                    {
                        var newkala = new kala();
                        newkala.Name = txtname.Text;
                        newkala.price = float.Parse(txtpric.Text);
                        newkala.tedad = int.Parse(txtcount.Text);
                        var ms= blk.Update(id_kala, newkala);
                        txtname.Clear();
                        txtcount.Clear();
                        txtpric.Clear();
                        MessageBox.Show(ms);
                    }
                    

                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var blk = new blkala();
                if (MessageBox.Show("!!!ممکن است تمام اطلاعات حال حاظر بانک اطلاعاتی شما تغییر کند \n !اگر مشکلی با این مورد ندارید بله را انتخاب کنید", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                { 
                  var ms=  blk.Delete(id_kala);
                    MessageBox.Show(ms);
                
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void کپیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
