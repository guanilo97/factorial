using factorial;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace FactorialTesting
{
    class factorialTest
    {
        [Test]
        public void Caso1obtenerFactorial()
        {
            var factorial = new factorialdenumero();
            var f = factorial.Obtenerfactioral(5);

            Assert.AreEqual(120,f);

        }
    }
}
