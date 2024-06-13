using MakeMeUpzz.Model;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail CreateTransactionDetail(int transactionId, int makeupId, int quantity)
        {
            TransactionDetail transactionDetail = new TransactionDetail
            {
                TransactionId = transactionId,
                MakeupId = makeupId,
                Quantity = quantity
            };

            return transactionDetail;
        }
    }
}