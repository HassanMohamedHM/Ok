using System;
using System.Windows.Forms;
using BLLayer;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DALLayer;
namespace UILayer.WareHouses
{
    public partial class Frm_WareHouse : DevExpress.XtraEditors.XtraForm
    {
        WareHouseManager warehouse = new WareHouseManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && WareHouseView.RowCount > 0)
            {
                WareHouseView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled =  btnModify.Enabled = true;
                txtWareHouseCode.Text = WareHouseView.GetRowCellValue(index, WareHouseManager.WareHouseDetails.WareHouseCode.ToString()).ToString();
                txtWareHouseName.Text = WareHouseView.GetRowCellValue(index, WareHouseManager.WareHouseDetails.WareHouseName.ToString()).ToString();
                cmbSite.Text = WareHouseView.GetRowCellValue(index, WareHouseManager.WareHouseDetails.SiteName.ToString()).ToString();
                cmbType.Text = WareHouseView.GetRowCellValue(index, WareHouseManager.WareHouseDetails.WareHouseType.ToString()).ToString();
                cmbManager.Text = WareHouseView.GetRowCellValue(index, WareHouseManager.WareHouseDetails.WareHouse_Manager.ToString()).ToString();
                txtNotes.Text = WareHouseView.GetRowCellValue(index, WareHouseManager.WareHouseDetails.Notes.ToString()).ToString();

            }
        }
        public Frm_WareHouse()
        {
            InitializeComponent();
        }
        private void FRM_WareHouse_Load(object sender, EventArgs e)
        {
            try
            {
                #region Fill All ComboBox By Data :
                SiteManager.FillSiteComboBox(cmbSite);
                EmployeeManager.FillEmployeeComboBox(cmbManager);
                cmbType.DataSource = Enum.GetValues(typeof(WareHouseManager.WareHouseType));
                #endregion

                #region Fill Grid By Data :
                WareHouseGrid.DataSource = warehouse.CreateTable();
                #endregion
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
                txtWareHouseName.Text = txtNotes.Text = "";
                txtWareHouseCode.Text = warehouse.GetCode().ToString();
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
                if (txtWareHouseName.Text == "")
                {
                    MessageBox.Show("You Must Enter WareHouse Name");
                    return;
                }
                warehouse.Add(new WareHouse()
                {
                    WareHouse_Code = int.Parse(txtWareHouseCode.Text),
                    WareHouse_Name = txtWareHouseName.Text,
                    Site_Code = int.Parse(cmbSite.SelectedValue.ToString()),
                    WareHouse_Type = cmbType.Text,
                    ManagerCode = int.Parse(cmbManager.SelectedValue.ToString()),
                    Notes = txtNotes.Text
                });
                btnSave.Enabled = false;
                btnAddNew.Enabled =  btnModify.Enabled = true;
                MessageBox.Show("New WareHouse Successfully Added");
                FRM_WareHouse_Load(null, null);
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
                if (txtWareHouseName.Text == "")
                {
                    MessageBox.Show("You Must Enter Inventory Name");
                    return;
                }
                WareHouse wh = warehouse.Get(int.Parse(txtWareHouseCode.Text));
                wh.WareHouse_Name = txtWareHouseName.Text;
                wh.Site_Code = int.Parse(cmbSite.SelectedValue.ToString());
                wh.WareHouse_Type = cmbType.Text;
                wh.ManagerCode = int.Parse(cmbManager.SelectedValue.ToString());
                wh.Notes = txtNotes.Text;
                warehouse.Update(wh);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected WareHouse Successfully Modified");
                FRM_WareHouse_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                WareHouseView.FocusedRowHandle = ModifiedRowIndex;
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
                WareHouse wh = warehouse.Get(int.Parse(txtWareHouseCode.Text));
                warehouse.Delete(wh);
                MessageBox.Show("Selected WareHouse Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_WareHouse_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private int RowFocusedIndex = 0;
        private void WareHouseView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
            if (RowFocusedIndex < WareHouseView.RowCount - 1)
            {
                GetFocusedRowData(++RowFocusedIndex);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            RowFocusedIndex = WareHouseView.RowCount - 1;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void WareHouseView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void WareHouseView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
    }
}