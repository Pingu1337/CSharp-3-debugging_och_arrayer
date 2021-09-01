using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexaDatatyperKata
{
    class OnlineOrders
    {
        public int orderNumber;
        public string orderName;
        public string Value;

       
        private static int _nextAvailibleOrderNumber;
        private static string _orderName;
        private static string _Value;

        public OnlineOrders()
        {
            Random rnd = new Random();
            orderNumber = rnd.Next(00000, 99999);
           // orderNumber = _nextAvailibleOrderNumber; // Work in Progress
            orderName = _orderName;
            Value = _Value;
        }
    }
}