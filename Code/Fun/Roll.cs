using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Systêm
{
    class Roll
    {

        

        public Roll()
        {
            RollSystêm();
        }

        public void RollSystêm()
        {

            string rollCommande = Console.ReadLine();

            if (rollCommande == "!roll")
            {
                Random rdm = new Random();
                int Number = rdm.Next(0, 100);

                Console.WriteLine(Number);
            }

            
        }


    }
}
