﻿using Microsoft.EntityFrameworkCore;
using OrderStore.Domain.Intefaces;
using OrderStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStore.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context):base(context)
        {
        }
        public async Task<IEnumerable<Order>> GetOrdersByOrderName(string orderName)
        {
            return await _context.Orders.Where(c => c.OrderDetails.Contains(orderName)).ToListAsync();
        }
    }
}
