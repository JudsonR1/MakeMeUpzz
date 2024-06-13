using MakeMeUpzz.Model;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader CreateTransactionHeader(int userId, DateTime date)
        {
            TransactionHeader transactionHeader = new TransactionHeader
            {
                UserId = userId,
                TransactionDate = date
            };

            return transactionHeader;
        }
    }
}