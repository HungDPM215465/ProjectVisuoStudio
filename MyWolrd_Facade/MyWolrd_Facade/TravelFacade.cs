using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWolrd_Facade
{
    public class TravelFacade
    {
        private Bank bank = new Bank();
        private PassportOffice passport = new PassportOffice();
        private Insurance insurance = new Insurance();

        public bool IsEligible(Traveler traveler, int amount)
        {
            Console.WriteLine("{0} is applying for a travel package costing {1:C}\n",
                traveler.Name, amount);

            bool eligible = true;

            if (!bank.HasSufficientFunds(traveler, amount))
            {
                eligible = false;
            }
            else if (!passport.IsPassportValid(traveler))
            {
                eligible = false;
            }
            else if (!insurance.HasValidInsurance(traveler))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
