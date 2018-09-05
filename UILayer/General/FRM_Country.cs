using System;
using System.Windows.Forms;
using BLLayer;
using DALLayer;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
namespace UILayer.General
{
    public partial class FRM_Country : DevExpress.XtraEditors.XtraForm
    {
        CountryManager country = new CountryManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && CountryView.RowCount > 0)
            {
                CountryView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = true;
                txtCountryCode.Text = CountryView.GetRowCellValue(index, CountryManager.CountryDetails.CountryCode.ToString()).ToString();
                txtCountryName.Text = CountryView.GetRowCellValue(index, CountryManager.CountryDetails.CountryName.ToString()).ToString();
            }
        }
        public FRM_Country()
        {
            InitializeComponent();
        }
        private void FRM_Country_Load(object sender, EventArgs e)
        {
            try
            {
                CountryGrid.DataSource = country.CreateTable();
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
                txtCountryCode.Text = country.GetCode().ToString();
                txtCountryName.Text = "";
                btnSave.Enabled = true;
                btnAddNew.Enabled = btnModify.Enabled = false;
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
                if (txtCountryName.Text == "")
                {
                    MessageBox.Show("You Must Enter Country Name");
                    return;
                }
                country.Add(new Country() { Country_Code = int.Parse(txtCountryCode.Text), Country_Name = txtCountryName.Text });
                btnSave.Enabled = false;
                btnAddNew.Enabled =  btnModify.Enabled = true;
                txtCountryCode.Text = txtCountryName.Text = "";
                MessageBox.Show("New Country Successfully Added");
                FRM_Country_Load(null, null);
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
                if (txtCountryName.Text == "")
                {
                    MessageBox.Show("You Must Enter Country Name");
                    return;
                }
                Country co = country.Get(int.Parse(txtCountryCode.Text));
                co.Country_Name = txtCountryName.Text;
                country.Update(co);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected Country Successfully Modified");
                FRM_Country_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                CountryView.FocusedRowHandle = ModifiedRowIndex;
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
                Country co = country.Get(int.Parse(txtCountryCode.Text));
                country.Delete(co);
                MessageBox.Show("Selected Country Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_Country_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private int RowFocusedIndex = 0;
        private void CountryView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
            if (RowFocusedIndex < CountryView.RowCount - 1)
            {
                GetFocusedRowData(++RowFocusedIndex);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            RowFocusedIndex = CountryView.RowCount - 1;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void CountryView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void CountryView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
    }
}