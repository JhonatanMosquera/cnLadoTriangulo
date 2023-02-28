using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnLadoTriangulo
{
    /// <summary>
    /// Nombre: Jhonatan Stiven Mosquera Moreno
    /// fecha: 24/02/2023
    /// descripcion: Ladotriangulo
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor ingrese el primero lado de triangulo");
            double lado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el segundo lado de triangulo");
            double lado2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el tercer lado de triangulo");
            double lado3 = Convert.ToDouble(Console.ReadLine());
            //instanciamos el metodo para saber cual lado es mayor
            LadoMayor(lado1, lado2, lado3);
            //instanciamos el metodo para saber si es equilatero
            CompararEquilatero(lado1, lado2, lado3);
            Console.ReadKey();
        }

        //metodo para saber cual lado es mayor
        public static void LadoMayor(double lado1, double lado2, double lado3)
        {

            if (lado1 > lado2 && lado1 > lado3)
            {

                Console.WriteLine("El lado mayor es el 1");

            }
            else if (lado2 > lado1 && lado2 > lado3)
            {

                Console.WriteLine("El lado mayor es el 2");

            }
            else if (lado3 > lado1 && lado3 > lado2)
            {
                Console.WriteLine("El lado mayor es el 3");
            }
            else
            {
                Console.WriteLine("Hay dos o 3 lados iguales");
            }

        }

        public static void CompararEquilatero(double lado1, double lado2, double lado3)
        {
            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("Es un triangulo equilatero");
            }
            else
            {
                Console.WriteLine("No es un triangulo equilatero");
            }

        }


    }

}
