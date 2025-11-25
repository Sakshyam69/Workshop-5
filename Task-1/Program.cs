using System;

BankAccount acc = new BankAccount("ACCSakshyam", 12200);
Console.WriteLine("Account Number: " + acc.AccountNumber);
acc.Deposit(500);
acc.Withdraw(200);
Console.WriteLine("Remaining Balance = " + acc.Balance);