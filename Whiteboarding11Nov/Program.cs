using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboarding11Nov
{
    class Program
    {

        static void Main(string[] args)
        {          
            Console.WriteLine(FindSumIfValueIsNotInRange(21,60));
        }
       
        public static int FindSumIfValueIsNotInRange(int a, int b)
        {
            if (a <= 20 && a >= 10)
                return a;

            else if (b <= 20 && b >= 10)
                return b;
            else
                return a + b;


        }
        public static string FizzBuzz(string a)
        {
            if (a.StartsWith("F") && a.EndsWith("B"))
                return "FizzBuzz";
            else if (a.StartsWith("F"))
                return "Fizz";
            else if (a.EndsWith("B"))
                return "Buzz";
            else
                return a;
        }
        public static bool IsValueWithin2ofMultipleOfTen(int a)
        {
            return a % 10 <= 2;
        }
        public static bool IsMultipleButNotBoth(int a)
        {
            return a % 7 == 0 && a % 3 != 0 || a % 7 != 0 && a % 3 == 0;
        }
        public static bool IsMultipleOrOneAbove(int a)
        {
            return a % 13 == 0 || (a % 13) == 1;
        }
        public static bool IsSumDiffEitherValue5(int a, int b)
        {
            return a == 5 || b == 5 || a + b == 5 || Math.Abs(a - b) == 5;
        }
        public static string NewStringByIndices(string a)
        {
            if (a.Length < 9)
                return a;
            return a.Substring(0, 2) + a.Substring(4, 2) + a.Substring(8, 2);
        }
        public static string RemoveLetters(string a, char c)
        {
            string result = a;
            int i = 0;
            while(i < a.Length)
            {
                if(a[i] == c && i != 0 && i != a.Length-1)
                {
                   a = a.Remove(i, 1);
                }
                i++;
            }
            return a;
        }
        public static int ISubstringPresent(string a, string b)
        {
            int count = 0;
            int i = 0;
            while(i < a.Length-1 && i < b.Length-1)
            {
                if(a.Substring(i,2) == b.Substring(i,2))
                {
                    count++;
                }
                i++;
            }
            return count;
        }
        public static bool IsSequencePresent(string a)
        {
            int i = 2;
            while(i< a.Length)
            {
                if (a[i - 2] == a[i - 1] && a[i-1] == a[i])
                {
                    return true;
                }
                else
                    i++;
            }
            return false;
        }
        public static bool IsNumberPresent(int [] arr, int num)
        {
            return arr.Length < 4 ? arr.Contains(num) : arr.Take(4).Contains(num);
        }
        public static string EveryOtherletter(string s)
        {
            int i = 0;
            string newString = string.Empty;
            while(i < s.Length)
            {
                newString += s[i];
                i += 2;
            }
            return newString;
        }
        public static int HighestNumberWithinRange(int x, int y)
        {
            x = x <= 30 && x >= 20 ? x : 0;
            y = y <= 30 && y >= 20 ? y : 0;
            return Math.Max(x, y);
        }
        public static int ClosetTo100(int x, int y)
        {
            int result = x == y ? 0 : Math.Min(x - 100, y - 100);
            return result != 0 ? result + 100 : result;
        }
        public static int Max3(int x, int y, int z)
        {
            return Math.Max(x, Math.Max(y, z));
        }

        public static Dictionary<string, int> MeanMode(int[] arr)
        {
            int mode = 0;
            int count = 1;
            int curr = 0;
            int sum = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                count = arr[i] == arr[i - 1] ? ++count : count = 1;
                curr = curr < count ? count : curr;
                mode = curr == count ? arr[i - 1] : mode;
                sum += arr[i-1];
                sum += i + 1 == arr.Length - 1 ? arr[i] : 0;
            }
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("Mean", sum / arr.Length);
            d.Add("Mode", mode);
            return d; 
        }
        public static int DMode(int [] arr)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            foreach(var item in arr)
            {
                if(d.ContainsKey(item))
                {
                    d[item]++;
                }
                else
                {
                    d.Add(item, 1);
                }

            }
            return d.Keys.Max();
        }
        public static bool Test(int num)
        {
            return (num < 200 && num >= 190) || (num < 100 && num >= 90);
        }
        public static string IfString(string a)
        {
            a = a.Substring(0, 2).Equals("if") ? a : a.Insert(0,"if");
            return a;
        }
        public static string AddFirstLast(string s)
        {
            if (s.Length < 2)
                return s;
            else
            {
                var c = s.Substring(s.Length - 1);
                s = c + s + c;
            }
            return s;



            
        }
        
    }         
}














