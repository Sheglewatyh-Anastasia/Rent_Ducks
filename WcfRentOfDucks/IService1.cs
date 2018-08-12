using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfRentOfDucks
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        int InsertOrder(Orders o);

        [OperationContract]
        int UpdateOrder(Orders o);

        [OperationContract]
        int DeleteOrder(Orders o);

        [OperationContract]
        int UpdateDuck(Ducks d);

        [OperationContract]
        int InsertOrderDuck(OrderDuck od);

        [OperationContract]
        int DeleteOrderDuck(OrderDuck od);

        [OperationContract]
        List<Orders> GetAllOrders();

        [OperationContract]
        List<Ducks> GetAllDucks();

        [OperationContract]
        long GetDucksInStock(Ducks d);

        [OperationContract]
        decimal GetDucksPrice(Ducks d);

        [OperationContract]
        long GetDucksLeased(Ducks d);

        [OperationContract]
        int MaxOrderId();

        [OperationContract]
        long GetNumberDuck(Orders o, string s);

        [OperationContract]
        DateTime GetDateOrder(Orders o, string s);

        // TODO: Добавьте здесь операции служб
    }

    // Используйте контракт данных, как показано на следующем примере, чтобы добавить сложные типы к сервисным операциям.
    // В проект можно добавлять XSD-файлы. После построения проекта вы можете напрямую использовать в нем определенные типы данных с пространством имен "WcfRentOfDucks.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
