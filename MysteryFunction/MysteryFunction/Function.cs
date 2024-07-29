using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MysteryFunction
{
    public class Function
    {
        public static long FindIndex(long input)
        {
            var inBin = Convert.ToString(input, 2);
            var binLength = inBin.Length;
            var arrLen = (int)Math.Pow(2, binLength);
            var rowOptions = new List<List<long>>();
            var commons = new List<long>();
            for(var i = binLength-1; i>=0; i--)
            {
                var mod = (long)Math.Pow(2, binLength-1 - i)*4;
                var modX = input % mod;
                var low = mod / 4;
                var high = mod * 3 / 4;
                if (inBin[i] == '1')
                {
                    for(long j=0; j<arrLen; j++)
                    {
                        if (j%mod >= low && j % mod < high) commons.Add(j);
                    }
                }
                else
                {
                    for (long j = 0; j < arrLen; j++)
                    {
                        if(j % mod < low || j % mod >= high) commons.Add(j);
                    }
                }
            }

            return commons.GroupBy(c => c).Select(c => new { c,count = c.Count() }).OrderByDescending(c => c.count).FirstOrDefault().c.Key;
        }

        public static long FindIndexV2(long input)
        {
            if (input < 2) return input;
            var inBin = Convert.ToString(input, 2);
            var index = "0";
            for (var i = 0; i < inBin.Length; i++)
            {
                if(inBin[i] == '1' && index[i] == '0')
                {
                    index += '1';
                }
                else if(inBin[i] == '1' && index[i] == '1')
                {
                    index += '0';
                }
                else if (inBin[i] == '0')
                {
                    index += index[i];
                }
            }
            return Convert.ToInt64(index, 2);
        }

        public static long FindValue(long index)
        {
            var inBin = Convert.ToString(index, 2);
            var arrLen = (int)Math.Pow(2, inBin.Length);
            var num = String.Empty;
            for(var i=arrLen-1; i>=0; i--)
            {
                var mod = Math.Pow(2, i) * 4;
                var modX = index % mod;
                if(modX >= mod/4 && modX < mod * 3 / 4)
                {
                    num += '1';
                }
                else
                {
                    num += '0';
                }
            }
            return Convert.ToInt64(num,2);
        }

        public static long FindValueV2(long index)
        {
            if(index == 0) return 0;
            var inBin = Convert.ToString(index, 2);
            var value = String.Empty;
            for(var i=inBin.Length-1; i>0; i--)
            {
                if (inBin[i] != inBin[i - 1])
                {
                    value = '1' + value;
                }
                else
                {
                    value = '0' + value;
                }
            }
            return Convert.ToInt64("1"+value,2);
        }

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

        public static long Mystery(long index)
        {
            if (index == 0) return 0;
            var inBin = Convert.ToString(index, 2);
            var value = String.Empty;
            for (var i = inBin.Length - 1; i > 0; i--)
            {
                if (inBin[i] != inBin[i - 1])
                {
                    value = '1' + value;
                }
                else
                {
                    value = '0' + value;
                }
            }
            return Convert.ToInt64("1" + value, 2);
        }

        public static long MysteryInv(long input)
        {
            if (input < 2) return input;
            var inBin = Convert.ToString(input, 2);
            var index = "0";
            for (var i = 0; i < inBin.Length; i++)
            {
                if (inBin[i] == '1' && index[i] == '0')
                {
                    index += '1';
                }
                else if (inBin[i] == '1' && index[i] == '1')
                {
                    index += '0';
                }
                else if (inBin[i] == '0')
                {
                    index += index[i];
                }
            }
            return Convert.ToInt64(index, 2);
        }

        public static string NameOfMystery()
        {
            return "gray code";
        }
    }
}
