using System;

namespace arayuzler_ornek
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********İNTERFACE********");
            X5 x5 = new X5();
            Console.WriteLine(x5.HangiMarkanınAraci().ToString());
            Console.WriteLine(x5.KacTekerlektenOlusur());
            Console.WriteLine(x5.StandartRengiNE().ToString());

            Console.WriteLine("************");
            A8 a8 = new A8();
            Console.WriteLine(a8.HangiMarkanınAraci().ToString());
            Console.WriteLine(a8.KacTekerlektenOlusur());
            Console.WriteLine(a8.StandartRengiNE().ToString());

            Console.WriteLine("*********ABSTRACT******");
            newX5 x51 = new newX5();
            Console.WriteLine(x51.HangiMarkanınAraci().ToString());
            Console.WriteLine(x51.KacTekerlektenOlusur());
            Console.WriteLine(x51.StandartRengiNE().ToString());

            Console.WriteLine("************");
            NewA8 a81 = new NewA8();
            Console.WriteLine(a81.HangiMarkanınAraci().ToString());
            Console.WriteLine(a81.KacTekerlektenOlusur());
            Console.WriteLine(a81.StandartRengiNE().ToString());

           
        }
    }
}