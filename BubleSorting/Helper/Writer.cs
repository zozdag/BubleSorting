using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSorting.Helper
{
    public class Writer
    {
        public static void WriteListConsole(int[] list)
        {
            Console.WriteLine();
            foreach (var item in list)
            {

                Console.Write(item+" - ");

            }

        }
    }
}
