using Order.Core;
using Order.Core.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService.Core;
using WCFService.Core.IRepository;

namespace Order.Application.Service
{

    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public bool Add()
        {
            return _orderRepository.Insert();
        }

        public OrderEntity Find()
        {
            return _orderRepository.Find();
        }

        public bool Modify()
        {
            return _orderRepository.Update();
        }

        public bool Remove()
        {
            return _orderRepository.Delete();
        }
    }
}
