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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DALLayer;

namespace UILayer.WareHouses
{
    public partial class FRM_Site : DevExpress.XtraEditors.XtraForm
    {
        SiteManager site = new SiteManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && SiteView.RowCount > 0)
            {
                SiteView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = true;
                txtSiteCode.Text = SiteView.GetRowCellValue(index, SiteManager.SiteDetails.SiteCode.ToString()).ToString();
                txtSiteName.Text = SiteView.GetRowCellValue(index, SiteManager.SiteDetails.SiteName.ToString()).ToString();
                txtSiteAddress.Text = SiteView.GetRowCellValue(index, SiteManager.SiteDetails.SiteAddress.ToString()).ToString();
                cmbCity.Text = SiteView.GetRowCellValue(index, SiteManager.SiteDetails.CityName.ToString()).ToString();
                cmbCountry.Text = SiteView.GetRowCellValue(index, SiteManager.SiteDetails.CountryName.ToString()).ToString();
                cmbType.Text = SiteView.GetRowCellValue(index, SiteManager.SiteDetails.SiteType.ToString()).ToString();
                txtNotes.Text = SiteView.GetRowCellValue(index, SiteManager.SiteDetails.Notes.ToString()).ToString();

            }
        }
        public FRM_Site()
        {
            InitializeComponent();
        }

        private void FRM_Site_Load(object sender, EventArgs e)
        {
            try
            {
                #region Fill All ComboBox By Data :
                CountryManager.FillCountryComboBox(cmbCountry);
                cmbCountry_SelectionChangeCommitted(null, null);
                #endregion

                #region Fill Grid By Data :
                SiteGrid.DataSource = site.CreateTable();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                CityManager.FillCityComboBox(cmbCity, int.Parse(cmbCountry.SelectedValue.ToString()));
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
                txtSiteName.Text = txtSiteAddress.Text = txtNotes.Text = "";
                txtSiteCode.Text = site.GetCode().ToString();
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
                if (txtSiteName.Text == "")
                {
                    MessageBox.Show("You Must Enter Site Name");
                    return;
                }
                else if (txtSiteAddress.Text == "")
                {
                    MessageBox.Show("You Must Enter Site Address");
                    return;
                }
                site.Add(new Site()
                {
                    Site_Code = int.Parse(txtSiteCode.Text),
                    Site_Name = txtSiteName.Text,
                    Address = txtSiteAddress.Text,
                    City_Code = int.Parse(cmbCity.SelectedValue.ToString()),
                    Site_Type = cmbType.Text,
                    Notes = txtNotes.Text

                });
                btnSave.Enabled = false;
                btnAddNew.Enabled =  btnModify.Enabled = true;
                MessageBox.Show("New Site Successfully Added");
                FRM_Site_Load(null, null);
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
                if (txtSiteName.Text == "")
                {
                    MessageBox.Show("You Must Enter Branch Name");
                    return;
                }
                else if (txtSiteAddress.Text == "")
                {
                    MessageBox.Show("You Must Enter Branch Address");
                    return;
                }
                Site st = site.Get(int.Parse(txtSiteCode.Text));
                st.Site_Name = txtSiteName.Text;
                st.Address = txtSiteAddress.Text;
                st.City_Code = int.Parse(cmbCity.SelectedValue.ToString());
                st.Site_Type = cmbType.Text;
                st.Notes = txtNotes.Text;
                site.Update(st);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected Site Successfully Modified");
                FRM_Site_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                SiteView.FocusedRowHandle = ModifiedRowIndex;
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
                Site st = site.Get(int.Parse(txtSiteCode.Text));
                site.Delete(st);
                MessageBox.Show("Selected Site Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_Site_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private int RowFocusedIndex = 0;
        private void SiteView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
            if (RowFocusedIndex < SiteView.RowCount - 1)
            {
                GetFocusedRowData(++RowFocusedIndex);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            RowFocusedIndex = SiteView.RowCount - 1;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void SiteView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }

        private void SiteView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
    }
}