using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfRentOfDucks
{
    [DataContract]
    public class Ducks
    {
        [DataMember]
        public int id_duck { get; set; }
        [DataMember]
        public string color { get; set; }
        [DataMember]
        public long number_in_stock { get; set; }
        [DataMember]
        public long number_leased { get; set; }
        [DataMember]
        public decimal price { get; set; }
    }
}
