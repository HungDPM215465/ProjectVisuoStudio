using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWolrd_Facade
{
    public class Bank
    {
        public bool HasSufficientFunds(Traveler t, int amount)
        {
            Console.WriteLine("Checking bank account for " + t.Name + "...");
        
            return true;
        }
    }
}
