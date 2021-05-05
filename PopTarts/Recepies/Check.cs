using System;
using System.Collections.Generic;
using System.Text;

namespace PopTarts.Recepies
{
    public static class Check
    {
        /// <summary>
        /// Checks if number got one decimal
        /// </summary>
        /// <param name="p0"></param>
        /// <returns></returns>
        public static bool IsDecimal(decimal p0) 
        {
            var isADecimal = p0.ToString().Contains(",");
            if (isADecimal)
            {
                var _decimal = p0.ToString().Split(",")[1].Length;
                if(_decimal > 1)
                {
                    return false; 
                }
                return true;
            }
            return false;
        }
    }
}
