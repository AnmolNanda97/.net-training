using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD
{

    
    class Employee
    {
        private int id;
        private string name, designation;
        private int salary;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Salary { get => salary; set => salary = value; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Emplist = new List<Employee>();
            Emplist.Add(new Employee { Id = 1, Name = "Steve", Designation = "Administrator", Salary = 5000 });
            Emplist.Add(new Employee { Id = 2, Name = "Warner", Designation = "Developer", Salary = 4000 });
            Emplist.Add(new Employee { Id = 3, Name = "Kane", Designation = "Freelancer", Salary = 6000 });
            Emplist.Add(new Employee { Id = 4, Name = "Root", Designation = "Ux developer", Salary = 8000 });

            int choice,y;
            do { 
                Console.WriteLine("Select the action to be performed");
                Console.WriteLine("1.View the List Of Employees\n2.Add an Employee\n3.Delete an Employee\n4.Update");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Emp ID \t Name \t Designation \t Salary");
                        Console.WriteLine("---------------------------------------");
                        foreach (Employee emp in Emplist)
                        {
                            Console.WriteLine($"{emp.Id} \t {emp.Name}\t {emp.Designation} \t {emp.Salary}");
                            Console.WriteLine("---------------------------------------");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter the ID, Name, Designation and Salary of the Employee");
                        Console.Write("ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("NAME: ");
                        string name = Console.ReadLine();
                        Console.Write("DESIGNATION: ");
                        string designation = Console.ReadLine();
                        Console.Write("SALARY:");
                        int salary = int.Parse(Console.ReadLine());
                        Emplist.Add(new Employee { Id = id, Name = name, Designation = designation, Salary = salary });
                        Console.WriteLine("\nEmployee data successfully added!!!");
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine("Select the Id of the Employee to be deleted");
                            int iD = int.Parse(Console.ReadLine());
                            foreach (Employee item in Emplist)
                            {
                                if (iD == item.Id)
                                {
                                    Emplist.Remove(item);

                                }
                            }
                        }

                        catch (Exception e)
                        {
                            //Console.WriteLine(e.Message);
                        }
                        // Emplist.Remove(new Employee { Id = ID });

                        Console.WriteLine("The Employee data is successfully deleted!!!");
                        break;

                    case 4:
                        Update(Emplist);
                        break;

                    default:
                        Console.WriteLine("Please enter a valid choice!!!");
                        break;
                }
                Console.WriteLine("To continue press 1 and to exit press 0");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("_______________________________________________________________");
          } while (y == 1);
        }

        private static void Update(List<Employee> Emplist)
        {
            try
            {
                Console.WriteLine("Enter the ID for which u want to update the data");
                int ID = int.Parse(Console.ReadLine());
                int indexpostion = Emplist.FindIndex(x => x.Id == ID);
                Console.WriteLine(indexpostion);
                foreach (Employee item in Emplist)
                {
                    if (ID == item.Id)
                    {
                      
                                Emplist.Remove(item);
                        Console.WriteLine("ENter the Updated fields");
                                Console.Write("ID: ");
                                int uid = int.Parse(Console.ReadLine());
                        Console.Write("NAME: ");
                        string uname = Console.ReadLine();
                        Console.Write("DESIGNATION: ");
                        string udesignation = Console.ReadLine();
                        Console.Write("SALARY: ");
                        int usalary = int.Parse(Console.ReadLine());

                        Emplist.Insert(indexpostion, new Employee { Id = uid, Name = uname, Designation = udesignation, Salary = usalary });
   
                        
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
