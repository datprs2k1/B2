using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai_3
{
    internal class Program
    {
        static List<Hotel> hotel = new List<Hotel>();
        static List<Customer> customer = new List<Customer>();
        static List<Book> books = new List<Book>();

        static void Main(string[] args)
        {

            int choose;
            do
            {
                Console.Write("----------------------------------\n");
                Console.WriteLine("1. Hotel");
                Console.WriteLine("2. List Hotel");
                Console.WriteLine("3. Book");
                Console.WriteLine("4. Check");
                Console.WriteLine("5. Revenue");
                Console.WriteLine("6. Customer");
                Console.WriteLine("7. Exit");
                Console.Write("Select: ");
                choose = Convert.ToInt32(Console.ReadLine());

                switch(choose)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("----------------------------------\n");
                        Console.Write("Number of hotel: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i < n; i++)
                        {
                            Hotel a = new Hotel();
                            a.Input();
                            hotel.Add(a);
                        }
                        Console.WriteLine("Press any button to exit.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("List Hotel");
                        foreach (Hotel i in hotel)
                            i.Output();
                        Console.WriteLine("Press any button to exit.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("----------------------------------\n");
                        bookroom();
                        Console.WriteLine("Press any button to exit.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("----------------------------------\n");
                        findAvaiable();
                        Console.WriteLine("Press any button to exit.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("----------------------------------\n");
                        Report();
                        Console.WriteLine("Press any button to exit.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("List Customer");
                        foreach (Customer a in customer)
                        {
                            a.Output();
                        }
                        Console.WriteLine("Press any button to exit.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        break;
                }

            } while (choose != 7);

        }

        public static void bookroom()
        {
            Customer a = new Customer();
            Hotel b = new Hotel();
            Room c = new Room();

            Console.Write("CMND: ");
            int cmnd = Convert.ToInt32(Console.ReadLine());

            a = customer.Find(x => x.CMND == cmnd);

            if(a == null)
            {
                Console.WriteLine("Customer dose not exist.");
                Console.Write("----------------------------------\n");
                a = new Customer();
                a.Input();
                customer.Add(a);
            }

            Console.Clear() ;

            Console.Write("Hotel ID: ");
            int hotel_id = Convert.ToInt32(Console.ReadLine());

            b = hotel.Find(x => x.ID== hotel_id);

            if (b == null)
            {
                Console.WriteLine("Hotel dose not exist.");
                Console.Write("----------------------------------\n");
                b = new Hotel();
                b.Input();
                hotel.Add(b);
            }

            Console.Clear();

            do
            {
                Console.Write("Room ID: ");
                int room_id = Convert.ToInt32(Console.ReadLine());
                c = b.Rooms.Find(x => x.ID == room_id);
                if(c == null)
                {
                    Console.Write("----------------------------------\n");
                    Console.WriteLine("Room dose not exist.");
                }
            } while (c == null);

            Console.Clear();

            Console.Write("Start date: ");
            DateTime start_date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("End date: ");
            DateTime end_date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Book d = new Book();
            d.CMND = a.CMND;
            d.Name = a.Name;
            d.Hotel_id = b.ID;
            d.Room_id = c.ID;
            d.Start_date = start_date;
            d.End_date = end_date;

            books.Add(d);
        }

        static void findAvaiable()
        {
            Console.Write("Start date: ");
            DateTime start_date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("End date: ");
            DateTime end_date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            List<Hotel> avaiable = new List<Hotel>();
            foreach(Hotel a in hotel)
            {
                Hotel hotel = new Hotel();
                hotel.ID = a.ID;
                hotel.Name = a.Name;
                hotel.Address = a.Address;
                hotel.Rooms = new List<Room>();
                
                foreach(Room r in a.Rooms)
                {
                    Book find = new Book();
                    find = books.Find(x => x.Hotel_id== a.ID && x.Room_id == r.ID && x.Start_date <= end_date && x.End_date >= start_date);

                    if(find == null)
                    {
                        hotel.Rooms.Add(r);
                    }
                }

                avaiable.Add(hotel);
            }

            Console.Clear();

            foreach(Hotel hotel in avaiable)
            {
                hotel.Output();
            }
        }

        static void Report()
        {
            double revenue = 0;

            foreach(Book a in books)
            {
                int day = Convert.ToInt32((a.End_date - a.Start_date).TotalDays);
                Hotel b = hotel.Find(x => x.ID == a.Hotel_id);
                Room c = b.Rooms.Find(x => x.ID == a.Room_id);
                revenue += day * c.Cost;

                Console.WriteLine("Revenue: {0}", revenue);

            }
        }

    }
}
