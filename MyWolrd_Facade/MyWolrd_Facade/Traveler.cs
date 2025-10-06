using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWolrd_Facade
{
    public class Traveler
    {
        private string name;

        public Traveler(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
