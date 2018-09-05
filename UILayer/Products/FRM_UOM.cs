using System;
using DALLayer;
using BLLayer;
using DevExpress.XtraEditors;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using System.Windows.Forms;
namespace UILayer.Products
{
    public partial class FRM_UOM : DevExpress.XtraEditors.XtraForm
    {
        UOMConversionsManager uom = new UOMConversionsManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && UOMView.RowCount > 0)
            {
                UOMView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = true;
                txtUOMCode.Text = UOMView.GetRowCellValue(index, UOMConversionsManager.UOMDetails.ID.ToString()).ToString();
                UnitFrom.EditValue = UOMView.GetRowCellValue(index, UOMConversionsManager.UOMDetails.UnitFromCode.ToString()).ToString();
                UnitTo.EditValue = UOMView.GetRowCellValue(index, UOMConversionsManager.UOMDetails.UnitToCode.ToString()).ToString();
                spFactor.Value = decimal.Parse(UOMView.GetRowCellValue(index, UOMConversionsManager.UOMDetails.Factor.ToString()).ToString());
                UOMConversions c = uom.Get(int.Parse(txtUOMCode.Text));
                if (c.IsSpecial == true)
                {
                    radUOMType.SelectedIndex = 1;
                    Product.EditValue = c.ProductCode;
                }
                else
                {
                    radUOMType.SelectedIndex = 0;
                }


            }
        }
        public FRM_UOM()
        {
            InitializeComponent();
        }

        private void FRM_UOM_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new UnitManager().CreateTable();
                #region Unit From :
                HelperClass.FillSearchLookUpByData(UnitFrom, dt, UnitManager.UnitDetails.UnitName.ToString(), UnitManager.UnitDetails.UnitCode.ToString());
                #endregion

                #region Unit To :
                HelperClass.FillSearchLookUpByData(UnitTo, dt, UnitManager.UnitDetails.UnitName.ToString(), UnitManager.UnitDetails.UnitCode.ToString());
                #endregion

                #region Product :
                HelperClass.FillSearchLookUpByData(Product, new ProductManager().CreateTable(),
                     ProductManager.ProductDetails.ProductName.ToString(),
                     ProductManager.ProductDetails.ProductCode.ToString());
                #endregion

                #region Fill Grid View :
                UOMGrid.DataSource = uom.CreateTable();
                #endregion

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void radUOMType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProduct.Visible = Product.Visible = radUOMType.SelectedIndex == 0 ? false : true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtUOMCode.Text = uom.GetCode().ToString();
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

                uom.Add(new UOMConversions()
                {
                    ID = int.Parse(txtUOMCode.Text),
                    Unit_Code_From = int.Parse(UnitFrom.EditValue.ToString()),
                    Unit_Code_To = int.Parse(UnitTo.EditValue.ToString()),
                    Factor = spFactor.Value,
                    IsSpecial = radUOMType.SelectedIndex == 0 ? false : true,
                    ProductCode = radUOMType.SelectedIndex == 0 ? null : (int?)int.Parse(Product.EditValue.ToString())
                });
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = true;
                MessageBox.Show("New UOM Conversion Successfully Added");
                FRM_UOM_Load(null, null);
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
                UOMConversions uc = uom.Get(int.Parse(txtUOMCode.Text));
                uc.Unit_Code_From = int.Parse(UnitFrom.EditValue.ToString());
                uc.Unit_Code_To = int.Parse(UnitTo.EditValue.ToString());
                uc.Factor = spFactor.Value;
                uc.IsSpecial = radUOMType.SelectedIndex == 0 ? false : true;
                uc.ProductCode = radUOMType.SelectedIndex == 0 ? null : (int?)int.Parse(Product.EditValue.ToString());
                uom.Update(uc);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected UOM Conversion Successfully Modified");
                FRM_UOM_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                UOMView.FocusedRowHandle = ModifiedRowIndex;
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
                UOMConversions uc = uom.Get(int.Parse(txtUOMCode.Text));
                uom.Delete(uc);
                MessageBox.Show("Selected UOM Conversion Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_UOM_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private int RowFocusedIndex = 0;
        private void UOMView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
            if (RowFocusedIndex < UOMView.RowCount - 1)
            {
                GetFocusedRowData(++RowFocusedIndex);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            RowFocusedIndex = UOMView.RowCount - 1;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void UOMView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void UOMView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
    }
}