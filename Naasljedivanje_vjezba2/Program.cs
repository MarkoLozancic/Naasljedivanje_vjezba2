using System;

namespace Naasljedivanje_vjezba2
{
    class ProgramskiJezik
    {
        double postotak;

        public double Postotak { get => postotak; set => postotak = value; }

        public void Postotci()
        {

        }
    }
    class Proceduralni:ProgramskiJezik
    {
    }
    class Objektni : ProgramskiJezik
    { 
    }
    class Funkcionalni : ProgramskiJezik
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
          
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();
            do
            {
                Console.WriteLine("Unesi postotak proceduralnog, objektnog te funkcionalnog tipa programa: ");
                int postotak = Convert.ToInt32(Console.ReadLine());
                x.Postotak = postotak;
                postotak = Convert.ToInt32(Console.ReadLine());
                y.Postotak = postotak;
               postotak = Convert.ToInt32(Console.ReadLine());
                z.Postotak = postotak;
                if (x.Postotak + y.Postotak + z.Postotak != 100)
                {
                    Console.WriteLine("Krivi unos, molim te ponovi!");
                }
            }
            while (x.Postotak + y.Postotak + z.Postotak != 100);

            if (x.Postotak >= y.Postotak && x.Postotak >= z.Postotak)
            { Console.WriteLine("Najvecim postotkom je programski jezik Proceduralni!"); } 
            else if(y.Postotak >= x.Postotak && y.Postotak >= z.Postotak)
            { Console.WriteLine("Najvecim postotkom je programski jezik Objektni!"); }
            else
            { Console.WriteLine("Najvecim postotkom je programski jezik Funkcionalni!"); }
            Console.ReadKey();
        }
    }
}
