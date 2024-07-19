using DBCrudApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DBCrudApp.Repositories
{
    public static class PersonRepository
    {
        //Change the connectionString as per your Database
        public static string _connectionString { get; set; } = @"Data Source=DESKTOP-3J635BH;Initial Catalog=DBCRUDApp;Integrated Security=True;Encrypt=False";


        public static List<Person> GetData()
        {
            string commandString = "Select * FROM Person;";

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
                    Id = (int)row["ID"],
                    FirstName = (string)row["FIRSTNAME"],
                    LastName = (string)row["LASTNAME"],
                    DOB = (DateTime)row["DOB"],
                    Designition = (string)row["DESIGNITION"],
                    Address = row["ADDRESS"].ToString()!,
                    Email = (string)row["EMAIL"],
                    Phone = row["PHONE"].ToString()!,
                    CNIC = (string)row["CNIC"],
                    isActive = row["IsActive"] != DBNull.Value ? (bool)row["IsActive"] : false,
                };

                persons.Add(person);
            }

            return persons;
        }


        public static bool CreatePerson(Person person)
        {
            //right your code here
            string isActive = person.isActive ? "1" : "0";
            string insertQuery = $"INSERT INTO PERSON (FIRSTNAME,LASTNAME,DOB,EMAIL,PHONE,ADDRESS,DESIGNITION, CNIC,IsActive) VALUES ('{person.FirstName}',  '{person.LastName}'  , '{person.DOB}'  , '{person.Email}' , '{person.Phone}' ,  '{person.Address}'  ,'{person.Designition}' , '{person.CNIC}' , {isActive}  )";
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
            insertCommand.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public static bool UpdatePerson(Person person)
        {
            //Right your

            string UpdateQuery = $"UPDATE PERSON SET LASTNAME = '{person.LastName}'  WHERE ID =  '{person.Id}' ";
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, connection);
            UpdateCommand.ExecuteNonQuery();
            connection.Close();

            return true;
        }

        public static bool DeletePerson(Person person)
        {
            //Right your code
            string deleteQuery = $"DELETE FROM PERSON WHERE ID = {person.Id}";
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
            deleteCommand.ExecuteNonQuery();
            //     Console.WriteLine("Deleted Successfully");
            return true;
        }

    }
}
