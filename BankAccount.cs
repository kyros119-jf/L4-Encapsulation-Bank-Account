public class BankAccount
{
    // Private fields protect account data from being changed directly
    private string accountNumber;
    private decimal balance;


    public string AccountNumber
    {
        get
        {
            return accountNumber;
        }
    } 

    public decimal Balance
    {
        get
        {
            return balance;
        }
    }

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        this.accountNumber = accountNumber;

        // Prevent an account from starting with a negative balance
        if (initialBalance < 0)
        {
            balance = 0;
        }
        else
        {
            balance = initialBalance;
        }   

    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }

        else
        {
            Console.WriteLine(" Deposit amount is invalid");
        }
      
    }

    public void Withdraw(decimal amount)
    {

        // Only withdraw when the amount is valid and enough money is available
        if ( amount > 0 && amount <= balance)
        {
            balance -= amount;

        }
        else
        {
            Console.WriteLine("Error: Insufficient Funds");
        }

    }
}