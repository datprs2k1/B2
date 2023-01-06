using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class Customer
    {
        private int cmnd;
        private string name;
        private int age;
        private string gender;
        private string address;

        public int CMND { get => cmnd; set => cmnd = value;}
        public string Name { get => name; set=> name = value; }
        public int Age { get=> age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set=> address = value; }

        public Customer() { }
        public Customer(int cMND, string name, int age, string gender, string address)
        {
            CMND = cMND;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Age = age;
            Gender = gender ?? throw new ArgumentNullException(nameof(gender));
            Address = address ?? throw new ArgumentNullException(nameof(address));
        }

        public void Input()
        {
            Console.Write("----------------------------------\n");
            Console.WriteLine("Customer");
            Console.Write("CMND: ");
            CMND = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gender: ");
            Gender = Console.ReadLine();
            Console.Write("Address: ");
            Address = Console.ReadLine();
        }

        public void Output()
        {
            Console.Write("----------------------------------\n");
            Console.WriteLine("CMND: {0}", CMND);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Gender: {0}", Gender);
            Console.WriteLine("Address: {0}", Address);
        }
    }
}
