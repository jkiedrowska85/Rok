// See https://aka.ms/new-console-template for more information
namespace Rok
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());

            if (i % 4 == 0)
            {
                Console.WriteLine("Rok przestępny");
            }
            else
            if (i % 100 == 0 && i <= 100 )
            {
                Console.WriteLine("Rok przestępny");
            }
            else
            if (i % 400 == 0 && i <= 400)
            {
                Console.WriteLine(" Rok przestępny");
            }
            else
                Console.WriteLine(" Rok nieprzestępny");
        }
    }
}
