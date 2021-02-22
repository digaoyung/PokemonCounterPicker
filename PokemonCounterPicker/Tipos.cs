using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonCounterPicker
{
    class Tipos
    {

        string tipoA;

        public void TypeSetter(int set1)
        {
            string[] TypeList = new string[19] { "-----", "Bug", "Dark", "Dragon", "Electric", "Fairy", "Fighting", "Fire", "Flying", "Ghost", "Grass", "Ground", "Ice", "Normal", "Poison", "Psychic", "Rock", "Steel", "Water" };
            tipoA = TypeList[set1];

        }
        public override string ToString()
        {
            return "Selecionou " + tipoA;
        }
        static void Bug()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) " +
                "em Pokémon do tipo Dark, Grass e Psychic");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) " +
                "em Pokémon do tipo Fairy, Fight, Fire, Flying, Ghost, Poison, Steel");
        }
        static void Dark()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo ghost, psych");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo dark, fairy, fight");
        }
        static void Dragon()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Dragon");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Steel");
            Console.WriteLine("Esse ataque não afeta Pokémon do tipo Fairy");
        }
        static void Electric()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Water, Flying");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Dragon, Electric, Grass");
            Console.WriteLine("Esse ataque não afeta Pokémon do tipo Ground");
        }
        static void Fairy()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Dark, Dragon, Fight");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Fire, Poison, Steel");
        }
        static void Fighting()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Dark, Ice, Normal, Rock, Steel");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Bug, Fairy, Flying, Poison, Psychic");
            Console.WriteLine("Esse ataque não afeta Pokémon do tipo Ghost");
        }
        static void Fire()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Bug, Steel, Gress, Ice");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Dragon, Fire, Rock, Water");
        }
        static void Flying()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Bug, Fight, Grass");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Electric, Rock, Steel");
        }
        static void Ghost()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Ghost, Psychic");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Dark");
            Console.WriteLine("Esse ataque não afeta Pokémon do tipo Normal");
        }
        static void Grass()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Ground, Rock, Water");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Bug, Dragon, Fire, Flying, Grass, Poison, Steel");
        }
        static void Ground()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Electric, Fire, Poison, Rock");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Bug, Grass");
            Console.WriteLine("Esse ataque não afeta Pokémon do tipo Flying");
        }
        static void Ice()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Dragon, Flying, Grass, Ground");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Fire, Ice, Stel, Water");
        }
        static void Normal()
        {
            Console.WriteLine("Esse ataque não causa dano dobrado (Super Effective)");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Rock, Steel");
            Console.WriteLine("Esse ataque não afeta Pokémon do tipo Ghost");
        }
        static void Poison()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Fairy, Grass");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Poison, Ground, Rock, Ghost");
            Console.WriteLine("Esse ataque não afeta Pokémon do tipo Steel");
        }
        static void Psychic()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Fight, Poison");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Psychic, Steel");
            Console.WriteLine("Esse ataque não afeta Pokémon do tipo Dark");
        }
        static void Rock()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Bug, Fire, Flying, Ice");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Fight, Ground, Steel");
        }
        static void Steel()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Ice, Rock");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Electric, Fire, Steel, Water");
        }
        static void Water()
        {
            Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Fire, Ground, Rock");
            Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Dragon, Grass, Water");
        }
    }
}
