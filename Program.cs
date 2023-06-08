class program
{
    private static object access;
    public static string AccountHolderName { get; set; }
    public static decimal Balance { get; private set; }

    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        bool isRunning = true;
       
        while (isRunning)
        {
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Display Account Holder Name");
            Console.WriteLine("3. Display Balance");
            Console.WriteLine("4. Deposit Money");
            Console.WriteLine("5. Withdraw Money");
            Console.WriteLine("6. DisplayAllAccounts");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    account.CreateAccount();
                    break;
                case 2:
                    account.DisplayAccountDetails();
                    break;
                case 3:
                    account.DisplayBalance();
                    break;
                case 4:
                    Console.Write("Enter the account number: ");
                    string accountNumber = (Console.ReadLine());
                    Console.Write("Enter the amount to deposit: ");
                    decimal depositAmount = decimal.Parse(Console.ReadLine());
                    DepositMoney(depositAmount);
                    break;
                case 5:
                    //Console.Write("Enter the account number: ");
                    //string accountNumber = (Console.ReadLine());
                    Console.Write("Enter the amount to withdraw: ");
                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                    WithdrawMoney(withdrawAmount);
                    break;
                case 6:
                    DisplayAccountDetails();
                    break;
                case 8:
                    isRunning = false;
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
            Console.WriteLine();
        }
    }

  
}
