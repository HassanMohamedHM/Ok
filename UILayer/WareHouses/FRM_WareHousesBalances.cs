using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLLayer;
namespace UILayer.WareHouses
{
    public partial class FRM_WareHousesBalances : DevExpress.XtraEditors.XtraForm
    {
        public FRM_WareHousesBalances()
        {
            InitializeComponent();
        }

        private void FRM_WareHousesBalances_Load(object sender, EventArgs e)
        {
            try
            {
                OnHandGrid.DataSource = new OnHandProductManager().CreateTable();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}