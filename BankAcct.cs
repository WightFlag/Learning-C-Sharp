using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dBanasTuts
{
    class BankAcct
    {
        private Object acctLock = new object();
        double Balance { get; set; }    

        public BankAcct(double bal)
        {
            Balance = bal;
        }

        public double Withdraw(double amt)
        {
            if((Balance -  amt) < 0)
            {
                Console.WriteLine($"sorry ${Balance} in Account.");
                return Balance;
            }

            lock (acctLock)
            {
                if (Balance >= amt)
                {
                    Console.WriteLine("Remove {0} and {1} left in Account", amt, (Balance - amt));
                    Balance -= amt;
                }
                return Balance;
            }
        }
        public void IssueWithdraw()
        {
            Withdraw(1);
        }
    }
}
