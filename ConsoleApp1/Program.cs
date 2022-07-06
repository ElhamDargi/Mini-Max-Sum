using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            arr.Add(256741038);
            arr.Add(623958417);
            arr.Add(467905213);
            arr.Add(714532089);
            arr.Add(938071625);
            arr.Sort();
            Int64 min = 0, max=min;
            //for (int i = 0; i < 4; i++)
            //{
            //    min += arr[i];
            //}
            //arr.Reverse();
            //for (int i = 0; i < 4; i++)
            //{
            //    max += arr[i];
            //}
            for (int i = 0,j=4; i < 4; i++,j--)
            {
                min += arr[i];
                max += arr[j];
            }
            Console.WriteLine(min + " " + max);



            //BigInteger min;
            //min = arr.Sum()- arr.Max();
            //BigInteger max;
            //max = arr.Sum()- arr.Min();
            //Console.WriteLine(min + " " + max);
        }
    }
}
