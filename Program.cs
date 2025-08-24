

namespace recursividad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ingresa el numero de inicio de la recursividad");
            int numero = Convert.ToInt32(Console.ReadLine());
            recursividad(numero);
        }
        public static void recursividad(int numero)
        {
            if (numero <= 0)
            {
                Console.WriteLine("fin de la cuenta regresiva");
                return;
            }
            Console.WriteLine($"contando {numero}");
            recursividad(numero - 1);
        }


    }
    
}
// crea un codigo de recursividad y luego subelo a git hub
