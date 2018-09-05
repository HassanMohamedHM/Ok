using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BLLayer;
using DALLayer;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Linq;
using System.Threading;
using System.Data;
namespace UILayer.Accounts
{
    public partial class FRM_TransactionLines : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        long TransactionCode;
        bool IsPost;
        TransactionLineManager lines = new TransactionLineManager();
        public FRM_TransactionLines(long _TransCode, bool _IsPost)
        {
            InitializeComponent();
            try
            {
                this.TransactionCode = _TransCode;
                this.IsPost = _IsPost;
                txtTransCode.Text = TransactionCode.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FRM_TransactionLines_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsPost == true)
                {
                    btnAddNew.Enabled = btnDelete.Enabled = btnPost.Enabled = false;
                    panelControl1.Enabled = false;
                }
                
                #region Display Lines for Existing Transaction :
                lines.MakeFirstTable(TransactionCode);
                LinesGrid.DataSource = lines.DataSet;
                LinesGrid.DataMember = lines.DataMember;
                #endregion

                #region FillAccountsType :
                cmbAccountType.Properties.Items.AddRange(typeof(AccountsManager.AccountFilterationTypes).GetEnumValues());
                cmbOffsetType.Properties.Items.AddRange(typeof(AccountsManager.AccountFilterationTypes).GetEnumValues());
                #endregion

                LinesView.InitNewRow += LinesView_InitNewRow;
                btnCancel_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void LinesView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                #region Get Full Accounts Code :
                string fullAccount = Account.EditValue.ToString();
                string fullOffsetAccount = OffsetAccount.EditValue.ToString();
                fullAccount = GetFullAccountCode(AccountDeminsions, fullAccount);
                fullOffsetAccount = GetFullAccountCode(OffsetDeminsions, fullOffsetAccount);
                if (cmbAccountType.Text==AccountsManager.AccountFilterationTypes.Customer.ToString())
                {
                    fullAccount = "1-" + fullAccount;
                }
                else if (cmbAccountType.Text==AccountsManager.AccountFilterationTypes.Vendor.ToString())
                {
                    fullAccount = "2-" + fullAccount;
                }
                if (cmbOffsetType.Text == AccountsManager.AccountFilterationTypes.Customer.ToString())
                {
                    fullOffsetAccount = "1-" + fullOffsetAccount;
                }
                else if (cmbOffsetType.Text == AccountsManager.AccountFilterationTypes.Vendor.ToString())
                {
                    fullOffsetAccount = "2-" + fullOffsetAccount;
                }
                #endregion

                #region Add Line To DataBase :
                long linecode = lines.AddTransactionLineDetails(TransactionCode, deLineDate.DateTime.Date, cmbAccountType.Text,
                          fullAccount, spDebitAmount.Value == 0 ? null : (decimal?)spDebitAmount.Value,
                          spCreditAmount.Value == 0 ? null : (decimal?)spCreditAmount.Value,
                            txtDescription.Text, cmbOffsetType.Text, fullOffsetAccount); 
                #endregion

                #region Add Line To GridView :

                GridView view = sender as GridView;
                view.SetRowCellValue(e.RowHandle, view.Columns[0], linecode);
                view.SetRowCellValue(e.RowHandle, view.Columns[1], TransactionCode);
                view.SetRowCellValue(e.RowHandle, view.Columns[2], deLineDate.DateTime.Date);
                view.SetRowCellValue(e.RowHandle, view.Columns[3], cmbAccountType.Text);
                view.SetRowCellValue(e.RowHandle, view.Columns[4], fullAccount);
                view.SetRowCellValue(e.RowHandle, view.Columns[5], spDebitAmount.Value == 0 ? null : (decimal?)spDebitAmount.Value);
                view.SetRowCellValue(e.RowHandle, view.Columns[6], spCreditAmount.Value == 0 ? null : (decimal?)spCreditAmount.Value);
                view.SetRowCellValue(e.RowHandle, view.Columns[7], txtDescription.Text);
                view.SetRowCellValue(e.RowHandle, view.Columns[8], cmbOffsetType.Text);
                view.SetRowCellValue(e.RowHandle, view.Columns[9], fullOffsetAccount);

                #endregion


                btnCancel_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Used To Get All Financial Deminsion Code
        /// </summary>
        /// <param name="deminsions">Control that Contains All Financial Deminsions Controls</param>
        /// <param name="fullAccount">Variable That Holdes Main Account Code</param>
        /// <returns>return Full Account Code</returns>
        private string GetFullAccountCode(PanelControl deminsions,string fullAccount)
        {
            for (int i = 0; i < deminsions.Controls.Count; i++)
            {
                SearchLookUpEdit ctr = (deminsions.Controls[i] as SearchLookUpEdit);
                if (ctr.EditValue == null)
                {
                    continue;
                }
                fullAccount += "-" + ctr.Tag + "-" + ctr.EditValue;
            }
            return fullAccount;
        }
        private void btnAddNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            //panelControl1.Visible = true; ;
            //LinesGrid.Location = new Point(0, panelControl1.Height);
        }
        AccountsManager accManager = new AccountsManager();
        void GetAccountsUponToFilterType(string value, SearchLookUpEdit item)
        {
            /*
             * Ledger ==>> Get All Acounts
             * Customer ==>> Get Customer Only
             * Vendor ==>> Get Vendor Only
             * Bank ==>> Get Bank  Only
             */
            item.Properties.DataSource = null;
            item.Properties.View.Columns.Clear();
            item.EditValue = null;
            if (value == AccountsManager.AccountFilterationTypes.Ledger.ToString())
            {
                item.Properties.DataSource = CreateCustomTable(accManager.CreateTable());
                item.Properties.DisplayMember = item.Properties.ValueMember = AccountsManager.AccountDetails.accCode.ToString();
            }
            else if (value == AccountsManager.AccountFilterationTypes.Customer.ToString())
            {
                item.Properties.DataSource =CreateCustomTable(new CustomerManager().CreateTable());
                item.Properties.DisplayMember = item.Properties.ValueMember = CustomerManager.CustomerDetails.CustomerCode.ToString();
            }
            else if (value == AccountsManager.AccountFilterationTypes.Vendor.ToString())
            {
                item.Properties.DataSource =CreateCustomTable( new VendorManager().CreateTable());
                item.Properties.DisplayMember = item.Properties.ValueMember = VendorManager.VendorDetails.VendorCode.ToString();
            }
            else if (value == AccountsManager.AccountFilterationTypes.Bank.ToString())
            {

            }
        }

