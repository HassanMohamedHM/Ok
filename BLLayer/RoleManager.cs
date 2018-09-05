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
   public class RoleManager:Repository<Role>
    {
        public enum RoleDetails
        {
            RoleCode,
            RoleName
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().Role_Code + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<Role> SourceData)
        {
            dt.Rows.Clear();
            foreach (Role Role in SourceData)
            {
                dt.Rows.Add(Role.Role_Code, Role.Role_Name);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = RoleDetails.RoleCode.ToString(), ArabicCaption = "الكود ", EnglishCaption = "Role Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = RoleDetails.RoleName.ToString(), ArabicCaption = "الدور", EnglishCaption = "Role Name", DataType = typeof(string) });
            return headers;
        }
        public static void FillRoleComboBox(ComboBox ComboBoxName)
        {
            FillCombox(ComboBoxName, new RoleManager().CreateTable(), RoleDetails.RoleName.ToString(), RoleDetails.RoleCode.ToString());
        }
    }
}
