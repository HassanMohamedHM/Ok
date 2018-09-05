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
    public partial class FRM_User : DevExpress.XtraEditors.XtraForm
    {
        UserManager User = new UserManager();
        UserRolesManager userrole = new UserRolesManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && UserView.RowCount > 0)
            {
                UserView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled =  btnModify.Enabled = true;
                txtUserCode.Text = UserView.GetRowCellValue(index, UserManager.UserDetails.UserCode.ToString()).ToString();
                txtUserName.Text = UserView.GetRowCellValue(index, UserManager.UserDetails.UserName.ToString()).ToString();
                txtPassword.Text = UserView.GetRowCellValue(index, UserManager.UserDetails.Password.ToString()).ToString();
                cmbRole.Text = UserView.GetRowCellValue(index, UserManager.UserDetails.Role.ToString()).ToString();
                cmbEmployee.Text = UserView.GetRowCellValue(index, UserManager.UserDetails.Employee.ToString()).ToString();
            }

        }
        public FRM_User()
        {
            InitializeComponent();
        }
        private void FRM_User_Load(object sender, EventArgs e)
        {
            try
            {
                EmployeeManager.FillEmployeeComboBox(cmbEmployee);
                RoleManager.FillRoleComboBox(cmbRole);
                UserGrid.DataSource = User.CreateTable();
                UserView.Columns[UserManager.UserDetails.Password.ToString()].Visible = false;
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
                txtUserCode.Text = User.GetCode().ToString();
                txtUserName.Text = "";
                txtPassword.Text = "";
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
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("You Must Enter User Name");
                    return;
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("You Must Enter Password");
                    return;
                }
                User.Add(new User()
                {
                    User_Code = int.Parse(txtUserCode.Text),
                    User_Name = txtUserName.Text,
                    Password = txtPassword.Text,
                    Employee_Code = int.Parse(cmbEmployee.SelectedValue.ToString())
                });
                userrole.Add(new UserRoles()
                {
                    User_Code = int.Parse(txtUserCode.Text),
                    Role_Code = int.Parse(cmbRole.SelectedValue.ToString())
                });
                btnSave.Enabled = false;
                btnAddNew.Enabled =  btnModify.Enabled = true;
                txtUserCode.Text = txtUserName.Text = "";
                MessageBox.Show("New User Successfully Added");
                FRM_User_Load(null, null);
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
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("You Must Enter User Name");
                    return;
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("You Must Enter Password");
                    return;
                }
                User ur = User.Get(int.Parse(txtUserCode.Text));
                ur.User_Name = txtUserName.Text;
                ur.Password = txtPassword.Text;
                ur.Employee_Code = int.Parse(cmbEmployee.SelectedValue.ToString());
                User.Update(ur);
                userrole.DeleteMulti(ur.UserRoles);
                userrole.Add(new UserRoles()
                {
                    User_Code = int.Parse(txtUserCode.Text),
                    Role_Code = int.Parse(cmbRole.SelectedValue.ToString())
                });
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected User Successfully Modified");
                FRM_User_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                UserView.FocusedRowHandle = ModifiedRowIndex;
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
                User ur = User.Get(int.Parse(txtUserCode.Text));
                userrole.DeleteMulti(ur.UserRoles);
                User.Delete(ur);
                MessageBox.Show("Selected User Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_User_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private int RowFocusedIndex = 0;
        private void UserView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
            if (RowFocusedIndex < UserView.RowCount - 1)
            {
                GetFocusedRowData(++RowFocusedIndex);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            RowFocusedIndex = UserView.RowCount - 1;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void UserView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void UserView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
    }
}
