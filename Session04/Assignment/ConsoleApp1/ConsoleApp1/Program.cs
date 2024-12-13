using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //int x1, x2, x3, y1, y2, y3;
            //int.TryParse(Console.ReadLine(), out x1);
            //int.TryParse(Console.ReadLine(), out y1);
            //int.TryParse(Console.ReadLine(), out x2);
            //int.TryParse(Console.ReadLine(), out y2);
            //int.TryParse(Console.ReadLine(), out x3);
            //int.TryParse(Console.ReadLine(), out y3);
            //int area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
            //if (area == 0)
            //{
            //    Console.WriteLine("Straight Line");
            //}
            //else
            //{
            //    Console.WriteLine("Not Straight Line");
            //}
            #endregion
            #region 2
            //int WorkerTime = int.Parse(Console.ReadLine());
            //if(WorkerTime>1 && WorkerTime < 4)
            //{
            //    Console.WriteLine("highly efficient");
            //}
            //else if (WorkerTime < 5)
            //{
            //    Console.WriteLine("He is instructed to increase their speed");
            //}
            //else if (WorkerTime < 6)
            //{
            //    Console.WriteLine("he is provided with training to enhance their speed");
            //}
            //else if (WorkerTime > 5)
            //{
            //    Console.WriteLine("he is required to leave the company");
            //}
            #endregion
            #region 3
            //int n;
            //int.TryParse(Console.ReadLine(), out n);
            //int[,] matrix = new int[n,n];
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < n; j++)
            //    {
            //        if (j == i)
            //        {
            //            matrix[i,j] = 1;
            //        }
            //        else
            //        {
            //            matrix[i,j] = 0;
            //        }
            //    }
            //}
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < n; j++)
            //    {
            //        Console.Write($"{matrix[i,j]} ");
            //    }
            //    Console.WriteLine("");
            //}
            #endregion
            #region 4
            //int n;
            //int.TryParse(Console.ReadLine(), out n);
            //int[] arr = new int[n];
            //long sum = 0;
            //for(int i = 0; i < n; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //    sum += arr[i];
            //}
            //Console.WriteLine(sum);
            #endregion
            #region 5
            //int n;
            //int.TryParse(Console.ReadLine(), out n);
            //int[] arr1 = new int[n], arr2 = new int[n];
            //for(int i = 0; i < n; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr1[i]);
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr2[i]);
            //}
            //int[] arr3 = new int[2*n];
            //int l = 0, r = 0;
            //for(int i = 0; i < 2*n; i++)
            //{
            //    if(l<n && r < n)
            //    {
            //        if (arr1[l] < arr2[r])
            //        {
            //            arr3[i] = arr1[l];
            //            l++;
            //        }
            //        else
            //        {
            //            arr3[i] = arr2[r];
            //            r++;
            //        }
            //    }
            //    else if (l < n)
            //    {
            //        arr3[i] = arr1[l];
            //        l++;
            //    }
            //    else
            //    {
            //        arr3[i] = arr2[r];
            //        r++;
            //    }
            //}
            //foreach(int i in arr3)
            //{
            //    Console.Write(i);
            //    Console.Write(" ");
            //}
            #endregion
            #region 6
            //int n;
            //int.TryParse(Console.ReadLine(), out n);
            //int[] arr = new int[n];
            //SortedSet<int> v = new SortedSet<int>();
            //for(int i = 0; i < n; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //    v.Add(arr[i]);
            //}
            //Array.Sort(arr);
            //int[] freq = new int[arr[n-1]+5];
            //Array.Fill(freq, 0);
            //for(int i = 0; i < n; i++)
            //{
            //    freq[arr[i]]++;
            //}
            //foreach(int s in v)
            //{
            //    Console.WriteLine($"frequency of {s} is {freq[s]}");
            //}
            #endregion
            #region 7
            //int n;
            //int.TryParse(Console.ReadLine(), out n);
            //int[] arr = new int[n];
            //for(int i = 0; i < n; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //Array.Sort(arr);
            //Console.WriteLine($"Minimum Element is {arr[0]}");
            //Console.WriteLine($"Maximum Element is {arr[n-1]}");
            #endregion
            #region 8
            //int n;
            //int.TryParse(Console.ReadLine(), out n);
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //Array.Sort(arr);
            //int large = arr[n - 1];
            //int pointer = n-1;
            //while (pointer>=0 && (arr[pointer] == large))
            //{
            //    pointer--;
            //}
            //if (pointer < 0)
            //{
            //    Console.WriteLine("There is no second larger");
            //}
            //else
            //{
            //    Console.WriteLine(arr[pointer]);
            //}
            #endregion
            #region 9
            //int n;
            //int.TryParse(Console.ReadLine(), out n);
            //int[] arr = new int[n];
            //for(int i = 0; i < n; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //int mx = 0;
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            mx = int.Max(mx, j - i - 1);
            //        }
            //    }
            //}
            //Console.WriteLine(mx);
            #endregion
            #region 10
            //string s;
            //s = Console.ReadLine();
            //int size = 1;
            //string res = "";
            //for(int i = 0; i < s.Length; i++)
            //{
            //    if (s[i]==' ')
            //    {
            //        size++;
            //    }
            //}
            //string[] words = new string[size];
            //int p = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == ' ')
            //    {
            //        words[p] = res;
            //        res = "";
            //        p++;
            //    }
            //    else
            //    {
            //        res += s[i];
            //    }
            //}
            //words[p] = res;
            //for (int i = size-1; i >=0; i--)
            //{
            //    Console.Write(words[i]);
            //    Console.Write(" ");
            //}
            //**************************************
            //Or
            //************************************
            //string[] words = s.Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries);
            //for(int i = words.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(words[i]);
            //    Console.Write(" ");
            //}
            #endregion
            #region 11
            //int n,m;
            //int.TryParse(Console.ReadLine(), out n);
            //int.TryParse(Console.ReadLine(), out m);
            //int[,] arr1 = new int[n, m],arr2=new int[n,m];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        int.TryParse(Console.ReadLine(), out arr1[i, j]);
            //    }
            //}
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < m; j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //    }
            //}
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < m; j++)
            //    {
            //        Console.Write(arr2[i,j]+" ");
            //    }
            //    Console.WriteLine("");
            //}
            #endregion
            #region 12
            //int n;
            //int.TryParse(Console.ReadLine(), out n);
            //int[] arr = new int[n];
            //for(int i = 0; i < n; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //for(int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i]+" ");
            //}
            #endregion
        }
    }
}
