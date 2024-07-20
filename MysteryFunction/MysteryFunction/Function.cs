using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysteryFunction
{
    public class Function
    {
        public static int[][] FlipBits(int[][] input)
        {
            var pattern2 = String.Empty;
            var pattern4 = String.Empty;
            var pattern8 = String.Empty;
            var pattern16 = String.Empty;
            var pattern32 = String.Empty;
            var pattern64 = String.Empty;
            var pattern128 = String.Empty;
            var pattern256 = String.Empty;
            for(var i=0; i<input.Length; i++)
            {
                for(var j= input[i].Length-1; j>=0 ; j--)
                {
                    var mod4 = i % 4;
                    var mod8 = i % 8;
                    var mod16 = i % 16;
                    var mod32 = i % 32;
                    var mod64 = i % 64;
                    var mod128 = i % 128;
                    var mod256 = i % 256;
                    var mod512 = i % 512;
                    if ((mod4 >= 1 && mod4 < 3 && j == 0) ||
                        (mod8 >= 2 && mod8 < 6 && j == 1) ||
                        (mod16 >= 4 && mod16 <= 12 && j == 2) ||
                        (mod32 >= 8 && mod32 <= 24 && j == 3) ||
                        (mod64 >= 16 && mod64 <= 48 && j == 4) ||
                        (mod128 >= 32 && mod128 <= 96 && j == 5) ||
                        (mod256 >= 64 && mod256 <= 182 && j == 6) ||
                        (mod512 >= 128 && mod512 <= 364 && j == 7)
                    )
                    {
                        input[i][j] = 1;
                        switch (j)
                        {
                            case 0:
                                pattern2 += 1;
                                break;
                            case 1:
                                pattern4 += 1;
                                break;
                            case 2:
                                pattern8 += 1;
                                break;
                            case 3:
                                pattern16 += 1;
                                break;
                            case 4:
                                pattern32 += 1;
                                break;
                            case 5:
                                pattern64 += 1;
                                break;
                            case 6:
                                pattern128 += 1;
                                break;
                            case 7:
                                pattern256 += 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (j)
                        {
                            case 0:
                                pattern2 += 0;
                                break;
                            case 1:
                                pattern4 += 0;
                                break;
                            case 2:
                                pattern8 += 0;
                                break;
                            case 3:
                                pattern16 += 0;
                                break;
                            case 4:
                                pattern32 += 0;
                                break;
                            case 5:
                                pattern64 += 0;
                                break;
                            case 6:
                                pattern128 += 0;
                                break;
                            case 7:
                                pattern256 += 0;
                                break;
                        }
                    }
                }
            }
            return input;
        }

        public static int GetBinaryLength(int input)
        {
            return (int)Math.Log2(input);
        }

        public static int[][] GetTArray(int input)
        {
            int binLength = (int)Math.Ceiling(Math.Log2(input));
            var arrLen = (int)Math.Pow(2, binLength);
            var binArray = Enumerable.Range(0, arrLen).Select(i => new int[binLength]).ToArray();
            return binArray;
        }

        public static int Mystery(int input)
        {
            var arr = GetTArray(input);
            for (var i = 0; i < arr.Length; i++)
            {
                
            }
            throw new NotImplementedException();
        }
    }
}
