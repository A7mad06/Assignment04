using System.Collections.Specialized;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        #region Test Functions
        static void doubling(int x)
        {
            Console.WriteLine((x * 2));
        }
        static int sum(int a, int b)
        {
            return a + b;
        }
        static long sumArr(int[] arr)
        {
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static long sumArr2(ref int[] arr)
        {
            long sum = 0;
            arr = new int[] { 4, 5, 6, 7 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void arrFun(int[] arr, out int sum, out int avg)
        {
            sum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;

        }
        static int Summ(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        } 
        #endregion
        static void Main(string[] args)
        {

            #region Functions
            #region pass by value
            //doubling(5);
            //Console.WriteLine(sum(5,100));
            #endregion
            #region Pass by ref
            //int x, y;
            //x = 10; y = 50;
            //swap(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //int[] arr = { 1, 2, 3, 4 };
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(sumArr(arr));
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(sumArr2(ref arr));
            //Console.WriteLine(arr[0]);
            #endregion
            #region Pass by output
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int sum, avg;
            //arrFun(arr,out sum, out avg);
            //Console.WriteLine(sum);
            //Console.WriteLine(avg);
            #endregion
            #region Pass by params
            //Console.WriteLine(Summ(1,2,3,4,5,6,7,8,9,10));
            #endregion
            #endregion
            #region boxing and unboxing
            //object obj = new object();
            //obj = new string("ahmad");
            //obj = 3;//implicit casting (from value type to reference type)[boxing]
            //int x = (int)obj;//explicit casting (from reference type to value type) [unboxing]
            #endregion
            #region Nullable Value Type
            //int? s=5;
            //s = null;

            //double? x;
            //x = 17.5;
            //x = null;
            #endregion
            #region Nullable Reference Type
            //string s = "Hello";
            //s = null;
            //string? t = "aaa";
            //t = null;
            #endregion
            #region Exception Handelling
            //try
            //{
            //    int x, y;
            //    x = int.Parse(Console.ReadLine());
            //    y = int.Parse(Console.ReadLine());
            //    Console.WriteLine(x/y);
            //    int[] arr = { 1, 2, 3, 4 };
            //    arr[100] = 5;
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(DivideByZeroException d)
            //{
            //    Console.WriteLine(d.Message);
            //}
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #region Protective Code
            //int x, y;
            //do
            //{
            //    Console.WriteLine("Enter x:");
            //} while (!int.TryParse(Console.ReadLine(), out x));
            //do
            //{
            //    Console.WriteLine("Enter y:");
            //} while (!int.TryParse(Console.ReadLine(), out y) || y==0);
            //Console.WriteLine(x/y);
            //int?[] arr = { 1, 2, 3, 4 };
            //if (arr?.Length > 100) {
            //    Console.WriteLine(arr[100]);
            //}
            #endregion

        }
    }
}
