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
    public partial class FRM_Customer : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        CustomerManager Customer = new CustomerManager();
        private void GetFocusedRowData(int index)
        {
            
            if (index >= 0 && CustomerView.RowCount > 0)
            {
                CustomerView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = btnDelete.Enabled = true;
                txtCustCode.Text = CustomerView.GetRowCellValue(index, CustomerManager.CustomerDetails.CustomerCode.ToString()).ToString();
                Customer c = Customer.Get(int.Parse(txtCustCode.Text));
                txtCustName.Text = c.Customer_Name;
                txtAddress.Text = c.Address;
                City.EditValue = c.City_Code;
                txtMobile1.Text = c.Mobile1;
                txtMobile2.Text = c.Mobile2;
                txtEmail.Text = c.EMail;
                txtFaceBook.Text = c.FaceBook;
                spCreditLimit.Value = c.CreditLimit == null ? 0 : (decimal)c.CreditLimit;
                Group.EditValue = c.GroupCode;
                txtNotes.Text = c.Notes;
            }
        }
        public FRM_Customer()
        {
            InitializeComponent();
            try
            {

                #region Fill Search LookUp :
                HelperClass.FillSearchLookUpByData(City, new CityManager().CreateTable(), CityManager.CityDetails.CityName.ToString(),
                    CityManager.CityDetails.CityCode.ToString());

                HelperClass.FillSearchLookUpByData(Group, new CustomerGroupManager().CreateTable(), CustomerGroupManager.GroupDetails.GroupName.ToString(),
                  CustomerGroupManager.GroupDetails.GroupCode.ToString());
                #endregion
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FRM_Customer_Load(object sender, EventArgs e)
        {
            try
            {

                #region Fill Grid By Data :
                CustomerGrid.DataSource = Customer.CreateTable();
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
                txtCustCode.Text = Customer.GetCode().ToString();
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
                if (txtCustName.Text == "")
                {
                    MessageBox.Show("Customer Name Must Entered");
                    return;
                }
                Customer.Add(new Customer()
                {
                    Customer_Code = int.Parse(txtCustCode.Text),
                    Customer_Name = txtCustName.Text,
                    Address = txtAddress.Text,
                    City_Code = int.Parse(City.EditValue.ToString()),
                    Mobile1 = txtMobile1.Text,
                    Mobile2 = txtMobile2.Text,
                    EMail = txtEmail.Text,
                    FaceBook = txtFaceBook.Text,
                    Notes = txtNotes.Text,
                    CreditLimit = spCreditLimit.Value,
                    GroupCode = int.Parse(Group.EditValue.ToString())
                });
                MessageBox.Show("New Customer Successfully Added");
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = btnDelete.Enabled = true;
                FRM_Customer_Load(null, null);
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
                if (txtCustName.Text == "")
                {
                    MessageBox.Show("Customer Name Must Entered");
                    return;
                }
                Customer cust = Customer.Get(int.Parse(txtCustCode.Text));
                cust.Customer_Code = int.Parse(txtCustCode.Text);
                cust.Customer_Name = txtCustName.Text;
                cust.Address = txtAddress.Text;
                cust.City_Code = int.Parse(City.EditValue.ToString());
                cust.Mobile1 = txtMobile1.Text;
                cust.Mobile2 = txtMobile2.Text;
                cust.EMail = txtEmail.Text;
                cust.FaceBook = txtFaceBook.Text;
                cust.Notes = txtNotes.Text;
                cust.CreditLimit = spCreditLimit.Value;
                cust.GroupCode = int.Parse(Group.EditValue.ToString());
                Customer.Update(cust);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected Customer Successfully Modified");
                FRM_Customer_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                CustomerView.FocusedRowHandle = ModifiedRowIndex;
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
                int CustCode = int.Parse(txtCustCode.Text);
                if (new SalesHeaderManager().GetAll().Where(sa => sa.Customer_Code == CustCode).ToList().Count > 0)
                {
                    MessageBox.Show("You Can't Delete This Customer", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                Customer cust = Customer.Get(CustCode);
                Customer.Delete(cust);
                MessageBox.Show("Selected Customer Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_Customer_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private int RowFocusedIndex = 0;
        private void CustomerView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            RowFocusedIndex = e.FocusedRowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void CustomerView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void CustomerView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }

    }
}