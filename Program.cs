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

                    Console.WriteLine("Ingrese el dato {0},{1} ", fila+1, columna+1);
                    Datos[fila, columna] = Convert.ToSingle(Console.ReadLine()); 
                }
            }

            for (int fila = 0; fila < Datos.GetLength(0); fila++)
            {
                float sumaFila = 0;
                for (int columna = 0; columna < Datos.GetLength(1); columna++)
                {

                    sumaFila += Datos[fila, columna];

                }
                Console.WriteLine("la media de la fila es " +
               sumaFila / Datos.GetLength(1));
                
            }

           float sumaTotal = 0;
            foreach (float f in Datos)
            {
                sumaTotal += f;
            }
            Console.WriteLine("la media de la fila es " +
             sumaTotal / Datos.Length);


        }
    }
}
