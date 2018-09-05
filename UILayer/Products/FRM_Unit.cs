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

namespace UILayer.Products
{
    public partial class FRM_Unit : DevExpress.XtraEditors.XtraForm
    {
        UnitManager unit = new UnitManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && UnitView.RowCount > 0)
            {
                UnitView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = true;
                txtUnitCode.Text = UnitView.GetRowCellValue(index, UnitManager.UnitDetails.UnitCode.ToString()).ToString();
                txtUnitName.Text = UnitView.GetRowCellValue(index, UnitManager.UnitDetails.UnitName.ToString()).ToString();
                CategorySearch.EditValue = UnitView.GetRowCellValue(index, UnitManager.UnitDetails.catCode.ToString()).ToString();
            }
        }
        public FRM_Unit()
        {
            InitializeComponent();
        }
        private void FRM_Unit_Load(object sender, EventArgs e)
        {
            try
            {
                CategorySearch.Properties.DataSource = new UOMCategoryManager().CreateTable();
                CategorySearch.Properties.ValueMember = UOMCategoryManager.UnitCategoryDetails.CatCode.ToString();
                CategorySearch.Properties.DisplayMember = UOMCategoryManager.UnitCategoryDetails.Category.ToString();
                UnitGrid.DataSource = unit.CreateTable();
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
                txtUnitCode.Text = unit.GetCode().ToString();
                txtUnitName.Text = "";
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
                if (txtUnitName.Text == "")
                {
                    MessageBox.Show("You Must Enter Unit Name");
                    return;
                }
                unit.Add(new Unit()
                {
                    Unit_Code = int.Parse(txtUnitCode.Text),
                    Unit_Name = txtUnitName.Text,
                    CatCode = int.Parse(CategorySearch.EditValue.ToString())
                });
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = true;
                txtUnitCode.Text = txtUnitName.Text = "";
                MessageBox.Show("New Unit Successfully Added");
                FRM_Unit_Load(null, null);
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
                if (txtUnitName.Text == "")
                {
                    MessageBox.Show("You Must Enter Unit Name");
                    return;
                }
                Unit ui = unit.Get(int.Parse(txtUnitCode.Text));
                ui.Unit_Name = txtUnitName.Text;
                ui.CatCode = int.Parse(CategorySearch.EditValue.ToString());
                unit.Update(ui);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected Unit Successfully Modified");
                FRM_Unit_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                UnitView.FocusedRowHandle = ModifiedRowIndex;
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
                Unit ui = unit.Get(int.Parse(txtUnitCode.Text));
                unit.Delete(ui);
                MessageBox.Show("Selected Unit Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_Unit_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private int RowFocusedIndex = 0;
        private void UnitView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
            if (RowFocusedIndex < UnitView.RowCount - 1)
            {
                GetFocusedRowData(++RowFocusedIndex);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            RowFocusedIndex = UnitView.RowCount - 1;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void UnitView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void UnitView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
    }
}