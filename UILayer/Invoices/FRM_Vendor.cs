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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace UILayer.Invoices
{
    public partial class FRM_Vendor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        VendorManager vendor = new VendorManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && VendorView.RowCount > 0)
            {
                VendorView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = btnDelete.Enabled = true;
                txtVendorCode.Text = VendorView.GetRowCellValue(index, VendorManager.VendorDetails.VendorCode.ToString()).ToString();
                Vendor c = vendor.Get(int.Parse(txtVendorCode.Text));
                txtVendorName.Text = c.Vendor_Name;
                txtAddress.Text = c.Address;
                City.EditValue = c.City_Code;
                txtMobile1.Text = c.Mobile1;
                txtMobile2.Text = c.Mobile2;
                txtEmail.Text = c.EMail;
                Group.EditValue = c.GroupCode;
                txtNotes.Text = c.Notes;
            }
        }
        public FRM_Vendor()
        {
            InitializeComponent();
            try
            {

                #region Fill Search LookUp :
                HelperClass.FillSearchLookUpByData(City, new CityManager().CreateTable(), CityManager.CityDetails.CityName.ToString(),
                    CityManager.CityDetails.CityCode.ToString());

                HelperClass.FillSearchLookUpByData(Group, new VendorGroupManager().CreateTable(), VendorGroupManager.GroupDetails.GroupName.ToString(),
                  VendorGroupManager.GroupDetails.GroupCode.ToString());
                #endregion
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FRM_Vendor_Load(object sender, EventArgs e)
        {
            try
            {

                #region Fill Grid By Data :
                VendorGrid.DataSource = vendor.CreateTable();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                foreach (Control ctr in panelControl2.Controls)
                {
                    if (ctr is TextEdit && !(ctr is SearchLookUpEdit))
                        ctr.Text = "";
                    if (ctr is SpinEdit)
                        ctr.Text = "0";
                }
                txtVendorCode.Text = vendor.GetCode().ToString();
                btnSave.Enabled = true;
                btnAddNew.Enabled = btnDelete.Enabled = btnModify.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (txtVendorName.Text == "")
                {
                    MessageBox.Show("Vendor Name Must Entered");
                    return;
                }
                vendor.Add(new Vendor()
                {
                    Vendor_Code = int.Parse(txtVendorCode.Text),
                    Vendor_Name = txtVendorName.Text,
                    Address = txtAddress.Text,
                    City_Code = int.Parse(City.EditValue.ToString()),
                    Mobile1 = txtMobile1.Text,
                    Mobile2 = txtMobile2.Text,
                    EMail = txtEmail.Text,
                    Notes = txtNotes.Text,
                    GroupCode = int.Parse(Group.EditValue.ToString())
                });
                MessageBox.Show("New Vendor Successfully Added");
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = btnDelete.Enabled = true;
                FRM_Vendor_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnModify_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (txtVendorName.Text == "")
                {
                    MessageBox.Show("Vendor Name Must Entered");
                    return;
                }
                Vendor cust = vendor.Get(int.Parse(txtVendorCode.Text));
                cust.Vendor_Code = int.Parse(txtVendorCode.Text);
                cust.Vendor_Name = txtVendorName.Text;
                cust.Address = txtAddress.Text;
                cust.City_Code = int.Parse(City.EditValue.ToString());
                cust.Mobile1 = txtMobile1.Text;
                cust.Mobile2 = txtMobile2.Text;
                cust.EMail = txtEmail.Text;
                cust.Notes = txtNotes.Text;
                cust.GroupCode = int.Parse(Group.EditValue.ToString());
                vendor.Update(cust);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected Vendor Successfully Modified");
                FRM_Vendor_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                VendorView.FocusedRowHandle = ModifiedRowIndex;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                int VendorCode = int.Parse(txtVendorCode.Text);
                if (new PurchaseManager().GetAll().Where(sa => sa.Vendor_Code == VendorCode).ToList().Count > 0)
                {
                    MessageBox.Show("You Can't Delete This Vendor", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                Vendor cust = vendor.Get(VendorCode);
                vendor.Delete(cust);
                MessageBox.Show("Selected Vendor Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_Vendor_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private int RowFocusedIndex = 0;
        private void VendorView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            RowFocusedIndex = e.FocusedRowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void VendorView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void VendorView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }

    }
}