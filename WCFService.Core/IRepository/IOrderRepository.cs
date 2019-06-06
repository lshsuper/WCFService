using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFService.Core.Entity;

namespace WCFService.Core.IRepository
{
    public interface IOrderRepository
    {
        bool Insert();
        bool Update();
        bool Delete();
        OrderEntity Find();
    }
}
