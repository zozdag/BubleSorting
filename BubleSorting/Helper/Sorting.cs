using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSorting.Helper
{
    public class Sorting
    {

        //  int[7] { 5, 7, 2, 9, 6, 1, 3,11,12 } sample
     
        public static int[] BubleSortingProcessor(int[] unSortedList)
        {
            int lastRememberVal = 0;
            int endCounter = 0;
            while (true)
            {
                for (int i = 0; i <= unSortedList.Length - 1; i++)
                {
                    if (i == unSortedList.Length - 1) // if we reached last Index in Array we must break for iteration
                        break; 
                    if (unSortedList[i] <= unSortedList[i + 1])
                    {
                        endCounter++;
                    }
                    else if (unSortedList[i] > unSortedList[i + 1])
                    {
                        lastRememberVal = unSortedList[i]; // remember for exchange index vals
                        unSortedList[i] = unSortedList[i + 1];
                        unSortedList[i + 1] = lastRememberVal;
                    }

                }
                if (endCounter == unSortedList.Length - 1)
                {
                    break;
                }
                endCounter= 0;
            }

            return unSortedList;
        }
    }
}
