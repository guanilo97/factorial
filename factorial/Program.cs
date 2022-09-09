using System;

namespace factorial
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese  numero");
           int n1 = int.Parse(Console.ReadLine());
            var f = new factorialdenumero();
            var fac = f.Obtenerfactioral(n1);
            Console.WriteLine("el factorial es" + fac);
            Console.ReadLine();
        }
    }
}
