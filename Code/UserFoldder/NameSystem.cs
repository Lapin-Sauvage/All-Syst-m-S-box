using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Systêm.UserFoler
{
    class NameSystem 
    {

        protected string name;
        protected string prefix;

        public NameSystem()
        {

        }

        public void SpawnName()
        {

            
            
            string namecommand = Console.ReadLine();

            if (namecommand == "!name")
            {
                Console.WriteLine("Mettez votre nom et prénom par la même occasion :");
                name = Console.ReadLine();

                

            }



            

        }

    }
}
