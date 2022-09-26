
BankAccount myAccount = new BankAccount("Per");

Console.WriteLine($"Account owner is : {myAccount.name}");

myAccount.Deposit(2000);
Console.WriteLine($"Account balance is : {myAccount.Balance}");

myAccount.Withdraw(1500);
Console.WriteLine($"Account balance is : {myAccount.Balance}");
