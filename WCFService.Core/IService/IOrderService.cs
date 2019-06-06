using System.ServiceModel;
using WCFService.Core;
using WCFService.Core.Entity;

namespace WCFService.Core.IService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IOrderService”。
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        bool Add();
        [OperationContract]
        bool Modify();
        [OperationContract]
        bool Remove();
        [OperationContract]
        OrderEntity Find();
    }
}
