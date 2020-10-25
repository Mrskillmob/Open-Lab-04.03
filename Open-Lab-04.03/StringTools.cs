using System;
using System.Linq;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            if (original.Length < 2)
            {
                return original;
            }
            
            char[] unoriginal = new char[original.Length-1];
            for (int i = 0; i < original.Length-1; i++)
            {
                unoriginal[i] = original[i];
            }
            Array.Reverse(unoriginal);
            char[] rg3 = new char[unoriginal.Length - 1];
            for (int i = 0; i < unoriginal.Length-1; i++)
            {
                rg3[i] = unoriginal[i];
            }
            Array.Reverse(rg3);
            string a = String.Join("", rg3);
            return a;
            


        }
    }
}
