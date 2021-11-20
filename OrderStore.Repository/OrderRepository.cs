using Microsoft.EntityFrameworkCore;
using OrderStore.Domain.Intefaces;
using OrderStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStore.Repository
{
    public class OrderRepository : IGenericRepository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context)
        {
            _context =  context ;
        }

        public Task Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<Order> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Order>> GetOrdersByOrderName(string orderName)
        {
            return await _context.Orders.Where(c => c.OrderDetails.Contains(orderName)).ToListAsync();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
