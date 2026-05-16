using System;

public class Calculadora
{
    // ==================== SOBRECARGA DE MÉTODOS ====================
    // (Todo igual, solo cambio ObtenerNumeros y añado métodos de menú)

    // Versiones con arrays
    public static int Sumar(int[] numeros)
    {
        int total = 0;
        foreach (int n in numeros) total += n;
        return total;
    }

    public static double Sumar(double[] numeros)
    {
        double total = 0.0;
        foreach (double n in numeros) total += n;
        return total;
    }

    public static float Sumar(float[] numeros)
    {
        float total = 0f;
        foreach (float n in numeros) total += n;
        return total;
    }

    // Versiones con dos números
    public static int Sumar(int a, int b) => a + b;
    public static double Sumar(double a, double b) => a + b;
    public static float Sumar(float a, float b) => a + b;

    // Multiplicar (análogo)
    public static int Multiplicar(int[] numeros)
    {
        int total = 1;
        foreach (int n in numeros) total *= n;
        return total;
    }
    public static double Multiplicar(double[] numeros)
    {
        double total = 1.0;
        foreach (double n in numeros) total *= n;
        return total;
    }
    public static float Multiplicar(float[] numeros)
    {
        float total = 1f;
        foreach (float n in numeros) total *= n;
        return total;
    }
    public static int Multiplicar(int a, int b) => a * b;
    public static double Multiplicar(double a, double b) => a * b;
    public static float Multiplicar(float a, float b) => a * b;

    // Promedio
    public static double Promedio(int[] numeros) => Sumar(numeros) / (double)numeros.Length;
    public static double Promedio(double[] numeros) => Sumar(numeros) / numeros.Length;
    public static float Promedio(float[] numeros) => Sumar(numeros) / numeros.Length;

    // Factorial
    public static long Factorial(int n)
    {
        if (n < 0) return -1;
        long resultado = 1;
        for (int i = 1; i <= n; i++) resultado *= i;
        return resultado;
    }

    // EsPar
    public static bool EsPar(int numero) => numero % 2 == 0;

    // Función de control original (sin cambios)
    public static void CalcularYMostrar(char operacion, double[] numeros)
    {
        switch (operacion)
        {
            case '+':
                Console.WriteLine($"Suma: {Sumar(numeros)}");
                break;
            case '*':
                Console.WriteLine($"Producto: {Multiplicar(numeros)}");
                break;
            case 'A':
                Console.WriteLine($"Promedio: {Promedio(numeros)}");
                break;
            default:
                Console.WriteLine("Operación no válida.");
                break;
        }
    }

    // ----- NUEVA VERSIÓN DE ObtenerNumeros (SIN out) -----
    public static double[] ObtenerNumeros()
    {
        Console.Write("¿Cuántos números? ");
        int cantidad = int.Parse(Console.ReadLine() ?? "0");
        double[] arreglo = new double[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Número {i + 1}: ");
            arreglo[i] = double.Parse(Console.ReadLine() ?? "0");
        }
        return arreglo;
    }

    // ----- MÉTODOS AUXILIARES PARA EL MENÚ -----
    private static void EjecutarOperacionAritmetica(string operacion)
    {
        double[] nums = ObtenerNumeros();
        char oper = operacion == "sumar" ? '+' : (operacion == "multiplicar" ? '*' : 'A');
        CalcularYMostrar(oper, nums);
    }

    private static void EjecutarFactorial()
    {
        Console.Write("Ingrese un entero: ");
        int f = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Factorial: {Factorial(f)}");
    }

    private static void EjecutarEsPar()
    {
        Console.Write("Ingrese un entero: ");
        int x = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine(EsPar(x) ? "Sí es par" : "No es par");
    }
    public static void Main(string[] args)
    {
       
        string opcion = "";
        while (opcion.ToLower() != "salir")
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("SUMAR / MULTIPLICAR / PROMEDIO / FACTORIAL / ESPAR / SALIR");
            opcion = Console.ReadLine() ?? "";
            opcion = opcion.ToLower().Trim();

            switch (opcion)
            {
                case "sumar":
                case "multiplicar":
                case "promedio":
                    EjecutarOperacionAritmetica(opcion);
                    break;
                case "factorial":
                    EjecutarFactorial();
                    break;
                case "espar":
                    EjecutarEsPar();
                    break;
                case "salir":
                    Console.WriteLine("¡Adiós!");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        
    }
}