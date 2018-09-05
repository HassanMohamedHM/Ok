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
using System.IO;
namespace UILayer.Settings
{
   
    public partial class FRM_Organization : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        OrganizationManager orgManager = new OrganizationManager();
        public FRM_Organization()
        {
            InitializeComponent();
        }
        Organization org;
        private void FRM_Organization_Load(object sender, EventArgs e)
        {
            try
            {
                HelperClass.FillSearchLookUpByData(SearchCity, new CityManager().CreateTable(),
                    CityManager.CityDetails.CityName.ToString(),
                    CityManager.CityDetails.CityCode.ToString());




                org = orgManager.Get(1);
                txtName.Text = org.OrganizationName;
                txtAddress.Text = org.Address;
                SearchCity.EditValue = org.City_Code;
                txtPhone.Text = org.Phone;
                txtMobile.Text = org.Mobile;
                txtFax.Text = org.Fax;
                txtWebsite.Text = org.Website;
                txtEmail.Text = org.EMail;

                picLogo.Image = org.Logo == null ? null : Image.FromStream(new MemoryStream(org.Logo));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (txtEmail.Text != "")
                {
                    MessageBox.Show("You Must Enter Name", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                org.OrganizationName = txtName.Text;
                org.Address = txtAddress.Text;
                org.City_Code = int.Parse(SearchCity.EditValue.ToString());
                txtPhone.Text = org.Phone;
                org.Mobile = txtMobile.Text;
                org.Fax = txtFax.Text;
                org.Website = txtWebsite.Text;
                org.EMail = txtEmail.Text;

                if (picLogo.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picLogo.Image.Save(ms, picLogo.Image.RawFormat);
                        org.Logo = ms.ToArray();
                    }
                }
                else
                {
                    org.Logo = null;
                }
                orgManager.Update(org);
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnChooseImgae_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd=new OpenFileDialog())
                {
                    ofd.Multiselect = false;
                    if (ofd.ShowDialog()==DialogResult.OK)
                    {
                        picLogo.Image = Image.FromFile(ofd.FileName);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            picLogo.Image = null;
        }
    }
}