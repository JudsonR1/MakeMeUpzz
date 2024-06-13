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
    public class TransactionHeaderController
    {
        public static int InsertTransactionHeader(int userId, DateTime dt)
        {
            return TransactionHeaderHandler.InsertTransactionHeader(userId, dt);
        }

        public static List<TransactionHeader> GetTransactionHeadersByUserId(int userId)
        {
            return TransactionHeaderHandler.GetTransactionHeadersByUserId(userId);
        }
    }
}