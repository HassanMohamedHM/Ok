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
    public partial class FRM_CategoryUnit : DevExpress.XtraEditors.XtraForm
    {
        UOMCategoryManager cat = new UOMCategoryManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && UnitCategoryView.RowCount > 0)
            {
                UnitCategoryView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled =  btnModify.Enabled = true;
                txtCatCode.Text = UnitCategoryView.GetRowCellValue(index, UOMCategoryManager.UnitCategoryDetails.CatCode.ToString()).ToString();
                txtCatName.Text = UnitCategoryView.GetRowCellValue(index, UOMCategoryManager.UnitCategoryDetails.Category.ToString()).ToString();
            }
        }
        public FRM_CategoryUnit()
        {
            InitializeComponent();
        }
        private void FRM_CategoryUnit_Load(object sender, EventArgs e)
        {
            try
            {
                UnitCategoryGrid.DataSource = cat.CreateTable();
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
                txtCatCode.Text = cat.GetCode().ToString();
                txtCatName.Text = "";
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
                if (txtCatName.Text == "")
                {
                    MessageBox.Show("You Must Enter Unit Name");
                    return;
                }
                cat.Add(new UOMCCategory() { CatCode = int.Parse(txtCatCode.Text), CatName = txtCatName.Text });
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = true;
                txtCatCode.Text = txtCatName.Text = "";
                MessageBox.Show("New Category Successfully Added");
                FRM_CategoryUnit_Load(null, null);
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
                if (txtCatName.Text == "")
                {
                    MessageBox.Show("You Must Enter Unit Name");
                    return;
                }
                UOMCCategory uom = cat.Get(int.Parse(txtCatCode.Text));
                uom.CatName = txtCatName.Text;
                cat.Update(uom);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected Category Successfully Modified");
                FRM_CategoryUnit_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                UnitCategoryView.FocusedRowHandle = ModifiedRowIndex;
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
                UOMCCategory uom = cat.Get(int.Parse(txtCatCode.Text));
                cat.Delete(uom);
                MessageBox.Show("Selected Category Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_CategoryUnit_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private int RowFocusedIndex = 0;
        private void UnitCategoryView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
            if (RowFocusedIndex < UnitCategoryView.RowCount - 1)
            {
                GetFocusedRowData(++RowFocusedIndex);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            RowFocusedIndex = UnitCategoryView.RowCount - 1;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void UnitCategoryView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void UnitCategoryView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
    }
}