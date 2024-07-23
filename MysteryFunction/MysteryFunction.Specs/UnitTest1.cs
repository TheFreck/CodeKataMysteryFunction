using Machine.Specifications;

namespace MysteryFunction.Specs
{
    public class When_Getting_Binary_Array
    {
        Establish context = () =>
        {
            input = 23;
            expect = new Dictionary<long, int[]>
            {
                {0,new int[]{0,0,0,0,0 } },
                {1,new int[]{0,0,0,0,0 } },
                {2,new int[]{0,0,0,0,0 } },
                {3,new int[]{0,0,0,0,0 } },
                {4,new int[]{0,0,0,0,0 } },
                {5,new int[]{0,0,0,0,0 } },
                {6,new int[]{0,0,0,0,0 } },
                {7,new int[]{0,0,0,0,0 } },
                {8,new int[]{0,0,0,0,0 } },
                {9,new int[]{0,0,0,0,0 } },
                {10,new int[]{0,0,0,0,0 } },
                {11,new int[]{0,0,0,0,0 } },
                {12,new int[]{0,0,0,0,0 } },
                {13,new int[]{0,0,0,0,0 } },
                {14,new int[]{0,0,0,0,0 } },
                {15,new int[]{0,0,0,0,0 } },
                {16,new int[]{0,0,0,0,0 } },
                {17,new int[]{0,0,0,0,0 } },
                {18,new int[]{0,0,0,0,0 } },
                {19,new int[]{0,0,0,0,0 } },
                {20,new int[]{0,0,0,0,0 } },
                {21,new int[]{0,0,0,0,0 } },
                {22,new int[]{0,0,0,0,0 } },
                {23,new int[]{0,0,0,0,0 } },
                {24,new int[]{0,0,0,0,0 } },
                {25,new int[]{0,0,0,0,0 } },
                {26,new int[]{0,0,0,0,0 } },
                {27,new int[]{0,0,0,0,0 } },
                {28,new int[]{0,0,0,0,0 } },
                {29,new int[]{0,0,0,0,0 } },
                {30,new int[]{0,0,0,0,0 } },
                {31,new int[]{0,0,0,0,0 } },
            };
        };

        Because of = () => answer = Function.GetTArray(input);

        It Should_Return_An_Empty_Array_Of_Correct_Length = () => answer.Count.ShouldEqual(expect.Count);
        It Should_Return_An_Array_Of_Zero_Arrays = () =>
        {
            for (var i = 0; i < answer.Count; i++)
            {
                for (var j = 0; j < answer[i].Length; j++)
                {
                    answer[i][j].ShouldEqual(0);
                }
            }
        };

        private static Dictionary<long,int[]> expect;
        private static long input;
        private static Dictionary<long, int[]> answer;
    }

    public class When_Converting_Int_To_Binary
    {
        Establish context = () =>
        {
            input = 7;
            expect = 2;
        };

        Because of = () => answer = Function.GetBinaryLength(input);

        It Should_Return_The_Number_Of_Places_In_The_Binary = () => answer.ShouldEqual(expect);

        private static long answer;
        private static long input;
        private static long expect;
    }

    public class When_Finding_The_Mystery_Array
    {
        Establish context = () =>
        {
            input = 6;
            expect = 5;
        };

        Because of = () => answer = Function.Mystery(input);

        It Should_Return_Value_From_Bin_Index = () => answer.ShouldEqual(expect);

        private static long input;
        private static long expect;
        private static long answer;
    }

