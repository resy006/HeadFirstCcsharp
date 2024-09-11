using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Guy
    {
        public string Name;
        public int Cash;

        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " Buck.");
        }

        public int GiveCashs(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + "isn't a vaild amount.");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine(Name + " says: " + "i don't have enough cash to give you " + amount);
                return 0;
            }
            Cash -= amount;
            return amount;
        }

        public void ReceiveCashs(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("0 Cashs");
            }
            else
            {
                Cash+= amount;
            }
        }

    }
}
