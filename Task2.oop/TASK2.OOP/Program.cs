
using System;

class BankAccount
{
    private string accountNumber;
    private string accountHolderName;
    private double balance;
    private string accountType;
    private string branchName;

    public BankAccount(string accNum, string holderName, double bal, string type, string branch)
    {
        accountNumber = accNum;
        accountHolderName = holderName;

        if (bal >= 0)
            balance = bal;
        else
        {
            Console.WriteLine("Error: Initial balance cannot be negative!");
            balance = 0;
        }

        accountType = type;
        branchName = branch;
    }

    ~BankAccount()
    {
        Console.WriteLine("BankAccount object is destroyed.");
    }

    public string AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public string AccountHolderName
    {
        get { return accountHolderName; }
        set { accountHolderName = value; }
    }

    public double Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
                balance = value;
            else
                Console.WriteLine("Error: Balance cannot be negative!");
        }
    }
    public string AccountType
    {
        get { return accountType; }
        set { accountType = value; }
    }

    public string BranchName
    {
        get { return branchName; }
        set { branchName = value; }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposit successful. New Balance: " + balance);
        }
        else
        {
            Console.WriteLine("Error: Deposit amount must be positive!");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdraw successful. New Balance: " + balance);
        }
        else
        {
            Console.WriteLine("Error: Insufficient balance or invalid amount!");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine("------ Account Information ------");
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolderName);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("Account Type: " + accountType);
        Console.WriteLine("Branch Name: " + branchName);
        Console.WriteLine("--------------------------------");
    }
}

class Program
{
    static void Main()
    {
       
        BankAccount acc1 = new BankAccount(
            "112",
            "Noor Mahmoud",
            1500,
            "Saving",
            "Amman Branch"
        );

        acc1.Deposit(500);
        acc1.Withdraw(300);
        acc1.DisplayInfo();

        Console.WriteLine();

        
        BankAccount acc2 = new BankAccount(
            "2002",
            "Salsabeel Ali",
            210,
            "Current",
            "Irbid Branch"
        );

        acc2.Withdraw(2000);   
        acc2.Deposit(-100);    
        acc2.DisplayInfo();
    }
}