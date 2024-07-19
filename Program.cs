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
        string answer;
        do
        {
            Console.WriteLine("Select from the options below\n1.Retrieve\n2.Create\n3.Update\n4.Delete");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    var list = PersonRepository.GetData();
                    foreach (var item in list)
                    {
                        Console.WriteLine($"{item.Id}\t|\t{item.FirstName} {item.LastName}\t|\t{item.DOB.ToString("yyyy-MM-dd")}\t|\t{item.Address}\t|\t{item.Phone}\t|\t{item.Email}\t|\t{item.CNIC}\t|\t{item.Designition}");
                    }
                    Console.WriteLine("Enter Id of Person to retrieve attendence");
                    choice = int.Parse(Console.ReadLine());
                    var list1 = PersonAttendanceRepository.GetPersonAttendence(choice);
                    foreach (var item in list1)
                    {
                        Console.WriteLine($"{item.PERSONID}\t|\t {item.FirstName} {item.LastName}\t|\t{item.Desginition}\t|\t{item.AttendenceDate}\t|\t");
                    }
                    break;



                case 2:
                    var person = new Person();


                    Console.Write("Enter First Name: ");
                    person.FirstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    person.LastName = Console.ReadLine();

                    Console.Write("Enter Address: ");
                    person.Address = Console.ReadLine();

                    Console.Write("Enter Date of Birth: ");
                    person.DOB = DateTime.Parse(Console.ReadLine());

                    Console.Write("Enter CNIC: ");
                    person.CNIC = Console.ReadLine();

                    Console.Write("Enter Designation: ");
                    person.Designition = Console.ReadLine();

                    Console.Write("Enter Phone Number: ");
                    person.Phone = Console.ReadLine();

                    Console.Write("Enter Email: ");
                    person.Email = Console.ReadLine();

                    Console.Write("Is the person active? true / false : ");
                    person.isActive = bool.Parse(Console.ReadLine());

                    bool result = PersonRepository.CreatePerson(person);
                    string message = result ? "Person created!" : "Failed something went wrong";
                    Console.WriteLine(message);
                    break;

                case 3:

                    Console.Write("Enter the ID of the person you want to update: ");
                    int ID = Convert.ToInt32(Console.ReadLine());

                    var person1 = new Person { Id = ID };

                    Console.Write("Enter new First Name: ");
                    person1.FirstName = Console.ReadLine();

                    Console.Write("Enter new Last Name: ");
                    person1.LastName = Console.ReadLine();

                    Console.Write("Enter new Address: ");
                    person1.Address = Console.ReadLine();

                    Console.Write("Enter new Date of Birth (yyyy-mm-dd): ");
                    person1.DOB = DateTime.Parse(Console.ReadLine());

                    Console.Write("Enter new CNIC: ");
                    person1.CNIC = Console.ReadLine();

                    Console.Write("Enter new Designation: ");
                    person1.Designition = Console.ReadLine();

                    Console.Write("Enter new Phone Number: ");
                    person1.Phone = Console.ReadLine();

                    Console.Write("Enter new Email: ");
                    person1.Email = Console.ReadLine();

                    Console.Write("Is the person active? (true/false): ");
                    person1.isActive = Console.ReadLine() == "TRUE" ? true : false;

                    bool result1 = PersonRepository.UpdatePerson(person1);
                    string message1 = result1 ? "Person updated!" : "Failed something went wrong";
                    Console.WriteLine(message1);
                    break;

                case 4:

                    Console.Write("Enter the ID of the person you want to delete: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    var person2 = new Person { Id = id };

                    if (PersonRepository.DeletePerson(person2))
                    {
                        Console.WriteLine("Person deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to delete person.");
                    }
                    break;

                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
            Console.WriteLine("Do you want to continue?");
            answer = Console.ReadLine();
        }
        while (answer != "no");
    }
}