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

        public static long[][] GetTArray(long input)
        {
            long binLength = (long)Math.Ceiling(Math.Log2(input));
            var arrLen = (int)Math.Pow(2, binLength);
            var arr = Enumerable.Range(0, arrLen).Select(i => new long[binLength]).ToArray();
            return arr;
        }

        public static long Mystery(long input)
        {
            long binLength = (long)Math.Ceiling(Math.Log2(input));
            int arrLen = (int)Math.Pow(2, binLength);
            var arr = new long[arrLen][];
            for (long i = 0; i < arr.Length; i++)
            {
                arr[i] = new long[binLength];
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
            var answers = new List<long>();
            long binLength = (long)Math.Ceiling(Math.Log2(input));
            long arrLen = (long)Math.Pow(2, binLength);
            var arr = new long[arrLen][];
            for (long i = 0; i < arr.Length; i++)
            {
                arr[i] = new long[binLength];
                int mod = 2;
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
                var entry = arr[i];
                long answer = 0;
                for (long k = 0; k < entry.Length; k++)
                {
                    answer += entry[k] * (long)Math.Pow(2, k);
                }
                answers.Add(answer);
                if(answer == input)
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
