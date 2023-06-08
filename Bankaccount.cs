class BankAccount
{
    private static int accountCounter = 0;
   // private IEnumerable<BankAccount> accounts;

    static decimal Balance { get; set; }
    public static string AccountNumber { get; }
    public static string AccountHolderName { get; set; }
    public static string DisplayAccountDetails { get; set; }

    public BankAccount(string accountHolderName, decimal initialBalance)
    {
        AccountHolderName = accountHolderName;
        Balance = initialBalance;     
    }

    public BankAccount()
    {
        
    }
    protected virtual string GenerateAccountNumber()
    {
        accountCounter++;
        return "ACC" + accountCounter.ToString("D4");
    }
    public  void CreateAccount()
    {

        List<BankAccount> accounts = new List<BankAccount>();
        Console.Write("Enter account holder name: ");
        string accountHolderName = Console.ReadLine();
        Console.Write("Enter initial balance: ");
        decimal initialBalance = decimal.Parse(Console.ReadLine());
       
        BankAccount account = new BankAccount(accountHolderName, initialBalance);
        accounts.Add(account);

        Random random = new Random();
        int randomNumber = random.Next(1000, 9999); // Generate a random 4-digit number

        string accountNumber = "ACC" + accountCounter.ToString("D4") + randomNumber.ToString();

        Console.WriteLine("Your Account Number is : $ " + accountNumber);

        Console.WriteLine("Account created successfully!");
    }

    public static void DisplayAccountHolderName()
    {
        Console.WriteLine("Account Holder Name: " + AccountHolderName);
    }

    public static void DisplayBalance()
    {
        Console.WriteLine("Balance: $" + Balance);
    }

    public static void DepositMoney(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine("Successfully deposited $" + amount);
        }
        else
        {
            Console.WriteLine("Invalid amount! Deposit failed.");
        }
    }

    public static void WithdrawMoney(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("Successfully withdrawn $" + amount);
        }
        else
        {
            Console.WriteLine("Invalid amount or insufficient balance! Withdrawal failed.");
        }
    }

    public static void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Account Holder Name: " + AccountHolderName);
        Console.WriteLine("Balance: " + Balance);
    }
}

