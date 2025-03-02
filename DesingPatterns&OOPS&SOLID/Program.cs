//Encapsulation

using DesingPatterns_OOPS_SOLID.OopPrinciples.Encapsulation;

BankAccount bankAccount = new BankAccount(100);

Console.WriteLine(bankAccount.GetBalance());


bankAccount.Deposit(50);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.WithDraw(200);
Console.WriteLine(bankAccount.GetBalance());