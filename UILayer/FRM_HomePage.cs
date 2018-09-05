using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using System.Threading;
using System;
using System.Windows.Forms;
using BLLayer;
using System.Linq;
using System.Collections.Generic;
using DALLayer;
using DevExpress.XtraCharts;
using System.Threading.Tasks;
namespace UILayer
{
    public partial class FRM_HomePage : RibbonForm
    {
        
        public FRM_HomePage()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-EG");
            InitializeComponent();
           // InitSkinGallery();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void TapPage_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            switch (TapPage.SelectedTabPageIndex)
            {
                case 0: RiBPages.SelectedPage = HomePage;
                    HomeTaps_SelectedPageChanged(null, null);
                    
                    break;
                case 1: RiBPages.SelectedPage = SalesPage; break;
                case 2: RiBPages.SelectedPage = PurchasesPage; break;
                case 3: RiBPages.SelectedPage = ExpensesPage; break;
                case 4: RiBPages.SelectedPage = WareHousesPage; break;
                case 5: RiBPages.SelectedPage = ProductsPage; break;
                case 6: RiBPages.SelectedPage = HRPage; break;
                case 7: RiBPages.SelectedPage = AccountsPage; break;
                case 8: RiBPages.SelectedPage = UsersPage; break;
                case 9: RiBPages.SelectedPage = SettingsPage; break;
                default:
                    break;
            }
        }

        private void RiBPages_SelectedPageChanged(object sender, System.EventArgs e)
        {
            switch (RiBPages.SelectedPage.PageIndex)
            {
                case 0: TapPage.SelectedTabPageIndex = 0; break;
                case 1: TapPage.SelectedTabPageIndex = 1; break;
                case 2: TapPage.SelectedTabPageIndex = 2; break;
                case 3: TapPage.SelectedTabPageIndex = 3; break;
                case 4: TapPage.SelectedTabPageIndex = 4; break;
                case 5: TapPage.SelectedTabPageIndex = 5; break;
                case 6: TapPage.SelectedTabPageIndex = 6; break;
                case 7: TapPage.SelectedTabPageIndex = 7; break;
                case 8: TapPage.SelectedTabPageIndex = 8; break;
                case 9: TapPage.SelectedTabPageIndex = 9; break;
                default:
                    break;
            }
        }

        private void HomePage_Load(object sender, System.EventArgs e)
        {
            try
            {

                LoginEmployeeName.Caption = "إسم المستخدم    " + new UserManager().Get(int.Parse(Thread.CurrentPrincipal.Identity.Name)).User_Name;
                HomeTaps_SelectedPageChanged(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddSalesInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             new Invoices.FRM_SalesInvoice().Show();
        }

        private void btnCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new  Invoices.FRM_Customer().Show();
        }

        private void btnPurchaseInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            new Invoices.FRM_PurchaseInvoice().Show();
        }

