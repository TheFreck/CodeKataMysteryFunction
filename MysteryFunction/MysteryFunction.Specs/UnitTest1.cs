using Machine.Specifications;

namespace MysteryFunction.Specs
{
    public class When_Getting_Binary_Array
    {
        Establish context = () =>
        {
            input = 23;
            expect = new int[32][];
        };

        Because of = () => answer = Function.GetTArray(input);

        It Should_Return_An_Empty_Array_Of_Correct_Length = () => answer.Length.ShouldEqual(expect.Length);
        It Should_Return_An_Array_Of_Zero_Arrays = () =>
        {
            for (var i = 0; i < answer.Length; i++)
            {
                for (var j = 0; j < answer[i].Length; j++)
                {
                    answer[i][j].ShouldEqual(0);
                }
            }
        };

        private static int[][] expect;
        private static int input;
        private static int[][] answer;
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

        private static int answer;
        private static int input;
        private static int expect;
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

        private static int input;
        private static int expect;
        private static int answer;
    }

    public class When_Flipping_The_Last_Four_Bits
    {
        Establish context = () =>
        {
            input = new int[][]
            {
                new int[]{0,0,0,0 },
                new int[]{0,0,0,0 },
                new int[]{0,0,0,0 },
                new int[]{0,0,0,0 },
                new int[]{0,0,0,0 },
                new int[]{0,0,0,0 },
                new int[]{0,0,0,0 },
                new int[]{0,0,0,0 },
                new int[]{0,0,0,0 },
                new int[]{0,0,0,0 },
                new int[]{0,0,0,0 },
                new int[]{0,0,0,0 },
                new int[]{0,0,0,0 },
                new int[]{0,0,0,0 },
                new int[]{0,0,0,0 },
                new int[]{0,0,0,0 }
            };
            expect = new int[][]
            {
                new int[]{0,0,0,0 },
                new int[]{1,0,0,0 },
                new int[]{1,1,0,0 },
                new int[]{0,1,0,0 },
                new int[]{0,1,1,0 },
                new int[]{1,1,1,0 },
                new int[]{1,0,1,0 },
                new int[]{0,0,1,0 },
                new int[]{0,0,1,1 },
                new int[]{1,0,1,1 },
                new int[]{1,1,1,1 },
                new int[]{0,1,1,1 },
                new int[]{0,1,0,1 },
                new int[]{1,1,0,1 },
                new int[]{1,0,0,1 },
                new int[]{0,0,0,1 }
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

        private static int[][] input;
        private static int[][] expect;
        private static int[][] answer;
    }
}