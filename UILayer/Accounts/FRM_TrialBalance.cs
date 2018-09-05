using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BLLayer;
namespace UILayer.Accounts
{
    public partial class FRM_TrialBalance : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccountsManager account = new AccountsManager();
        public FRM_TrialBalance()
        {
            InitializeComponent();
            btnDisplay_ItemClick(null, null);
        }

        private void btnDisplay_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable  dt=account.DisplayTrialBalance((DateTime?)DateFrom.EditValue, (DateTime?)DateTo.EditValue);
                TrialBalanceGrid.DataSource = dt;
                TrialBalanceGrid.DataMember = dt.TableName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            TrialBalanceBand.ShowRibbonPrintPreview();
        }
    }
}