        private void btnVendors_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Invoices.FRM_Vendor().Show();
        }

        private void btnWareHouses_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new WareHouses.Frm_WareHouse().Show();
        }

        private void btnSites_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new WareHouses.FRM_Site().Show();
        }

        private void btnProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             new Products.FRM_Product().Show();
        }

        private void btnUnits_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Products.FRM_Unit().Show();
        }

        private void btnEmployees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new HR.FRM_Employee().Show();
        }

        private void btnJobs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new General.FRM_Job().Show();
        }

        private void btnMaritalStatus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new General.FRM_MaritalStatus().Show();
        }

        private void btnUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Users.FRM_User().Show();
        }

        private void btnRoles_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Users.FRM_Role().Show();
        }

        private void btnScreens_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Users.FRM_Screen().Show();
        }

        private void btnPermissions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Users.FRM_Permission().Show();
        }

        private void chkEnglish_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //chkArabic.Checked = !chkEnglish.Checked;
            //if (chkEnglish.Checked)
            //{
            //    UILayer.Properties.Settings.Default.Language = "en-US";
            //    UILayer.Properties.Settings.Default.Save();
            //    this.Controls.Clear();
            //    InitializeComponent();
            //}
        }

        private void chkArabic_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //chkEnglish.Checked = !chkArabic.Checked;
            //if (chkArabic.Checked)
            //{
            //    UILayer.Properties.Settings.Default.Language = "ar-EG";
            //    UILayer.Properties.Settings.Default.Save();
            //    this.Controls.Clear();
            //    InitializeComponent();
            //}
        }

        private void btnJournals_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Accounts.FRM_Journal().Show();
        }

        private void btnSalesInvoices_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Invoices.FRM_Sales().Show();
        }
        private void btnWHBalances_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new WareHouses.FRM_WareHousesBalances().Show();
        }

        private void btnAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Licences.FRM_About().Show();
        }

        private void btnCities_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new General.FRM_City().Show();
        }

        private void btnCountries_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new General.FRM_Country().Show();
        }
        private void AddFinDem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Accounts.FRM_AddFinancialDeminsion().Show();
        }

        private void btnAllFinDem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Accounts.FRM_FinancialDeminsion().Show();
        }

        private void btnUnitCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Products.FRM_CategoryUnit().Show();
        }

        private void btnUOMConversions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Products.FRM_UOM().Show();

        }

        private void GeneralAccountst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Accounts.FRM_GeneralAccounts().Show();
        }

        private void btnProductPosting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Posting.FRM_ItemGroupPosting().Show();
        }

        private void btnCustomerPosting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Posting.FRM_CustomerPosting().Show();
        }

        private void btnVendorPosting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Posting.FRM_VendorPosting().Show();
        }

        private void btnAccountStructure_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Accounts.FRM_AccountStructure().Show();
        }

        private void btnGeneralJournals_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Accounts.Frm_TransactionHeader().Show();
        }

        private void btnCustomerStatement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Accounts.FRM_CustomerStatement().Show();
        }

        private void btnVendorStatement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Accounts.FRM_VendorStatement().Show();
        }


        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {

                SortedList<int, decimal> MostSoldItems = new SortedList<int, decimal>();
                MostSoldItems = ProductManager.GetMostSoldProductOnPeriod((DateTime?)DateFrom.EditValue, (DateTime?)DateTo.EditValue);
                Series s = new Series("ترتيب الأصناف الأكثر مبيعاً", ViewType.Bar);
                foreach (int pCode in MostSoldItems.Keys)
                {
                    decimal k;
                    MostSoldItems.TryGetValue(pCode, out k);
                    s.Points.Add(new SeriesPoint(new ProductManager().Get(pCode).Product_Name, k));
                }
                s.SeriesPointsSortingKey = SeriesPointKey.Value_1;
                s.SeriesPointsSorting = SortingMode.Descending;
                MostSellItem.Series.Clear();
                MostSellItem.Series.Add(s);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void HomeTaps_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                switch (HomeTaps.SelectedTabPageIndex)
                {
                    case 0: btnDisplay_Click(null, null);
                        break;
                    case 1:
                        ZeroItemGrid.DataSource = ProductManager.GetZeroProductQuantity(0);
                        break;

                    case 2:
                        btnDisplayProductsUponQty_Click(null,null);
                        break;
                    case 3:
                        simpleButton1_Click(null, null);
                        break;
                    case 4:
                        SortedList<int, decimal> PrfoitItems = new SortedList<int, decimal>();
                        PrfoitItems = ProductManager.GetProfit();
                        Series s = new Series("الربحية", ViewType.Bar);
                        Series s1 = new Series("البيع", ViewType.Bar);

                        foreach (int pCode in PrfoitItems.Keys)
                        {
                            decimal k;
                            PrfoitItems.TryGetValue(pCode, out k);
                            Product p = new ProductManager().Get(pCode);
                            SeriesPoint sp = new SeriesPoint(p.Product_Name, k);
                            s.Points.Add(sp);


                            s1.Points.Add(new SeriesPoint(p.Product_Name, p.SalesDetails.Sum(sm => sm.Qty)));

                        }
                        s1.SeriesPointsSortingKey = SeriesPointKey.Value_1;
                        s1.SeriesPointsSorting = SortingMode.Descending;

                        s.SeriesPointsSortingKey = SeriesPointKey.Value_1;
                        s.SeriesPointsSorting = SortingMode.Descending;
                        ProfitChart.Series.Clear();
                        ProfitChart.Series.Add(s);
                        ProfitChart.Series.Add(s1);
                        
                        
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void btnDisplayProductsUponQty_Click(object sender, EventArgs e)
        {
            try
            {
               VariableItemGrid.DataSource = ProductManager.GetZeroProductQuantity(spQty.Value);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = ProductManager.GetNotSoldProductsOnPeriod((DateTime?)dateEdit2.EditValue, (DateTime?)dateEdit1.EditValue);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAccountStatement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Accounts.FRM_AccountStatement().Show();
        }

        private void btnTrialBalance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Accounts.FRM_TrialBalance().Show();
        }

        private void btnBomJournal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new WareHouses.FRM_BOMJournal().Show();
        }

        private void btnVendorBalance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Accounts.FRM_VendorStatement().Show();
        }

        private void btnCustomerBalance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Accounts.FRM_CustomerStatement().Show();
        }

        private void btnOrganization_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Settings.FRM_Organization().Show();
        }

        #region Sales Invoices :

        SalesHeaderManager sales = new SalesHeaderManager();
        private void btnAllSalesInvoices_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HelperClass.FillGrid(sales.GetSalesInvoices(), SalesGrid, SalesView);
        }

        private void btnAllCashInvoices_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HelperClass.FillGrid(sales.GetCashSalesInvoices(), SalesGrid, SalesView);
        }

        private void btnAllAccrualIncoices_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HelperClass.FillGrid(sales.GetAccrualSalesInvoices(), SalesGrid, SalesView);
        }

        private void btnSalesDisplay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HelperClass.FillGrid(sales.GetSpecifiedSalesInvoices(DateTime.Parse(SalesFromDate.EditValue.ToString()), DateTime.Parse(SalesToDate.EditValue.ToString())), SalesGrid, SalesView);
        }

        private void btnSalesInvoicePrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SalesView.ShowPrintPreview();
        } 

        #endregion




    }
}