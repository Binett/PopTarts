using System;
using System.Collections.Generic;
using System.Text;

namespace PopTarts.Recepies
{
    public static class Convertion
    {
        public static float ConvertToDL(float cups) //Nicklas + Tobias
        {
           return MathF.Round(cups * 2.36588237F, 1);
        } 

        public static void RoundToOneDecimal()//
        {
            
        }
               
    }
}
