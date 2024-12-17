using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        #region Test Funcs
        static void swap1(int x,int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }
        static void swap2(ref int x,ref int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }
        static void sumAndSub(int x,int y,out int sum,out int sub)
        {
            sum = x + y;
            sub = x - y;
        }
        static bool IsPrime(int x)
        {
            if(x==0 || x == 1)
            {
                return false;
            }
            else if (x % 2 == 0 && x!=2)
            {
                return false;
            }
            else
            {
                for(int i = 3; i * i <= x; i+=2)
                {
                    if (x % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static int DigSum(int x)
        {
            int sum = 0;
            while (x>0)
            {
                sum += x % 10;
                x /= 10;
            }
            return sum;
        }
        static void MinMaxArray(int[] arr,ref int mx,ref int mn)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                mx = Math.Max(mx, arr[i]);
                mn = Math.Min(mn, arr[i]);
            }
        }
        static long fac(int x)
        {
            long fc = 1;
            for(int i = x; i > 0; i--)
            {
                fc *= i;
            }
            return fc;
        }
        static void ChangeChar(ref string? s,int pos,char rep)
        {
            string? res = "";
            if (s!=null && pos >= s.Length)
            {
                Console.WriteLine("Out of range");
            }
            else
            {
                for (int i = 0; i < s?.Length; i++)
                {
                    if (i == pos)
                    {
                        res += rep;
                    }
                    else
                    {
                        res += s[i];
                    }
                }
                s = res;
            }
        }
        static void swap3(string x,string y)
        {
            string t = y;
            y = x;
            x = t;
        }
        static void swap4(ref string x, ref string y)
        {
            string t = y;
            y = x;
            x = t;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //// in passing by value we take a copy of the parameter in the function but don't modify the parameter itself
            //int x = 5, y = 10;
            //swap1(x, y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            ////the x and y values here did't change because in the function it takes a copy of their values only

            //// in passing by reference the function takes the variable itself and modify on it
            //swap2(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            ////here values of x and y have been swapped
            #endregion
            #region Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            // in passing by value we take a copy of the parameter in the function but don't modify the parameter itself
            string x = "ahmad", y = "mohammed";
            swap3(x, y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            //the x and y values here did't change because in the function it takes a copy of their values only

            // in passing by reference the function takes the variable itself and modify on it
            swap4(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            //here values of x and y have been swapped
            #endregion
            #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int x = 10, y = 4;
            //int sum, sub;
            //sumAndSub(x,y,out sum, out sub);
            //Console.WriteLine(sum);
            //Console.WriteLine(sub);
            #endregion
            #region Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //int x;
            //do
            //{
            //    Console.WriteLine("Enter X:");
            //}while(!int.TryParse(Console.ReadLine(),out x));
            //Console.WriteLine(DigSum(x));
            #endregion
            #region Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not
            //int x;
            //do
            //{
            //    Console.WriteLine("Enter X:");
            //}
            //while (!int.TryParse(Console.ReadLine(),out x));
            //if (IsPrime(x))
            //{
            //    Console.WriteLine("Prime");
            //}
            //else
            //{
            //    Console.WriteLine("Not Prime");
            //}
            #endregion
            #region Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int mn=int.MaxValue, mx=0;
            //int[] arr = { 6, 4, 7, 3, 7, 4, 7, 3, 35, 76, 23, 908, 325 };
            //MinMaxArray(arr, ref mx,ref mn);
            //Console.WriteLine(mx);
            //Console.WriteLine(mn);
            #endregion
            #region Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //int x;
            //do
            //{
            //    Console.WriteLine("Enter the Number:");
            //}
            //while (!int.TryParse(Console.ReadLine(),out x) || x<0);
            //Console.WriteLine(fac(x));
            #endregion
            #region Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //string? s;
            //s = "ahmad";
            //ChangeChar(ref s, 3, 'P');
            //Console.WriteLine(s);
            #endregion
        }
    }
}
