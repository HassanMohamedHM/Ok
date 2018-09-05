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
    public partial class FRM_Role : DevExpress.XtraEditors.XtraForm
    {
        RoleManager role = new RoleManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && RoleView.RowCount > 0)
            {
                RoleView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = true;
                txtRoleCode.Text = RoleView.GetRowCellValue(index, RoleManager.RoleDetails.RoleCode.ToString()).ToString();
                txtRoleName.Text = RoleView.GetRowCellValue(index, RoleManager.RoleDetails.RoleName.ToString()).ToString();
            }
        }
        public FRM_Role()
        {
            InitializeComponent();
        }
        private void FRM_Role_Load(object sender, EventArgs e)
        {
            try
            {
                RoleGrid.DataSource = role.CreateTable();
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
                txtRoleCode.Text = role.GetCode().ToString();
                txtRoleName.Text = "";
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
                if (txtRoleName.Text == "")
                {
                    MessageBox.Show("You Must Enter Role Name");
                    return;
                }
                role.Add(new Role() { Role_Code = int.Parse(txtRoleCode.Text), Role_Name = txtRoleName.Text });
                btnSave.Enabled = false;
                btnAddNew.Enabled =  btnModify.Enabled = true;
                txtRoleCode.Text = txtRoleName.Text = "";
                MessageBox.Show("New Role Successfully Added");
                FRM_Role_Load(null, null);
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
                if (txtRoleName.Text == "")
                {
                    MessageBox.Show("You Must Enter Role Name");
                    return;
                }
                Role pr = role.Get(int.Parse(txtRoleCode.Text));
                pr.Role_Name = txtRoleName.Text;
                role.Update(pr);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected Role Successfully Modified");
                FRM_Role_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                RoleView.FocusedRowHandle = ModifiedRowIndex;
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
                Role pr = role.Get(int.Parse(txtRoleCode.Text));
                role.Delete(pr);
                MessageBox.Show("Selected Role Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_Role_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private int RowFocusedIndex = 0;
        private void RoleView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
            if (RowFocusedIndex < RoleView.RowCount - 1)
            {
                GetFocusedRowData(++RowFocusedIndex);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            RowFocusedIndex = RoleView.RowCount - 1;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void RoleView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void RoleView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
    }
}
