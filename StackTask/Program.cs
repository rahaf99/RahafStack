using System;

namespace StackTask
{
	public delegate void StackDelegate(String message);
	class Program
    {
		static void Main(string[] args)
        {
			StackDelegate del = Print;
			Console.WriteLine("let's start!!");
			StackLinkList<int> s = new StackLinkList<int>();
			s.push(1);
			s.push(2);
			s.push(3);
			s.push(4);
			s.push(5);
			s.push(6);
			s.print();
			del("s.pop: "+s.pop());
			s.print();
			del("s.peak: ");
			s.peak();
			s.print();
			del("s.clear: ");
			s.clear();
			s.print();
		}
		//StackDelegate del = (string message) =>  Console.WriteLine(message);
		static void Print(string message)
		{
			Console.WriteLine(message);
		}
	}
}
