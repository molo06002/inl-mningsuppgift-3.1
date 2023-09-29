using System;
namespace inlämningsuppgift1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till tekikums tävling. För att du ska kunna delta måste du vara 16 - 19 år gammal.");
            Console.WriteLine("Skriv in ditt ålder här: ");
            string x = Console.ReadLine();
            int y = Convert.ToInt32(x);
            Console.Clear();
            switch (y)
            {
                case 16:
                    Console.WriteLine("Du är 16 år gammal, du får delta i tävlingen");
                    break;

                case 17:
                    Console.WriteLine("Du är 17 år gammal, du får delta i tävlingen");
                    break;

                case 18:
                    Console.WriteLine("Du är 18 år gammal, du får delta i tävlingen");
                    break;

                case 19:
                    Console.WriteLine("Du är 19 år gammal, du får delta i tävlingen");
                    break;

                default:
                    Console.WriteLine("Du är antingen över 19 år gammal eller under 16, du får inte delta i tävlingen");
                    break;
            }

        }
    }
}