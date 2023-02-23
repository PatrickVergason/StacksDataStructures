using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StacksDataStructures {
	public interface IQueue<T> {
		public void Enqueue(T item);
		public T? Dequeue();
		public T? Peek();
	}
	public class MyQueue<T> : IQueue<T>, ICollection<T>, IEnumerable<T> {

		private T[] internalArray;

		public MyQueue(int maxSize = 10) {
			internalArray = new T[maxSize];
			CurrentLocation = internalArray.Length - 1;
		}
		private int _count;
		public int Count {
			get {
				return _count; }
			set {
				_count = Math.Max(0, value);
			}
		}
		private int _currentLocation;
		private int CurrentLocation {
			get {
				return _currentLocation;
			}
			set {
				_currentLocation = Math.Min(internalArray.Length - 1, value);
			}
		}

		public bool IsReadOnly => throw new NotImplementedException();

		public void Add(T item) {
			Enqueue(item);
		}
		public void Clear() => Array.Clear(internalArray);
		public bool Contains(T item) => throw new NotImplementedException();
		public void CopyTo(T[] array, int index) {
			if (index + Count > array.Length) {
				throw new ArgumentException("Target array isn't large enough to copy all elements of the stack.");
			}

			for (int i = 0; i < Count; i++) {
				array.SetValue(internalArray[i], index + i);
			}
		}
		public T? Dequeue() {
			Count--;
			CurrentLocation++;
			T? result = internalArray[internalArray.Length - 1];
			for (int i = internalArray.Length - 1; i > CurrentLocation; i--) {
				internalArray[i] = internalArray[i - 1];
			}
			return result;
		}
		public void Enqueue(T item) {
			Count++;
			internalArray[CurrentLocation--] = item;
		}
		public IEnumerator<T> GetEnumerator() {
			for (int i = internalArray.Length-1; i >= 0; i--) {
				yield return internalArray[i];
			}
		}
	public T? Peek() {
			return internalArray[internalArray.Length - 1];
		}
		public bool Remove(T item) => throw new NotImplementedException();
		IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
	}
}
