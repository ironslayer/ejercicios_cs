using System;

public class Ejericios2
{
    // static int sumarMasCinco(int n)
    // {
    //     int respuesta = n + 5;
    //     return respuesta;
    // }

    // static void imprimirArreglo(int[] arreglo)
    // {
    //     for(int i=0; i<5; i++)
    //     {
    //         Console.Write(arreglo[i]+" ");
    //     }
    // }

    // static void sumarUnMonto(int n, int x)
    // {
    //     int respuesta = n + x;
    //     Console.WriteLine("Resultado2: "+respuesta);
    // }
    public static void Main(string[] args)
    {
        // int numero = 0;
        // string texto = "hola";
        // double numero2 = 0.01;
        // float numero3 = 0.121f;
        // bool mrespuesta = false;
        // Console.Write("Introduzca un número: ");
        // string valor = Console.ReadLine()!;
        // int n = int.Parse(valor);

        // if (10>n)
        // {
        //     Console.WriteLine (true);
        // }
        // else
        // {
        //     Console.WriteLine (false); 
        // }

        // for(int i=0; i<n; i++)
        // {
        //     Console.WriteLine(i+1); 
        // }

        // switch (n)
        // {
        //     case 1:
        //         Console.WriteLine("Respuesta1");
        //         break;
        //     case 2:
        //         Console.WriteLine("Respuesta2");
        //         break;
        //     case 3:
        //         Console.WriteLine("Respuesta3");
        //         break;
        //     default:
        //         Console.WriteLine("No se pudo hacer nada.");
        //         break;
        // }
        
        // Console.WriteLine("Sumando más 5: ");
        // int res = sumarMasCinco(n);
        // Console.WriteLine("Resultado: "+res);
        // Console.WriteLine("Sumando un monto por segunda funcion: ");
        // sumarUnMonto(n,100);


        // int[] numeros = new int[5];
        // numeros[0]=10;
        // numeros[1]=20;
        // numeros[2]=30;
        // numeros[3]=100;
        // numeros[4]=1000;

        // Console.WriteLine("Numero en la posicion 3: "+numeros[3]);

        // numeros[3] = numeros[3] * 2;

        // Console.WriteLine("Numero en la posicion 3 (x2): "+numeros[3]);


        // for(int i=0; i<5; i++)
        // {
        //     Console.Write("Introduzca numero "+(i+1)+": ");
        //     string valor = Console.ReadLine()!;
        //     int num = int.Parse(valor);
        //     numeros[i] = num;
        //      for(int j=0; j<5; i++)
        //     {
                
        //     }
        // }

        // Console.WriteLine("Imprimiendo valores del array...");
        // imprimirArreglo(numeros);
     
        // Console.WriteLine("Sumanado más 5 a cada valor del arreglo....");
        // Console.WriteLine();

        // for(int i=0; i<5; i++)
        // {
        //     numeros[i] = sumarMasCinco(numeros[i]);
        // }

        // Console.WriteLine("Imprimiendo valores del array despues de la suma...");
        // Console.WriteLine();
        // imprimirArreglo(numeros);
     
        Console.Write("Número de filas: ");
        int filas = int.Parse(Console.ReadLine());

        Console.Write("Número de columnas: ");
        int columnas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[filas, columnas];

        // Llenar la matriz pidiendo datos al usuario
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Imprimir la matriz
        Console.WriteLine("\n=== TU MATRIZ ===");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

         for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");

                if (matriz[i, j] % 2 == 0)
                {
                    Console.WriteLine("Es par"+ "\t");
                }else
                {
                    Console.WriteLine("Es impar"+ "\t");
                }
            }
            Console.WriteLine();
        }

    }

    

    
}