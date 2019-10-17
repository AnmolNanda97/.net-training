using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Generation
{
    class Program
    {
      static  string[] items = new string[] { "Atta - 1kg", "Rice - 1kg", "Sugar - 1kg", "Salt - 1kg", "Dal - 1kg", "Tea - 1pack","Bread - 1pack","Butter - 1pack" };
       static double[] price = new double[] { 55, 60, 45, 20, 90, 50, 40, 55 };

        
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("\tList of Items\n");
            Console.WriteLine("_________________________________");
            Console.WriteLine("Items\t\t\tPrice");
            Console.WriteLine("_________________________________");
            for (int k = 0,j=0; k < items.Length & j<price.Length; k++,j++)
            {
                Console.Write(items[k]+"\t\t");
                
                    Console.WriteLine(price[j]);
                Console.WriteLine("--------------------------------");
            }
            string item;
            double total=0;
            int qty;
           int x;
            int y=0;
            int i = 0;
            string[] it = new string[10];
            int[] q = new int[10];



            do
            {
                y++;
                Console.WriteLine("Enter the Item And its Quantity");
                Console.Write("Item:");
                item = Console.ReadLine();
                Console.Write("Quantity:");
                qty = int.Parse(Console.ReadLine());
                string choice = Convert.ToString(item.ToString().ToUpper());
                switch (choice)
                {
                    case "ATTA":
                        total = total + (qty * 55);
                        break;

                    case "RICE":
                        total = total + (qty * 60);
                        break;

                    case "SUGAR":
                        total = total + (qty * 45);
                        break;

                    case "SALT":
                        total = total + (qty * 20);
                        break;

                    case "DAL":
                        total = total + (qty * 90);
                        break;

                    case "TEA":
                        total = total + (qty * 50);
                        break;

                    case "BREAD":
                        total = total + (qty * 40);
                        break;

                    case "BUTTER":
                        total = total + (qty * 55);
                        break;

                    default:
                        Console.WriteLine("Please enter a valid item");
                        break;
                }
                
                    
                q[i] = qty;
                    it[i] = choice;
                i++;
                
                Console.WriteLine("Purchase more? \n If yes Enter 1 or else 0");
                x = int.Parse(Console.ReadLine());
            } while (x==1);
            Console.WriteLine("_________________________________\n");

            Console.WriteLine("\tBill");
            Console.WriteLine("_________________________________\n");
            Console.WriteLine("Items\t\tQuantity");
            Console.WriteLine("_________________________________");
            for (int t = 0; t < y; t++)
            {
                Console.Write(it[t] + "\t\t");

                Console.WriteLine(q[t]);
                Console.WriteLine("--------------------------------");
            }
            Console.Write("Total Amount:");
            Console.WriteLine(total);



        }
    }
}
