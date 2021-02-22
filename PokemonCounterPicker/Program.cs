using System;

namespace PokemonCounterPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Tipos tipos = new Tipos();
            Menu();
            int ins = int.Parse(Console.ReadLine());
            while (ins != 0 && ins <= 18)
            {
                tipos.TypeSetter(ins);
                Console.Write("ESCOLHA UM NOVO TIPO: ");
                ins = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
        static void Menu() {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("         POKÉMON COUNTER PICKER          ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("DIGITE O TIPO DO ATAQUE A SER UTILIZADO");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("LISTA COM OS TIPOS:");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1 - Bug         10 - Grass");
            Console.WriteLine("2 - Dark        11 - Ground");
            Console.WriteLine("3 - Dragon      12 - Ice");
            Console.WriteLine("4 - Electric    13 - Normal");
            Console.WriteLine("5 - Fairy       14 - Poison");
            Console.WriteLine("6 - Fight       15 - Psychic");
            Console.WriteLine("7 - Fire        16 - Rock");
            Console.WriteLine("8 - Flying      17 - Steel");
            Console.WriteLine("9 - Ghost       18 - Water");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("PARA ENCERRAR O PROGRAMA, DIGITE QUALQUER NÚMERO QUE NÃO ESTEJA NA LISTA. ");
            Console.Write("ESCOLHA UM TIPO: ");

        }
    }
}
