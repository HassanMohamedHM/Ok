using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using System.Data;
using System.Windows.Forms;
namespace BLLayer
{
   public class PermissionManager:Repository<Permission>
   {
       public enum PermissionDetails
       {
           PermissionCode,
           PermissionName
       }
       public override object GetCode()
       {
           if (GetAll().Count() > 0)
           {
               return (GetAll().ToList().Last().Permission_Code + 1).ToString();
           }
           return "1";
       }
       protected sealed override void CreateRows(ref DataTable dt, IQueryable<Permission> SourceData)
       {
           dt.Rows.Clear();
           foreach (Permission permission in SourceData)
           {
               dt.Rows.Add(permission.Permission_Code, permission.Permission_Name);
           }
       }
       protected sealed override List<TableHeader> SetHeaders()
       {
           List<TableHeader> headers = new List<TableHeader>();
           headers.Add(new TableHeader() { ColumnName = PermissionDetails.PermissionCode.ToString(), ArabicCaption = "كود الصلاحية", EnglishCaption = "Permission Code", DataType = typeof(int) });
           headers.Add(new TableHeader() { ColumnName = PermissionDetails.PermissionName.ToString(), ArabicCaption = "إسم الصلاحية", EnglishCaption = "Permission Name", DataType = typeof(string) });
           return headers;
       }
       public static void FillPermissionComboBox(ComboBox ComboBoxName)
       {
           FillCombox(ComboBoxName, new PermissionManager().CreateTable(), PermissionDetails.PermissionName.ToString(), PermissionDetails.PermissionCode.ToString());
       }
    }
}
