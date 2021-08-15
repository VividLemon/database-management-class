using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class Employee : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; } = DateTime.Now;
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, DateTime dateOfBirth, string phoneNumber, string address, string state, string zip, decimal salary)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Address = address;
            State = state;
            Zip = zip;
            Salary = salary;
        }
    }
}
