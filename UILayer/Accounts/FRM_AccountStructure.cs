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
    public partial class FRM_AccountStructure : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        StructureDeminsionsManager deminsions = new StructureDeminsionsManager();
        AccountStructureManager accstructure = new AccountStructureManager();
        DataTable dt;

        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && AccountStructureView.RowCount > 0)
            {
                AccountStructureView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = btnDelete.Enabled = true;
                txtStructureCode.Text = AccountStructureView.GetRowCellValue(index,
                    AccountStructureManager.AccountStructureDetails.StructureCode.ToString()).ToString();
                AccountStructure acst = accstructure.Get(int.Parse(txtStructureCode.Text));
                txtStructureName.Text = acst.StructureName;
                dt.Rows.Clear();
               // FinancialDeminsionView.Columns.Clear();
                FinancialDeminsionGrid.DataSource = null;
                foreach (StructureDeminsions item in acst.StructureDeminsions)
                {
                    Account.EditValue = item.AccCode;
                    
                    dt.Rows.Add(item.FinCatCode, item.FinancialCategory.FinCatName);
                }
                FinancialDeminsionGrid.DataSource = dt;
                FinancialDeminsionGrid.DataMember = dt.TableName;
            }
        }
        public FRM_AccountStructure()
        {
            InitializeComponent();
            try
            {
                HelperClass.FillSearchLookUpByData(Account, new AccountsManager().CreateTable(),
                    AccountsManager.AccountDetails.accName.ToString(),
                    AccountsManager.AccountDetails.accCode.ToString());

                HelperClass.FillSearchLookUpByData(FinancialCategory, new FinancialDeminsionCategoryManager().CreateTable(),
                    FinancialDeminsionCategoryManager.FinDemCatDetails.FinDemCatName.ToString(),
                    FinancialDeminsionCategoryManager.FinDemCatDetails.FinDemCatCode.ToString());



               
                dt = new DataTable();
                dt.Columns.Add("DemCode", typeof(int));
                dt.Columns.Add("DemName", typeof(string));
                FinancialDeminsionGrid.DataSource = dt;
                FinancialDeminsionGrid.DataMember = dt.TableName;
                FinancialDeminsionView.InitNewRow += FinancialDeminsionView_InitNewRow;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void FinancialDeminsionView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            FinancialDeminsionView.SetRowCellValue(e.RowHandle, FinancialDeminsionView.Columns[0], FinancialCategory.EditValue);
            FinancialDeminsionView.SetRowCellValue(e.RowHandle, FinancialDeminsionView.Columns[1], FinancialCategory.Text);
        }
        private void FRM_AccountStructure_Load(object sender, EventArgs e)
        {
            try
            {
                AccountStructureGrid.DataSource = accstructure.CreateTable();
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
                txtStructureName.Text = "";
                txtStructureCode.Text = accstructure.GetCode().ToString();
                Account.EditValue = null;
                dt.Rows.Clear();
                FinancialDeminsionGrid.DataSource = dt;
                btnSave.Enabled = true;
                btnAddNew.Enabled = btnDelete.Enabled = btnModify.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddSegment_Click(object sender, EventArgs e)
        {
            FinancialDeminsionGrid.EmbeddedNavigator.Buttons.DoClick(FinancialDeminsionGrid.EmbeddedNavigator.Buttons.EndEdit);
            if (FinancialCategory.EditValue == null)
            {
                MessageBox.Show("You Must Choose Finacial Category","Stop",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            if (FinancialDeminsionView.RowCount >= 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() == FinancialCategory.EditValue.ToString())
                    {
                        MessageBox.Show("You Can't Add the Same Finacial Category -->> " + FinancialCategory.Text, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }
            FinancialDeminsionView.AddNewRow();
        }

        private void btnFinDelete_Click(object sender, EventArgs e)
        {
            FinancialDeminsionView.DeleteRow(FinancialDeminsionView.FocusedRowHandle);
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (txtStructureName.Text == "")
                {
                    MessageBox.Show("Account Structure Name Must Entered");
                    return;
                }
                else if (FinancialDeminsionView.RowCount <= 0)
                {
                    MessageBox.Show("You Must Choose at least one Financial Deminsion Category");
                    return;
                }
                accstructure.Add(new AccountStructure()
                {
                    StructureCode = int.Parse(txtStructureCode.Text),
                    StructureName = txtStructureName.Text
                });
                FinancialDeminsionGrid.EmbeddedNavigator.Buttons.DoClick(FinancialDeminsionGrid.EmbeddedNavigator.Buttons.EndEdit);
                for (int i = 0; i < FinancialDeminsionView.RowCount; i++)
                {
                    deminsions.Add(new StructureDeminsions()
                          {
                              StructureCode = int.Parse(txtStructureCode.Text),
                              AccCode = Account.EditValue.ToString(),
                              FinCatCode = int.Parse(FinancialDeminsionView.GetRowCellValue(i, FinancialDeminsionView.Columns[0]).ToString())
                          });
                }

                MessageBox.Show("New Account Structure Successfully Added");
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = btnDelete.Enabled = true;
                FRM_AccountStructure_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private int RowFocusedIndex = 0;
        private void AccountStructureView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RowFocusedIndex = e.FocusedRowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }

        private void AccountStructureView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }

        private void AccountStructureView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
    }
}