using System;
using System.Collections.Generic;

namespace Practise
{

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override int GetHashCode()
        {
            //return (X, Y).GetHashCode();

            int value = 0;
            value += int.MaxValue;
            value += Y;
            return value * X;
        }

        public static bool CompareHashCode(Point p1, Point p2)
        {
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            return p1.GetHashCode() == p2.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point(0, 0);
            //Point p2 = new Point(1, 1);

            //if (Point.CompareHashCode(p1, p2))
            //{
            //    Console.WriteLine("equals");
            //};

            //try
            //{
            //    throw new Exception();
            //}
            //finally
            //{
            //    Console.WriteLine("block finally");
            //}
            string result = DuplicateEncode("recede");
            Console.WriteLine(result);
        }

        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (dic.ContainsKey(word[i]))
                {
                    dic[word[i]] = dic[word[i]] + 1;
                }
                else
                {
                    dic.Add(word[i], 1);
                }
            }

            foreach (KeyValuePair<char, int> pair in dic)
            {
                if (pair.Value > 1)
                {
                    word.Replace(pair.Key, ')');
                }
                else
                {
                   word =  word.Replace(pair.Key, '(');
                }
            }

            return word;
        }

    }

    
   
}
