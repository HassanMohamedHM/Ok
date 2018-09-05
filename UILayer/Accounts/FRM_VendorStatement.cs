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
using DALLayer;
using BLLayer;
namespace UILayer.Accounts
{
    public partial class FRM_VendorStatement : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FRM_VendorStatement()
        {
            InitializeComponent();
        }

        private void FRM_CustomerStatement_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new VendorManager().CreateTable().Copy();
                for (int i = 2; i < dt.Columns.Count; i = 2)
                {
                    dt.Columns.RemoveAt(i);
                }
                VendorSearchLookUpEdit.DataSource = dt;
                VendorSearchLookUpEdit.DisplayMember = VendorSearchLookUpEdit.ValueMember = VendorManager.VendorDetails.VendorCode.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        decimal Vendor_Debit, Vendor_Credit;
        private void btnDisplay_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (Vendor.EditValue == null)
                {
                    MessageBox.Show("You must Choose Vendor", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                DataTable dt = VendorManager.GetVendorStatement(Vendor.EditValue.ToString(), null, null, out Vendor_Debit, out Vendor_Credit);
                VendorStatementGrid.DataSource = dt;
                VendorStatementGrid.DataMember = dt.TableName;
                VendorDebit.Caption = Vendor_Debit.ToString();
                VendorCredit.Caption = Vendor_Credit.ToString();
                VendorBalance.Caption = (Vendor_Debit - Vendor_Credit).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPeriodDisplay_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (Vendor.EditValue == null)
                {
                    MessageBox.Show("You must Choose Vendor", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (DateFrom.EditValue == null)
                {
                    MessageBox.Show("You must Choose From Date", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (DateTo.EditValue == null)
                {
                    MessageBox.Show("You must Choose To Date", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if ((DateTime)DateFrom.EditValue > (DateTime)DateTo.EditValue)
                {
                    MessageBox.Show("From Date must be Less than Or Equal To Date", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                DataTable dt = VendorManager.GetVendorStatement(Vendor.EditValue.ToString(), (DateTime)DateFrom.EditValue, (DateTime)DateTo.EditValue, out Vendor_Debit, out Vendor_Credit);
                VendorStatementGrid.DataSource = dt;
                VendorStatementGrid.DataMember = dt.TableName;
                VendorDebit.Caption = Vendor_Debit.ToString();
                VendorCredit.Caption = Vendor_Credit.ToString();
                VendorBalance.Caption = (Vendor_Debit - Vendor_Credit).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            VendorStatementView.ShowRibbonPrintPreview();
        }
    }
}