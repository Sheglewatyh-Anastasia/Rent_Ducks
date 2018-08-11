using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfRentOfDucks
{
    [DataContract]
    public class Orders
    {
        [DataMember]
        public int id_order { get; set; }
        [DataMember]
        public DateTime date_beginning { get; set; }
        [DataMember]
        public DateTime date_expiration { get; set; }
        [DataMember]
        public decimal price { get; set; }
        [DataMember]
        public long number_red_duck { get; set; }
        [DataMember]
        public long number_green_duck { get; set; }
        [DataMember]
        public long number_black_duck { get; set; }
    }
}
