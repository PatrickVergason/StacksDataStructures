using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksDataStructures {
	public class Program {
		public static void Main(string[] args) {
			IQueue<int> q = new MyQueue<int>();
			q.Enqueue(1);
			q.Enqueue(2);
			q.Enqueue(3);

			Console.WriteLine(q.Dequeue());
			Console.WriteLine(q.Dequeue());
			Console.WriteLine(q.Dequeue());

			q.Enqueue(100);
			q.Enqueue(200);
			q.Enqueue(300);

			Console.WriteLine(q.Dequeue());
			Console.WriteLine(q.Dequeue());
			Console.WriteLine(q.Dequeue());
		}
	}
}