using System;
using System.Collections;

namespace StackExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack my_stack=new Stack();
            my_stack.Push("sarita");
            my_stack.Push("Rita");
            my_stack.Push("Ram");
            my_stack.Push("Shayam");
            foreach(string str in my_stack)
            {
                Console.WriteLine(str);

            }
            Console.WriteLine("After poping the elements");
            my_stack.Pop();
            foreach(string str in my_stack)
            {
                Console.WriteLine(str);
            }
        }
    }
}