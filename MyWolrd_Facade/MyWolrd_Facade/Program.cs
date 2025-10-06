using System;

namespace MyWolrd_Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            TravelFacade travel = new TravelFacade();

           
            Traveler traveler = new Traveler("Lê Quốc Hưng");

           
            bool approved = travel.IsEligible(traveler, 50000);

            Console.WriteLine("\n" + traveler.Name +
                    " has been " + (approved ? "APPROVED" : "REJECTED") + " for the trip!");

            Console.ReadKey();
        }
    }
}

