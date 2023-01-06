using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class Hotel
    {
        private int id;
        private string name;
        private string address;
        private string type;
        private List<Room> rooms;

        public Hotel() { }
        public Hotel(int id, string name, string address, string type, List<Room> rooms)
        {
            this.id = id;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.address = address ?? throw new ArgumentNullException(nameof(address));
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.rooms = rooms ?? throw new ArgumentNullException(nameof(rooms));
        }

        public int ID { get => id; set => id = value; }    
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set=> address = value; }
        public string Type { get => type; set => type = value; }
        public List<Room> Rooms { get => rooms; set => rooms = value; }

        public void Input()
        {
            Rooms = new List<Room>();

            Console.Write("----------------------------------\n");
            Console.WriteLine("Hotel");
            Console.Write("ID: ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Address: ");
            Address = Console.ReadLine();
            Console.Write("Type: ");
            Type = Console.ReadLine();
            Console.Write("Number of room: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Room a = new Room();
                a.Input();
                Rooms.Add(a);
            }

        }

        public void Output()
        {
            Console.Write("----------------------------------\n");
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("Type: {0}", Type);
            Console.Write("----------------------------------\n");
            Console.WriteLine("Room");
            foreach(Room a in Rooms)
            {
                a.Output();
            }
        }
    }
}
