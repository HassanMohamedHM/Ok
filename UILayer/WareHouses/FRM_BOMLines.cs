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
using DALLayer;
using BLLayer;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Drawing;
namespace UILayer.WareHouses
{
    public partial class FRM_BOMLines : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BOMOutputProductManager output = new BOMOutputProductManager();
        BOMIngredientsProductsManager ingred = new BOMIngredientsProductsManager();
        long BOMCode;
        bool IsPosted;
        public FRM_BOMLines(long _BOMCode,bool _IsPosted)
        {
            InitializeComponent();
            this.BOMCode = _BOMCode;
            this.IsPosted = _IsPosted;

        }

        private void FRM_BOMJournal_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsPosted==true)
                {
                    btnNew.Enabled = btnDelete.Enabled = btnPost.Enabled = btnValidate.Enabled = false;
                    LinesView.OptionsBehavior.Editable = false;
                }

                #region Fill Products :
                repProduct.DataSource = new ProductManager().CreateTable();
                repProduct.DisplayMember = repProduct.ValueMember = ProductManager.ProductDetails.ProductCode.ToString();
                #endregion

                #region Initialize Lines View to accept Data :
                DataTable dt = BOMHeaderManager.GetBomDetails(BOMCode);
                LinesGrid.DataSource = dt;
                LinesGrid.DataMember = dt.TableName;
                #endregion


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (IsPosted == false)
                {
                    LinesView.AddNewRow();
                    LinesGrid.EmbeddedNavigator.Buttons.DoClick(LinesGrid.EmbeddedNavigator.Buttons.EndEdit);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LinesView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                if (LinesView.RowCount <= 1)
                {
                    int OUtCode = int.Parse(output.GetCode().ToString());
                    LinesView.SetRowCellValue(e.RowHandle, LinesView.Columns[0], "OUT" + OUtCode);
                    LinesView.SetRowCellValue(e.RowHandle, LinesView.Columns[4], "0");
                    LinesView.SetRowCellValue(e.RowHandle, LinesView.Columns[5], "1");

                    output.Add(new BOMOutputProduct()
                          {
                              BOMCode=BOMCode,
                              OutputCode = OUtCode,
                              LookUpCode = "OUT" + OUtCode,
                              Cost=0,
                              Quantity=1
                          });
                }
                else
                {
                    int INGCode = int.Parse(ingred.GetCode().ToString());
                    LinesView.SetRowCellValue(e.RowHandle, LinesView.Columns[0], "ING" + INGCode);
                    LinesView.SetRowCellValue(e.RowHandle, LinesView.Columns[4], "0");
                    LinesView.SetRowCellValue(e.RowHandle, LinesView.Columns[5], "1");

                    ingred.Add(new BOMIngredientsProducts()
                    {
                        BOMCode = BOMCode,
                        IngCode = INGCode,
                        LookUpCode = "ING" + INGCode,
                        OutputCode = long.Parse(LinesView.GetRowCellValue(0, LinesView.Columns[0]).ToString().Substring(3)),
                        Cost = 0,
                        Quantity = 1
                    });
                }

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
                if (LinesView.RowCount > 0 && LinesView.FocusedRowHandle > 0)
                {
                    BOMIngredientsProducts BOMIngr = ingred.Get(
                        long.Parse(LinesView.GetRowCellValue(LinesView.FocusedRowHandle,
                        LinesView.Columns[0]).ToString().Substring(3)));
                    ingred.Delete(BOMIngr);
                    LinesView.DeleteRow(LinesView.FocusedRowHandle);
                    GetTotalCost();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        int RowHandle;
        GridColumn Column;
        private void LinesView_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {
                if (LinesView.IsFilterRow(e.RowHandle))
                {
                    e.RepositoryItem = new RepositoryItemTextEdit();
                }
                else
                {
                    if (e.RowHandle >= 0 && e.Column.AbsoluteIndex == 3)
                    {
                        int PCode;
                        bool IsParsed = int.TryParse(LinesView.GetRowCellValue(e.RowHandle, LinesView.Columns[1]).ToString(), out PCode);

                        if (IsParsed == true)
                        {
                            FillWareHouse(PCode, e.RowHandle);
                            RepositoryItemSearchLookUpEdit re = (RepositoryItemSearchLookUpEdit)repWareHouse.Clone();
                            e.RepositoryItem = re;
                        }
                        else
                        {
                           // MessageBox.Show("You Must Choose Product Firstly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LinesView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    if (LinesView.IsFilterRow(RowHandle))
                    {
                        LinesView.ShowFilterEditor(Column);
                    }
                }
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.N)
                {
                    btnNew_ItemClick(null, null);
                }
                if (e.KeyCode == Keys.Delete)
                {

                    btnDelete_ItemClick(null, null);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LinesView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            Column = e.Column;
            RowHandle = e.RowHandle;

        }

        private void LinesView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
          
            string Code=LinesView.GetRowCellValue(e.RowHandle, LinesView.Columns[0]).ToString();

            if (e.RowHandle >= 0)
            {
                if (e.RowHandle == 0)
                {
                    BOMOutputProduct outProduct = output.Get(int.Parse(Code.Substring(3)));
                    switch (e.Column.AbsoluteIndex)
                    {
                        case 1:
                               outProduct.ProductCode = int.Parse(e.Value.ToString());
                               LinesView.SetRowCellValue(e.RowHandle, LinesView.Columns[2], new ProductManager().Get(int.Parse(e.Value.ToString())).Product_Name);
                             
                            break;
                        case 3:
                            outProduct.WHCode = int.Parse(e.Value.ToString());
                            e.Column.ColumnEdit = new RepositoryItemTextEdit();
                            break;
                        case 4:
                            outProduct.Cost = decimal.Parse(e.Value.ToString());
                            //GetTotalCost();
                            GetTotalLineCost(e.RowHandle, 5, decimal.Parse(e.Value.ToString()));
                            break;
                        case 5:
                            outProduct.Quantity = decimal.Parse(e.Value.ToString());
                            GetTotalCost();
                            GetTotalLineCost(e.RowHandle, 4, decimal.Parse(e.Value.ToString()));
                            break;
                        default:
                            break;
                    }
                    output.Update(outProduct);
                }
                else
                {
                     BOMIngredientsProducts ingProduct = ingred.Get(int.Parse(Code.Substring(3)));
                    switch (e.Column.AbsoluteIndex)
                    {
                        case 1:
                            int PCode= int.Parse(e.Value.ToString());
                            ingProduct.ProductCode = PCode;
                            DALLayer.Product productMgr = new ProductManager().Get(PCode);
                            decimal? Cost=productMgr.ProductOnHand.Count()>0?productMgr.ProductOnHand.FirstOrDefault().AvgCost:null;
                            LinesView.SetRowCellValue(e.RowHandle, LinesView.Columns[4],Cost==null?0:Cost );
                            LinesView.SetRowCellValue(e.RowHandle, LinesView.Columns[2], new ProductManager().Get(PCode).Product_Name);
                            break;
                        case 3:
                            ingProduct.WHCode = int.Parse(e.Value.ToString());
                            e.Column.ColumnEdit = new RepositoryItemTextEdit();
                            break;
                        case 4:
                            ingProduct.Cost = decimal.Parse(e.Value.ToString());
                            GetTotalLineCost(e.RowHandle, 5, decimal.Parse(e.Value.ToString()));
                            break;
                        case 5:
                            ingProduct.Quantity = decimal.Parse(e.Value.ToString());
                            GetTotalLineCost(e.RowHandle, 4, decimal.Parse(e.Value.ToString()));
                            break;
                        case 6:
                            GetTotalCost();
                            break;
                        default:
                            break;
                    }
                    ingred.Update(ingProduct);
                }
            }
        }

        private void GetTotalLineCost(int rowHandle,int ColumnIndex, decimal Value)
        {
            LinesView.SetRowCellValue(rowHandle, LinesView.Columns[6]
              , Value * decimal.Parse((LinesView.GetRowCellValue(rowHandle, LinesView.Columns[ColumnIndex])).ToString()));
        }

        private void GetTotalCost()
        {
            decimal total = 0;
            for (int i = 1; i < LinesView.RowCount; i++)
            {
                total += decimal.Parse(LinesView.GetRowCellValue(i, LinesView.Columns[6]).ToString());
            }
            LinesView.SetRowCellValue(0, LinesView.Columns[4], total / decimal.Parse(LinesView.GetRowCellValue(0, LinesView.Columns[5]).ToString()));
        }

        private void FillWareHouse(int PCode,int RowHandle)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("v1", typeof(string));
            dt.Columns.Add("v2", typeof(string));
            dt.Columns.Add("v3", typeof(string));
            dt.Rows.Clear();
            if (RowHandle == 0)
            {
                WareHouseManager WHManager = new WareHouseManager();
                foreach (DALLayer.WareHouse item in WHManager.GetAll())
                {
                    decimal? Qty=item.ProductOnHand.Where(w=>w.Product_Code==PCode).Sum(s=>s.Qty);
                    dt.Rows.Add(item.WareHouse_Code, item.WareHouse_Name,
                        Qty == null ? 0 : Qty);
                }
            }
            else
            {
                Product productMgr = new ProductManager().Get(PCode);
                foreach (ProductOnHand item in productMgr.ProductOnHand)
                {
                    dt.Rows.Add(item.WareHouse.WareHouse_Code, item.WareHouse.WareHouse_Name, item.Qty);
                }
            }
            repWareHouse.DataSource = dt;
            repWareHouse.ValueMember = repWareHouse.DisplayMember = "v1";

        }

        private void btnPost_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                BOMHeaderManager.PostBom(BOMCode);
                btnNew.Enabled = btnDelete.Enabled = btnPost.Enabled = btnValidate.Enabled = false;
                LinesView.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnValidate_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}