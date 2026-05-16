using System;

public class EjericiosVectores
{
  
    public static void Main(string[] args)
    {
        // 1
        // Dado un arreglo A de tamanio N imprimir su arreglo adjunto acumulado C. Se
        // define como vector acumulado de A a un vector C del mismo tamanio tal que
        // todo elemento i-esimo en C es igual a la suma de los i elementos de A.

        // Ejemplo:
        // N = 5
        // A = { 7, 5, 0, 1, 5 }
        // Salida:
        // C = { 7, 12, 12 ,13, 18 }
        // Solucion

        // int N = int.Parse(Console.ReadLine());

        // string[] datos = Console.ReadLine().Split();

        // int[] A = new int[N];

        // for (int i = 0; i < N; i++)
        // {
        //     A[i] = int.Parse(datos[i]); 
        // }

        // int[] C = new int[N];

        // int sumaActual = 0;

        // for (int i = 0; i < N; i++)
        // {
        //     // sumaActual = sumaActual + A[i];
        //     sumaActual += A[i];
        //     C[i] = sumaActual;
        // }

        // Console.WriteLine("Imprimiendo vector C.....");
        // for (int i = 0; i < N; i++)
        // {
        //     Console.Write(C[i]+" ");
        // }




        
        // 2. Ivan es un chico muy amistoso, buscando el amor de su vida pero antes debe
        // saber cuanto tiene de promedio en sus examenes.En el colegio que esta tiene N
        // examenes(cosa que excesivo para Ivan) Ivan quiere saber cual es su promedio de
        // notas y ası poder empezar a buscar el amor de su vida. Dado N examenes seguidos
        // de N numeros que representan la nota de cada examen.Hallar el promedio de su
        // nota (parte entera).
        // Ejemplo Entrada  Ejemplo Salida
        // 5
        // 5 5 5 5 5        5
        // 6
        // 1 2 3 4 5 6      3

        // int N = int.Parse(Console.ReadLine());

        // string[] datos = Console.ReadLine().Split();

        // int[] notas = new int[N];

        // for (int i = 0; i < N; i++)
        // {
        //     notas[i] = int.Parse(datos[i]);
        // }

        // int suma = 0;

        // for (int i = 0; i < N; i++)
        // {
        //     suma = suma + notas[i];
        //     // suma += notas[i];
        // }

        // int promedio = suma / N;

        // Console.WriteLine("Promedio: "+promedio);



        // 3. 
        // Elabora un algoritmo que dado un vector de enteros X, devuelva un nuevo vector
        // Y con los elementos de X, pero sin repetir ningun numero.
        // Entrada: X = { 2, 3, 4, 5, 6, 3, 4, 6, 8, 5, 6, 2, 9, 0, 1, 2 }
        // Salida: Y = { 2, 3, 4, 5, 6, 8, 9, 0, 1 }

        // Solucion



        // Sumar todos los elementos de la matriz
        
        // FxC
        // Ejemplo
        // 2 3
        // Matriz
        // 1 2 3
        // 4 5 6

        // salida
        // 1 + 2 + 3 + 4 + 5 + 6 = 21

        // string[] dims = Console.ReadLine().Split();

        // int F = int.Parse(dims[0]);
        // int C = int.Parse(dims[1]);

        // int[,] matriz = new int[F,C];

        // for (int i = 0; i < F; i++)
        // {
        //     string[] fila = Console.ReadLine().Split();
        //     for (int j = 0; j < C; j++)
        //     {
        //       matriz[i,j] = int.Parse(fila[j]);  
        //     }
        // }

        // int suma = 0;

        // for (int i = 0; i < F; i++)
        // {
        //     for (int j = 0; j < C; j++)
        //     {
        //         suma = suma + matriz[i,j];
        //     }
        // }

        // Console.WriteLine("La suma de los elementos de la matriz es: "+suma);



        // Imprimir la diagonal principal de la matriz

        // N=3

        // EJEMPLO:


        // 1 2 3
        // 4 5 6
        // 7 8 9

        // SALIDA:

        // 1 5 9

        int N= int.Parse(Console.ReadLine());

        int[,] matrizCuadrada = new int [N,N];

        for (int i = 0; i < N; i++)
        {
            string[] fila = Console.ReadLine().Split();
            for (int j = 0; j < N; j++)
            {
                matrizCuadrada[i,j] = int.Parse(fila[j]);
            }
        }

        Console.WriteLine("La diagonal princial es:");
        for (int i = 0; i < N; i++)
        {
            Console.Write(matrizCuadrada[i,i]+" ");
        }

    }

    

    
}