using DBCrudApp.Models;
using DBCrudApp.Repositories;
using System;
namespace DBCrudApp;


public static class Program
{
    public static void Main(string[] args)
    {
        //Add ANother table of PersonAttendance With Columns {Id, PersonId, AttendanceDateTime, IsActive}
        //write CreateAttendance and GetData functions
        //Make sure these work properly

        var list = PersonRepository.GetData();

        foreach (var item in list)
        {
            Console.WriteLine($"{item.Id}\t|\t{item.FirstName} {item.LastName}\t|\t{item.DOB.ToString("yyyy-MM-dd")}\t|\t{item.Address}\t|\t{item.Phone}\t|\t{item.Email}\t|\t{item.CNIC}\t|\t{item.Designition}");
        }

        //Person person = new Person();
        //person.FirstName = "AbdulQadoos";
        //person.LastName = "Javed";
        //person.Address = "Lahore";
        //person.DOB = DateTime.Parse("2024-06-21");
        //person.CNIC = "1234";
        //person.Designition = "Intern";
        //person.Phone = "03323";
        //person.Email = "asad@mail.com";
        //person.isActive = true;
        //bool result = PersonRepository.CreatePerson(person);
        //string message = result ? "Person created!" : "Failed somthing went wrong";
        //Console.WriteLine(message);


        //Person person = new Person();
        //Console.Write("Enter First Name: ");
        //person.FirstName = Console.ReadLine();

        //Console.Write("Enter Last Name: ");
        //person.LastName = Console.ReadLine();

        //Console.Write("Enter Address: ");
        //person.Address = Console.ReadLine();

        //Console.Write("Enter Date of Birth: ");
        //person.DOB = DateTime.Parse(Console.ReadLine());

        //Console.Write("Enter CNIC: ");
        //person.CNIC = Console.ReadLine();

        //Console.Write("Enter Designation: ");
        //person.Designition = Console.ReadLine();

        //Console.Write("Enter Phone Number: ");
        //person.Phone = Console.ReadLine();

        //Console.Write("Enter Email: ");
        //person.Email = Console.ReadLine();

        //Console.Write("Is the person active? ");
        //person.isActive = bool.Parse(Console.ReadLine());

        //bool result = PersonRepository.CreatePerson(person);
        //string message = result ? "Person created!" : "Failed something went wrong";
        //Console.WriteLine(message);

        //Console.ReadLine();

        //Console.Write("Enter the ID of the person you want to Update: ");
        //int ID = Convert.ToInt32(Console.ReadLine());
        //Person person = new Person { Id=2,LastName="Mughal"};
        //person.LastName = "Ali";
        //bool result = PersonRepository.UpdatePerson(person);
        //string message = result ? "Person Updated!" : "Failed somthing went wrong";
        //Console.WriteLine(message);

        //Console.Write("Enter the ID of the person you want to update: ");
        //int ID = Convert.ToInt32(Console.ReadLine());

        //Person person = new Person { Id = ID };

        //Console.Write("Enter new First Name: ");
        //person.FirstName = Console.ReadLine();

        //Console.Write("Enter new Last Name: ");
        //person.LastName = Console.ReadLine();

        //Console.Write("Enter new Address: ");
        //person.Address = Console.ReadLine();

        //Console.Write("Enter new Date of Birth (yyyy-mm-dd): ");
        //person.DOB = DateTime.Parse(Console.ReadLine());

        //Console.Write("Enter new CNIC: ");
        //person.CNIC = Console.ReadLine();

        //Console.Write("Enter new Designation: ");
        //person.Designition = Console.ReadLine();

        //Console.Write("Enter new Phone Number: ");
        //person.Phone = Console.ReadLine();

        //Console.Write("Enter new Email: ");
        //person.Email = Console.ReadLine();

        //Console.Write("Is the person active? (true/false): ");
        //person.isActive = bool.Parse(Console.ReadLine());

        //bool result = PersonRepository.UpdatePerson(person);
        //string message = result ? "Person updated!" : "Failed something went wrong";
        //Console.WriteLine(message);

        Console.ReadLine();









        //Console.Write("Enter the ID of the person you want to delete: ");
        //int id = Convert.ToInt32(Console.ReadLine());

        //Person person = new Person { Id = id };

        //if (PersonRepository.DeletePerson(person))
        //{
        //    Console.WriteLine("Person deleted successfully!");
        //}
        //else
        //{
        //    Console.WriteLine("Failed to delete person.");
        //}

        //Console.ReadLine();
    }
}




  