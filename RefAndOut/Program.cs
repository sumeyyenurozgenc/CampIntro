using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            #region RefUsing

            int num1 = 5;
            int num2 = 7;
            var resultRef = MultiplyRef(ref num1, num2);
            Console.WriteLine("Ref işlemi Sonucu: " + resultRef);

            #endregion

            #region OutUsing

            int num3;
            int num4 = 3;
            var resultOut = MultiplyOut(out num3, num4);
            Console.WriteLine("Out işlemi Sonucu: " + resultOut);

            #endregion



        }
        static int MultiplyRef(ref int num1, int num2)
        {
            num1 = 8;
            return num1 * num2;
        }

        static int MultiplyOut(out int num1, int num2)
        {
            num1 = 11;
            return num1 * num2;
        }
    }
}
