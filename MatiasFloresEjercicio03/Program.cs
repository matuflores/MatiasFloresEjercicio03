using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatiasFloresEjercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Obtener equivalente de grados Celsius en grados Fahrenheit";

            double gradosCelsius, gradosFahrenheit;
            double mayorTemperatura, temperaturaMasAlta;
            double promeidodDeTemperaturas, sumaDeTemperaturas;
            int cantidadDeTemperaturas;

            Console.WriteLine("Ingrese la cantidad de temperaturas que");
            Console.Write("desee conocer su equivalente en Fahrenheit: ");
            cantidadDeTemperaturas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" "); //Escribo este "espacio" para que haya una separacion en cada ciclo.

            sumaDeTemperaturas = 0;
            mayorTemperatura = -70;

            for (int contador = 1; contador < cantidadDeTemperaturas+1; contador++)
            {
                do
                {
                    Console.Write($"Ingrese {contador}° temperatura en grados celsius: ");
                    gradosCelsius = Convert.ToDouble(Console.ReadLine());
                } while (gradosCelsius<-70 || gradosCelsius>60);

                gradosFahrenheit = convertirCelsiusAFahrenheit(gradosCelsius);
                sumaDeTemperaturas = sumaDeTemperaturas + gradosCelsius;

                if (gradosCelsius>mayorTemperatura)
                {
                    temperaturaMasAlta = contador;
                    mayorTemperatura = gradosCelsius;
                }
                Console.WriteLine($"El equivalente de {gradosCelsius}° Celsius en Fahrenheit es: {gradosFahrenheit}");

                Console.WriteLine(" "); //Escribo este "espacio" para que haya una separacion en cada ciclo.
            }

            promeidodDeTemperaturas = sumaDeTemperaturas / cantidadDeTemperaturas;

            Console.WriteLine($"La temperatura mas alta es: {mayorTemperatura}° Celsius");
            Console.WriteLine($"El promedio de temperaturas en grados Celsius es: {promeidodDeTemperaturas}");

            Console.ReadLine();
        }

        private static double convertirCelsiusAFahrenheit(double gradosCelsius)
        {
            return 1.8 * gradosCelsius + 32;
        }
    }
}
