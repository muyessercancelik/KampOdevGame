using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdevGame
{
    class OrderManager : IOrderService
    {
        public void SatisYap(Products products)
        {
            Console.WriteLine("Satın alma işlemi gerçekleşti.");
        }
    }
}
