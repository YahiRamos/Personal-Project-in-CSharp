using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRPERSONAL
{
    class validadores
    {
        public static bool num(char e)
        {
            string CHP = "0123456789\b";
            bool existe;
            existe = CHP.Contains(e);
            if(existe==true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
