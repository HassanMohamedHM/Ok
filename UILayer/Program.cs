using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Threading;
using System.Security.Principal;
using System.Security.Permissions;
using BLLayer;
using System.Linq;
namespace UILayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            //DialogResult result = DialogResult.None;
            //using (Users.FRM_Login loginform=new Users.FRM_Login())
            //{
            //    result = loginform.ShowDialog();
            //}
            //if (result == DialogResult.OK)
            //{
            //    PrincipalPermission permission = new PrincipalPermission(PermissionState.Unrestricted);
            //    permission.Demand();
            //    Application.Run(new HomePage());
            //}

            //Application.Run(new Licences.FRM_Licence());
            Application.Run(new Users.FRM_Login());
            //Application.Run(new Invoices.FRM_InvoiceSales());
        }
    }
}
