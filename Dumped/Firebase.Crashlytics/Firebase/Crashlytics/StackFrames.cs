/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 46: Firebase.Crashlytics.dll - Assembly: Firebase.Crashlytics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Crashlytics
{
	internal class StackFrames : IDisposable, IEnumerable<Firebase.Crashlytics.FirebaseCrashlyticsFrame>
	{
		// Fields
		private HandleRef swigCPtr;
		protected bool swigCMemOwn;
	
		// Properties
		public bool IsFixedSize { get; }
		public bool IsReadOnly { get; }
		public FirebaseCrashlyticsFrame this[int index] { get => default; set {} }
		public int Capacity { get; set; }
		public int Count { get; }
		public bool IsSynchronized { get; }
	
		// Nested types
		public sealed class StackFramesEnumerator : IEnumerator<FirebaseCrashlyticsFrame>
		{
			// Fields
			private StackFrames collectionRef;
			private int currentIndex;
			private object currentObject;
			private int currentSize;
	
			// Properties
			object IEnumerator.Current { get; }
			public FirebaseCrashlyticsFrame Current { get; }
	
			// Constructors
			public StackFramesEnumerator(StackFrames collection);
	
			// Methods
			public bool MoveNext();
			public void Reset();
			public void Dispose();
		}
	
		// Constructors
		internal StackFrames(IntPtr cPtr, bool cMemoryOwn);
		public StackFrames(ICollection c);
		public StackFrames();
		public StackFrames(StackFrames other);
		public StackFrames(int capacity);
	
		// Methods
		internal static HandleRef getCPtr(StackFrames obj);
		~StackFrames();
		public virtual void Dispose();
		public void CopyTo(FirebaseCrashlyticsFrame[] array);
		public void CopyTo(FirebaseCrashlyticsFrame[] array, int arrayIndex);
		public void CopyTo(int index, FirebaseCrashlyticsFrame[] array, int arrayIndex, int count);
		IEnumerator<FirebaseCrashlyticsFrame> IEnumerable<FirebaseCrashlyticsFrame>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public StackFramesEnumerator GetEnumerator();
		public void Clear();
		public void Add(FirebaseCrashlyticsFrame x);
		private uint size();
		private uint capacity();
		private void reserve(uint n);
		private FirebaseCrashlyticsFrame getitemcopy(int index);
		private FirebaseCrashlyticsFrame getitem(int index);
		private void setitem(int index, FirebaseCrashlyticsFrame val);
		public void AddRange(StackFrames values);
		public StackFrames GetRange(int index, int count);
		public void Insert(int index, FirebaseCrashlyticsFrame x);
		public void InsertRange(int index, StackFrames values);
		public void RemoveAt(int index);
		public void RemoveRange(int index, int count);
		public static StackFrames Repeat(FirebaseCrashlyticsFrame value, int count);
		public void Reverse();
		public void Reverse(int index, int count);
		public void SetRange(int index, StackFrames values);
	}
}
