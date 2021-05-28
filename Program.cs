using System;

namespace Arrays2dimesiones
{
    class Program
    {
        static void Main(string[] args)

            
        {

            const int Filas = 2, Columnas = 5;
            float[,] Datos = new float[2, 5];

            for (int fila = 0; fila < Filas; fila++)
            {
                for (int columna = 0; columna < Columnas; columna++)
                {

                    Console.WriteLine("Ingrese el dato {0},{1}", fila+1, columna+1);
                    Datos[fila, columna] = Convert.ToSingle(Console.ReadLine()); 
                }
            }


        }
    }
}
