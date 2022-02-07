using System;
using System.Linq;

namespace RefOutArrayString
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ref Out
            //int test1;
            //Console.WriteLine($"Line 10 Main Method: {test1}");


            //ChangeValueRef(ref test1);

            //Console.WriteLine($"Line 15 Main Method {test1}");

            //ChangeValueOut(out test1);

            //Console.WriteLine($"Line 15 Main Method {test1}");
            #endregion

            #region String Method
            //string word = "    HelloWadasdasdorlod     ";
            //char[] chararr = { 'H', 'h', 'r' };
            //bool checkchar = word.Contains('h');
            //bool checkchar = word.Contains("World");
            //bool checkchar = word.EndsWith('d');
            //bool checkchar = word.EndsWith("World");
            //bool checkchar = word.Equals("World");
            //int checkchar = word.IndexOf('h');
            //int firstindex_o = word.IndexOf('o');
            //firstindex_o++;
            //int checkchar = word.IndexOf('o',firstindex_o);
            //int checkchar = word.IndexOf('o', word.IndexOf('o')+1);
            //int checkchar = word.IndexOf('o', word.IndexOf('o')+1,10);
            //int checkchar = word.IndexOfAny(chararr);
            //string checkchar = String.Join('/', "word", "hello");
            //string checkchar = String.Join(" P225 ", "word", "hello");
            //int checkchar = word.LastIndexOf('o', word.LastIndexOf('o')-1);
            //int checkchar = word.LastIndexOf('a', word.LastIndexOf('a')-1,10);
            //string[] checkchar = word.Split('a');

            //foreach (string item in checkchar)
            //{
            //    Console.WriteLine(item);
            //}

            //string checkchar = word.Substring(5);
            //string checkchar = word.Substring(5,7);
            //string checkchar = word.ToLower();
            //string checkchar = word.ToUpper();
            //string checkchar = word;
            //Console.WriteLine(checkchar);
            //Console.WriteLine(checkchar.Length);
            //string checkchar2 = word.Trim();
            //Console.WriteLine(checkchar2);
            //Console.WriteLine(checkchar2.Length);
            //string checkchar = word;
            //Console.WriteLine(checkchar);
            //Console.WriteLine(checkchar.Length);
            //string checkchar2 = word.TrimEnd();
            //Console.WriteLine(checkchar2);
            //Console.WriteLine(checkchar2.Length);
            //string checkchar = word;
            //Console.WriteLine(checkchar);
            //Console.WriteLine(checkchar.Length);
            //string checkchar2 = word.TrimStart();
            //Console.WriteLine(checkchar2);
            //Console.WriteLine(checkchar2.Length);
            #endregion
            #region Array Method
            int[] numbers = { 5,77,8,10};
            numbers.Max();

            //int check = Array.IndexOf(numbers, 15);
            //Console.WriteLine(check);

            Array.Reverse(numbers);

            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            Array.Sort(numbers);

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            string[] arr = { };
            #endregion

        }

        #region Ref Out
        //static void ChangeValueRef(ref int a)
        //{
        //    a *= 5;
        //    Console.WriteLine($"Line 21 ChangeValueRef: {a}");
        //}

        //static void ChangeValueOut(out int a)
        //{
        //    a = 5;
        //    a *= 5;
        //    Console.WriteLine($"Line 21 ChangeValueOut: {a}");
        //}
        #endregion
    }
}
