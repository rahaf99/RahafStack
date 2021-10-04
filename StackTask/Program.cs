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
				s.push(2);
				s.push(3);
				s.push(4);
				s.push(5);
				s.push(6);
				s.print();
				Console.WriteLine(s.pop());
				s.peak();
				s.print();
				s.clear();
				s.print();
			}
    }
}
