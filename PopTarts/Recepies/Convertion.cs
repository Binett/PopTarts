using System;
using System.Collections.Generic;
using System.Text;

namespace PopTarts.Recepies
{
    public static class Convertion
    {
        public static decimal ConvertToDL(decimal cups) //Nicklas + Tobias
        {
           return RoundToOneDecimal(cups * (decimal)2.36588237);
        } 

        public static decimal RoundToOneDecimal(decimal p0)//hoffmann
        {
            return decimal.Round(p0, 1);
        }
               
    }
}
