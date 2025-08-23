public class Program
{
    public static void Main(string[] args)
    {
        sumaHastaN();
        imprimirNumero();
        tablaMultiplicar();
        AreaCirculo();
        JerarquiaNumeros();
    }


    public static void imprimirNumero()
    {
         int i;
         for (i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }


    }

    public static void sumaHastaN()
    {
         Console.WriteLine("ingrese el numero limite de sumas");
         int limite = Convert.ToInt32(Console.ReadLine());
         int suma = 0;
         int i;

        for (i = 1; i <= limite; i++)
        {
            suma += i;

            Console.WriteLine($"la suma de los numero hasta {limite} es igual a {suma}");
        }
    }

    public static void tablaMultiplicar()
    {
         Console.WriteLine("Ingrese un numero");
         int numero = Convert.ToInt32(Console.ReadLine());
         int i;



         for (i = 1; i <= 10; i++)
        {
            int multiplicacion = numero * i;
            Console.WriteLine($"la tabla de multiplicacion de {numero} es igual a {multiplicacion}");
        }

    }
    public static void AreaCirculo()
    {
        Console.WriteLine("Ingresa el radio del circulo");
        double radio = Convert.ToInt32(Console.ReadLine());
        double pi = Math.PI;

        double area = pi * (radio * radio);
        Console.WriteLine($"el area del circulo es {area}");
    }
    public static void JerarquiaNumeros()
    {
        Console.WriteLine("Ingrese el primer numero");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if ((num1 > num2) && (num1 > num3))
        {
            Console.WriteLine($"{num1} es mayor que {num2} y mayor que {num3}");
        }
        else if ((num2 > num1) && (num2 > num3))
        {
            Console.WriteLine($"{num2} es mayor que {num1} y mayor que {num3}");
        }
        else
        {
            Console.WriteLine($"{num3} es mayor");
        }

    }
    }



    
        