        private DataTable CreateCustomTable(DataTable Source)
        {
            DataTable dt = Source.Copy();
            for (int i = 2; i < dt.Columns.Count; i = 2)
            {
                dt.Columns.RemoveAt(i);
            }
            return dt;
        }        
        void GetDeminsions(string accCode,PanelControl ctr)
        {
            if (!string.IsNullOrEmpty(accCode))
            {
               ICollection<StructureDeminsions> AllDeminsions= accManager.Get(accCode).StructureDeminsions;
               ctr.Controls.Clear();
               int XLocation = 0;
               foreach (StructureDeminsions deminsion in AllDeminsions)
                {
                    if (deminsion != null)
                    {
                        /*
                         * 1    -->     Customer
                         * 2    -->     Vendor
                         * 3    -->     Branch
                         * 4    -->     Sites
                         * 5    -->     Department
                         * 6    -->     Employee
                         */
                        
                        int width=ctr.Width / AllDeminsions.Count;
                        SearchLookUpEdit item = CreateElement();
                        item.Size = new System.Drawing.Size(width, 20);
                        item.Location = new Point(XLocation, 3);
                        item.Tag = deminsion.FinCatCode;
                        item.ToolTip = deminsion.FinancialCategory.FinCatName;
                        ctr.Controls.Add(item);
                        XLocation += width;
                        switch (deminsion.FinCatCode)
                        {
                            case 1:
                                item.Properties.DataSource =CreateCustomTable(new CustomerManager().CreateTable());
                                item.Properties.DisplayMember = item.Properties.ValueMember = CustomerManager.CustomerDetails.CustomerCode.ToString(); break;
                            case 2:
                                item.Properties.DataSource =CreateCustomTable( new VendorManager().CreateTable());
                                item.Properties.DisplayMember = item.Properties.ValueMember = VendorManager.VendorDetails.VendorCode.ToString(); break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            case 6:
                                item.Properties.DataSource =CreateCustomTable( new EmployeeManager().CreateTable());
                                item.Properties.DisplayMember = item.Properties.ValueMember = EmployeeManager.EmployeeDetails.EmployeeCode.ToString(); break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
        private void cmbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbAccountType.SelectedIndex==-1)
                {
                    return;
                }
                GetAccountsUponToFilterType(cmbAccountType.EditValue.ToString(), Account);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void cmbOffsetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbOffsetType.SelectedIndex == -1)
                {
                    return;
                }
                GetAccountsUponToFilterType(cmbOffsetType.EditValue.ToString(), OffsetAccount);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        SearchLookUpEdit CreateElement()
        {
            SearchLookUpEdit grid = new SearchLookUpEdit();
            grid.Properties.NullText = "";
            grid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            grid.Properties.View.OptionsView.ShowAutoFilterRow = true;
            return grid;
        }
        private void Account_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 if (Account.EditValue==null)
                {
                    AccountDeminsions.Controls.Clear();
                    return;                    
                }
                if (cmbAccountType.EditValue.ToString() == AccountsManager.AccountFilterationTypes.Ledger.ToString())
                {
                    if (accManager.Get(Account.EditValue.ToString()).AllowManualEntry==false)
                    {
                        MessageBox.Show("This Account Not AllowManual Entry");
                        Account.EditValue = null;
                    }
                    else
                    {
                        GetDeminsions(Account.EditValue.ToString(), AccountDeminsions); 
                    }
                }
                else
                {
                    AccountDeminsions.Controls.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void OffsetAccount_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (OffsetAccount.EditValue==null)
                {
                    AccountDeminsions.Controls.Clear();
                    return;                    
                }
                if (cmbOffsetType.EditValue.ToString() == AccountsManager.AccountFilterationTypes.Ledger.ToString())
                {
                    if (accManager.Get(OffsetAccount.EditValue.ToString()).AllowManualEntry == false)
                    {
                        MessageBox.Show("This Account Not AllowManual Entry");
                        OffsetAccount.EditValue = null;
                    }
                    else
                    {
                        GetDeminsions(OffsetAccount.EditValue.ToString(), OffsetDeminsions);
                    }
                }
                else
                {
                    OffsetDeminsions.Controls.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (deLineDate.EditValue==null)
                {
                    MessageBox.Show("You must Choose Line Date", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return; 
                }
                else if (Account.EditValue == null)
                {
                    MessageBox.Show("You must Choose Account", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (spDebitAmount.Value == 0 && spCreditAmount.Value == 0)
                {
                    MessageBox.Show("You must Enter Credit Or Debit Amount", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (OffsetAccount.EditValue == null)
                {
                    MessageBox.Show("You must Choose Offset Account", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
              
                LinesView.AddNewRow();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //panelControl1.Visible = false; ;
            //LinesGrid.Location = new Point(0, 0);
            AccountDeminsions.Controls.Clear();
            OffsetDeminsions.Controls.Clear();
            spCreditAmount.Value = spDebitAmount.Value = 0;
            txtDescription.Text = "";
            Account.EditValue = null;
            Account.Properties.DataSource = null;
            Account.Properties.View.Columns.Clear();
            OffsetAccount.EditValue = null;
            OffsetAccount.Properties.DataSource = null;
            OffsetAccount.Properties.View.Columns.Clear();
            cmbOffsetType.SelectedIndex= cmbAccountType.SelectedIndex = -1;
            deLineDate.DateTime = DateTime.Now;
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (LinesView.FocusedRowHandle >= 0)
                {
                    TransactionLines l = lines.Get(long.Parse(LinesView.GetRowCellValue(LinesView.FocusedRowHandle, LinesView.Columns[0]).ToString()));
                    lines.Delete(l);
                    LinesView.DeleteRow(LinesView.FocusedRowHandle);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void spDebitAmount_EditValueChanged(object sender, EventArgs e)
        {
            if (spDebitAmount.Value != 0)
            {
                spCreditAmount.Value = 0;
            }
           
        }

        private void spCreditAmount_EditValueChanged(object sender, EventArgs e)
        {
            if (spCreditAmount.Value!=0)
            {
                spDebitAmount.Value = 0; 
            }
        }   

        private void btnPost_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (lines.GetAll().Where(l => l.transCode == TransactionCode).Count() > 0)
                {
                    int userCode = int.Parse(Thread.CurrentPrincipal.Identity.Name.ToString());
                    PostedTransactionsManager postLines = new PostedTransactionsManager();
                    foreach (TransactionLines item in lines.GetAll().Where(l => l.transCode == TransactionCode))
                    {
                        postLines.AddPostedTransactionDetails(TransactionCode, DateTime.Now, userCode, item.accCode,
                           item.DebitAmount == null ? null : item.DebitAmount, item.CreditAmount == null ? null : item.CreditAmount);

                        postLines.AddPostedTransactionDetails((long)item.transCode, DateTime.Now, userCode, item.offsetAccCode,
                       item.DebitAmount == null ? item.CreditAmount : null, item.CreditAmount == null ? item.DebitAmount : null);
                    }
                    TransactionHeaderManager headerManager = new TransactionHeaderManager();
                    TransactionHeader header = headerManager.Get(TransactionCode);
                    header.IsPosted = true;
                    headerManager.Update(header);
                    btnAddNew.Enabled = btnDelete.Enabled = btnPost.Enabled = false;
                    panelControl1.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}