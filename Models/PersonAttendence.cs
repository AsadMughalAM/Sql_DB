using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCrudApp.Models
{
    public class PersonAttendence
    {
        public int Id { get; set; } //Id for Attendence
        public int PERSONID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CNIC { get; set; }
        public string Desginition { get; set; }
        public DateTime AttendenceDate {  get; set; }
    }
}
