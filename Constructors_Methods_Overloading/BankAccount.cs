using static System.Net.Mime.MediaTypeNames;

namespace Constructors_Methods_Overloading
{
    public class BankAccount
    {
        //Feilds
        private string _name;
        private string _accountNumber;
        private double _balance;

        //Constructor
        public BankAccount(string AccountNumber, string Name, double Balance)
        {
            _name = Name;
            _accountNumber = AccountNumber;
            _balance = Balance;
        }

        //Properties
        public string Name { get => _name; set => _name = value; }
        public string AccountNumber { get => _accountNumber; }
        public double Balance { get => _balance;}

        //Methods
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
            }
        }

        public override string ToString()
        {
            return $"{AccountNumber} - {Name} - Current Balance: {_balance.ToString("c")}";
        }
    }

}