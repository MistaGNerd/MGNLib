using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGNLib.Core
{
    public static class ListExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringList"></param>
        /// <returns></returns>
        internal static string OutputAsSingleString(this List<string> stringList)
        {
            string output = "";
            foreach (string s in stringList)
            {
                output += " " + s + ",";
            }
            return output;
        }
    }
}
