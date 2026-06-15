using System;
using System.Collections.Generic;

class User
{
    public string Name;
    public string Password;
    public double Balance;

    public User(string name, string password)
    {
        Name = name;
        Password = password;
        Balance = 0;
    }
}

class Transaction
{
    public string Type;
    public double Amount;
    public DateTime Date;

    public Transaction(string type, double amount)
    {
        Type = type;
        Amount = amount;
        Date = DateTime.Now;
    }
}

class PaySecure
{
    static Dictionary<string, User> users = new Dictionary<string, User>();
    static List<Transaction> history = new List<Transaction>();

    static User currentUser = null;

    static void Register()
    {
        Console.Write("Enter Username: ");
        string name = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        if (!users.ContainsKey(name))
        {
            users.Add(name, new User(name, password));
            Console.WriteLine("Registration Successful!");
        }
        else
        {
            Console.WriteLine("User already exists!");
        }
    }

    static void Login()
    {
        Console.Write("Enter Username: ");
        string name = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        if (users.ContainsKey(name) &&
            users[name].Password == password)
        {
            currentUser = users[name];
            Console.WriteLine("Login Successful!");
            UserMenu();
        }
        else
        {
            Console.WriteLine("Invalid Username or Password");
        }
    }

    static void AddMoney()
    {
        Console.Write("Enter Amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        currentUser.Balance += amount;

        history.Add(new Transaction("Money Added", amount));

        Console.WriteLine("Money Added Successfully!");
    }

    static void SendMoney()
    {
        Console.Write("Enter Amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount <= currentUser.Balance)
        {
            currentUser.Balance -= amount;

            history.Add(new Transaction("Money Sent", amount));

            Console.WriteLine("Money Sent Successfully!");
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }

    static void CheckBalance()
    {
        Console.WriteLine("Current Balance = ₹" + currentUser.Balance);
    }

    static void ViewHistory()
    {
        Console.WriteLine("\nTransaction History");

        foreach (Transaction t in history)
        {
            Console.WriteLine(
                t.Type + " | ₹" +
                t.Amount + " | " +
                t.Date);
        }
    }

    static void UserMenu()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== PAYSECURE MENU =====");
            Console.WriteLine("1. Add Money");
            Console.WriteLine("2. Send Money");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Transaction History");
            Console.WriteLine("5. Logout");

            Console.Write("Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddMoney();
                    break;

                case 2:
                    SendMoney();
                    break;

                case 3:
                    CheckBalance();
                    break;

                case 4:
                    ViewHistory();
                    break;

                case 5:
                    Console.WriteLine("Logged Out Successfully!");
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

        } while (choice != 5);
    }

    public static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== PAYSECURE =====");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");

            Console.Write("Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Register();
                    break;

                case 2:
                    Login();
                    break;

                case 3:
                    Console.WriteLine("Thank You!");
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

        } while (choice != 3);
    }
}