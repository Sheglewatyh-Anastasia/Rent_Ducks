using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfRentOfDucks
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        public Service1()
        {
            ConnectToDatabase();
        }

        SqlConnection connect;
        SqlCommand comm;

        SqlConnectionStringBuilder connectStringBuilder;

        void ConnectToDatabase()
        {
            connectStringBuilder = new SqlConnectionStringBuilder();
            connectStringBuilder.DataSource = "MYCOMP\\SQLEXPRESS";
            connectStringBuilder.InitialCatalog = "RentDucks";
            connectStringBuilder.Encrypt = true;
            connectStringBuilder.TrustServerCertificate = true;
            connectStringBuilder.ConnectTimeout = 30;
            connectStringBuilder.AsynchronousProcessing = true;
            connectStringBuilder.MultipleActiveResultSets = true;
            connectStringBuilder.IntegratedSecurity = true;

            connect = new SqlConnection(connectStringBuilder.ToString());
            comm = connect.CreateCommand();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int InsertOrder(Orders o)
        {
            try
            {
                comm.CommandText = "INSERT INTO Orders VALUES(@date_beginning, @date_expiration, @price, @number_red_duck, @number_green_duck, @number_black_duck)";
                comm.Parameters.AddWithValue("date_beginning", o.date_beginning);
                comm.Parameters.AddWithValue("date_expiration", o.date_expiration);
                comm.Parameters.AddWithValue("price", o.price);
                comm.Parameters.AddWithValue("number_red_duck", o.number_red_duck);
                comm.Parameters.AddWithValue("number_green_duck", o.number_green_duck);
                comm.Parameters.AddWithValue("number_black_duck", o.number_black_duck);

                comm.CommandType = CommandType.Text;
                connect.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public int UpdateOrder(Orders o)
        {
            try
            {
                comm.CommandText = "UPDATE Orders SET date_beginning=@date_beginning, date_expiration=@date_expiration, price=@price, number_red_duck=@number_red_duck, number_green_duck=@number_green_duck, number_black_duck=@number_black_duck WHERE id_order=@id_order";
                comm.Parameters.AddWithValue("id_order", o.id_order);
                comm.Parameters.AddWithValue("date_beginning", o.date_beginning);
                comm.Parameters.AddWithValue("date_expiration", o.date_expiration);
                comm.Parameters.AddWithValue("price", o.price);
                comm.Parameters.AddWithValue("number_red_duck", o.number_red_duck);
                comm.Parameters.AddWithValue("number_green_duck", o.number_green_duck);
                comm.Parameters.AddWithValue("number_black_duck", o.number_black_duck);

                comm.CommandType = CommandType.Text;
                connect.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public int DeleteOrder(Orders o)
        {
            try
            {
                comm.CommandText = "DELETE FROM Orders WHERE id_order=@id_order";
                comm.Parameters.AddWithValue("id_order", o.id_order);

                comm.CommandType = CommandType.Text;
                connect.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public List<Orders> GetAllOrders()
        {
            List<Orders> orders_list = new List<Orders>();
            try
            {
                comm.CommandText = "SELECT * FROM Orders";
                comm.CommandType = CommandType.Text;

                connect.Open();

                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders()
                    {
                        id_order = Convert.ToInt32(reader[0]),
                        date_beginning = Convert.ToDateTime(reader[1]),
                        date_expiration = Convert.ToDateTime(reader[2]),
                        price = Convert.ToDecimal(reader[3]),
                        number_red_duck = Convert.ToInt64(reader[4]),
                        number_green_duck = Convert.ToInt64(reader[5]),
                        number_black_duck = Convert.ToInt64(reader[6])
                    };
                    orders_list.Add(orders);
                }
                return orders_list;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public int MaxOrderId()
        {
            int result = 0;
            try
            {
                comm.CommandText = "SELECT MAX(id_order) FROM Orders";
                comm.CommandType = CommandType.Text;

                connect.Open();

                result = (int)comm.ExecuteScalar();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public int UpdateDuck(Ducks d)
        {
            try
            {
                comm.CommandText = "UPDATE Duck SET number_in_stock=@number_in_stock, number_leased=@number_leased WHERE id_duck=@id_duck";
                comm.Parameters.AddWithValue("id_duck", d.id_duck);
                comm.Parameters.AddWithValue("number_in_stock", d.number_in_stock);
                comm.Parameters.AddWithValue("number_leased", d.number_leased);

                comm.CommandType = CommandType.Text;
                connect.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public List<Ducks> GetAllDucks()
        {
            List<Ducks> ducks_list = new List<Ducks>();
            try
            {
                comm.CommandText = "SELECT * FROM Duck";
                comm.CommandType = CommandType.Text;

                connect.Open();

                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    Ducks ducks = new Ducks()
                    {
                        id_duck = Convert.ToInt32(reader[0]),
                        color = reader[1].ToString(),
                        number_in_stock = Convert.ToInt64(reader[2]),
                        number_leased = Convert.ToInt64(reader[3]),
                        price = Convert.ToDecimal(reader[4])
                    };
                    ducks_list.Add(ducks);
                }
                return ducks_list;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public long GetDucksInStock(Ducks d)
        {
            long result = 0;
            try
            {
                comm.CommandText = "SELECT number_in_stock FROM Duck WHERE id_duck=@id_duck";
                comm.Parameters.AddWithValue("id_duck", d.id_duck);
                comm.CommandType = CommandType.Text;

                connect.Open();

                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    result = Convert.ToInt64(reader[0]);
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public decimal GetDucksPrice(Ducks d)
        {
            long result = 0;
            try
            {
                comm.CommandText = "SELECT price FROM Duck WHERE id_duck=@id_duck";
                comm.Parameters.AddWithValue("id_duck", d.id_duck);
                comm.CommandType = CommandType.Text;

                connect.Open();

                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    result = Convert.ToInt64(reader[0]);
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public long GetDucksLeased(Ducks d)
        {
            long result = 0;
            try
            {
                comm.CommandText = "SELECT number_leased FROM Duck WHERE id_duck=@id_duck";
                comm.Parameters.AddWithValue("id_duck", d.id_duck);
                comm.CommandType = CommandType.Text;

                connect.Open();

                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    result = Convert.ToInt64(reader[0]);
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public int InsertOrderDuck(OrderDuck od)
        {
            try
            {
                comm.CommandText = "INSERT INTO OrderDuck VALUES(@id_order, @id_duck)";
                comm.Parameters.AddWithValue("id_order", od.id_order);
                comm.Parameters.AddWithValue("id_duck", od.id_duck);

                comm.CommandType = CommandType.Text;
                connect.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public int DeleteOrderDuck(OrderDuck od)
        {
            try
            {
                comm.CommandText = "DELETE FROM OrderDuck WHERE id_order=@id_order AND id_duck=@id_duck";
                comm.Parameters.AddWithValue("id_order", od.id_order);
                comm.Parameters.AddWithValue("id_duck", od.id_duck);

                comm.CommandType = CommandType.Text;
                connect.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public long GetNumberDuck(Orders o, string s)
        {
            long result = 0;

            try
            {
                comm.CommandText = "SELECT " + s + " FROM Orders WHERE id_order=@id_order";
                comm.Parameters.AddWithValue("id_order", o.id_order);
                comm.CommandType = CommandType.Text;

                connect.Open();

                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    result = Convert.ToInt64(reader[0]);
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public DateTime GetDateOrder(Orders o, string s)
        {
            DateTime result = DateTime.Today;
            try
            {
                comm.CommandText = "SELECT " + s + " FROM Orders WHERE id_order=@id_order";
                comm.Parameters.AddWithValue("id_order", o.id_order);
                comm.CommandType = CommandType.Text;

                connect.Open();

                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    result = Convert.ToDateTime(reader[0]);
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
    }
}
