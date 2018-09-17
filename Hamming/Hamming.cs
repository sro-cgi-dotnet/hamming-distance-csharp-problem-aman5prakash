using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
            // checking if original string is null or not
            if(original == null)
            {
                throw(new ArgumentNullException("original"));
            }

            // checking if current string is null or not
            else if(current == null)
            {
                throw(new ArgumentNullException("current"));
            }

            // checking if current string is equals to original string or not
            else if(original.Length != current.Length)
            {
                throw(new ArgumentException("Hamming Distance can only be calculated over strings of equal length"));
            }
            else
            {
            int hammingDistance = 0;
            int n = original.Length;

            // To take every element of current string check with every element of original string at same position 
            for(int i = 0; i < n; i++)
            {
                if(original[i] != current[i])
                {
                    hammingDistance++;
                }
            }
            return hammingDistance;
            }
        }
    }
}
