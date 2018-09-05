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
using DevExpress.XtraGrid.Views.Base;
using DALLayer;
using DevExpress.XtraGrid.Views.Grid;

namespace UILayer.General
{
    public partial class FRM_MaritalStatus : DevExpress.XtraEditors.XtraForm
    {
        MaritalStatusManager status = new MaritalStatusManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && MaritalStatusView.RowCount > 0)
            {
                MaritalStatusView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled =  btnModify.Enabled = true;
                txtMaritalStatusCode.Text = MaritalStatusView.GetRowCellValue(index, MaritalStatusManager.MaritalStatusDetails.MaritalStatusCode.ToString()).ToString();
                txtMaritalStatusName.Text = MaritalStatusView.GetRowCellValue(index, MaritalStatusManager.MaritalStatusDetails.MaritalStatusName.ToString()).ToString();
            }
        }
        public FRM_MaritalStatus()
        {
            InitializeComponent();
        }
        private void FRM_MaritalStatus_Load(object sender, EventArgs e)
        {
            try
            {
                MaritalStatusGrid.DataSource = status.CreateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaritalStatusCode.Text = status.GetCode().ToString();
                txtMaritalStatusName.Text = "";
                btnSave.Enabled = true;
                btnAddNew.Enabled = btnDelete.Enabled = btnModify.Enabled = false;
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
                if (txtMaritalStatusName.Text == "")
                {
                    MessageBox.Show("You Must Enter MaritalStatus Name");
                    return;
                }
                status.Add(new MaritalStatus() { MaritalStatusCode = int.Parse(txtMaritalStatusCode.Text), MaritalStatusName = txtMaritalStatusName.Text });
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = true;
                txtMaritalStatusCode.Text = txtMaritalStatusName.Text = "";
                MessageBox.Show("New MaritalStatus Successfully Added");
                FRM_MaritalStatus_Load(null, null);
                btnLast_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaritalStatusName.Text == "")
                {
                    MessageBox.Show("You Must Enter MaritalStatus Name");
                    return;
                }
                MaritalStatus st = status.Get(int.Parse(txtMaritalStatusCode.Text));
                st.MaritalStatusName = txtMaritalStatusName.Text;
                status.Update(st);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected MaritalStatus Successfully Modified");
                FRM_MaritalStatus_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                MaritalStatusView.FocusedRowHandle = ModifiedRowIndex;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MaritalStatus st = status.Get(int.Parse(txtMaritalStatusCode.Text));
                status.Delete(st);
                MessageBox.Show("Selected MaritalStatus Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_MaritalStatus_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private int RowFocusedIndex = 0;
        private void MaritalStatusView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            RowFocusedIndex = e.FocusedRowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            RowFocusedIndex = 0;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (RowFocusedIndex > 0)
            {
                GetFocusedRowData(--RowFocusedIndex);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (RowFocusedIndex < MaritalStatusView.RowCount - 1)
            {
                GetFocusedRowData(++RowFocusedIndex);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            RowFocusedIndex = MaritalStatusView.RowCount - 1;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void MaritalStatusView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void MaritalStatusView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
    }
}