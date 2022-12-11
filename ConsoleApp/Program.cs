namespace Lab02_RecursivoFibonacci;
class Program
{
    static void Main(string[] args)
    {
        int n;
        int tiempo1, tiempo2, aux, aux2;
        do
        {
            Console.Write("Intorduzca el numero enesimo de la serie: ");
            n = int.Parse(Console.ReadLine());
            if (n <= 1)
            {
                Console.WriteLine("El numero no puede ser negativo o debe ser mayor a 0 y 1");
            }
        } while (n <= 1);
        Console.Write("Los numeros de la serie fibonacci en recursivo son: \n");
        tiempo1 = int.Parse($"{DateTime.Now:fffff}");
        for (int k = 0; k <= n; k++)
        {
            Console.WriteLine(FibonacciRecursivo(k));
        }
        tiempo2 = int.Parse($"{DateTime.Now:fffff}");
        aux = tiempo2 - tiempo1;
        Console.Write("El tiempo de ejecucion para la recursividad fue de " + aux + " milisegundos");
        Console.Write("\nLos numeros de la serie fibonacci en iterativo son: \n");
        tiempo1 = int.Parse($"{DateTime.Now:fffff}");
        fibonacciIterativo(n);
        tiempo2 = int.Parse($"{DateTime.Now:fffff}");
        aux2 = tiempo2 - tiempo1;
        Console.Write("El tiempo de ejecucion para la iteracion fue de " + aux2+ " milisegundos");
        if (aux < aux2)
        {
            Console.Write("\nLa recursividad fue mas rapida que la iteracion");
        }
        else
        {
            Console.Write("\nLa iteracion fue mas rapida que la recursividad");
        }
    }

    static long FibonacciRecursivo(int n)
    {
        if (n < 2) { return n; } else { return FibonacciRecursivo(n - 2) + FibonacciRecursivo(n - 1); }
    }

    static void fibonacciIterativo(int n)
    {
        long ant1, ant2;
        ant1 = ant2 = 1;
        Console.WriteLine("0 \n1 \n1");
        for (int i = 1; i <= n - 2; i++)
        {
            long actual = ant1 + ant2;
            Console.WriteLine(actual);
            ant2 = ant1;
            ant1 = actual;
        }
    }
}