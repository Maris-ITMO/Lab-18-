using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18_Самработа_Коллекции
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            Console.WriteLine(Check(Console.ReadLine()) ? "Корректно расставлены" : "Некорректно расставлены");
            Console.ReadKey();
        }
        static bool Check(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> sk = new Dictionary<char, char>
            {
                ['('] = ')',
                ['['] = ']',
                ['{'] = '}',
            };
            foreach (char c in s)
            {
                if (sk.ContainsKey(c))
                {
                    stack.Push(sk[c]);
                }
                if (sk.ContainsValue(c))
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}


/// ВАРИАНТ ВТОРОЙ 

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите строку");
//            Console.WriteLine(Check(Console.ReadLine()) ? "Корректно расставлены" : "Некорректно расставлены");
//            Console.ReadKey();
//        }

//        static bool Check(string str)
//        {
//            Stack<char> stack = new Stack<char>();
//            foreach (char c in str)
//            {
//                if (c == '(' || c == '[' || c == '{')
//                {
//                    stack.Push(c);
//                }
//                else if (c == ')' || c == ']' || c == '}')
//                {
//                    if (stack.Count == 0)
//                    {
//                        return false;
//                    }
//                    char top = stack.Pop();
//                    if (c == ')' && top != '(' ||
//                        c == ']' && top != '[' ||
//                        c == '}' && top != '{')
//                    {
//                        return false;
//                    }
//                }
//            }
//            if (stack.Count == 0)
//                return true;
//            else
//                return false;
//        }
//    }
//}