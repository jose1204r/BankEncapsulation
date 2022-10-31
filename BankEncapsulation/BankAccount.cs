using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double Balance = 0; // PRIVATE 

        public void Deposit(double deposit) // DEPOSIT 
        {

            Balance += deposit;

        }

        public double GetBalance() // RETURN BALANCE 
        {
            
           
            return Balance;
        
        
        }


    }
}
