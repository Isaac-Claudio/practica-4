using System;

namespace Convertidor_de_Temperatura
{
    class Program
    {
        class prototipo
        {
            public void inicio()
            {
                Console.WriteLine("Por favor elija su formato de temperatura origen. 1 para F, 2 para C, 3 para K.");
            }

            public int Operacion(int a, int b)
            {
                int c;
                c = a + b;
                return c;
            }

        }
        class Kelvin
        {
            public void ResolucionKelvin()
            {
                int resultado;
                int Kelvin_Cel = -273;
                int valorKelvin;
                prototipo prototipo = new prototipo();
                Console.WriteLine("Ha seleccionado Kelvin. Ingrese el valor: ");
                valorKelvin = Convert.ToInt32(Console.ReadLine());

                resultado = prototipo.Operacion(valorKelvin, Kelvin_Cel);
                Console.WriteLine("El valor en Celsius es : "+ resultado);
                resultado = (prototipo.Operacion(valorKelvin, Kelvin_Cel) * 9 / 5) + 32;
                Console.WriteLine("El valor en Farenheit es: " + resultado);
            }


        }
        class Celsius
        {
            public void ResolucionCelsius()
            {
                prototipo prototipo = new prototipo();
                int resultado;
                int Celsius_Kel = 273;
                int valorCelsius;
                Console.WriteLine("Ha seleccionado Celsius. Ingrese el valor: ");
                valorCelsius = Convert.ToInt32(Console.ReadLine());

                resultado = prototipo.Operacion(valorCelsius, Celsius_Kel);
                Console.WriteLine("El valor en Kelvin es: " + resultado);
                resultado = ((valorCelsius / 5) * 9) + 32;
                Console.WriteLine("El valor en Farenheit es: " + resultado);
            }
        }
        class Farenheit
        {
            public void ResolucionFarenheit()
            {
                prototipo prototipo = new prototipo();
                int a;
                int resultado;
                int Farenheit_Kel = 273;
                int valorFarenheit;
                Console.WriteLine("Ha seleccionado Farenheit. Ingrese el valor: ");
                valorFarenheit = Convert.ToInt32(Console.ReadLine());

                a = ((valorFarenheit - 32) * 5 / 9);
                Console.WriteLine("El valor en Celsius es: " + a);
                resultado = prototipo.Operacion(valorFarenheit, Farenheit_Kel);
                Console.Write("El valor en Kelvin es: " + resultado);
            }
        }
        static void Main(string[] args)
        {
            prototipo prototipo = new prototipo();
            Kelvin kelvin = new Kelvin();
            Celsius celsius = new Celsius();
            Farenheit farenheit = new Farenheit();
            int input;
            prototipo.inicio();
            input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                farenheit.ResolucionFarenheit();
            }
            else if (input == 2)
            {
                celsius.ResolucionCelsius();

            }
            else if (input == 3)
            {
                kelvin.ResolucionKelvin();
            }
            Console.ReadKey();
            
           
        }
    }
}
