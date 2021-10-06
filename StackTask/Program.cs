using System;

namespace StackTask
{

	public class Program
    {
		public delegate void StackDelegate();
		static void Main(string[] args)
        {
			Console.WriteLine("let's start!!");
			IStack<int> s = new StackLinkList<int>();
			s.Push(1);
			s.Push(2);
			s.Push(3);
			s.Push(4);
			s.Push(5);
			s.Push(6);
			s.PrintByDelegate((x)=> { Console.Write(x.ToString()+", "); });
		}
	}
}
