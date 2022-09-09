using System;
using System.Collections.Generic;
using System.Text;

namespace factorial
{
   public  class factorialdenumero
    {
        public int Obtenerfactioral(int n1)
        {
            int fac = 1;
            for (int i = 1; i <= n1; i++)
            {
                fac = fac * i;
            }
            return fac;

        }
    }
}
