using System;

// interface 
public interface IBank
{
    void Withdraw(int amount);
    void Deposit(int amount);
}

// Real Subject 
public class Bank : IBank
{
    public void Withdraw(int amount)
    {
        Console.WriteLine("Withdrawing: " + amount);
    }
    public void Deposit(int amount)
    {
        Console.WriteLine("Depositing: " + amount);
    }
}

// Proxy Class 
public class BankProxy : IBank
{
    Bank bank;
    public BankProxy()
    {
        this.bank = new Bank();
    }
    public void Withdraw(int amount)
    {
        if (amount > 500)
            Console.WriteLine("You can not Withdraw more than 500");
        else
            bank.Withdraw(amount);
    }
    public void Deposit(int amount)
    {
        if (amount > 5000)
            Console.WriteLine("You can not Deposit more than 5000");
        else
            bank.Deposit(amount);
    }
}

// Client 
public class Program
{
    static void Main(string[] args)
    {
        BankProxy bankProxy = new BankProxy();

        // Withdrawing more than 500 
        bankProxy.Withdraw(600);

        // Depositing more than 5000 
        bankProxy.Deposit(6000);
    }
}