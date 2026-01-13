using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class banksystem
    {
        private string AccountHolder;
        private string branchName;
        private int phoneNumber;
        private int balance;
        private int accountNumber;

        public string accountholder
        {
            get { return AccountHolder; }
            set { AccountHolder = value; }
        }

        public string BranchName
        {
            get { return branchName; }
            set { branchName = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public banksystem(string AccountHolder , int phoneNumber, string branchName, int balance, int accountNumber)
        {
            this.AccountHolder = AccountHolder;
            this.branchName = branchName;
            this.phoneNumber = phoneNumber;
            this.balance = balance;
            this.accountNumber = accountNumber;
        }

        public void CreateAccount()
        {
            Console.Write("Enter your accountholder: ");
           accountholder = Console.ReadLine();

            Console.Write("Enter your Phone number: ");
            phoneNumber = int.Parse(Console.ReadLine());


            Console.Write("Enter Branch Name: ");
            branchName = Console.ReadLine();



            Console.Write("Enter Balance: ");
            balance = int.Parse(Console.ReadLine());

        }

        public void Withdraw(int amount)
        {
            balance -= amount;
        }

        public void Transfer(banksystem target, int amount)
        {
            balance -= amount;
            target.balance += amount;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Bank accountholder: {AccountHolder}");
            Console.WriteLine($"Branch: {branchName}");
            Console.WriteLine($"Balance: {balance}");
            Console.WriteLine($"Account Number: {accountNumber}");
        }

        ~banksystem()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            banksystem b1 = new banksystem("Noor", "Amman", "0791828411", 200, 1234567);
            banksystem b2 = new banksystem("Salsabeel", "irbid", "075623140", 500, 9876543);

            Console.WriteLine("1- Create Account");
            Console.WriteLine("2- Withdraw");
            Console.WriteLine("3- Transfer");
            Console.WriteLine("4- Show Info");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {

                case 1:


                    b1.CreateAccount();
                    Console.WriteLine("Account Created Successfully");

                    break;


                case 2:
                    Console.Write("Withdraw Amount: ");
                    int y = int.Parse(Console.ReadLine());

                    if (y % 5 == 0)
                    {
                        b1.Withdraw(y);
                        Console.WriteLine("Withdraw Done");
                    }
                    else
                    {
                        Console.WriteLine("Invalid withdraw amount");
                    }
                    break;


                case 3:
                    Console.Write("Transfer Amount: ");
                    int x = int.Parse(Console.ReadLine());

                    if (x >= 1)
                    {
                        b1.Transfer(b2, x);
                        Console.WriteLine("Transfer Done");
                    }
                    else
                    {
                        Console.WriteLine("Invalid transfer amount");
                    }
                    break;


                case 4:
                    b1.PrintInfo();
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
   
