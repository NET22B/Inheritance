using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal static class Extensions
    {
        public static string AddString(this string first, string second)
        {
            return first + " " + second;
        }

        //public static void PrintAll(this List<IDrivable> source)
        //{
        //    foreach (var v in source)
        //    {
        //        Console.WriteLine(v.Drive(50));
        //    }
        //} 
        
        public static void PrintAll(this IEnumerable<IDrivable> source)
        {
            foreach (var v in source)
            {
                Console.WriteLine(v.Drive(50));
            }
        }
    }
}
