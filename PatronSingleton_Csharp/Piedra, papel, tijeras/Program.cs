using System;

namespace Piedra__papel__tijeras
{
    class Reglas 
    {
        private readonly static Reglas instance = new Reglas();
        
        private Reglas()
        {
            Console.WriteLine("Bienvenido a piedra, papel, tijeras. Escriba 1 para piedra, 2 para papel y 3 para tijeras. Papel le gana a piedra, piedra le gana a tijeras y tijeras le gana a papel.");
        }

        public static Reglas getInstance
        {
            get
            {
                return instance;
            }
        }
        public void Juego()
        {
            Random random = new Random();
            int input;
            int pc_input = random.Next(1, 4);
            Console.WriteLine("Para empezar, elija su jugada.");
            input = Convert.ToInt32(Console.ReadLine());

           
            if (input == 1 && pc_input == 2)
            {
                Console.WriteLine("Has elegido piedra, la maquina ha elegido papel, pierdes.");
            }
           else if (input == 1 && pc_input == 3)
            {
                Console.WriteLine("Has elegido piedra, la maquina ha elegido tijeras, ganas.");
            }
            else if (input == 1 && pc_input == 1)
            {
                Console.WriteLine("Has elegido piedra, la maquina ha elegido piedra, empate.");
            }
            else if (input == 2 && pc_input == 1)
            {
                Console.WriteLine("Has elegido papel, la maquina ha elegido piedra, ganas.");
            }
            else if (input == 2 && pc_input == 2)
            {
                Console.WriteLine("Has elegido papel, la maquina ha elegido papel, empate.");
            }
            else if (input == 2 && pc_input == 3)
            {
                Console.WriteLine("Has elegido papel, la maquina ha elegido tijera, pierdes.");
            }
            else if (input == 3 && pc_input == 1)
            {
                Console.WriteLine("Has elegido tijeras, la maquina ha elegido piedra, pierdes.");
            }
            else if (input == 3 && pc_input == 2)
            {
                Console.WriteLine("Has elegido tijeras, la maquina ha elegido papel, ganas.");
            }
            else if (input == 3 && pc_input == 3)
            {
                Console.WriteLine("Has elegido tijeras, la maquina ha elegido tijeras, empate.");
            }
        }
    }
    class Program
    {
        static Reglas jugar = Reglas.getInstance;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            jugar.Juego();
            Console.ReadKey();
        }
    }
}
