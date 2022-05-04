using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IOrderBusiness
    {
        
            public Task<List<AmazonOrders>> GetAllAmazonOrdersOrders();
            public Task<AmazonOrders> GetAmazonOrderById(int Id);
            public Task InsertAmazonOrder(AmazonOrders amazonOrders);
            public Task UpdateAmazonOrder(AmazonOrders amazonOrders);
            public Task DeleteAmazonOrder(int Id);
        
    }
}
