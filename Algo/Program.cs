using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo.Sorters;

namespace Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataCount = int.Parse(args[0]);
            var sortType = args[1];

            Console.WriteLine("Source Data:");
            var sourceData = DataGenerator.CreateFullRandom(dataCount);
            for (var i = 0; i < sourceData.Length; i++)
            {
                Console.Write(sourceData[i] + " ");
            }

            ISorter sorter;
            switch (sortType) {
                case "insert":
                    sorter = new InsertSorter();
                    break;

                case "merge":
                    sorter = new MergeSorter();
                    break;

                case "heap":
                    sorter = new HeapSorter();
                    break;

                default:
                    throw new ArgumentException("sorterType is undefined");
            }

            var resultData = sorter.Sort(sourceData);
            Console.WriteLine();
            Console.WriteLine("Result Data:");
            for (var i = 0; i < resultData.Length; i++)
            {
                Console.Write(resultData[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