    public class When_Flipping_The_Last_Four_Bits
    {
        Establish context = () =>
        {
            input = new long[][]
            {
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
                new long[]{0,0,0,0,0,0 },
            };
            expect = new long[][]
            {
                new long[]{0,0,0,0,0,0},
                new long[]{1,0,0,0,0,0},
                new long[]{1,1,0,0,0,0},
                new long[]{0,1,0,0,0,0},
                new long[]{0,1,1,0,0,0},
                new long[]{1,1,1,0,0,0},
                new long[]{1,0,1,0,0,0},
                new long[]{0,0,1,0,0,0},
                new long[]{0,0,1,1,0,0},
                new long[]{1,0,1,1,0,0},
                new long[]{1,1,1,1,0,0},
                new long[]{0,1,1,1,0,0},
                new long[]{0,1,0,1,0,0},
                new long[]{1,1,0,1,0,0},
                new long[]{1,0,0,1,0,0},
                new long[]{0,0,0,1,0,0},
                new long[]{0,0,0,1,1,0},
                new long[]{1,0,0,1,1,0},
                new long[]{1,1,0,1,1,0},
                new long[]{0,1,0,1,1,0},
                new long[]{0,1,1,1,1,0},
                new long[]{1,1,1,1,1,0},
                new long[]{1,0,1,1,1,0},
                new long[]{0,0,1,1,1,0},
                new long[]{0,0,1,0,1,0},
                new long[]{1,0,1,0,1,0},
                new long[]{1,1,1,0,1,0},
                new long[]{0,1,1,0,1,0},
                new long[]{0,1,0,0,1,0},
                new long[]{1,1,0,0,1,0},
                new long[]{1,0,0,0,1,0},
                new long[]{0,0,0,0,1,0},
                new long[]{0,0,0,0,1,1},
                new long[]{1,0,0,0,1,1},
                new long[]{1,1,0,0,1,1},
                new long[]{0,1,0,0,1,1},
                new long[]{0,1,1,0,1,1},
                new long[]{1,1,1,0,1,1},
                new long[]{1,0,1,0,1,1},
                new long[]{0,0,1,0,1,1},
                new long[]{0,0,1,1,1,1},
                new long[]{1,0,1,1,1,1},
                new long[]{1,1,1,1,1,1},
                new long[]{0,1,1,1,1,1},
                new long[]{0,1,0,1,1,1},
                new long[]{1,1,0,1,1,1},
                new long[]{1,0,0,1,1,1},
                new long[]{0,0,0,1,1,1},
                new long[]{0,0,0,1,0,1},
                new long[]{1,0,0,1,0,1},
                new long[]{1,1,0,1,0,1},
                new long[]{0,1,0,1,0,1},
                new long[]{0,1,1,1,0,1},
                new long[]{1,1,1,1,0,1},
                new long[]{1,0,1,1,0,1},
                new long[]{0,0,1,1,0,1},
                new long[]{0,0,1,0,0,1},
                new long[]{1,0,1,0,0,1},
                new long[]{1,1,1,0,0,1},
                new long[]{0,1,1,0,0,1},
                new long[]{0,1,0,0,0,1},
                new long[]{1,1,0,0,0,1},
                new long[]{1,0,0,0,0,1},
                new long[]{0,0,0,0,0,1},
            };
        };

        Because of = () => answer = Function.FlipBits(input);

        It Should_Flip_The_Correct_Bits = () =>
        {
            for (var i = 0; i < expect.Length; i++)
            {
                for (var j = 0; j < expect[i].Length; j++)
                {
                    if(answer[i][j] != expect[i][j])
                    {
                        var ans = answer[i][j];
                        var exp = expect[i][j];
                    }
                    answer[i][j].ShouldEqual(expect[i][j]);
                }
            }
        };

        private static long[][] input;
        private static long[][] expect;
        private static long[][] answer;
    }

    public class When_Getting_Index_From_Binary_Array
    {
        Establish context = () =>
        {
            input = 5;
            expect = 6;
        };

        Because of = () => answer = Function.MysteryInv(input);

        It Should_Return_The_Index_For_The_Input = () => answer.ShouldEqual(expect);
        
        private static long input;
        private static long expect;
        private static long answer;
    }

    public class When_Building_The_Specific_Bin_Index
    {
        Establish context = () =>
        {
            input = 7;
            expect = 
        };
    }
}