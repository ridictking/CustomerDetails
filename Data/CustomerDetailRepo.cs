using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Data
{
    public class CustomerDetailRepo
    {
        private string _connectionString;

        public CustomerDetailRepo(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IList<CustomerDetailModel> GetList()
        {
            List<CustomerDetailModel> result = new List<CustomerDetailModel>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "Select * from CustomerOrderDetail";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                     using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                CustomerDetailModel model = new CustomerDetailModel()
                                {
                                    CustomerOrderId = Convert.ToInt32(reader["CustomerId"]),
                                    ItemId = Convert.ToInt32(reader["ItemId"]),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Price = Convert.ToDecimal(reader["Price"])
                                };
                                result.Add(model);
                            }
                        }
                    }
                };
            };
            return result;
        }
    }
}
