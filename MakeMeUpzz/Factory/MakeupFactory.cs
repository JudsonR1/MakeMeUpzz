using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class MakeupFactory
    {
        public static Makeup CreateMakeup(string name, int price)
        {
            Makeup makeup = new Makeup
            {
                MakeupName = name,
                MakeupPrice = price
            };

            return makeup;
        }
    }
}