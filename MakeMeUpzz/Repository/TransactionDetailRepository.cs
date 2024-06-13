using MakeMeUpzz.Model;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class TransactionDetailRepository
    {
        public static void InsertTransactionDetail(TransactionDetail transactionDetail)
        {
            Database1Entities db = new Database1Entities();
            db.TransactionDetails.Add(transactionDetail);
            db.SaveChanges();
        }

        public static List<TransactionDetail> GetTransactionDetails()
        {
            Database1Entities db = new Database1Entities();
            return db.TransactionDetails.ToList();
        }

        public static List<TransactionDetail> GetTransactionDetailByTransactionId(int id)
        {
            Database1Entities db = new Database1Entities();
            return db.TransactionDetails.Where(x => x.TransactionId == id).ToList();
        }
    }
}