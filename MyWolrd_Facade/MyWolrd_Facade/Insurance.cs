using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWolrd_Facade
{
    public class Insurance
    {
        public bool HasValidInsurance(Traveler t)
        {
            Console.WriteLine("Checking travel insurance for " + t.Name + "...");
            
            return true;
        }
    }
}
