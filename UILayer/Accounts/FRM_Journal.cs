using System;
using System.Windows.Forms;
using BLLayer;
using DALLayer;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
namespace UILayer.Accounts
{
    public partial class FRM_Journal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        JournalManager journal = new JournalManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && JournalView.RowCount > 0)
            {
                JournalView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = true;
                txtJournalCode.Text = JournalView.GetRowCellValue(index, JournalManager.JournalDetails.JournalCode.ToString()).ToString();
                txtJournalName.Text = JournalView.GetRowCellValue(index, JournalManager.JournalDetails.JournalName.ToString()).ToString();
            }

        }
        public FRM_Journal()
        {
            InitializeComponent();
        }
        private void FRM_Journal_Load(object sender, EventArgs e)
        {
            try
            {
                JournalGrid.DataSource = journal.CreateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int RowFocusedIndex = 0;
        private void JournalView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            RowFocusedIndex = e.FocusedRowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void JournalView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void JournalView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void btnAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                txtJournalCode.Text = journal.GetCode().ToString();
                txtJournalName.Text = "";
                btnSave.Enabled = true;
                btnAddNew.Enabled = btnDelete.Enabled = btnModify.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtJournalName.Text == "")
                {
                    MessageBox.Show("You Must Enter Journal Name");
                    return;
                }
                JournalNames jr = journal.Get(int.Parse(txtJournalCode.Text));
                jr.JournalName = txtJournalName.Text;
                journal.Update(jr);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected Journal Successfully Modified");
                FRM_Journal_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                JournalView.FocusedRowHandle = ModifiedRowIndex;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtJournalName.Text == "")
                {
                    MessageBox.Show("You Must Enter Journal Name");
                    return;
                }
                journal.Add(new JournalNames()
                {
                    JournalCode = int.Parse(txtJournalCode.Text),
                    JournalName = txtJournalName.Text
                });
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = true;
                MessageBox.Show("New Journal Successfully Added");
                FRM_Journal_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                JournalNames jr = journal.Get(int.Parse(txtJournalCode.Text));
                journal.Delete(jr);
                MessageBox.Show("Selected Journal Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_Journal_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}