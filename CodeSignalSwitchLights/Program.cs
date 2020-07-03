using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalSwitchLights
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 0, 0, 1, 0, 1, 0, 1 };
            arr = switchLights(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
        public static int[] switchLights(int[] a)
        {
            List<int> output = a.ToList();
            int count = 0;
            while (count < a.Length)
            {
                if (output[count] == 1)
                {
                    count++;
                    for (int i = 0; i < count; i++)
                    {

                        if (output[i] == 1)
                            output[i] = 0;
                        else if (output[i] == 0)
                            output[i] = 1;

                    }
                }
                else
                    count++;
            }
            return output.ToArray();
        }
    }
}
