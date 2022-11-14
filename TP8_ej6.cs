/*6) Precargar un arreglo con 10 valores enteros y programar un método de búsqueda en el
arreglo que permita determinar si un valor ingresado por el usuario existe dentro de dicho
arreglo.*/
using System;
namespace TP8C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int [] arregloNumeros ={10, 15, 254, -8, 35, 40 ,142, 45, 50};
            int valor;
            Console.WriteLine("Ingrese un valor: ");
            valor = Convert.ToInt32 (Console.ReadLine());
            buscarEnArreglo(arregloNumeros,valor);
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
        private static void buscarEnArreglo(int []numeros, int buscar)
        {
            bool encontrado =false;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros [i] == buscar)
                {
                    encontrado = true;
                }
            }
            Console.WriteLine(encontrado == true ? "El valor fue encontrado":"El valor no fue encontrado");
        }
    }
}