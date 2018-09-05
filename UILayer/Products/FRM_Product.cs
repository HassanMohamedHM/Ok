using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BLLayer;
using DALLayer;
using System.IO;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
namespace UILayer.Products
{
    public partial class FRM_Product : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ProductManager product = new ProductManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && ProductView.RowCount > 0)
            {
                ProductView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = true;
                txtProductCode.Text = ProductView.GetRowCellValue(index, ProductManager.ProductDetails.ProductCode.ToString()).ToString();

                Product pr = product.Get(int.Parse(txtProductCode.Text));

                txtProductName.Text = pr.Product_Name;
                txtDescription.Text = pr.ProductDesc;
                txtSearchName.Text = pr.SearchName;
                ProductImage.Image = Image.FromStream(new MemoryStream(pr.Product_Image));
                txtBarcode.Text = pr.Product_Barcode;
                DefPurchaseWareHouse.EditValue = pr.DefPurchaseWH;
                DefSalesWareHouse.EditValue = pr.DefSalesWH;
                DefWareHouseUnit.EditValue = pr.DefInventoryUnit;
                DefPurchaseUnit.EditValue = pr.DefPurchaseUnit;
                DefSalesUnit.EditValue = pr.DefSalesUnit;
                DefPurchasePrice.EditValue = pr.DefPurchasePrice;
                DefSalesPrice.EditValue = pr.DefSalesPrice;
                ProductType.EditValue = pr.ProductType;
                PrGroup.EditValue = pr.GroupCode;

            }
        }
        public FRM_Product()
        {
            InitializeComponent();
            try
            {
                #region Fill SearchEdit By Data :
                WareHouseManager wh = new WareHouseManager();

                HelperClass.FillSearchLookUpByData(DefPurchaseWareHouse, wh.CreateTable(), WareHouseManager.WareHouseDetails.WareHouseName.ToString(),
                   WareHouseManager.WareHouseDetails.WareHouseCode.ToString());

                HelperClass.FillSearchLookUpByData(DefSalesWareHouse, wh.CreateTable(), WareHouseManager.WareHouseDetails.WareHouseName.ToString(),
                  WareHouseManager.WareHouseDetails.WareHouseCode.ToString());

                UnitManager unit = new UnitManager();

                HelperClass.FillSearchLookUpByData(DefWareHouseUnit, unit.CreateTable(), UnitManager.UnitDetails.UnitName.ToString(),
                  UnitManager.UnitDetails.UnitCode.ToString());

                HelperClass.FillSearchLookUpByData(DefPurchaseUnit, unit.CreateTable(), UnitManager.UnitDetails.UnitName.ToString(),
                  UnitManager.UnitDetails.UnitCode.ToString());

                HelperClass.FillSearchLookUpByData(DefSalesUnit, unit.CreateTable(), UnitManager.UnitDetails.UnitName.ToString(),
                  UnitManager.UnitDetails.UnitCode.ToString());

                #region Product Types :
                DataTable PrTypes = new DataTable();
                PrTypes.Columns.Add("TypeName", typeof(string));
                PrTypes.Rows.Add(ProductManager.ProductType.RM.ToString());
                PrTypes.Rows.Add(ProductManager.ProductType.PKG.ToString());
                PrTypes.Rows.Add(ProductManager.ProductType.PACK.ToString());
                PrTypes.Rows.Add(ProductManager.ProductType.SFG.ToString());
                PrTypes.Rows.Add(ProductManager.ProductType.FG.ToString());
                PrTypes.Rows.Add(ProductManager.ProductType.Service.ToString());
                PrTypes.Rows.Add(ProductManager.ProductType.CoProduct.ToString());

                HelperClass.FillSearchLookUpByData(ProductType, PrTypes, "TypeName", "TypeName"); 
                #endregion

                HelperClass.FillSearchLookUpByData(PrGroup, new ProductGroupManager().CreateTable(), ProductGroupManager.GroupDetails.GroupName.ToString(),
                   ProductGroupManager.GroupDetails.GroupCode.ToString());
                #endregion
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FRM_Product_Load(object sender, EventArgs e)
        {
            try
            {
                #region Fill Grid By Data :
                ProductGrid.DataSource = product.CreateTable();
                #endregion
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                foreach (Control ctr in panelControl2.Controls)
                {
                    if (ctr is TextEdit || ctr is SpinEdit)
                    {
                        ctr.Text = "";
                    }
                }
                txtProductCode.Text = product.GetCode().ToString();
                btnSave.Enabled = true;
                btnAddNew.Enabled = btnDelete.Enabled = btnModify.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (txtProductName.Text == "")
                {
                    MessageBox.Show("You Must Enter Product Name", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (DefPurchaseWareHouse.EditValue == null || DefSalesWareHouse.EditValue == null)
                {
                    MessageBox.Show("You Must Choose All WhareHouses", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (DefWareHouseUnit.EditValue == null || DefPurchaseUnit.EditValue == null || DefSalesUnit.EditValue == null)
                {
                    MessageBox.Show("You Must Choose All Units", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (ProductType.EditValue == null)
                {
                    MessageBox.Show("You Must Choose Product Type", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (PrGroup.EditValue == null)
                {
                    MessageBox.Show("You Must Choose Product Group", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                MemoryStream ms = new MemoryStream();
                ProductImage.Image.Save(ms, ProductImage.Image.RawFormat);
                product.Add(new Product()
                {
                    Product_Code = int.Parse(txtProductCode.Text),
                    Product_Name = txtProductName.Text,
                    ProductDesc = txtDescription.Text,
                    SearchName = txtSearchName.Text,
                    Product_Image = ms.ToArray(),
                    Product_Barcode = txtBarcode.Text,
                    DefPurchaseWH = int.Parse(DefPurchaseWareHouse.EditValue.ToString()),
                    DefSalesWH = int.Parse(DefSalesWareHouse.EditValue.ToString()),
                    DefInventoryUnit = int.Parse(DefWareHouseUnit.EditValue.ToString()),
                    DefPurchaseUnit = int.Parse(DefPurchaseUnit.EditValue.ToString()),
                    DefSalesUnit = int.Parse(DefSalesUnit.EditValue.ToString()),
                    DefPurchasePrice = DefPurchasePrice.Value,
                    DefSalesPrice = DefSalesPrice.Value,
                    ProductType = ProductType.Text,
                    GroupCode = int.Parse(PrGroup.EditValue.ToString())
                });
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = true;
                MessageBox.Show("New Product Successfully Added");
                FRM_Product_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnModify_ItemClick(object sender, ItemClickEventArgs e)
        {

            try
            {
                if (txtProductName.Text == "")
                {
                    MessageBox.Show("You Must Enter Product Name", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (DefPurchaseWareHouse.EditValue == null || DefSalesWareHouse.EditValue == null)
                {
                    MessageBox.Show("You Must Choose All WhareHouses", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (DefWareHouseUnit.EditValue == null || DefPurchaseUnit.EditValue == null || DefSalesUnit.EditValue == null)
                {
                    MessageBox.Show("You Must Choose All Units", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (ProductType.EditValue == null)
                {
                    MessageBox.Show("You Must Choose Product Type", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (PrGroup.EditValue == null)
                {
                    MessageBox.Show("You Must Choose Product Group", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                MemoryStream ms = new MemoryStream();
                ProductImage.Image.Save(ms, ProductImage.Image.RawFormat);
                Product pr = product.Get(int.Parse(txtProductCode.Text));
                pr.Product_Name = txtProductName.Text;
                pr.ProductDesc = txtDescription.Text;
                pr.SearchName = txtSearchName.Text;
                pr.Product_Image = ms.ToArray();
                pr.Product_Barcode = txtBarcode.Text;
                pr.DefPurchaseWH = int.Parse(DefPurchaseWareHouse.EditValue.ToString());
                pr.DefSalesWH = int.Parse(DefSalesWareHouse.EditValue.ToString());
                pr.DefInventoryUnit = int.Parse(DefWareHouseUnit.EditValue.ToString());
                pr.DefPurchaseUnit = int.Parse(DefPurchaseUnit.EditValue.ToString());
                pr.DefSalesUnit = int.Parse(DefSalesUnit.EditValue.ToString());
                pr.DefPurchasePrice = DefPurchasePrice.Value;
                pr.DefSalesPrice = DefSalesPrice.Value;
                pr.ProductType = ProductType.Text;
                pr.GroupCode = int.Parse(PrGroup.EditValue.ToString());
                product.Update(pr);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected Product Successfully Modified");
                FRM_Product_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                ProductView.FocusedRowHandle = ModifiedRowIndex;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Product pr = product.Get(int.Parse(txtProductCode.Text));
                product.Delete(pr);
                MessageBox.Show("Selected Product Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_Product_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUOM_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FRM_UOM().Show();
        }

        private void btnOnHand_ItemClick(object sender, ItemClickEventArgs e)
        {
            new WareHouses.FRM_WareHousesBalances().Show();
        }

        private int RowFocusedIndex = 0;
        private void ProductView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            RowFocusedIndex = e.FocusedRowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }

        private void ProductView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void ProductView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        ProductImage.Image = Image.FromFile(ofd.FileName);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ProductImage_Click(object sender, EventArgs e)
        {
            btnAddImage_Click(null, null);
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            try
            {
                ProductImage.Image = UILayer.Properties.Resources.Product;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}