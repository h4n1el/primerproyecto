
namespace numeracion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("ingresa un numero, imbecil");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 70 && numero <= 80)
            {
                Console.WriteLine(" tu nota es C, jodio etupido");
            }
            else if (numero >= 80 && numero <= 90)
            {
                Console.WriteLine("cabron tu nota es B");
            }
            else if (numero >= 90 && numero <= 100)
            {
                Console.WriteLine("tu fucking nota es A mamabicho");
            }

            Console.ReadKey();
       


        }
    }
}

