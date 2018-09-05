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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using System.Threading;
namespace UILayer.WareHouses
{
    public partial class FRM_BOMJournal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BOMHeaderManager bom = new BOMHeaderManager();
        int Usercode;
        public FRM_BOMJournal()
        {
            InitializeComponent();
            Usercode = int.Parse(Thread.CurrentPrincipal.Identity.Name);
        }

        private void FRM_BOMJournal_Load(object sender, EventArgs e)
        {
            try
            {

                #region Fill Journal Names :
                repJournal.DataSource = new JournalManager().CreateTable();
                repJournal.DisplayMember = repJournal.ValueMember = JournalManager.JournalDetails.JournalCode.ToString();
                #endregion


                #region Initialize Header View to accept Data :
                DataTable dt = bom.CreateTable();
                HeaderGrid.DataSource = dt;
                HeaderGrid.DataMember = dt.TableName;
                #endregion

              
                
                HeaderView_RowClick(null, null);


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
                HeaderView.AddNewRow();
                HeaderGrid.EmbeddedNavigator.Buttons.DoClick(HeaderGrid.EmbeddedNavigator.Buttons.EndEdit);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void HeaderView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                int bomCode = int.Parse(bom.GetCode().ToString());
                HeaderView.SetRowCellValue(e.RowHandle, HeaderView.Columns[0], "BOM" + bomCode);
                HeaderView.SetRowCellValue(e.RowHandle, HeaderView.Columns[4], false);

                bom.Add(new BOMHeader()
                      {
                          BOMCode = bomCode,
                          BOMLookUpCode = "BOM" + bomCode,
                          UserCode=Usercode,
                          IsPosted = false
                      });

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
                if (HeaderView.RowCount > 0 && HeaderView.FocusedRowHandle >= 0)
                {
                    BOMHeader h = bom.Get(int.Parse(HeaderView.GetRowCellValue(HeaderView.FocusedRowHandle, HeaderView.Columns[0]).ToString().Substring(3)));

                    if (IsPosted == false)
                    {
                        bom.Delete(h);
                        HeaderView.DeleteRow(HeaderView.FocusedRowHandle);
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show("You Can't Delete This Bom Journal", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        int RowHandle;
        GridColumn Column;
        private void HeaderView_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {
                if (HeaderView.IsFilterRow(e.RowHandle))
                {
                    e.RepositoryItem = new RepositoryItemTextEdit();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void HeaderView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    if (HeaderView.IsFilterRow(RowHandle))
                    {
                        HeaderView.ShowFilterEditor(Column);
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
        int BOMCode;
        bool IsPosted;
        private void HeaderView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                Column = e.Column;
                RowHandle = e.RowHandle;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void HeaderView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string bomCode = HeaderView.GetRowCellValue(e.RowHandle, HeaderView.Columns[0]).ToString();
            BOMHeader h = bom.Get(int.Parse(bomCode.Substring(3)));
            
            if (e.RowHandle >= 0)
            {
                switch (e.Column.AbsoluteIndex)
                {
                    case 1:
                        h.BOMDate = DateTime.Parse(e.Value.ToString()).Date;
                        break;
                    case 2:
                        h.JournalCode = int.Parse(e.Value.ToString());
                        break;
                    case 3:
                        h.Description = e.Value.ToString();
                        break;
                    default:
                        break;
                }
                bom.Update(h);
            }
        }

        private void btnLines_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (HeaderView.RowCount > 0 && HeaderView.FocusedRowHandle >= 0)
            {
                new FRM_BOMLines(BOMCode, IsPosted).ShowDialog();
            }
        }

        private void btnPost_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (HeaderView.RowCount > 0 && HeaderView.FocusedRowHandle >= 0)
                {
                    BOMHeaderManager.PostBom(BOMCode);
                    btnNew.Enabled = btnDelete.Enabled = btnPost.Enabled = btnValidate.Enabled = false;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void HeaderView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (HeaderView.RowCount > 0)
            {
                BOMCode = int.Parse(HeaderView.GetRowCellValue(HeaderView.FocusedRowHandle, HeaderView.Columns[0]).ToString().Substring(3));
                IsPosted = bool.Parse(HeaderView.GetRowCellValue(HeaderView.FocusedRowHandle, HeaderView.Columns[4]).ToString());

                btnDelete.Enabled = btnPost.Enabled = btnValidate.Enabled = !IsPosted;
                HeaderView.OptionsBehavior.Editable = !IsPosted;
            }
        }

        private void FRM_BOMJournal_Activated(object sender, EventArgs e)
        {
            FRM_BOMJournal_Load(null, null);
        }

     
    }
}