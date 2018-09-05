using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace BLLayer
{
    public class AccountsManager : Repository<Accounts>
    {
        public enum AccountFilterationTypes
        {
            Ledger,
            Customer,//1
            Vendor,//2
            Bank

        }
        public enum AccountDetails
        {
            accCode,
            accName,
            accLevel,
            MainAccCode,
            MainAccName
        } 

        protected sealed override void CreateRows(ref System.Data.DataTable dt, IQueryable<Accounts> SourceData)
        {
            dt.Rows.Clear();
            foreach (Accounts acc in SourceData)
            {
                dt.Rows.Add(
                    acc.accCode,
                    acc.accName,
                    acc.accLevel,
                    acc.MainAccCode == null ? "" : Get(acc.MainAccCode).accCode,
                    acc.MainAccCode == null ? "" : Get(acc.MainAccCode).accName
                    );
            }
        }

        protected sealed override List<TableHeader> SetHeaders()
        {
           
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = AccountDetails.accCode.ToString(), ArabicCaption = "كود الحساب", EnglishCaption = "Account Code", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = AccountDetails.accName.ToString(), ArabicCaption = "إسم الحساب", EnglishCaption = "Account Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = AccountDetails.accLevel.ToString(), ArabicCaption = "مستوى الحساب", EnglishCaption = "Account Level", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = AccountDetails.MainAccCode.ToString(), ArabicCaption = "كود الحساب الأب", EnglishCaption = "Main Account Code", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = AccountDetails.MainAccName.ToString(), ArabicCaption = "إسم الحساب الأب", EnglishCaption = "Main Account Name", DataType = typeof(string) });
            return headers;
        }

        public void DisplayChartOfAccount(TreeView tree)
        {
            tree.Nodes.Clear();
            foreach (Accounts acc in GetAll().Where(ac => ac.MainAccCode == null))
            {
                TreeNode node = new TreeNode(acc.accCode + "--" + acc.accName);
                node.Tag = acc.accCode;
                node.ForeColor = Color.Red;
                tree.Nodes.Add(node);
                DisplaySubAccounts(node);
            }
        }

        private void DisplaySubAccounts(TreeNode node)
        {
            foreach (Accounts acc in GetAll().Where(ac => ac.MainAccCode == (string)node.Tag))
            {

                TreeNode child = new TreeNode(acc.accCode + "--" + acc.accName);
                child.Tag = acc.accCode;
                node.Nodes.Add(child);
                DisplaySubAccounts(child);
            }
        }

        public static DataTable GetAccountStatement(string AccountCode, DateTime? DateFrom, DateTime? DateTo, out decimal AccountDebit, out decimal AccountCredit)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("v1", typeof(string));
            dt.Columns.Add("v2", typeof(string));
            dt.Columns.Add("v3", typeof(string));
            dt.Columns.Add("v4", typeof(string));
            PostedTransactionsManager manager = new PostedTransactionsManager();
            List<PostedTransactions> PostedTransactionsList = new List<PostedTransactions>();

            if (!string.IsNullOrEmpty(AccountCode))
            {
                foreach (PostedTransactions item in manager.GetAll())
                {
                    string accCode = item.accCode.Split('-')[0];
                    if (accCode==AccountCode)
                    {
                        PostedTransactionsList.Add(item);
                    }
                }
            }
            if (DateFrom != null && DateTo != null)
            {
                PostedTransactionsList = PostedTransactionsList.Where(p => (p.PostedDate.Value >= DateFrom.Value && p.PostedDate.Value <= DateTo.Value)).ToList();
            }
            foreach (PostedTransactions item in PostedTransactionsList)
            {
                dt.Rows.Add(item.PostedDate.Value.ToShortDateString(), item.PostedTime, item.DebitAmount, item.CreditAmount);
            }
            AccountDebit = PostedTransactionsList.Sum(p => p.DebitAmount) == null ? 0 : (decimal)PostedTransactionsList.Sum(p => p.DebitAmount);
            AccountCredit = PostedTransactionsList.Sum(p => p.CreditAmount) == null ? 0 : (decimal)PostedTransactionsList.Sum(p => p.CreditAmount);
            return dt;
        }


        public DataTable DisplayTrialBalance(DateTime? DateFrom, DateTime? DateTo)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("v1", typeof(string));//accCode
            dt.Columns.Add("v2", typeof(string));//accName
            dt.Columns.Add("v3", typeof(string));//Begining Debit Balance
            dt.Columns.Add("v4", typeof(string));//Begining credit Balance
            dt.Columns.Add("v5", typeof(string));//Debit Balance
            dt.Columns.Add("v6", typeof(string));//Credit Balance
            dt.Columns.Add("v7", typeof(string));//Closing Debit Balance
            dt.Columns.Add("v8", typeof(string));//Closing credit Balance


            List<PostedTransactions> listBalance = new List<PostedTransactions>();
            List<PostedTransactions> listBegin = new List<PostedTransactions>();


            PostedTransactionsManager posted = new PostedTransactionsManager();

            IQueryable<PostedTransactions> BalanceTransactions = DateFrom == null ? posted.GetAll() :
                posted.GetAll().Where(p => p.PostedDate >= DateFrom && p.PostedDate <= DateTo);

            IQueryable<PostedTransactions> BeginingTransactions = DateFrom == null ? posted.GetAll() :
               posted.GetAll().Where(p => p.PostedDate < DateFrom);


            foreach (Accounts acc in new AccountsManager().GetAll())
            {
                listBalance.Clear();
                listBegin.Clear();
                foreach (PostedTransactions item in BalanceTransactions)
                {
                    if (acc.accCode == item.accCode.Split('-')[0])
                    {
                        listBalance.Add(item);
                    }
                }

                if (DateFrom!=null)
                {
                    foreach (PostedTransactions item in BeginingTransactions)
                    {
                        if (acc.accCode == item.accCode.Split('-')[0])
                        {
                            listBegin.Add(item);
                        }
                    }
                }
                else
                {
                    if (BeginingTransactions.FirstOrDefault(b => b.TransactionHeader.JournalCode == 5) != null)
                    {
                        listBegin.Add(BeginingTransactions.FirstOrDefault(b => b.TransactionHeader.JournalCode == 5));
                    }
                }


                if (listBalance.Count > 0)
                {
                    decimal AccountDebit = listBalance.Sum(p => p.DebitAmount) == null ? 0 : (decimal)listBalance.Sum(p => p.DebitAmount);
                    decimal AccountCredit = listBalance.Sum(p => p.CreditAmount) == null ? 0 : (decimal)listBalance.Sum(p => p.CreditAmount);

                    decimal BeginAccountDebit = listBegin.Count > 0 ? listBegin.Sum(p => p.DebitAmount) == null ? 0 : (decimal)listBegin.Sum(p => p.DebitAmount) : 0;
                    decimal BeginAccountCredit = listBegin.Count > 0 ? listBegin.Sum(p => p.CreditAmount) == null ? 0 : (decimal)listBegin.Sum(p => p.CreditAmount) : 0;

                    dt.Rows.Add(acc.accCode, acc.accName,
                        BeginAccountDebit > BeginAccountCredit ? (BeginAccountDebit - BeginAccountCredit).ToString() : "-",
                        BeginAccountCredit > BeginAccountDebit ? (BeginAccountCredit - BeginAccountDebit).ToString() : "-",
                        AccountDebit == 0 ? "-" : AccountDebit.ToString(),
                        AccountCredit == 0 ? "-" : AccountCredit.ToString(),
                        AccountDebit > AccountCredit ? (AccountDebit - AccountCredit).ToString() : "-",
                        AccountCredit > AccountDebit ? (AccountCredit - AccountDebit).ToString() : "-");
                }
            }
            return dt;

        }

    }
}
