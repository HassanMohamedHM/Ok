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
using DALLayer;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace UILayer.Users
{
    public partial class FRM_Permission : DevExpress.XtraEditors.XtraForm
    {
         PermissionManager Permission = new PermissionManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && PermissionView.RowCount > 0)
            {
                PermissionView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnDelete.Enabled = btnModify.Enabled = true;
                txtPermissionCode.Text = PermissionView.GetRowCellValue(index, PermissionManager.PermissionDetails.PermissionCode.ToString()).ToString();
                txtPermissionName.Text = PermissionView.GetRowCellValue(index, PermissionManager.PermissionDetails.PermissionName.ToString()).ToString();
            }
        }
        public FRM_Permission()
        {
            InitializeComponent();
        }
        private void FRM_Permission_Load(object sender, EventArgs e)
        {
            try
            {
                PermissionGrid.DataSource = Permission.CreateTable();
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
                txtPermissionCode.Text = Permission.GetCode().ToString();
                txtPermissionName.Text = "";
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
                if (txtPermissionName.Text == "")
                {
                    MessageBox.Show("You Must Enter Permission Name");
                    return;
                }
                Permission.Add(new Permission() { Permission_Code = int.Parse(txtPermissionCode.Text), Permission_Name = txtPermissionName.Text });
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnDelete.Enabled = btnModify.Enabled = true;
                txtPermissionCode.Text = txtPermissionName.Text = "";
                MessageBox.Show("New Permission Successfully Added");
                FRM_Permission_Load(null, null);
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
                if (txtPermissionName.Text == "")
                {
                    MessageBox.Show("You Must Enter Permission Name");
                    return;
                }
                Permission pr = Permission.Get(int.Parse(txtPermissionCode.Text));
                pr.Permission_Name = txtPermissionName.Text;
                Permission.Update(pr);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected Permission Successfully Modified");
                FRM_Permission_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                PermissionView.FocusedRowHandle = ModifiedRowIndex;
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
                Permission pr = Permission.Get(int.Parse(txtPermissionCode.Text));
                Permission.Delete(pr);
                MessageBox.Show("Selected Permission Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_Permission_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private int RowFocusedIndex = 0;
        private void PermissionView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
            if (RowFocusedIndex < PermissionView.RowCount - 1)
            {
                GetFocusedRowData(++RowFocusedIndex);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            RowFocusedIndex = PermissionView.RowCount - 1;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void PermissionView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void PermissionView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
    }
}
  