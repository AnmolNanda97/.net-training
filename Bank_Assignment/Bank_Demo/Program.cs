using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Demo
{
    class banks
    {
        public int accno;
        public string accname;
        public int atm_pin;
        public double opening_balance;
        public double deposit_amount;
        public double withdrawl_amount;
        public double balance;
        public int choice;

        public void CheckBalance(banks[] ba, int i)
        {
            Console.WriteLine("You have chosen to check balance");
            Console.WriteLine("Your balance is Rs." + ba[i].balance + "\n");
            
        }

        public void DepositAmount(banks[] ba, int i)
        {
            Console.WriteLine("You have chosen to deposit amount\n");
            Console.WriteLine("Enter the amount to be deposited\n");
            ba[i].deposit_amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Your deposit of Rs." + ba[i].deposit_amount + " is successful\n");
            ba[i].balance = (ba[i].balance + ba[i].deposit_amount) - ba[i].withdrawl_amount;
            Console.WriteLine("Your Current balance is Rs." + ba[i].balance + "\n");
            
        }

        public void WithdrawAmount(banks[] ba, int i)
        {
            Console.WriteLine("You have chosen for withdrawl\n");
            Console.WriteLine("Enter the amount you want to withdraw");
            ba[i].withdrawl_amount = int.Parse(Console.ReadLine());
            if (ba[i].withdrawl_amount > ba[i].balance)
            {
                Console.WriteLine("Insufficient money in the account\n");
                Console.WriteLine("Your Current balance is Rs." + ba[i].balance);
            }
            else
            {
                ba[i].balance = ba[i].balance - ba[i].withdrawl_amount;
                Console.WriteLine("Your Current balance is " + ba[i].balance + "\n");
                

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            banks[] acc = new banks[10];
            banks bank = new banks();
            acc[0] = new banks { accno = 10401011, accname = "Anmol", atm_pin = 101, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            acc[1] = new banks { accno = 10401012, accname = "Tony", atm_pin = 102, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            acc[2] = new banks { accno = 10401013, accname = "Ram", atm_pin = 103, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            acc[3] = new banks { accno = 10401014, accname = "Virat", atm_pin = 104, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            acc[4] = new banks { accno = 10401015, accname = "Aman", atm_pin = 105, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            acc[5] = new banks { accno = 10401016, accname = "Sunil", atm_pin = 106, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            acc[6] = new banks { accno = 10401017, accname = "Sekhar", atm_pin = 107, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            acc[7] = new banks { accno = 10401018, accname = "Rahul", atm_pin = 108, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            acc[8] = new banks { accno = 10401019, accname = "Rohit", atm_pin = 109, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            acc[9] = new banks { accno = 10401010, accname = "Satwik", atm_pin = 110, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };



            Console.WriteLine("\tEnter your ATM pin");
            Console.Write("PIN: ");
            int y;
            int a = int.Parse(Console.ReadLine());
            int i = (a % 100) - 1;
            if (a > 100 && a < 111)
            {


                Console.WriteLine("\nAccount number is\n" + acc[i].accno + "\nAccount Bearer is:\n" + acc[i].accname + "\nYour Balance is:\n" + acc[i].balance);
                Console.WriteLine("_____________________________________________________________");
                do
                {
                    Console.WriteLine("\tPLEASE SELECT YOUR ACTION OF ITEM\n \t1-Check balance\n\t2-Deposit Amount\n\t3-Withdraw Amount\n");
                    Console.Write("Action:");
                    bank.choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n_____________________________________________________________");
                    switch (bank.choice)
                    {
                        case 1:
                            bank.CheckBalance(acc, i);
                            break;
                        case 2:
                            bank.DepositAmount(acc, i);
                            break;
                        case 3:
                            bank.WithdrawAmount(acc, i);
                            break;

                    }
                    Console.WriteLine("_____________________________________________________________");
                    Console.WriteLine("Do you want to perform any other action?\n If yes press 1 or 0 to exit");
                    y = int.Parse(Console.ReadLine());
                } while (y==1);
                Console.WriteLine("\tThank you for using the ATM service");

            }
            else
            {

                Console.WriteLine("\tALERT!!!\nWrong ATM PIN.\nPlease enter your valid PIN");
            }


           
        }
    }
}
