using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksDataStructures {
	public class Deque<T> : IStack<T>, IQueue<T> {
		public T? Dequeue() => throw new NotImplementedException();
		public void Enqueue(T item) => throw new NotImplementedException();
		public T? Peek() => throw new NotImplementedException();
		public T? Pop() => throw new NotImplementedException();
		public void Push(T item) => throw new NotImplementedException();
	}
}
