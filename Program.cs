namespace laboratorio_PROI_06_16;

class Program
{
    static void Main(string[] args)
    {
        
    }
    static void Ejercicio1()
    {
        float [,] Mat = new float[,] {{45, 25, -10},{15, 38, 0}, {-20, 15.5f, 10.8f},{30,41,4}};
        float suma;
        ImprimirMatriz(Mat);
        Console.WriteLine();
        for(int c = 0; c <= Mat.GetUpperBound(1); c++){
            suma = 0;
            for(int f = 0; f <= Mat.GetUpperBound(0); f++){
                suma += Mat[f,c];
            }
            Console.WriteLine($"Suma Columna{c+1} = {suma}");
        }
    }
    static void Ejercicio3()
    {

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
}
