using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWolrd_Facade
{
    public class PassportOffice
    {
        public bool IsPassportValid(Traveler t)
        {
            Console.WriteLine("Verifying passport for " + t.Name + "...");
           
            return true;
        }
    }
}
