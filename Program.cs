BankAccount account = new BankAccount("123456" ,500 );

Console.WriteLine($"Account Number: {account.AccountNumber:F2}");
Console.WriteLine($"Balance: ${account.Balance:F2}\n");

Console.WriteLine("Depositing $100...");
account.Deposit(100);
Console.WriteLine($"Balance: ${account.Balance:F2}\n");

Console.WriteLine("Withdrawing $200...");
account.Withdraw(200);
Console.WriteLine($"Balance ${account.Balance:F2}\n");

Console.WriteLine("Withdrawing $1000...");
account.Withdraw(1000);
Console.WriteLine($"Balance ${account.Balance:F2}");
