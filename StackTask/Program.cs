using System;

namespace StackTask
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("let's start!!");
			StackUsingLinkList<int> s = new StackUsingLinkList<int>();
			s.push(1);
			s.push(2);
			s.push(3);
			s.push(4);
			s.push(5);
			s.push(6);
			s.print();
			Console.WriteLine("s.pop: "+s.pop());
			s.print();
			Console.WriteLine("s.peak: ");
			s.peak();
			s.print();
			Console.WriteLine("s.clear: ");
			s.clear();
			s.print();
		}
    }
}
