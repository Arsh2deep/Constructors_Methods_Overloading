namespace Constructors_Methods_Overloading;
class Program
{
    static void Main(string[] args)
    {

        Car Defaultcar = new Car();
        Car carMakeModel = new Car("Toyota", "Rav4");
        Car Fullcar = new Car(2010,"Hyundai","Sonata",10000);
        Console.WriteLine(Defaultcar);
        Console.WriteLine(carMakeModel);
        Console.WriteLine(Fullcar);

        Console.WriteLine();

        Console.WriteLine("Bank Information");

        BankAccount bankAccount = new BankAccount("12345","Will Cram",20);
        Console.WriteLine(bankAccount.ToString());
        //Deposit 500 
        bankAccount.Deposit(500);
        Console.WriteLine(bankAccount.ToString());
        //Deposit -15000
        bankAccount.Deposit(-15000);
        Console.WriteLine(bankAccount.ToString());
        // Withdraw 300 from the account
        bankAccount.Withdraw(300);
        Console.WriteLine(bankAccount.ToString());
        //Withdraw -500 
        bankAccount.Withdraw(-500);
        Console.WriteLine(bankAccount.ToString());
    }

}

