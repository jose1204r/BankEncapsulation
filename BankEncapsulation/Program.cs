namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************CODERS BANK******************"); // APP TITLE 



            Console.WriteLine("PLEASE ENTER YOUR DEPOSIT : "); // APP MESSAGE 
            var userDeposit = double.Parse(Console.ReadLine()); // USER DEPOSIT IMPUT 
            var newAccount = new BankAccount(); // CLASS 
            newAccount.Deposit(userDeposit); // USER DEPOSIT
            var userBalance = newAccount.GetBalance(); //  RETURN ACCOUNT BALANCE
                                                       

            // DEPOSIT AND ACCOUNT BALANCE PRINT MESSAGE 
            Console.WriteLine($" YOUR DEPOSITED OF ${userDeposit} HAS BEEN PROCESSED YOUR NEW BALANCE IS : ${userBalance}");
        }
    }
}
