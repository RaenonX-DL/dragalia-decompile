/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	[Serializable]
	[DebuggerDisplay]
	public class ExposedList<T> : IEnumerable<T>
	{
		// Fields
		public T[] Items;
		public int Count;
		private const int DefaultCapacity = 4;
		private static readonly T[] EmptyArray;
		private int version;
	
		// Properties
		public int Capacity { get; set; }
	
		// Nested types
		[Serializable]
		public struct Enumerator : IEnumerator<T>
		{
			// Fields
			private ExposedList<T> l;
			private int next;
			private int ver;
			private T current;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			internal Enumerator(ExposedList<T> l);
	
			// Methods
			public void Dispose();
			private void VerifyState();
			public bool MoveNext();
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ExposedList();
		public ExposedList(IEnumerable<T> collection);
		public ExposedList(int capacity);
		internal ExposedList(T[] data, int size);
		static ExposedList();
	
		// Methods
		public void Add(T item);
		public void GrowIfNeeded(int newCount);
		public ExposedList<T> Resize(int newSize);
		public void EnsureCapacity(int min);
		private void CheckRange(int index, int count);
		private void AddCollection(ICollection<T> collection);
		private void AddEnumerable(IEnumerable<T> enumerable);
		public void AddRange(IEnumerable<T> collection);
		public int BinarySearch(T item);
		public int BinarySearch(T item, IComparer<T> comparer);
		public int BinarySearch(int index, int count, T item, IComparer<T> comparer);
		public void Clear(bool clearArray = true);
		public bool Contains(T item);
		public ExposedList<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter);
		public void CopyTo(T[] array);
		public void CopyTo(T[] array, int arrayIndex);
		public void CopyTo(int index, T[] array, int arrayIndex, int count);
		public bool Exists(Predicate<T> match);
		public T Find(Predicate<T> match);
		private static void CheckMatch(Predicate<T> match);
		public ExposedList<T> FindAll(Predicate<T> match);
		private ExposedList<T> FindAllList(Predicate<T> match);
		public int FindIndex(Predicate<T> match);
		public int FindIndex(int startIndex, Predicate<T> match);
		public int FindIndex(int startIndex, int count, Predicate<T> match);
		private int GetIndex(int startIndex, int count, Predicate<T> match);
		public T FindLast(Predicate<T> match);
		public int FindLastIndex(Predicate<T> match);
		public int FindLastIndex(int startIndex, Predicate<T> match);
		public int FindLastIndex(int startIndex, int count, Predicate<T> match);
		private int GetLastIndex(int startIndex, int count, Predicate<T> match);
		public void ForEach(Action<T> action);
		public Enumerator GetEnumerator();
		public ExposedList<T> GetRange(int index, int count);
		public int IndexOf(T item);
		public int IndexOf(T item, int index);
		public int IndexOf(T item, int index, int count);
		private void Shift(int start, int delta);
		private void CheckIndex(int index);
		public void Insert(int index, T item);
		private void CheckCollection(IEnumerable<T> collection);
		public void InsertRange(int index, IEnumerable<T> collection);
		private void InsertCollection(int index, ICollection<T> collection);
		private void InsertEnumeration(int index, IEnumerable<T> enumerable);
		public int LastIndexOf(T item);
		public int LastIndexOf(T item, int index);
		public int LastIndexOf(T item, int index, int count);
		public bool Remove(T item);
		public int RemoveAll(Predicate<T> match);
		public void RemoveAt(int index);
		public T Pop();
		public void RemoveRange(int index, int count);
		public void Reverse();
		public void Reverse(int index, int count);
		public void Sort();
		public void Sort(IComparer<T> comparer);
		public void Sort(Comparison<T> comparison);
		public void Sort(int index, int count, IComparer<T> comparer);
		public T[] ToArray();
		public void TrimExcess();
		public bool TrueForAll(Predicate<T> match);
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}
}
