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
using DALLayer;
using BLLayer;
namespace UILayer.Accounts
{
    public partial class FRM_FinancialDeminsion : DevExpress.XtraEditors.XtraForm
    {
        FinancialDeminsionManager findem = new FinancialDeminsionManager();
        DataTable dt;
        public FRM_FinancialDeminsion()
        {
            InitializeComponent();
            dgvDeminsions.BackgroundColor = this.BackColor;
        }

        private void FRM_FinancialDeminsion_Load(object sender, EventArgs e)
        {
            try
            {
                dt = findem.CreateTable();
                AddRowsToDatatGridView(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void AddRowsToDatatGridView(DataTable dt)
        {
            dgvDeminsions.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                dgvDeminsions.Rows.Add(
                    dr[FinancialDeminsionManager.FinDemDetails.FinDemCode.ToString()],
                    dr[FinancialDeminsionManager.FinDemDetails.FinDemName.ToString()],
                    dr[FinancialDeminsionManager.FinDemDetails.accCode.ToString()],
                    dr[FinancialDeminsionManager.FinDemDetails.accName.ToString()]
                    );
            }
        }
        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("{0} like '%{4}%' OR {1} like '%{4}%' OR {2} like '%{4}%' OR {3} like '%{4}%'",
                    FinDemCode.Name,
                    FinDemName.Name,
                    accCode.Name,
                    accName.Name,
                    txtSearch.Text.Trim().Replace("'", "''"));
                AddRowsToDatatGridView(dv.ToTable());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}