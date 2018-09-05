using System;
using System.Windows.Forms;
using BLLayer;
using DALLayer;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
namespace UILayer.General
{
    public partial class FRM_Job : DevExpress.XtraEditors.XtraForm
    {
        JobManager job = new JobManager();
        private void GetFocusedRowData(int index)
        {
            if (index >= 0 && JobView.RowCount > 0)
            {
                JobView.FocusedRowHandle = index;
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = true;
                txtJobCode.Text = JobView.GetRowCellValue(index, JobManager.JobDetails.JobCode.ToString()).ToString();
                txtJobName.Text = JobView.GetRowCellValue(index, JobManager.JobDetails.JobName.ToString()).ToString();
                txtNote.Text = JobView.GetRowCellValue(index, JobManager.JobDetails.Notes.ToString()).ToString();
            }
        }
        public FRM_Job()
        {
            InitializeComponent();
        }
        private void FRM_Job_Load(object sender, EventArgs e)
        {
            try
            {
                JobGrid.DataSource = job.CreateTable();
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
                txtJobCode.Text = job.GetCode().ToString();
                txtJobName.Text = txtNote.Text = "";
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
                if (txtJobName.Text == "")
                {
                    MessageBox.Show("You Must Enter Job Name");
                    return;
                }
                job.Add(new Job() { Job_Code = int.Parse(txtJobCode.Text), Job_Name = txtJobName.Text, Notes = txtNote.Text });
                btnSave.Enabled = false;
                btnAddNew.Enabled =  btnModify.Enabled = true;
                txtJobCode.Text = txtJobName.Text = txtNote.Text = "";
                MessageBox.Show("New Job Successfully Added");
                FRM_Job_Load(null, null);
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
                if (txtJobName.Text == "")
                {
                    MessageBox.Show("You Must Enter Job Name");
                    return;
                }
                Job jo = job.Get(int.Parse(txtJobCode.Text));
                jo.Job_Name = txtJobName.Text;
                jo.Notes = txtNote.Text;
                job.Update(jo);
                int ModifiedRowIndex = RowFocusedIndex;
                MessageBox.Show("Selected Job Successfully Modified");
                FRM_Job_Load(null, null);
                GetFocusedRowData(ModifiedRowIndex);
                JobView.FocusedRowHandle = ModifiedRowIndex;
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
                Job jo = job.Get(int.Parse(txtJobCode.Text));
                job.Delete(jo);
                MessageBox.Show("Selected Job Successfully Deleted");
                RowFocusedIndex = 0;
                FRM_Job_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private int RowFocusedIndex = 0;
        private void JobView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
            if (RowFocusedIndex < JobView.RowCount - 1)
            {
                GetFocusedRowData(++RowFocusedIndex);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            RowFocusedIndex = JobView.RowCount - 1;
            GetFocusedRowData(RowFocusedIndex);
        }
        private void JobView_RowCountChanged(object sender, EventArgs e)
        {
            GetFocusedRowData(RowFocusedIndex);
        }
        private void JobView_RowClick(object sender, RowClickEventArgs e)
        {
            RowFocusedIndex = e.RowHandle;
            GetFocusedRowData(RowFocusedIndex);
        }
    }
}