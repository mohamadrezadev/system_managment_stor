using pr;
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
using BEE;
using BLL;
 
namespace Real_Estate_Agent_Dashboard
{
    public partial class addfaktor : UserControl
    {
        public addfaktor()
        {
            InitializeComponent();
        }
        public int id_kala;
        public BEE.moshtari _moshtari=new BEE.moshtari();
        private List<kala> _listkala;

       
        private void updatedatagrid()
        {
            #region datagridload
            dgfaktor.DataSource = null;
            var blk = new blkala();
            dgfaktor.DataSource = _listkala;


            foreach (DataGridViewColumn i in dgfaktor.Columns)
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
        #region add faktor to db
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            
            circularProgress1.Visible = true;
            circularProgress1.Start();
            var blf = new blfaktor();
            var f = new factor();
            f.Date =DateTime.Parse(datafaktor.Text);
            f.Moshtari = _moshtari;
            f.Kalas = _listkala;
            f.totalpric = float.Parse(totalprice.Text);
            
            var m = blf.Create(new factor());
            MessageBox.Show(m);

            circularProgress1.Visible = false;
            circularProgress1.Stop();
        }
        #endregion
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        #region add to list kala chosess
        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            circularProgress1.Visible = true;
            circularProgress1.Start();

            _listkala.Add(_kala);
            updatedatagrid();

            circularProgress1.Visible = false;
            circularProgress1.Stop();
        }
        #endregion

        private void dgfaktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            var blm = new blmoshtari();
            //Thread th = new Thread(s=>
            //   checkedListBox1.Items.Add( blm.search_by_name(txtname.Text))
            //    ); ;
            //th.Start();
        }

        private void txttedadkala_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txttedadkala.Text, "[^0-9]"))
            {
                txttedadkala.Focus();
                txttedadkala.Text = txttedadkala.Text.Remove(txttedadkala.Text.Length - 1);
            }
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtprice.Text, "[^0-9]"))
            {
                txtprice.Focus();
                txtprice.Text = txtprice.Text.Remove(txtprice.Text.Length - 1);
            }
        }
        #region get dada moshtari for faktor
        private async void addfaktor_Load(object sender, EventArgs e)
        {
            lablename.Text = _moshtari.Name;
            datafaktor.Text = DateTime.Now.ToString();
            totalprice.Text = _listkala.Sum(s => s.price).ToString();
            txtname.Focus();
            var blm = new blmoshtari();
            if (txtname.Text!="")
            {
             var data= blm.searchbyname(txtname.Text);
                if (data!=null)
                {
                    _moshtari = data;
                    txtname.Text = _moshtari.Name;
                    txtname.Enabled = false;
                    txtnamekala.Focus();
                }
                else
                {
                    MessageBox.Show("اطلاعات مشتری وجود ندارد ");
                }

            }
            lablename.Text = _moshtari.Name;
            datafaktor.Text = DateTime.Today.ToString();
            totalprice.Text = _listkala.Sum(s => s.price).ToString();

        }
        #endregion

        #region get data kala for faktor
        private kala _kala;
        private void txtnamekala_TextChanged(object sender, EventArgs e)
        {
            if (txtnamekala.Text!="")
            {
                var blk = new blkala();
                var data = blk.searchbyname(txtnamekala.Text);
                if (data!=null)
                {
                    _kala = data;
                    txttedadkala.Focus();
                    if (txttedadkala.Text!=""|txttedadkala.Text!="0")
                    {
                      _kala.tedad =int.Parse( txttedadkala.Text);
                        txtprice.Focus();
                        if (txtprice.Text!=""| txtprice.Text!="0")
                        {
                            _kala.price =_kala.tedad * float.Parse( txtprice.Text);
                        }
                        else
                        {
                            MessageBox.Show("قیمت کالا را به درستی وارد نمایید !!");
                        }


                    }
                    else
                    {
                        MessageBox.Show("تعداد کالا انتخاب شده صحیح نمی باشد  !!");
                    }
                }
                else
                {
                    MessageBox.Show("کالای مورد نظر وجود ندارد ");
                }
            }
        }
        #endregion
    }
}
