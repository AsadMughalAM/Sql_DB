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
    public static class PersonAttendanceRepository
    {
        //Change the connectionString as per your Database
        public static string _connectionString { get; set; } = @"Data Source=DESKTOP-3J635BH;Initial Catalog=DBCRUDApp;Integrated Security=True;Encrypt=False";


        public static List<Person> GetData()
        {
            string commandString = "SELECT * FROM OFFICE";

            var connection = new SqlConnection(_connectionString);
            var command = new SqlCommand(commandString, connection);

            var dataAdapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            var personss = new List<Person>();

            foreach (DataRow row in dataTable.Rows)
            {
                var person = new Person()
                {
                    Id = (int)row["Id"],
                    PERSONID=(int)row["personid"],
                    ATTENDENCEDATETIME=(DateTime)row["attendencedatetime"],
                };

                personss.Add(person);
            }

            return personss;
        }

        public static List<PersonAttendence> GetPersonAttendence(int personId)
        {
            List<PersonAttendence> personAttendences = new List<PersonAttendence>();
            string query = $"Select p.FIRSTNAME, p.LASTNAME, p.DESIGNITION, p.CNIC, atten.* from ATTENDENCE atten join Person p on p.id = atten.PERSONID Where atten.PERSONID = {personId}";
            var connection = new SqlConnection(_connectionString);
            var command = new SqlCommand(query, connection);

            var dataAdapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                var attendence = new PersonAttendence()
                {
                    FirstName = (string)row["FIRSTNAME"],
                    LastName = (string)row["LASTNAME"],
                    CNIC = (string)row["CNIC"],
                    Desginition = (string)row["DESIGNITION"],
                    Id = (int)row["Id"],
                    PERSONID = (int)row["PERSONID"],
                    AttendenceDate = (DateTime)row["ATTENDENCE_DATE"],
                };

                personAttendences.Add(attendence);
            }


            return personAttendences;
        }

        public static bool CreatePersonAttendance(Person person)
        {
            //right your code here

            string insertQuery = $"INSERT INTO PERSON (ID,PERSONID,ATTENDENCEDATETIME) VALUES ( '{person.Id}',  '{person.PERSONID}'  , '{person.ATTENDENCEDATETIME}'  )";
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
            insertCommand.ExecuteNonQuery();
            connection.Close();
            return true;

        }


    }
}
