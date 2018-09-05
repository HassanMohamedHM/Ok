using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DALLayer
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private DbContext _Context;

        public DbContext Context
        {
            get { return _Context; }
        }
        private DbSet<T> _Set;
        public Repository()
            : this(OK_DBEntities.OK_DBEntitiesInstatnce)
        {
        }
        public Repository(DbContext Context)
        {
           
            _Context = Context;
            
            _Set = Context.Set<T>();
        }
        public virtual IQueryable<T> GetAll()
        {
            return _Set;
        }
        public virtual T Get(params object[] Id)
        {
            return _Set.Find(Id);
        }
        public virtual T Add(T entity)
        {
            _Set.Add(entity);
            return (_Context.SaveChanges() > 0) ? entity : null;
        }
        public virtual bool Update(T entity)
        {
            _Context.Entry<T>(entity).State = EntityState.Modified;
            return _Context.SaveChanges() > 0;
        }
        public virtual bool Delete(T entity)
        {
            _Set.Remove(entity);
            return _Context.SaveChanges() > 0;
        }
        public virtual object GetCode()
        {
            return "1";
        }
        protected abstract  void CreateRows(ref DataTable dt,IQueryable<T> SourceData);
        protected abstract  List<TableHeader> SetHeaders();
        private void CreateColumns(ref DataTable dt)
        {
            dt.Columns.Clear();
            string UICulture = Thread.CurrentThread.CurrentUICulture.IetfLanguageTag;
            foreach (TableHeader header in SetHeaders())
            {
                DataColumn Column = new DataColumn();
                if (UICulture == "ar-EG")
                {
                    Column.Caption = header.ArabicCaption;
                }
                else if (UICulture == "en-US")
                {
                    Column.Caption = header.EnglishCaption;
                }
                Column.ColumnName = header.ColumnName;
                Column.DataType = header.DataType;
                dt.Columns.Add(Column);
            }
        }
        public  DataTable CreateTable()
        {
            DataTable dt = new DataTable();
            CreateColumns(ref dt);
            CreateRows(ref dt, GetAll());
            return dt;
        }
        protected static void FillCombox(ComboBox ComboBoxName, object DataSource, string DisplayMember, string ValueMember)
        {
            ComboBoxName.DataSource = DataSource;
            ComboBoxName.DisplayMember = DisplayMember;
            ComboBoxName.ValueMember = ValueMember;
        }
        
        public bool DeleteMulti(IEnumerable<T> entities)
        {
            _Set.RemoveRange(entities);
            return _Context.SaveChanges() > 0;
        }


        private DataSet _DataSet;
        public const string tablename = "FirstTable";
        private string _DataMember = tablename;

        public DataSet DataSet
        {
            get { return _DataSet; }
            set { _DataSet = value; }
        }
        public string DataMember
        {
            get { return _DataMember; }
            set
            {
                _DataMember = value;
            }
        }

    }
}
