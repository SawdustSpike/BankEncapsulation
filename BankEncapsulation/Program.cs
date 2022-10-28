namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Welcome to your Automatic ATM Machine!");           
            var newAccount = new BankAccount();
            bool isNumber;
            double depo = 0.0;
            do
            {
                Console.WriteLine("Please enter the amount of money you would like to desposit.");
                isNumber = double.TryParse(Console.ReadLine(), out depo);
            }
            while (isNumber == false);

            newAccount.Deposit(depo);
            Console.WriteLine($"Your current account balance is ${newAccount.GetBalance()}");   

        }
    }
}
