using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using MakeMeUpzz.Controller;
using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class TransactionDetailHandler
    {
        public static void InsertTransactionDetail(int transactionId, int makeupId, int quantity)
        {
            TransactionDetail td = TransactionDetailFactory.CreateTransactionDetail(transactionId, makeupId, quantity);
            TransactionDetailRepository.InsertTransactionDetail(td);
        }

        public static List<TransactionDetail> GetTransactionDetailByTransactionId(int transactionId)
        {
            return TransactionDetailRepository.GetTransactionDetailByTransactionId(transactionId);
        }
    }
}