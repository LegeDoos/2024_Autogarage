using _2024_Autogarage.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024_Autogarage.DataAccessLayer
{
    public class DAL
    {
        string connectionString = $"Data Source=.;Initial Catalog=2024Autogarage;Integrated Security=True";

        private SqlConnection connection { get; }

        public DAL()
        {
            connection = new SqlConnection(connectionString);
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public List<CarOwner> GetAllCarowners()
        {
            List<CarOwner> theList = [];

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = $"select * from CarOwner";
           
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // haal gegevens uit reader
                        int id = Int32.Parse(reader[0].ToString());
                        string name = reader[1].ToString();

                        // maak het object met de constructor die we hebben gemaakt
                        CarOwner owner = new CarOwner(name);
                        owner.Id = id;

                        theList.Add(owner);
                    }
                }
            }
            return theList;
        }

    }
}
