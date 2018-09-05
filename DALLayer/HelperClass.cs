using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;

namespace DALLayer
{
    public class HelperClass
    {
        public static void FillSearchLookUpByData(SearchLookUpEdit ctr, object DataSource, string DisplayMember, string ValueMember)
        {
            ctr.Properties.DataSource = DataSource;
            ctr.Properties.DisplayMember = DisplayMember;
            ctr.Properties.ValueMember = ValueMember;
        }


        public static void FillGrid(DataTable Source,GridControl grid,GridView view)
        {
            grid.DataSource = null;
            grid.DataSource = Source;
            grid.DataMember = Source.TableName;
        }
    }
}


