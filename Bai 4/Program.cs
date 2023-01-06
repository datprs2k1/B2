using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai_4
{
    internal class Program
    {
        static List<Department> Departments = new List<Department>();
        static List<Employee> Employees = new List<Employee>();
        static void Main(string[] args)
        {
            int choose;

            do
            {
                Console.WriteLine("1. Department");
                Console.WriteLine("2. List Department");
                Console.WriteLine("3. Employee");
                Console.WriteLine("4. List Employee");
                Console.WriteLine("5. Find Employee");
                Console.WriteLine("6. List Tree");

                Console.Write("Select: ");
                choose = Convert.ToInt32(Console.ReadLine());

                switch(choose)
                {
                    case 1:
                        Console.Clear();
                        Department a = new Department();
                        a.Input();
                        Departments.Add(a);
                        Console.WriteLine("Press any button to exit.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine(string.Format("{0,-20}|{1,-20}|{2,-20}|{3,-20}", "ID", "Code", "Name", "Description"));
                        foreach (Department b in Departments)
                            b.Output();
                        Console.WriteLine("Press any button to exit.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Employee c = new Employee();
                        c.Input();
                        Department x = new Department();
                        do
                        {
                            Console.Write("Department code: ");
                            string d = Console.ReadLine();
                            x = Departments.Find(i => i.Code == d);

                            if (x == null)
                                Console.WriteLine("Department does not exist");
                        } while (x == null);

                        c.Department= x;

                        Employees.Add(c);
                        Console.WriteLine("Press any button to exit.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine(string.Format("{0,-21}{1,-21}{2,-21}{3,-21}{4,-21}{5,-21}", "Name", "Address", "Gender", "Position", "Start", "Department"));
                        foreach (Employee d in Employees)
                        {
                            Console.WriteLine(string.Format("{0,-21}{1,-21}{2,-21}{3,-21}{4,-21}{5,-21}", d.Name, d.Address, d.Gender == 1 ? "Male" : "Female", d.Position, d.Start.ToString("dd/MM/yyyy"), d.Department.Name));
                            Console.WriteLine();
                        }
                            
                        Console.WriteLine("Press any button to exit.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        FindEmployee();
                        Console.WriteLine("Press any button to exit.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Tree();
                        Console.WriteLine("Press any button to exit.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        break;
                }

            } while(choose != 0);
        }

        static void FindEmployee()
        {
            Console.Write("Employee name: ");
            string name = Console.ReadLine();

            Console.WriteLine();

            List<Employee> find = Employees.Where(x => x.Name.Equals(name)).ToList();

            if (find == null)
            {
                Console.WriteLine("Employee does not exist");
            } else
            {
                Console.WriteLine(string.Format("{0,-21}{1,-21}{2,-21}{3,-21}{4,-21}{5,-21}", "Name", "Address", "Gender", "Position", "Start", "Department"));

                foreach(Employee d in find)
                {
                    Console.WriteLine(string.Format("{0,-21}{1,-21}{2,-21}{3,-21}{4,-21}{5,-21}", d.Name, d.Address, d.Gender == 1 ? "Male" : "Female", d.Position, d.Start.ToString("dd/MM/yyyy"), d.Department.Name));
                }

            }
        }

        static void Tree()
        {
            int i = 1;
            foreach(Department a in Departments)
            {
                Console.WriteLine("{0}. Department {1}", i, a.Name);
                List<Employee> list = Employees.Where(x => x.Department.Name == a.Name).ToList();
                Console.WriteLine(string.Format("{0,-21}{1,-21}{2,-21}{3,-21}{4,-21}{5,-21}", "Name", "Address", "Gender", "Position", "Start", "Department"));
                list.ForEach(d =>
                {
                    Console.WriteLine(string.Format("{0,-21}{1,-21}{2,-21}{3,-21}{4,-21}{5,-21}", d.Name, d.Address, d.Gender == 1 ? "Male" : "Female", d.Position, d.Start.ToString("dd/MM/yyyy"), d.Department.Name));
                });
                Console.Write("----------------------------------\n");
                i++;
            }
        }
    }
}
