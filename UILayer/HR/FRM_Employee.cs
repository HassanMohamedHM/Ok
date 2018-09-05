using BLLayer;
using DALLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace UILayer.HR
{
    public partial class FRM_Employee : DevExpress.XtraEditors.XtraForm
    {
        EmployeeManager emp = new EmployeeManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && EmployeeView.RowCount > 0)
            {
                EmployeeView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = true;
                txtEmpCode.Text = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.EmployeeCode.ToString()).ToString();
                txtEmpName.Text = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.EmployeeName.ToString()).ToString();
                txtAddress.Text = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.Address.ToString()).ToString();
                cmbCity.Text = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.CityName.ToString()).ToString();
                cmbCountry.Text = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.CountryName.ToString()).ToString();
                cmbMaritalStatus.Text = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.MaritalStatus.ToString()).ToString();
                cmbJob.Text = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.JobName.ToString()).ToString();
                if (EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.ManagerName.ToString()).ToString() == "")
                {
                    chkManager.Checked = true;
                }
                else
                {
                    chkManager.Checked = false;
                    cmbManager.Text = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.ManagerName.ToString()).ToString();
                }
                BirthDate.EditValue = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.BirthDate.ToString());
                HireDate.EditValue = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.HireDate.ToString());
                EmpImage.Image = (Image)EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.Image.ToString());
                txtEmail.Text = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.Email.ToString()).ToString();
                txtLinkedIn.Text = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.LinkedIn.ToString()).ToString();
                txtFaceBook.Text = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.FaceBook.ToString()).ToString();
                txtMobile1.Text = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.Mobile1.ToString()).ToString();
                txtMobile2.Text = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.Mobile2.ToString()).ToString();
                spFixedSalary.EditValue = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.FixedSalary.ToString());
                spMotivateSalary.EditValue = EmployeeView.GetRowCellValue(index, EmployeeManager.EmployeeDetails.MotivateSalary.ToString());
            }
        }
        public FRM_Employee()
        {
            InitializeComponent();
        }
        private void FRM_Employee_Load(object sender, EventArgs e)
        {
            try
            {
                #region Fill All ComboBox By Data :
                CountryManager.FillCountryComboBox(cmbCountry);
                JobManager.FillJobComboBox(cmbJob);
                MaritalStatusManager.FillMaritalStatusCodeComboBox(cmbMaritalStatus);
                cmbCountry_SelectionChangeCommitted(null, null);
                #endregion

                #region Fill Grid By Data :
                EmployeeGrid.DataSource = emp.CreateTable();
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
        private void chkManager_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cmbManager.Enabled = !chkManager.Checked;
                if (cmbManager.Enabled == true)
                {
                    EmployeeManager.FillEmployeeComboBox(cmbManager);
                }
                else
                {
                    cmbManager.DataSource = null;
                }
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
                foreach (Control control in splitContainerControl1.Panel2.Controls)
                {
                    if (control is TextEdit)
                    {
                        control.Text = "";
                    }
                    else if (control is SpinEdit)
                    {
                        control.Text = "0";
                    }
                    else if (control is PictureEdit)
                    {
                        btnDeleteImage_Click(null, null);
                    }

                }
                txtEmpCode.Text = emp.GetCode().ToString();
                btnSave.Enabled = true;
                btnAddNew.Enabled = btnDelete.Enabled = btnModify.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private bool CheckRequiredData()
        {
            if (txtEmpName.Text == "")
            {
                MessageBox.Show("You Must Enter Employee Name");
                return false;
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("You Must Enter Employee Address");
                return false;
            }
            else if (spFixedSalary.Value == 0)
            {
                MessageBox.Show("You Must Enter Employee Fixed Salary");
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredData() == false)
                {
                    return;
                }
                MemoryStream ms = new MemoryStream();
                EmpImage.Image.Save(ms, EmpImage.Image.RawFormat);
                emp.Add(new Employee()
                {
                    Employee_Code = int.Parse(txtEmpCode.Text),
                    Employee_Name = txtEmpName.Text,
                    Manager_Code = chkManager.Checked == true ? null : (int?)int.Parse(cmbManager.SelectedValue.ToString()),
                    Job_Code = int.Parse(cmbJob.SelectedValue.ToString()),
                    BirthDate = BirthDate.DateTime.Date,
                    HireDate = HireDate.DateTime.Date,
                    Employee_Image = ms.ToArray(),
                    Address = txtAddress.Text,
                    City_Code = int.Parse(cmbCity.SelectedValue.ToString()),
                    Email = txtEmail.Text,
                    LinkedIn = txtLinkedIn.Text,
                    FaceBook = txtFaceBook.Text,
                    Mobile1 = txtMobile1.Text,
                    Mobile2 = txtMobile2.Text,
                    MaritalStatus_Code = int.Parse(cmbMaritalStatus.SelectedValue.ToString()),
                    FixedSalary = spFixedSalary.Value,
                    MotivateSalary = spMotivateSalary.Value,
                    NetSalary = spFixedSalary.Value + spMotivateSalary.Value
                });
                btnSave.Enabled = false;
                btnAddNew.Enabled =  btnModify.Enabled = true;
                MessageBox.Show("New Employee Successfully Added");
                FRM_Employee_Load(null, null);
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
                if (CheckRequiredData() == false)
                {
                    return;
                }
                MemoryStream ms = new MemoryStream();
                EmpImage.Image.Save(ms, EmpImage.Image.RawFormat);
                Employee em = emp.Get(int.Parse(txtEmpCode.Text));
                em.Employee_Name = txtEmpName.Text;
                em.Manager_Code = chkManager.Checked == true ? null : (int?)int.Parse(cmbManager.SelectedValue.ToString());
                em.Job_Code = int.Parse(cmbJob.SelectedValue.ToString());
                em.BirthDate = BirthDate.DateTime.Date;
                em.HireDate = HireDate.DateTime.Date;
                em.Employee_Image = ms.ToArray();
                em.Address = txtAddress.Text;
                em.City_Code = int.Parse(cmbCity.SelectedValue.ToString());
                em.Email = txtEmail.Text;
                em.LinkedIn = txtLinkedIn.Text;
                em.FaceBook = txtFaceBook.Text;
                em.Mobile1 = txtMobile1.Text;
                em.Mobile2 = txtMobile2.Text;
                em.MaritalStatus_Code = int.Parse(cmbMaritalStatus.SelectedValue.ToString());
                em.FixedSalary = spFixedSalary.Value;
                em.MotivateSalary = spMotivateSalary.Value;
                em.NetSalary = spFixedSalary.Value + spMotivateSalary.Value;
                emp.Update(em);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected Employee Successfully Modified");
                FRM_Employee_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                EmployeeView.FocusedRowHandle = ModifiedRowIndex;
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
                Employee em = emp.Get(int.Parse(txtEmpCode.Text));
                emp.Delete(em);
                MessageBox.Show("Selected Employee Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_Employee_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private int RowFocusedIndex = 0;
        private void EmployeeView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
            if (RowFocusedIndex < EmployeeView.RowCount - 1)
            {
                GetFocusedRowData(++RowFocusedIndex);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            RowFocusedIndex = EmployeeView.RowCount - 1;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void EmployeeView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void EmployeeView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            EmpImage.Image = UILayer.Properties.Resources.Employee;
        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Multiselect = false;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        EmpImage.Image = Image.FromFile(ofd.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EmpImage_Click(object sender, EventArgs e)
        {
            btnAddImage_Click(null, null);
        }
    }
}