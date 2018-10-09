using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ULTRALOTTOGENERATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            var lastDigit = 58;
            //using (System.IO.StreamWriter file =
            //new System.IO.StreamWriter(@"C:\DELETABLE\ULTRALOTTOGENERATOR\numbers.txt"))
            //{
                var count = 1;
                for (var d1 = 1; d1 <= lastDigit; d1++)
                {
                    for (var d2 = 1; d2 <= lastDigit; d2++)
                    {
                        for (var d3 = 1; d3 <= lastDigit; d3++)
                        {
                            for (var d4 = 1; d4 <= lastDigit; d4++)
                            {
                                for (var d5 = 1; d5 <= lastDigit; d5++)
                                {
                                    for (var d6 = 1; d6 <= lastDigit; d6++)
                                    {
                                        var digits = new List<int> { d1, d2, d3, d4, d5, d6 };
                                        if (digits.Count == digits.Distinct().Count())
                                        {
                                            //var cnt = $"{d1}-{d2}-{d3}-{d4}-{d5}-{d6}";
                                            //file.WriteLine(cnt);
                                            Console.WriteLine($"{d1}-{d2}-{d3}-{d4}-{d5}-{d6}");
                                            count++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                //file.WriteLine($"finised:{count}");
            //}
            Console.WriteLine($"Finished! {count}");
            Console.ReadLine();
        }
    }
}
