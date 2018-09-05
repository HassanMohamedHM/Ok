using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace BLLayer
{
    public class EmployeeManager:Repository<Employee>
    {
        public enum EmployeeDetails
        {
            EmployeeCode,
            EmployeeName,
            Address,
            CityName,
            CountryName,
            MaritalStatus,
            JobName,
            ManagerName,
            BirthDate,
            HireDate,
            Image,
            Email,
            LinkedIn,
            FaceBook,
            Mobile1,
            Mobile2,
            FixedSalary,
            MotivateSalary,
            NetSalary
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().Employee_Code + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<Employee> SourceData)
        {
            dt.Rows.Clear();
            foreach (Employee emp in  SourceData)
            {
                dt.Rows.Add(emp.Employee_Code, emp.Employee_Name, emp.Address, emp.City.City_Name, emp.City.Country.Country_Name,
                    emp.MaritalStatus.MaritalStatusName, emp.Job.Job_Name,
                    emp.Manager_Code==null?null:Get(emp.Manager_Code).Employee_Name,
                    emp.BirthDate,
                    emp.HireDate,Image.FromStream(new MemoryStream(emp.Employee_Image)), emp.Email, emp.LinkedIn, emp.FaceBook, emp.Mobile1, emp.Mobile2,
                    emp.FixedSalary, emp.MotivateSalary, emp.NetSalary);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.EmployeeCode.ToString(), ArabicCaption = "كود الموظف", EnglishCaption = "Employee Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.EmployeeName.ToString(), ArabicCaption = "إسم الموظف", EnglishCaption = "Employee Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.Address.ToString(), ArabicCaption = "العنوان", EnglishCaption = "Address", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.CityName.ToString(), ArabicCaption = "إسم المدينة", EnglishCaption = "City Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.CountryName.ToString(), ArabicCaption = "إسم الدولة", EnglishCaption = "Country Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.MaritalStatus.ToString(), ArabicCaption = "الحالة الإجتماعية", EnglishCaption = "Marital Status", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.JobName.ToString(), ArabicCaption = "الوظيفة", EnglishCaption = "Job Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.ManagerName.ToString(), ArabicCaption = "المدير", EnglishCaption = "Manager", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.BirthDate.ToString(), ArabicCaption = "تاريخ الميلاد", EnglishCaption = "Birth Date", DataType = typeof(DateTime) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.HireDate.ToString(), ArabicCaption = "تاريخ التوظيف", EnglishCaption = "Hire Date", DataType = typeof(DateTime) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.Image.ToString(), ArabicCaption = "الصورة", EnglishCaption = "Image", DataType = typeof(Image) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.Email.ToString(), ArabicCaption = "الإيميل", EnglishCaption = "E-Mail", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.LinkedIn.ToString(), ArabicCaption = "لينكد إن", EnglishCaption = "Linked In", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.FaceBook.ToString(), ArabicCaption = "فيسبوك", EnglishCaption = "FaceBook", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.Mobile1.ToString(), ArabicCaption = "محمول1", EnglishCaption = "Mobile1", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.Mobile2.ToString(), ArabicCaption = "محمول2", EnglishCaption = "Mobile2", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.FixedSalary.ToString(), ArabicCaption = "الراتب الثابت", EnglishCaption = "Fixed Salary", DataType = typeof(decimal) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.MotivateSalary.ToString(), ArabicCaption = "الحوافز", EnglishCaption = "Motivations", DataType = typeof(decimal) });
            headers.Add(new TableHeader() { ColumnName = EmployeeDetails.NetSalary.ToString(), ArabicCaption = "الراتب الصافى", EnglishCaption = "Net Salary", DataType = typeof(decimal) });
            return headers;
        }
        public static void FillEmployeeComboBox(ComboBox ComboBoxName)
        {
            FillCombox(ComboBoxName, new EmployeeManager().CreateTable(), EmployeeDetails.EmployeeName.ToString(), EmployeeDetails.EmployeeCode.ToString());
        }
    }
}
