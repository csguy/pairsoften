using System;
using System.Linq;
using System.Text;

    public class PairsOfTen
    {
        /**
         * This function will take a sum, and an int[], and will walk the array to determine which pairs of ints, match the sum
         * Given the sample data of [1, 6, 3, 2, 5, 5, 7, 8, 4, 8, 2, 5, 9, 9, 1], it will print out the following:
         * (1,9), (1,9), (6,4), (3,7), (2,8), (2,8), (5,5), (5,5), (5,5), (8,2), (8,2), (9,1), (9,1).
         *         
         * */
        public void PrintPairs(int sum, int[] valuesToSum)
        {
            StringBuilder sBuilder = new StringBuilder();
                        
            for (int i = 0, j = valuesToSum.Count() - 1; i < valuesToSum.Count();  i++)
            {                
                while (j > i)
                {
                    if (valuesToSum[j] + valuesToSum[i] == sum)
                    {
                        sBuilder.Append("(" + valuesToSum[i] + "," + valuesToSum[j] + "), ");
                    }
                    j--;
                    
                }

                j = valuesToSum.Count() - 1;                
            }
           
            sBuilder.Remove(sBuilder.Length - 2, 1);//remove trailing ,
            Console.WriteLine(sBuilder);            
        }       
    }

