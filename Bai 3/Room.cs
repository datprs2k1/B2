using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class Room
    {
        private int id;
        private string name;
        private double cost;
        private int floor;
        private int max;

        public Room() { }
        public Room(int id, string name, double cost, int floor, int max)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.floor = floor;
            this.max = max;
        }

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Cost { get => cost; set => cost = value;  }
        public int Floor { get => floor; set => floor = value;  }
        public int Max { get => max; set => max = value;  }

        public void Input()
        {
            Console.Write("----------------------------------\n");
            Console.WriteLine("Room");
            Console.Write("ID: ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Cost: ");
            Cost = Convert.ToDouble(Console.ReadLine());
            Console.Write("Floor: ");
            Floor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Max: ");
            Max = Convert.ToInt32(Console.ReadLine());
        }

        public void Output()
        {
            Console.Write("----------------------------------\n");
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Cost: {0}", Cost);
            Console.WriteLine("Floor: {0}", Floor);
            Console.WriteLine("Max: {0}", Max);
        }

    }
}
