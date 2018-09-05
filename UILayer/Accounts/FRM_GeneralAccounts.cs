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
namespace UILayer.Accounts
{
    public partial class FRM_GeneralAccounts : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccountsManager acc = new AccountsManager();
        public FRM_GeneralAccounts()
        {
            InitializeComponent();
        }

        private void FRM_GeneralAccounts_Load(object sender, EventArgs e)
        {
            try
            {
                acc.DisplayChartOfAccount(AccountTree);
                AccountTypeManager type = new AccountTypeManager();
                HelperClass.FillSearchLookUpByData(AccountType, type.CreateTable(), AccountTypeManager.accTypeDetails.typeName.ToString(), AccountTypeManager.accTypeDetails.typeCode.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void GetAccountCode()
        {
            string code = acc.GetAll().Where(a => a.MainAccCode == (string)txtMainAccountCode.Tag).Max(a => a.accCode);
            if (code == null)
            {
                txtAccCode.Text = txtMainAccountCode.Tag + "1";
            }
            else
            {
                txtAccCode.Text = txtMainAccountCode.Tag.ToString() + (int.Parse(code.Remove(0, txtMainAccountCode.Tag.ToString().Length)) + 1);
            }
        }
        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                acc.Add(new DALLayer.Accounts()
                    {
                        accCode = txtAccCode.Text,
                        accName = txtAccName.Text,
                        MainAccCode = txtMainAccountCode.Tag.ToString(),
                        accLevel = int.Parse(txtAccLevel.Text),
                        typeCode = int.Parse(AccountType.EditValue.ToString()),
                        AllowManualEntry = AllowManualEntry.Checked
                    });
                MessageBox.Show("success");
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = btnDelete.Enabled = true;
                TreeNode child = new TreeNode(txtAccCode.Text + "--" + txtAccName.Text);
                child.Tag = txtAccCode.Text;
                node.Nodes.Add(child);
                AccountTree_AfterSelect(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        TreeNode node;
        private void btnAddNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                txtMainAccountCode.Text = txtAccName.Text;
                txtMainAccountCode.Tag = txtAccCode.Text;
                txtAccName.Text = "";
                txtAccLevel.Text = (acc.Get((string)txtMainAccountCode.Tag).accLevel + 1).ToString();
                GetAccountCode();
                btnSave.Enabled = true;
                btnAddNew.Enabled = btnModify.Enabled = btnDelete.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModify_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DALLayer.Accounts ac = acc.Get(txtAccCode.Text);
                ac.accName = txtAccName.Text;
                ac.accLevel = int.Parse(txtAccLevel.Text);
                ac.MainAccCode = txtMainAccountCode.Text == "" ? null : txtMainAccountCode.Tag.ToString();
                ac.typeCode = int.Parse(AccountType.EditValue.ToString());
                ac.AllowManualEntry = AllowManualEntry.Checked;
                acc.Update(ac);
                MessageBox.Show("success");
                node.Text = txtAccCode.Text + "--" + txtAccName.Text;
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
                if (txtAccLevel.Text == "1")
                {
                    MessageBox.Show("You Can't Delete This Account ");
                    return;
                }
                DALLayer.Accounts ac = acc.Get(txtAccCode.Text);
                acc.Delete(ac);
                MessageBox.Show("Success");
                AccountTree.Nodes.Remove(node);
                AccountTree_AfterSelect(null, null);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AccountTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                node = AccountTree.SelectedNode;
                txtAccCode.Text = node.Tag.ToString();
                txtAccName.Text = node.Text.Split('-')[2];
                DALLayer.Accounts ac = acc.Get(txtAccCode.Text);
                txtMainAccountCode.Text = ac.MainAccCode == null ? "" : acc.Get(ac.MainAccCode).accName;
                txtMainAccountCode.Tag = ac.MainAccCode == null ? "" : acc.Get(ac.MainAccCode).accCode;
                AccountType.EditValue = ac.typeCode;
                txtAccLevel.Text = ac.accLevel.ToString();
                AllowManualEntry.Checked = (bool)ac.AllowManualEntry;
                btnSave.Enabled = false;
                btnAddNew.Enabled = btnModify.Enabled = btnDelete.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}