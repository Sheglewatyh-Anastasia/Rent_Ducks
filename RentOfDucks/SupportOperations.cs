using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentOfDucks.ServiceReference;

namespace RentOfDucks
{
    public class SupportOperations
    {
        public long DucksLeased(int i)
        {
            Ducks d = new Ducks()
            {
                id_duck = i
            };

            Service1Client service = new Service1Client();
            return service.GetDucksLeased(d);
        }

        public decimal Price(DateTime date_expiration_value, DateTime date_beginning_value, decimal red_value, decimal green_value, decimal black_value, string red_price, string green_price, string black_price)
        {
            int count_day = Count_Days(date_expiration_value, date_beginning_value);

            decimal price = (red_value * Convert.ToInt64(red_price) + green_value * Convert.ToInt64(green_price) + black_value * Convert.ToInt64(black_price)) * count_day;

            double disc = 0.85;

            if (Discount(red_value, green_value, black_value))
                price = price * Convert.ToDecimal(disc);

            return price;
        }

        public int Count_Days(DateTime date_expiration_value, DateTime date_beginning_value)
        {
            TimeSpan ts = date_expiration_value - date_beginning_value;

            return ts.Days;
        }

        public bool Discount(decimal red_value, decimal green_value, decimal black_value)
        {
            bool flag = false;
            if (red_value >= 3 || green_value >= 3 || black_value >= 3)
            {
                flag = true;
            }

            return flag;
        }
    }
}
