using System;

namespace matrizAsteriscosHuecoAlcentro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el tamanio de la matriz: ");
            int tamanioMatriz =int.Parse( Console.ReadLine());
            char[,] matrizAsteriscos = new char[tamanioMatriz, tamanioMatriz];

            creaMatrizAstericos(tamanioMatriz, matrizAsteriscos);
            muestraMatrizAstericos(tamanioMatriz, matrizAsteriscos);

        }

        private static void creaMatrizAstericos(int tamanioMatriz, char[,] matrizAsteriscos)
        {
            for (int i = 0; i < tamanioMatriz; i++)
            {
                for (int j = 0; j < tamanioMatriz; j++)
                {

                    matrizAsteriscos[i, j] = ('*');
                }
                
            }
            // reemplazando los valores con * por espacios en blanco
            for (int k = 1; k < tamanioMatriz - 1; k++)
            {
                for (int p = 1; p < tamanioMatriz - 1; p++)
                {
                    matrizAsteriscos[k, p] = (' ');
                }
               
            }
        }

        public static void muestraMatrizAstericos(int tam, char[,] matriz)
        {

            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
       
        }
     
    }
}
