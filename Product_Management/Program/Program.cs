using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Program
{

    class Customer
    {
    
        public string productId { get; set; }
        public string supplierId { get; set; }
        public string customerId { get; set; }
        public string customerName { get; set; }
        public string quantity { get; set; }
        public string Location { get; set; }
        public int Salary { get; set; }

    }
    class Program
    {
        static int total = 0;
        static int disc;
        static void Main(string[] args)
        {
            int y;
            do
            {
                Console.WriteLine("Enter the choice \n\n1.Show me the Product Table\n2.Show me the Supplier Table\n3.Entry of details\n4.Bill Generation");
                Console.WriteLine("===============================================================");
                Console.Write("CHOICE: ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                switch (choice)
                {
                    case 1:
                        ShowProducts();
                        break;


                    case 2:
                        showSuppliers();
                        break;

                    case 3:
                        CustomerDetail();
                         break;

                    case 4:
                        BillGeneration();
                        break;

                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
                Console.WriteLine("\n");
                Console.WriteLine("Enter 1 to continue 0 to exit");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("========================================================\n");
            } while (y == 1);
            Console.ReadLine();

        }

        static void ShowProducts()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=IN5CG9214Y3R; database=Product_Management; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from tblProduct";
            cmd.Connection = con;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine("PRODUCT ID \t PRODUCT NAME");
            Console.WriteLine("--------------------------");
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]} \t\t {rdr[1]}");
            }
            con.Close();
        }


        static void showSuppliers()
        {
            Customer customer = new Customer();
            Console.WriteLine("Please Enter the selected Product Id");
            Console.Write("PRODUCT ID: ");
            customer.productId= Console.ReadLine();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=IN5CG9214Y3R; database=Product_Management; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@productId", customer.productId);
            cmd.CommandText = "select * from tblSupplier where product_id=@productId";
           
            cmd.Connection = con;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            
            Console.WriteLine("SUPPLIER ID \t SUPPLIER NAME \t LOCATION \t PRICE");
            Console.WriteLine("--------------------------------------------------------");
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]} \t\t {rdr[1]} \t\t {rdr[2]} \t\t {rdr[4]}");
            }
            con.Close();
        }

        static void CustomerDetail()
        {

            Customer customer2 = new Customer();
            Console.WriteLine("Please Enter the selected Product Id");
            Console.Write("PRODUCT ID: ");
            customer2.productId = Console.ReadLine();
            Console.WriteLine("Please Enter the selected Supplier Id");
            Console.Write("SUPPLIER ID: ");
            customer2.supplierId = Console.ReadLine();
            Console.WriteLine("Please enter your name and the quantity of product you want");
            Console.Write("NAME: ");
            customer2.customerName = Console.ReadLine();
            Console.Write("QUANTITY: ");
            customer2.quantity = Console.ReadLine();

            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = "data source=IN5CG9214Y3R; database=Product_Management; integrated security = true";
            SqlCommand cmd2 = new SqlCommand();

            cmd2.Parameters.AddWithValue("@productId", customer2.productId);
            cmd2.Parameters.AddWithValue("@supplierId", customer2.supplierId);
            cmd2.Parameters.AddWithValue("@custname", customer2.customerName);
            cmd2.Parameters.AddWithValue("@quantity", customer2.quantity);
            cmd2.CommandText = "insert into tblCustomer(customer_name,product_id,supplier_id,quantity) values(@custname,@productId,@supplierId,@quantity)";
            cmd2.Connection = con2;
            con2.Open();

            int rowcount = cmd2.ExecuteNonQuery();
            if (rowcount > 0)
            {
                Console.WriteLine("Added!!!");
            }


            cmd2.CommandText = "select price from tblSupplier where supplier_id=@supplierId";
            object price = cmd2.ExecuteScalar();
            cmd2.CommandText = "select quantity from tblCustomer where customer_name=@custname";
            object quant = cmd2.ExecuteScalar();
            total = total + ((int)price*(int)quant);

            con2.Close();
        }


        static void BillGeneration()
        {
            Console.WriteLine("Have any coupon code");
            Console.Write("COUPON: ");
            string coupon = Convert.ToString(Console.ReadLine());
            
            if (coupon == "fiveoff")
            {
                disc = (5 / 100) * total;
            }
            else
            {
                disc = 0;
            }
            Console.WriteLine("__________________________________\n");
            Console.WriteLine($"Total price: \t{total}");
            Console.WriteLine($"Discounted price: \t{disc}");
            int gt = total - disc;
            Console.WriteLine($"GRAND TOTAL: \t{gt}");
            //Customer customer2 = new Customer();
            //Console.WriteLine("Please Enter the selected Supplier Id");
            //Console.Write("SUPPLIER ID: ");
            //customer2.supplierId = Console.ReadLine();

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source=IN5CG9214Y3R; database=Product_Management; integrated security = true";
            //SqlCommand cmd = new SqlCommand();
            //cmd.Parameters.AddWithValue("@supplierId", customer2.supplierId);
            //cmd.CommandText = "select price from tblSupplier where supplier_id=@supplierId";
            //cmd.Connection = con;
            //con.Open();
            //object price = cmd.ExecuteScalar();
            //total= total+(int)price;
            //Console.WriteLine("PRODUCT ID \t Price");
            //Console.WriteLine("--------------------------");
            
            //    Console.WriteLine(total);
            
            //con.Close();
        }


    }
}
