using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IAmazonRepository
    {
        public Task<List<AmazonOrders>> GetAllOrders();
        public Task<AmazonOrders> GetOrderById(int Id);
        public Task InsertOrder(AmazonOrders amazonOrders);
        public Task UpdateOrder(AmazonOrders amazonOrders);
        public Task DeleteOrderById(int Id);
    }
}
