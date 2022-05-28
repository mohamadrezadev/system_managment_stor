using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Agent_Dashboard
{
    public partial class moshtari : UserControl
    {
        public moshtari()
        {
            InitializeComponent();
        }
        private void updatedatagrid()
        {
            #region datagridload
            dgmoshtari.DataSource = null;
            var blm = new blmoshtari();
            var listdada = blm.Read_all();
            dgmoshtari.DataSource = listdada;
            int count = 0;
            foreach (DataGridViewColumn i in dgmoshtari.Columns)
            {
                switch (i.Name)
                {
                    case "Name":
                        i.HeaderText = "نام و نام خانوادگی";
                        i.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        i.HeaderCell.SortGlyphDirection = SortOrder.Descending;
                        i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                    case "phone_nuber":
                        i.HeaderText = "شماره تلفن ";
                        i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                    
                    default:
                        i.Visible = false;
                        break;

                };
                dgmoshtari.Columns[0].Name = "ردیف";
                dgmoshtari.Rows.Add(count);
                count++;
            }
            #endregion
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            updatedatagrid();
        }
    }
}
