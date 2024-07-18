using DBCrudApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCrudApp.Repositories
{
    public static class PersonAttendance
    {
        //Change the connectionString as per your Database
        public static string _connectionString { get; set; } = @"Data Source=DESKTOP-3J635BH;Initial Catalog=DBCRUDApp;Integrated Security=True;Encrypt=False";


        public static List<Person> GetData()
        {
            string commandString = "Select * FROM DBCRUDApp.dbo.A;";

            var connection = new SqlConnection(_connectionString);
            var command = new SqlCommand(commandString, connection);

            var dataAdapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            var persons = new List<Person>();

            foreach (DataRow row in dataTable.Rows)
            {
                var person = new Person()
                {
                    Id = (int)row["Id"],
                    FirstName = (string)row["FirstName"],
                    LastName = (string)row["LastName"],
                    Address = row["Address"].ToString()!,
                    Email = (string)row["Email"],
                    Phone = row["Phone"].ToString()!,
                    Designition = (string)row["Designition"],
                    CNIC = (string)row["CNIC"],
                    DOB = (DateTime)row["DOB"],
                 };

                persons.Add(person);
            }

            return persons;
        }


        public static bool CreatePersonAttendance(Person person)
        {
            //right your code here
            return false;
        }


    }
}
