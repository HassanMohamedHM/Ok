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
    public class UserManager : Repository<User>
    {
        public enum UserDetails
        {
            UserCode,
            UserName,
            Password,
            Role,
            Employee
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().User_Code + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<User> SourceData)
        {
            dt.Rows.Clear();
            foreach (User User in SourceData)
            {
                dt.Rows.Add(User.User_Code,User.User_Name,
                    User.Password, User.UserRoles.Where(r => r.User_Code == User.User_Code).FirstOrDefault().Role.Role_Name,
                    User.Employee.Employee_Name);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = UserDetails.UserCode.ToString(), ArabicCaption = "كود المستخدم", EnglishCaption = "User Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = UserDetails.UserName.ToString(), ArabicCaption = "إسم المستخدم", EnglishCaption = "User Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = UserDetails.Password.ToString(), ArabicCaption = "الباسورد", EnglishCaption = "Password", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = UserDetails.Role.ToString(), ArabicCaption = "الدور", EnglishCaption = "Role", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = UserDetails.Employee.ToString(), ArabicCaption = "الموظف", EnglishCaption = "Employee", DataType = typeof(string) });
            return headers;
        }
        public static void FillUserComboBox(ComboBox ComboBoxName)
        {
            FillCombox(ComboBoxName, new UserManager().CreateTable(), UserDetails.UserName.ToString(), UserDetails.UserCode.ToString());
        }
    }
}
