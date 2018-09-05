using System;
using System.Windows.Forms;
using BLLayer;
using System.Data.Entity;
using DALLayer;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace UILayer.General
{
    public partial class FRM_City : DevExpress.XtraEditors.XtraForm
    {
        CityManager city = new CityManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && CityView.RowCount > 0)
            {
                CityView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled =  btnModify.Enabled = true;
                txtCityCode.Text = CityView.GetRowCellValue(index, CityManager.CityDetails.CityCode.ToString()).ToString();
                txtCityName.Text = CityView.GetRowCellValue(index, CityManager.CityDetails.CityName.ToString()).ToString();
                cmbCountry.Text = CityView.GetRowCellValue(index, CityManager.CityDetails.CountryName.ToString()).ToString();
            }
        }
        public FRM_City()
        {
            InitializeComponent();
        }
        private void FRM_City_Load(object sender, EventArgs e)
        {
            try
            {
                CountryManager.FillCountryComboBox(cmbCountry);
                CityGrid.DataSource = city.CreateTable();
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
                txtCityCode.Text = city.GetCode().ToString();
                txtCityName.Text = "";
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
                if (txtCityName.Text == "")
                {
                    MessageBox.Show("You Must Enter City Name");
                    return;
                }
                city.Add(new City() { City_Code = int.Parse(txtCityCode.Text), City_Name = txtCityName.Text, Country_Code = int.Parse(cmbCountry.SelectedValue.ToString()) });
                btnSave.Enabled = false;
                btnAddNew.Enabled =  btnModify.Enabled = true;
                txtCityCode.Text = txtCityName.Text = "";
                MessageBox.Show("New City Successfully Added");
                FRM_City_Load(null, null);
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
                if (txtCityName.Text == "")
                {
                    MessageBox.Show("You Must Enter City Name");
                    return;
                }
                City co = city.Get(int.Parse(txtCityCode.Text));
                co.City_Name = txtCityName.Text;
                co.Country_Code = int.Parse(cmbCountry.SelectedValue.ToString());
                city.Update(co);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected City Successfully Modified");
                FRM_City_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                CityView.FocusedRowHandle = ModifiedRowIndex;
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
                City co = city.Get(int.Parse(txtCityCode.Text));
                city.Delete(co);
                MessageBox.Show("Selected City Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_City_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private int RowFocusedIndex = 0;
        private void CityView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
            if (RowFocusedIndex < CityView.RowCount - 1)
            {
                GetFocusedRowData(++RowFocusedIndex);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            RowFocusedIndex = CityView.RowCount - 1;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void CityView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void CityView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
    }
}