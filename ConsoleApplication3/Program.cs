using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public static int[] getNumber(int number)
        {
            int[] digits = number.ToString().Select(c => (int)char.GetNumericValue(c)).Reverse().ToArray();
            return digits;
        }

        private static bool IsPrime(int n)
        {
            bool prime = n == 2 || (n != 1 && n % 2 != 0);

            for (long i = 3; prime && i * i <= n; i += 2)
            {
                prime = n % i != 0;
            }

            return prime;
        }
      private static  int getNumber(int[] array)
        {
            int num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    num += array[i];
                }
                else
                {
                    num += (int)Math.Pow(10, i) * array[i];
                }
            }
            return num;
        }
        private static int[] makeCombination(int [] digits)
        { //197 971 719
            int[] newArray = new int[digits.Length];
            newArray[newArray.Length - 1] = digits[0];
            for (int i = 0; i < newArray.Length - 2; i++)
                newArray[i] = digits[i + 1];

                return newArray;
        }
        public static string RotateNumber(string number)
        {
            
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < number.Length; i++)
                sb.Append(number.Substring(i, 1));

            sb.Append(number[0]);

            return (sb.ToString());
        }
        public static bool isCircularPrime(int number)
        {


            string num = number.ToString();

            string buf = "";
            if (!IsPrime(Convert.ToInt32(num)))
            {
                return false;
            }
            buf = RotateNumber(num);
            if (!IsPrime(Convert.ToInt32(buf)))
            {
                return false;
            }
            while (buf != num)
            {
              //  Console.WriteLine(buf);
                buf = RotateNumber(buf);
                if (!IsPrime(Convert.ToInt32(buf)))
                {
                    return false;
                }
            }
            return true;
                
           
           
        }
        static void Main(string[] args)
        {
            int count = 0;
          for (int i=0;i<1000000;i++)
          {
            
             if (isCircularPrime(i))
               {
                   Console.WriteLine(i);
                   count++;
               }
           }
          Console.WriteLine(count);
          
           Console.ReadKey();
               
        }
    }
}
//commit