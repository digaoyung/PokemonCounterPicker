using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonCounterPicker
{
    class Tipos
    {
        
        int tipo1 = 0;
        int tipo2 = 0;
        string tipoA;
        string tipoB;
        public void TypeSetter(int set1, int set2)
        {
            tipo1 = set1;
            tipo2 = set2;
            string[] TypeList = new string[19] { "-----", "Bug", "Dark", "Dragon", "Electric", "Fairy", "Fighting", "Fire", "Flying", "Ghost", "Grass", "Ground", "Ice", "Normal", "Poison", "Psychic", "Rock", "Steel", "Water" };
            tipoA = TypeList[tipo1];
            if (tipo2 != 0)
            {
                tipoB = TypeList[tipo2];
            }
        }
        /*public void TypeReader()
        {

        }*/

        public override string ToString()
        {
            return tipoA + " e " + tipoB;
        }

    }
}
