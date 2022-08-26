public class capitulo2
{
    public static void Main(string[] args)
    {

        double mul;
        double doble;
        double media1;
        double suma;
        double cantidad;
        double uno;
        double dos;
        double tres;
        double cuatro;
        double mont;

        Console.WriteLine("Capitulo 2");

        Console.WriteLine("");



        Console.WriteLine("2.3:");
        Console.WriteLine("algoritmo que lea un valor entero, lo doble, se multiplique por 25 y visualice el resultado");
        Console.WriteLine("");

        Console.WriteLine("Inserte un numero entero:");
        cantidad = Double.Parse(Console.ReadLine());
        doble = cantidad * 2;
        Console.WriteLine("El doble: " + doble);
        Console.WriteLine("El doble multiplicado por 25: " + doble * 25);

        Console.WriteLine("");
        Console.WriteLine("2.4:");
        Console.WriteLine("algoritmo que lea cuatro variables y calcule e imprima su producto,su suma y su media aritmetica");
        Console.WriteLine("");

        Console.WriteLine("Coloque cuatro variables:");
        uno = Double.Parse(Console.ReadLine());
        dos = Double.Parse(Console.ReadLine());
        tres = Double.Parse(Console.ReadLine());
        cuatro = Double.Parse(Console.ReadLine());
        suma = uno + dos + tres + cuatro;
        mul = uno * dos * tres * cuatro;

        media1 = suma / 4;
        Console.WriteLine("Suma:" + suma);
        Console.WriteLine("multiplicación:" + mul);
        Console.WriteLine("media aritmetica:" + media1);

        Console.WriteLine("");
        Console.WriteLine("2.15:");
        Console.WriteLine("algoritmo que calcule y escriba el cuadrado de 821");
        Console.WriteLine("");

        Console.WriteLine("el cuadrado de 821 es: " + Math.Pow(821, 2));

        Console.WriteLine("");
        Console.WriteLine("2.16:");
        Console.WriteLine("algoritmo que calcule la suma de los enteros entre 1 y 10");
        Console.WriteLine("");


        Console.WriteLine("La suma de los números enteros del uno al 10 es " + 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10);

        Console.WriteLine("");
        Console.WriteLine("2.17:");
        Console.WriteLine("algoritmo que calcule y visualice la potencia de 2 entre 0 y 10");
        Console.WriteLine("");


        for (mont = 0; mont <= 10; mont++)
        {
            Console.WriteLine(Math.Pow(mont, 2));
        }
    }
}