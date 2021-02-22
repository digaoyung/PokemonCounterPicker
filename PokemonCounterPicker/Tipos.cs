using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonCounterPicker
{
    class Tipos
    {

        public void TypeSetter(int set1)
        {
            switch (set1)
            {
                case 1:
                    Console.WriteLine("É UM ATAQUE DO TIPO BUG");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Dark, Grass e Psychic");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Fairy, Fight, Fire, Flying, Ghost, Poison, Steel");
                    break;
                case 2:
                    Console.WriteLine("É UM ATAQUE DO TIPO DARK");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Ghost, Psychic");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Dark, Fairy, Fight");
                    break;
                case 3:
                    Console.WriteLine("É UM ATAQUE DO TIPO DRAGON");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Dragon");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Steel");
                    Console.WriteLine("Esse ataque não afeta Pokémon do tipo Fairy");
                    break;
                case 4:
                    Console.WriteLine("É UM ATAQUE DO TIPO ELECTRIC");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Water, Flying");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Dragon, Electric, Grass");
                    Console.WriteLine("Esse ataque não afeta Pokémon do tipo Ground");
                    break;
                case 5:
                    Console.WriteLine("É UM ATAQUE DO TIPO FAIRY");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Dark, Dragon, Fight");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Fire, Poison, Steel");
                    break;
                case 6:
                    Console.WriteLine("É UM ATAQUE DO TIPO FIGHT");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Dark, Ice, Normal, Rock, Steel");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Bug, Fairy, Flying, Poison, Psychic");
                    Console.WriteLine("Esse ataque não afeta Pokémon do tipo Ghost");
                    break;
                case 7:
                    Console.WriteLine("É UM ATAQUE DO TIPO FIRE");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Bug, Steel, Gress, Ice");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Dragon, Fire, Rock, Water");
                    break;
                case 8:
                    Console.WriteLine("É UM ATAQUE DO TIPO FLYING");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Bug, Fight, Grass");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Electric, Rock, Steel");
                    break;
                case 9:
                    Console.WriteLine("É UM ATAQUE DO TIPO GHOST");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Ghost, Psychic");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Dark");
                    Console.WriteLine("Esse ataque não afeta Pokémon do tipo Normal");
                    break;
                case 10:
                    Console.WriteLine("É UM ATAQUE DO TIPO GRASS");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Ground, Rock, Water");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Bug, Dragon, Fire, Flying, Grass, Poison, Steel");
                    break;
                case 11:
                    Console.WriteLine("É UM ATAQUE DO TIPO GROUND");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Electric, Fire, Poison, Rock");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Bug, Grass");
                    Console.WriteLine("Esse ataque não afeta Pokémon do tipo Flying");
                    break;
                case 12:
                    Console.WriteLine("É UM ATAQUE DO TIPO ICE");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Dragon, Flying, Grass, Ground");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Fire, Ice, Stel, Water");
                    break;
                case 13:
                    Console.WriteLine("É UM ATAQUE DO TIPO NORMAL");
                    Console.WriteLine("Esse ataque não causa dano dobrado (Super Effective)");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Rock, Steel");
                    Console.WriteLine("Esse ataque não afeta Pokémon do tipo Ghost");
                    break;
                case 14:
                    Console.WriteLine("É UM ATAQUE DO TIPO POISON");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Fairy, Grass");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Poison, Ground, Rock, Ghost");
                    Console.WriteLine("Esse ataque não afeta Pokémon do tipo Steel");
                    break;
                case 15:
                    Console.WriteLine("É UM ATAQUE DO TIPO PSYCHIC");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Fight, Poison");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Psychic, Steel");
                    Console.WriteLine("Esse ataque não afeta Pokémon do tipo Dark");
                    break;
                case 16:
                    Console.WriteLine("É UM ATAQUE DO TIPO ROCK");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Bug, Fire, Flying, Ice");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Fight, Ground, Steel");
                    break;
                case 17:
                    Console.WriteLine("É UM ATAQUE DO TIPO STEEL"); 
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Ice, Rock");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Electric, Fire, Steel, Water");
                    break;
                case 18:
                    Console.WriteLine("É UM ATAQUE DO TIPO WATER");
                    Console.WriteLine("Esse ataque causa dano dobrado (Super Effective) em Pokémon do tipo Fire, Ground, Rock");
                    Console.WriteLine("Esse ataque causa metade de dano (Not Very Effective) em Pokémon do tipo Dragon, Grass, Water");
                    break;
                default:
                    Console.WriteLine("Tipo inválido");
                    break;
            }
        }
    }
}
