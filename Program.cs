namespace laboratorio_PROI_06_16;

class Program
{
  static void Main(string[] args)
  {

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

  }
  static void Ejercicio7()
  {

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
