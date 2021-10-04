using System;

namespace StackTask
{
    class Program
    {
        static void Main(string[] args)
        {
				Console.WriteLine("let's start!!");
				StackUsingList<int> s = new StackUsingList<int>();
				s.push(1);
				s.print();
				Console.WriteLine("---------------");
				s.push(2);
				s.print();
				Console.WriteLine("---------------");
				s.push(3);
				s.print();
				Console.WriteLine("---------------");
				s.push(4);
				s.print();
				Console.WriteLine("---------------");
				s.push(5);
				s.print();
				Console.WriteLine("---------------");
				s.push(6);
				s.print();
				Console.WriteLine("---------------");
				Console.WriteLine(s.pop());
				s.print();
				Console.WriteLine("---------------");
				s.peak();
				Console.WriteLine("---------------");
				s.print();
				Console.WriteLine("---------------");
				s.clear();
				Console.WriteLine("---------------");
				s.print();
				Console.WriteLine("---------------");
			}
    }
}
