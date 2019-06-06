using System;
using WCFService.Core;
using WCFService.Core.Entity;
using WCFService.Core.IRepository;

namespace WCFService.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public bool Delete()
        {
            return true;
        }

        public OrderEntity Find()
        {
            return new OrderEntity()
            {
                OrderId = Guid.NewGuid().ToString("N"),Price=90000000
            };
        }

        public bool Insert()
        {
            return true;
        }

        public bool Update()
        {
            return true;
        }
    }
}
