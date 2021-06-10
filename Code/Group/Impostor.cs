using All_Systêm.UserFoler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Systêm.Group
{
    class Impostor : NameSystem
    {

        public Impostor()
        {


            bool PlayerImpostor = true;

            
        }
        // Importor Grade 
        public bool PlayerImpostor()
        {


            return false;
        }

        public bool ImpostorKill()
        {
            return false;
        }

        public void ImpostorVérification()
        {



            if (PlayerImpostor() == true) 
            {
                prefix = "Impostor";


            }


        }



    }
}
