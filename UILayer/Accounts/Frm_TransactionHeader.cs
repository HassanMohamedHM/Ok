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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Threading;

namespace UILayer.Accounts
{
    public partial class Frm_TransactionHeader : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        TransactionHeaderManager header = new TransactionHeaderManager();
        int UserCode;
        public Frm_TransactionHeader()
        {
            InitializeComponent();
            UserCode = int.Parse(Thread.CurrentPrincipal.Identity.Name);
        }

        public void Frm_TransactionHeader_Load(object sender, EventArgs e)
        {
            try
            {
                CmbGetGeneralJournals_SelectedIndexChanged(null, null);   
                HelperClass.FillSearchLookUpByData(JournalsName,new JournalManager().CreateTable(),
                JournalManager.JournalDetails.JournalName.ToString(),JournalManager.JournalDetails.JournalCode.ToString());
                HeaderView.InitNewRow += Headerview_InitNewRow;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Headerview_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                view.SetRowCellValue(e.RowHandle, HeaderView.Columns[0], header.GetCode());
                view.SetRowCellValue(e.RowHandle, HeaderView.Columns[1], JournalsName.EditValue.ToString());
                view.SetRowCellValue(e.RowHandle, HeaderView.Columns[2], JournalsName.Text.ToString());
                view.SetRowCellValue(e.RowHandle, HeaderView.Columns[3], txtDiscription.Text);
                view.SetRowCellValue(e.RowHandle, HeaderView.Columns[4], false);
                
                
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
                txtDiscription.Text = "";
                JournalsName.EditValue = null;
                HeaderGrid.Height -= panelControl3.Height;
                HeaderGrid.Location = new Point(0, panelControl3.Height);
                panelControl3.Visible = true;
                btnNew.Enabled = false;
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
                if (JournalsName.EditValue == null)
                {
                    MessageBox.Show("You must Choose Journal Name", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                CmbGetGeneralJournals.SelectedIndex = 1;
                HeaderView.AddNewRow();
                #region Add Transaction To DatatBase :
                header.AddHeaderDetails(long.Parse(header.GetCode().ToString()), int.Parse(JournalsName.EditValue.ToString()), DateTime.Now, txtDiscription.Text, UserCode, false);
                #endregion

                btnCancel_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void JournalsName_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            try
            {
                txtDiscription.Text = JournalsName.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        long TransCode;
        bool IsPost;
        private void btnLines_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (HeaderView.FocusedRowHandle >= 0)
                {

                    new FRM_TransactionLines(TransCode, IsPost).Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void HeaderView_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {

                if (e.RowHandle >= 0)
                {
                    TransCode = long.Parse(HeaderView.GetRowCellValue(e.RowHandle, HeaderView.Columns[0]).ToString());
                    IsPost = bool.Parse(HeaderView.GetRowCellValue(e.RowHandle, HeaderView.Columns[4]).ToString());
                    btnDelete.Enabled = btnPost.Enabled = !IsPost;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        TransactionLineManager lines = new TransactionLineManager();
        private void btnPost_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (HeaderView.FocusedRowHandle >= 0)
            {
                PostedTransactionsManager postLines = new PostedTransactionsManager();
                if (lines.GetAll().Where(l => l.transCode == TransCode).Count() > 0)
                {
                    foreach (TransactionLines item in lines.GetAll().Where(l => l.transCode == TransCode))
                    {
                        postLines.AddPostedTransactionDetails(TransCode, DateTime.Now, UserCode, item.accCode,
                           item.DebitAmount == null ? null : item.DebitAmount, item.CreditAmount == null ? null : item.CreditAmount);

                        postLines.AddPostedTransactionDetails((long)item.transCode, DateTime.Now, UserCode, item.offsetAccCode,
                       item.DebitAmount == null ? item.CreditAmount : null, item.CreditAmount == null ? item.DebitAmount : null);
                    }
                    TransactionHeaderManager headerManager = new TransactionHeaderManager();
                    TransactionHeader header = headerManager.Get(TransCode);
                    header.IsPosted = true;
                    headerManager.Update(header);
                    btnPost.Enabled = btnDelete.Enabled = false;
                    HeaderView.SetRowCellValue(HeaderView.FocusedRowHandle, HeaderView.Columns[4], true);
                }
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (HeaderView.FocusedRowHandle >= 0)
                {
                    lines.DeleteMulti(lines.GetAll().Where(l => l.transCode == TransCode));
                    header.Delete(header.Get(TransCode));
                    HeaderView.DeleteRow(HeaderView.FocusedRowHandle);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HeaderGrid.Height += panelControl3.Height;
            HeaderGrid.Location = new Point(0, 0);
            panelControl3.Visible = false;
            btnNew.Enabled = true;

        }

        private void CmbGetGeneralJournals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbGetGeneralJournals.SelectedIndex!=-1)
            {
                chkUserGeneralJournals.Checked = false;
                header.MakeFirstTable(CmbGetGeneralJournals.SelectedIndex);
                HeaderGrid.DataSource = header.DataSet;
                HeaderGrid.DataMember = header.DataMember; 
            }
        }

        private void chkUserGeneralJournals_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkUserGeneralJournals.Checked == true)
            {
                header.MakeFirstTable(3);
                HeaderGrid.DataSource = header.DataSet;
                HeaderGrid.DataMember = header.DataMember;
            }
            else
            {
                CmbGetGeneralJournals_SelectedIndexChanged(null, null);
            }
        }

        private void Frm_TransactionHeader_Activated(object sender, EventArgs e)
        {
            Frm_TransactionHeader_Load(null, null);
        }
    }
}
