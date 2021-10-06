using System;

namespace StackTask
{

	public class Program
    {
		public delegate void StackDelegate();
		static void Main(string[] args)
        {
			Console.WriteLine("let's start!!");
			StackLinkList<int> s = new StackLinkList<int>();
			s.push(1);
			s.push(2);
			s.push(3);
			s.push(4);
			s.push(5);
			s.push(6);
			s.printByDelegate((x)=> { Console.Write(x.ToString()+", "); });
		
		}
		
	}
}
