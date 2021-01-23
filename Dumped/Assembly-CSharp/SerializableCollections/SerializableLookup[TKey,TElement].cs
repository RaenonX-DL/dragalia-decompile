/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SerializableCollections
{
	[Serializable]
	public class SerializableLookup<TKey, TElement> : ILookup<TKey, TElement>
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int[] buckets;
		[HideInInspector]
		[SerializeField]
		private int count;
		[HideInInspector]
		[SerializeField]
		private int[] entriesHashCode;
		[HideInInspector]
		[SerializeField]
		private int[] entriesNext;
		[HideInInspector]
		[SerializeField]
		private TKey[] entriesKey;
		[HideInInspector]
		[SerializeField]
		private TElement[] entriesValue;
		private int version;
	
		// Properties
		public virtual IEqualityComparer<TKey> Comparer { get; }
		public int Count { get; }
		public IEnumerable<TElement> this[TKey key] { get => default; }
	
		// Nested types
		private class Grouping : IGrouping<TKey, TElement>
		{
			// Fields
			private readonly SerializableLookup<TKey, TElement> lookup;
			[CompilerGenerated]
			private TKey _Key_k__BackingField;
	
			// Properties
			public TKey Key { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public Grouping(SerializableLookup<TKey, TElement> lookup, TKey key);
	
			// Methods
			public IEnumerator<TElement> GetEnumerator();
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		private class LookupCollection : ICollection<TElement>
		{
			// Fields
			private readonly SerializableLookup<TKey, TElement> lookup;
			private readonly int version;
			private readonly List<int> indexes;
	
			// Properties
			public int Count { get; }
			public bool IsReadOnly { get; }
	
			// Nested types
			[CompilerGenerated]
			private sealed class _GetEnumerator_d__12 : IEnumerator<TElement>
			{
				// Fields
				private int __1__state;
				private TElement __2__current;
				public LookupCollection<TKey, TElement> __4__this;
				private int _i_5__2;
	
				// Properties
				TElement IEnumerator<TElement>.Current { [DebuggerHidden] get; }
				object IEnumerator.Current { [DebuggerHidden] get; }
	
				// Constructors
				[DebuggerHidden]
				public _GetEnumerator_d__12(int __1__state);
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose();
				private bool MoveNext();
				[DebuggerHidden]
				void IEnumerator.Reset();
			}
	
			// Constructors
			public LookupCollection(SerializableLookup<TKey, TElement> lookup, TKey key);
	
			// Methods
			public void Add(TElement item);
			public void Clear();
			public bool Contains(TElement item);
			public void CopyTo(TElement[] array, int arrayIndex);
			[IteratorStateMachine]
			public IEnumerator<TElement> GetEnumerator();
			public bool Remove(TElement item);
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		private static class SR
		{
			// Fields
			public const string InvalidOperation_EnumFailedVersion = "InvalidOperation_EnumFailedVersion";
			public const string InvalidOperation_EnumOpCantHappen = "InvalidOperation_EnumOpCantHappen";
			public const string ArgumentOutOfRange_Index = "ArgumentOutOfRange_Index";
			public const string Argument_InvalidArrayType = "Argument_InvalidArrayType";
			public const string NotSupported_ValueCollectionSet = "NotSupported_ValueCollectionSet";
			public const string Arg_RankMultiDimNotSupported = "Arg_RankMultiDimNotSupported";
			public const string Arg_ArrayPlusOffTooSmall = "Arg_ArrayPlusOffTooSmall";
			public const string Arg_NonZeroLowerBound = "Arg_NonZeroLowerBound";
			public const string NotSupported_KeyCollectionSet = "NotSupported_KeyCollectionSet";
			public const string Arg_WrongType = "Arg_WrongType";
			public const string ArgumentOutOfRange_NeedNonNegNum = "ArgumentOutOfRange_NeedNonNegNum";
			public const string Arg_HTCapacityOverflow = "Arg_HTCapacityOverflow";
			public const string Argument_AddingDuplicate = "Argument_AddingDuplicate";
	
			// Methods
			public static string Format(string f, params object[] args);
		}
	
		private static class HashHelpers
		{
			// Fields
			public static readonly int[] primes;
			public const int MaxPrimeArrayLength = 2146435069;
	
			// Constructors
			static HashHelpers();
	
			// Methods
			public static int GetPrime(int min);
			public static int GetMinPrime();
			public static int ExpandPrime(int oldSize);
		}
	
		[CompilerGenerated]
		private sealed class _FindEntries_d__20 : IEnumerable<int>, IEnumerator<int>
		{
			// Fields
			private int __1__state;
			private int __2__current;
			private int __l__initialThreadId;
			private TKey key;
			public TKey __3__key;
			public SerializableLookup<TKey, TElement> __4__this;
			private int _hashCode_5__2;
			private int _i_5__3;
	
			// Properties
			int IEnumerator<System.Int32>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _FindEntries_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<int> IEnumerable<int>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__27 : IEnumerator<IGrouping<TKey, TElement>>
		{
			// Fields
			private int __1__state;
			private IGrouping<TKey, TElement> __2__current;
			public SerializableLookup<TKey, TElement> __4__this;
			private IEnumerator<TKey> __7__wrap1;
	
			// Properties
			IGrouping<TKey, TElement> IEnumerator<System.Linq.IGrouping<TKey,TElement>>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetEnumerator_d__27(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		protected SerializableLookup();
		protected SerializableLookup(int initialCapacity);
		private SerializableLookup(int staticCapacity, bool forceSize);
	
		// Methods
		public void Add(TKey key, TElement value);
		public void Clear();
		public bool Contains(TKey key);
		private int FindEntry(TKey key);
		[IteratorStateMachine]
		private IEnumerable<int> FindEntries(TKey key);
		private void Initialize(int capacity);
		private void Initialize(int capacity, bool forceSize);
		private void Insert(TKey key, TElement value);
		private void Resize();
		private void Resize(int newSize, bool forceNewHashCodes);
		public bool TryGetValue(TKey key, out TElement value);
		[IteratorStateMachine]
		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public void TrimExcess();
	}
}
