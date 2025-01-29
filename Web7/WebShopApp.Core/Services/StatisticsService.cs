﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebShopApp.Core.Contracts;
using WebShopApp.Infrastructure.Data;

namespace WebShopApp.Core.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly ApplicationDbContext _context; 

        public StatisticsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public int CountClient()
        {
            return _context.Users.Count()-1;
        }


        public int CountOrders()
        {
            return _context.Orders.Count();
        }

        public int CountProduct()
        {
            return _context.Products.Count();
        }

        public decimal SumOrders()
        {
            var suma = _context.Orders.Sum(x => x.Quantity * x.Price - x.Quantity * x.Price * x.Discount / 100);
            return suma;
        }
    }
}
