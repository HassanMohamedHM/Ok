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
using DevExpress.XtraGrid.Views.Grid;
using DALLayer;
namespace UILayer.Users
{
    public partial class FRM_Screen : DevExpress.XtraEditors.XtraForm
    {
        ScreenManager screen = new ScreenManager();
        PermissionInScreenManagerManager perinscreen = new PermissionInScreenManagerManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && ScreenView.RowCount > 0)
            {
                ScreenView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnDelete.Enabled = btnModify.Enabled = true;
                txtScreenCode.Text = ScreenView.GetRowCellValue(index, ScreenManager.ScreenDetails.ScreenCode.ToString()).ToString();
                txtScreenName.Text = ScreenView.GetRowCellValue(index, ScreenManager.ScreenDetails.ScreenName.ToString()).ToString();
                DALLayer.Screen s = new ScreenManager().Get(int.Parse(txtScreenCode.Text));

                for (int i = 0; i < dgvPermissions.Rows.Count; i++)
                {
                    foreach (PermissionsInScreen p in s.PermissionsInScreen)
                    {
                        dgvPermissions.Rows[i].Cells[check.Name].Value = p.Permission_Code == int.Parse(dgvPermissions.Rows[i].Cells[PerCode.Name].Value.ToString()) ? true : dgvPermissions.Rows[i].Cells[check.Name].Value;
                    }
                }

            }
        }
        public FRM_Screen()
        {
            InitializeComponent();
            dgvPermissions.BackgroundColor = this.BackColor;
        }
        private void FRM_Screen_Load(object sender, EventArgs e)
        {
            try
            {
                ScreenGrid.DataSource = screen.CreateTable();
                FillPermissionsGrid();
                GetFocusedRowData(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillPermissionsGrid()
        {
            DataTable dt = new PermissionManager().CreateTable();
            dgvPermissions.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvPermissions.Rows.Add(dt.Rows[i][PermissionManager.PermissionDetails.PermissionCode.ToString()],
                    dt.Rows[i][PermissionManager.PermissionDetails.PermissionName.ToString()], "False");
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvPermissions.Rows.Count; i++)
                {
                    dgvPermissions.Rows[i].Cells[check.Name].Value = "False";
                }
                txtScreenCode.Text = screen.GetCode().ToString();
                txtScreenName.Text = "";
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
                if (txtScreenName.Text == "")
                {
                    MessageBox.Show("You Must Enter Screen Name");
                    return;
                }
                DALLayer.Screen s = screen.Add(new DALLayer.Screen() { Screen_Code = int.Parse(txtScreenCode.Text), Screen_Name = txtScreenName.Text });
                AddScreenPermissions(s);
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnDelete.Enabled = btnModify.Enabled = true;
                txtScreenCode.Text = txtScreenName.Text = "";
                MessageBox.Show("New Screen Successfully Added");
                FRM_Screen_Load(null, null);
                btnLast_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void AddScreenPermissions(DALLayer.Screen s)
        {

            for (int i = 0; i < dgvPermissions.Rows.Count; i++)
            {
                if (bool.Parse(dgvPermissions.Rows[i].Cells[check.Name].Value.ToString()) == true)
                {
                    perinscreen.Add(new PermissionsInScreen()
                    {
                        Screen_Code = s.Screen_Code,
                        Permission_Code = int.Parse(dgvPermissions.Rows[i].Cells[PerCode.Name].Value.ToString())
                    });
                }
            }

        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtScreenName.Text == "")
                {
                    MessageBox.Show("You Must Enter Screen Name");
                    return;
                }
                DALLayer.Screen sc = screen.Get(int.Parse(txtScreenCode.Text));
                sc.Screen_Name = txtScreenName.Text;
                perinscreen.DeleteMulti(sc.PermissionsInScreen);
                AddScreenPermissions(sc);
                screen.Update(sc);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected Screen Successfully Modified");
                FRM_Screen_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                ScreenView.FocusedRowHandle = ModifiedRowIndex;
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
                DALLayer.Screen sc = screen.Get(int.Parse(txtScreenCode.Text));
                perinscreen.DeleteMulti(sc.PermissionsInScreen);
                screen.Delete(sc);
                MessageBox.Show("Selected Screen Successfully Deleted");
                FRM_Screen_Load(null, null);
                RowFocusedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private int RowFocusedIndex = 0;
        private void ScreenView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
            if (RowFocusedIndex < ScreenView.RowCount - 1)
            {
                GetFocusedRowData(++RowFocusedIndex);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            RowFocusedIndex = ScreenView.RowCount - 1;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void ScreenView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void ScreenView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
    }
}