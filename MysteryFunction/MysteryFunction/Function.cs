using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MysteryFunction
{
    public class Function
    {
        //public static string FindIndex(long input)
        //{

        //}

        public static long[][] FlipBits(long[][] input)
        {
            for(var i=0; i<input.Length; i++)
            {
                int mod = 2;
                for(var j= input[i].Length-1; j>=0 ; j--)
                {
                    mod = (int)Math.Pow(2, j) * 4;
                    var modX = i % mod;
                    if(modX >= mod/4 && modX < 3 * mod / 4)
                    {
                        input[i][j] = 1;
                        continue;
                    }
                }
            }
            return input;
        }

        public static long GetBinaryLength(long input)
        {
            return (long)Math.Log2(input);
        }

        public static Dictionary<long, int[]> GetTArray(long input)
        {
            long binLength = (long)Math.Ceiling(Math.Log2(input));
            var arrLen = (int)Math.Pow(2, binLength);
            var arr = new Dictionary<long, int[]>();
            for (long i=0; i<arrLen; i++)
            {
                arr.Add(i,new int[binLength]);
            }
            return arr;
        }

        public static long Mystery(long input)
        {
            long binLength = (long)Math.Ceiling(Math.Log2(input));
            int arrLen = (int)Math.Pow(2, binLength);
            var arr = new Dictionary<long, int[]>();
            for (long i = 0; i < arrLen; i++)
            {
                arr.Add(i, new int[binLength]);
                long mod = 2;
                for (long j = arr[i].Length - 1; j >= 0; j--)
                {
                    mod = (int)Math.Pow(2, j) * 4;
                    long modX = i % mod;
                    if (modX >= mod / 4 && modX < 3 * mod / 4)
                    {
                        arr[i][j] = 1;
                        continue;
                    }
                }
            }
            var entry = arr[input];
            long answer = 0;
            for(long i =0; i<entry.Length;i++)
            {
                answer += entry[i] * (long)Math.Pow(2,i);
            }
            return answer;
        }

        public static long MysteryInv(long input)
        {
            var inBin = Convert.ToString(input, 2);
            long binLength = (long)Math.Ceiling(Math.Log2(input));
            long arrLen = (long)Math.Pow(2, binLength);
            var arr = new Dictionary<long, int[]>();
            for (long i = arrLen; i >=0; i--)
            {
                arr.Add(i, new int[binLength]);
                long mod = 2;
                for (long j = binLength - 1; j >= 0; j--)
                {
                    mod = (long)Math.Pow(2, j) * 4;
                    long modX = i % mod;
                    if (modX >= mod / 4 && modX < 3 * mod / 4)
                    {
                        arr[i][j] = 1;
                    }
                }
                var entry = arr[i];
                var binString = String.Join("",entry);
                if(binString == inBin)
                {
                    return i;
                }
            }

            return -1;
        }

        public static string NameOfMystery()
        {
            return "gray code";
        }
    }
}
