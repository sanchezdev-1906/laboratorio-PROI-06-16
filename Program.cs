namespace laboratorio_PROI_06_16;

class Program
{
    static void Main(string[] args)
    {
        int op;
        do
        {
            Console.Clear();
            Console.WriteLine("MENU DE OPCIONES");
            Console.WriteLine("1. Problema 1");
            Console.WriteLine("3. Problema 3");
            Console.WriteLine("5. Problema 5");
            Console.WriteLine("7. Problema 7");
            Console.WriteLine("9. Problema 9");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Digite una opcion");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out op))
            {
                Console.WriteLine("No es valido");
                op = -1;
            }

            switch (op)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 3:
                    Ejercicio3();
                    break;
                case 5:
                    Ejercicio5();
                    break;
                case 7:
                    Ejercicio7();
                    break;
                case 9:
                    Ejercicio9();
                    break;
                case 0:
                    Console.WriteLine("El program terminó");
                    break;
                default:
                    Console.WriteLine("Digite una opcion");
                    break;
            }
            Console.Write("Digite una tecla... ");
            Console.ReadKey();
        } while (op != 0);

    }
    static void Ejercicio1()
    {
        float[,] Mat = new float[,] { { 45, 25, -10 }, { 15, 38, 0 }, { -20, 15.5f, 10.8f }, { 30, 41, 4 } };
        float suma;
        ImprimirMatriz(Mat);
        Console.WriteLine();
        for (int c = 0; c <= Mat.GetUpperBound(1); c++)
        {
            suma = 0;
            for (int f = 0; f <= Mat.GetUpperBound(0); f++)
            {
                suma += Mat[f, c];
            }
            Console.WriteLine($"Suma Columna{c + 1} = {suma}");
        }
    }
    static void Ejercicio3()
    {
        int n;
        Console.WriteLine("Ingrese la dimension de la matriz.");
        string entrada = Console.ReadLine();
        if (!(int.TryParse(entrada, out n)) && int.Parse(entrada) < 1)
        {
            Console.WriteLine("El tamaño no es valido");
            return;
        }

        float[,] matriz = new float[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = i == j ? 1 : 0;
            }
        }

        ImprimirMatriz(matriz);
    }
    static void Ejercicio5()
    {
        Console.Write("Tamaño de la matriz: ");
        int N = int.Parse(Console.ReadLine());
        int[,] MatTri = new int[N, N];
        int x = 0;
        for (int f = 0; f < N; f++)
        {
            for (int c = 0; c <= x; c++)
            {
                MatTri[f, c] = c > f ? 0 : 1;
            }
        }
        ImprimirMatriz(MatTri);
    }
    static void Ejercicio7()
    {
        int n;
        Console.WriteLine("Ingrese la dimension de la matriz.");
        string entrada = Console.ReadLine();
        if (!(int.TryParse(entrada, out n)) && int.Parse(entrada) < 1)
        {
            Console.WriteLine("El tamaño no es valido");
            return;
        }

        float[,] matriz = new float[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = new Random().NextInt64(-100, 100);
            }
        }
        Console.WriteLine("Matriz desordenada");
        ImprimirMatriz(matriz);

        Array.Sort(matriz);
        Console.WriteLine("Matriz ordenada");
        ImprimirMatriz(matriz);
    }
    static void Ejercicio9()
    {

    }

    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i <= matriz.GetUpperBound(0); i++)
        {
            Console.Write("\n");
            for (int j = 0; j < matriz.GetUpperBound(1); j++)
            {
                Console.Write($"{matriz[i, j]} ");
            }
        }
        Console.Write("\n");
    }
    static void ImprimirMatriz(float[,] matriz)
    {
        for (int i = 0; i <= matriz.GetUpperBound(0); i++)
        {
            Console.Write("\n");
            for (int j = 0; j <= matriz.GetUpperBound(1); j++)
            {
                Console.Write($"{matriz[i, j]} ");
            }
        }
        Console.Write("\n");
    }
    static void ImprimirMatriz(double[,] matriz)
    {
        for (int i = 0; i <= matriz.GetUpperBound(0); i++)
        {
            Console.Write("\n");
            for (int j = 0; j <= matriz.GetUpperBound(1); j++)
            {
                Console.Write($"{matriz[i, j]} ");
            }
        }
        Console.Write("\n");
    }
    static void ImprimirMatriz(string[,] matriz)
    {
        for (int i = 0; i <= matriz.GetUpperBound(0); i++)
        {
            Console.Write("\n");
            for (int j = 0; j <= matriz.GetUpperBound(1); j++)
            {
                Console.Write($"{matriz[i, j]} ");
            }
        }
        Console.Write("\n");
    }
}
