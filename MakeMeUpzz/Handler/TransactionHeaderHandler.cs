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
    public class TransactionHeaderHandler
    {
        public static int InsertTransactionHeader(int userId, DateTime dt)
        {
            TransactionHeader th = TransactionHeaderFactory.CreateTransactionHeader(userId, dt);
            return TransactionHeaderRepository.InsertTransactionHeader(th);
        }

        public static List<TransactionHeader> GetTransactionHeadersByUserId(int userId)
        {
            return TransactionHeaderRepository.GetTransactionHeadersByUserId(userId);
        }
    }
}