using MakeMeUpzz.Model;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class TransactionHeaderRepository
    {
        public static int InsertTransactionHeader(TransactionHeader transactionHeader)
        {
            Database1Entities db = new Database1Entities();
            db.TransactionHeaders.Add(transactionHeader);
            db.SaveChanges();

            return transactionHeader.TransactionId;
        }

        public static List<TransactionHeader> GetTransactionHeadersByUserId(int userId)
        {
            Database1Entities db = new Database1Entities();
            return db.TransactionHeaders.Where(x => x.UserId == userId).ToList();
        }
    }
}