using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLayer
{
    public interface IInvoiceManager
    {
         void AddInvoiceHeader(string InvoiceCode,DateTime InvoiceDateTime,decimal Total,decimal Paied,decimal Reminder,
             bool InvoiceType,int WareHouseCode,int VendorCode,bool PaymentSystem,int UserCode);
          void AddInvoiceDetails(string InvoiceCode,int ProductCode,int UnitCode,double UnitPrice,decimal Qty,decimal Total);
    }
}
