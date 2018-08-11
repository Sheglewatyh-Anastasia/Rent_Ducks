using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfRentOfDucks
{
    [DataContract]
    public class OrderDuck
    {
        [DataMember]
        public int id_order_duck { get; set; }
        [DataMember]
        public long number_duck { get; set; }
        [DataMember]
        public int id_order { get; set; }
        [DataMember]
        public int id_duck { get; set; }
    }
}
