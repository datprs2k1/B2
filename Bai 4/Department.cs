using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class Department
    {
        private int id;
        private string code;
        private string name;
        private string description;

        public Department() { }
        public Department(int iD, string code, string name, string description)
        {
            ID = iD;
            Code = code;
            Name = name;
            Description = description;
        }

        public int ID { get => id; set => id = value; }
        public string Code { get => code; set=> code = value; }
        public string Name { get => name; set=> name = value; }
        public string Description { get => description; set=> description = value; }

        public void Input()
        {
            Console.Write("ID: ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Code: ");
            Code = Console.ReadLine();
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Description: ");
            Description = Console.ReadLine();

            Console.Write("----------------------------------\n");
        }

        public void Output()
        {
            Console.WriteLine(string.Format("{0,-21}{1,-21}{2,-21}{3,-21}", ID, Code, Name, Description));
        }
    }
}
