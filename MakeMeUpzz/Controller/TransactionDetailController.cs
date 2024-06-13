using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Factory;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class TransactionDetailController
    {
        public static void InsertTransactionDetail(int transactionId, int makeupId, int quantity)
        {
            TransactionDetailHandler.InsertTransactionDetail(transactionId, makeupId, quantity);
        }

        public static List<TransactionDetail> GetTransactionDetailByTransactionId(int transactionId)
        {
            return TransactionDetailHandler.GetTransactionDetailByTransactionId(transactionId);
        }
    }
}