using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class Employee
    {
        private string name;
        private DateTime dob;
        private string address;
        private int gender;
        private string position;
        private DateTime start;
        private Department department = new Department();

        public Employee() { }

        public Employee(string name, DateTime dob, string address, int gender, string position, DateTime start, Department department)
        {
            this.name = name;
            this.dob = dob;
            this.address = address;
            this.gender = gender;
            this.position = position;
            this.start = start;
            this.department = department;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Gender { get => gender; set => gender = value; }
        public string Position { get => position; set => position = value; }
        public DateTime Start { get => start; set => start = value; }
        public Department Department { get => department; set => department = value; }

        public void Input()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Address: ");
            Address = Console.ReadLine();
            Console.Write("Gender(1: Male, 2: Female): ");
            Gender = Convert.ToInt32(Console.ReadLine());
            Console.Write("Position: ");
            Position = Console.ReadLine();
            Console.Write("Start Date(dd/MM/yyyy): ");
            Start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        }

        public void Output()
        {
            Console.WriteLine(string.Format("{0,-21}{1,-21}{2,-21}{3,-21}{4,-21}", Name, Address, Gender == 1 ? "Male" : "Female", Position, Start.ToString("dd/MM/yyyy")));
        }

    }
}
