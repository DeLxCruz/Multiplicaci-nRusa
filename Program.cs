internal class Program
{
    private static void Main(string[] args)
    {
        // Desarrolle un programa que reciba como entrada el multiplicador y el multiplicando, y entregue
        // como resultado el producto de ambos, calculado mediante el método de multiplicación rusa.

        int multiplicador = 0;
        int multiplicando = 0;
        int resultado = 0;

        Console.WriteLine("Ingrese el multiplicador: ");
        multiplicador = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el multiplicando: ");
        multiplicando = int.Parse(Console.ReadLine());

        while (multiplicador >= 1)
        {
            if (multiplicador % 2 != 0)
            {
                resultado += multiplicando;
            }

            multiplicador /= 2;
            multiplicando *= 2;
        }

        Console.WriteLine("El resultado es: " + resultado);

        Console.ReadKey();
    }
}