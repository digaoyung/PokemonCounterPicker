using System;

namespace PokemonCounterPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Tipos tipos = new Tipos();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("         POKÉMON COUNTER PICKER          ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("LISTA COM OS TIPOS:");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1 - Bug         10 - Grass");
            Console.WriteLine("2 - Dark        11 - Ground");
            Console.WriteLine("3 - Dragon      12 - Ice");
            Console.WriteLine("4 - Electric    13 - Normal");
            Console.WriteLine("5 - Fairy       14 - Poison");
            Console.WriteLine("6 - Fighting    15 - Psychic");
            Console.WriteLine("7 - Fire        16 - Rock");
            Console.WriteLine("8 - Flying      17 - Steel");
            Console.WriteLine("9 - Ghost       18 - Water");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Digite os dois números correspondentes aos tipos, separados por espaços.");
            Console.Write("Se não houver tipo secundário, digite 0. ");
            string[] ins = Console.ReadLine().Split(' ');
            int tipoA = int.Parse(ins[0]);
            int tipoB = int.Parse(ins[1]);
            tipos.TypeSetter(tipoA, tipoB);
            Console.WriteLine();
            Console.WriteLine("Tipos inseridos:");
            Console.WriteLine(tipos);

        }
    }
}
