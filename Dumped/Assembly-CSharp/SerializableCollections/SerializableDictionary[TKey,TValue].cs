/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SerializableCollections
{
	[Serializable]
	public class SerializableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary
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
		private TValue[] entriesValue;
		[HideInInspector]
		[SerializeField]
		private int freeCount;
		[HideInInspector]
		[SerializeField]
		private int freeList;
		private int version;
		private KeyCollection keys;
		private ValueCollection values;
		private object _syncRoot;
	
		// Properties
		public virtual IEqualityComparer<TKey> Comparer { get; }
		public int Count { get; }
		public KeyCollection Keys { get; }
		ICollection<TKey> IDictionary<TKey,TValue>.Keys { get; }
		public ValueCollection Values { get; }
		ICollection<TValue> IDictionary<TKey,TValue>.Values { get; }
		public TValue this[TKey key] { get => default; set {} }
		bool ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
		bool ICollection.IsSynchronized { get; }
		object ICollection.SyncRoot { get; }
		bool IDictionary.IsFixedSize { get; }
		bool IDictionary.IsReadOnly { get; }
		ICollection IDictionary.Keys { get; }
		ICollection IDictionary.Values { get; }
		object IDictionary.this[object key] { get => default; set {} }
	
		// Nested types
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDictionaryEnumerator
		{
			// Fields
			private SerializableDictionary<TKey, TValue> dictionary;
			private int version;
			private int index;
			private KeyValuePair<TKey, TValue> current;
			private int getEnumeratorRetType;
			internal const int DictEntry = 1;
			internal const int KeyValuePair = 2;
	
			// Properties
			public KeyValuePair<TKey, TValue> Current { get; }
			object IEnumerator.Current { get; }
			DictionaryEntry IDictionaryEnumerator.Entry { get; }
			object IDictionaryEnumerator.Key { get; }
			object IDictionaryEnumerator.Value { get; }
	
			// Constructors
			internal Enumerator(SerializableDictionary<TKey, TValue> dictionary, int getEnumeratorRetType);
	
			// Methods
			public bool MoveNext();
			public void Dispose();
			void IEnumerator.Reset();
		}
	
		[DebuggerDisplay]
		[DebuggerTypeProxy]
		public sealed class KeyCollection : ICollection<TKey>, ICollection
		{
			// Fields
			private SerializableDictionary<TKey, TValue> dictionary;
	
			// Properties
			public int Count { get; }
			public TKey this[int index] { get => default; }
			bool ICollection<TKey>.IsReadOnly { get; }
			bool ICollection.IsSynchronized { get; }
			object ICollection.SyncRoot { get; }
	
			// Nested types
			public struct Enumerator : IEnumerator<TKey>
			{
				// Fields
				private SerializableDictionary<TKey, TValue> dictionary;
				private int index;
				private int version;
				private TKey currentKey;
	
				// Properties
				public TKey Current { get; }
				object IEnumerator.Current { get; }
	
				// Constructors
				internal Enumerator(SerializableDictionary<TKey, TValue> dictionary);
	
				// Methods
				public void Dispose();
				public bool MoveNext();
				void IEnumerator.Reset();
			}
	
			// Constructors
			public KeyCollection(SerializableDictionary<TKey, TValue> dictionary);
	
			// Methods
			public Enumerator GetEnumerator();
			public void CopyTo(TKey[] array, int index);
			void ICollection<TKey>.Add(TKey item);
			void ICollection<TKey>.Clear();
			bool ICollection<TKey>.Contains(TKey item);
			bool ICollection<TKey>.Remove(TKey item);
			IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator();
			IEnumerator IEnumerable.GetEnumerator();
			void ICollection.CopyTo(Array array, int index);
		}
	
		[DebuggerDisplay]
		[DebuggerTypeProxy]
		public sealed class ValueCollection : ICollection<TValue>, ICollection
		{
			// Fields
			private SerializableDictionary<TKey, TValue> dictionary;
	
			// Properties
			public int Count { get; }
			public TValue this[int index] { get => default; }
			bool ICollection<TValue>.IsReadOnly { get; }
			bool ICollection.IsSynchronized { get; }
			object ICollection.SyncRoot { get; }
	
			// Nested types
			public struct Enumerator : IEnumerator<TValue>
			{
				// Fields
				private SerializableDictionary<TKey, TValue> dictionary;
				private int index;
				private int version;
				private TValue currentValue;
	
				// Properties
				public TValue Current { get; }
				object IEnumerator.Current { get; }
	
				// Constructors
				internal Enumerator(SerializableDictionary<TKey, TValue> dictionary);
	
				// Methods
				public void Dispose();
				public bool MoveNext();
				void IEnumerator.Reset();
			}
	
			// Constructors
			public ValueCollection(SerializableDictionary<TKey, TValue> dictionary);
	
			// Methods
			public Enumerator GetEnumerator();
			public void CopyTo(TValue[] array, int index);
			void ICollection<TValue>.Add(TValue item);
			bool ICollection<TValue>.Remove(TValue item);
			void ICollection<TValue>.Clear();
			bool ICollection<TValue>.Contains(TValue item);
			IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator();
			IEnumerator IEnumerable.GetEnumerator();
			void ICollection.CopyTo(Array array, int index);
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
	
		// Constructors
		protected SerializableDictionary();
		protected SerializableDictionary(int initialCapacity);
		private SerializableDictionary(int staticCapacity, bool forceSize);
	
		// Methods
		public void Add(TKey key, TValue value);
		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair);
		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair);
		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair);
		public void Clear();
		public bool ContainsKey(TKey key);
		public bool ContainsValue(TValue value);
		private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index);
		public Enumerator GetEnumerator();
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator();
		public int FindEntry(TKey key);
		private void Initialize(int capacity);
		private void Initialize(int capacity, bool forceSize);
		private void Insert(TKey key, TValue value, bool add);
		private void Resize();
		private void Resize(int newSize, bool forceNewHashCodes);
		public bool Remove(TKey key);
		public bool TryGetValue(TKey key, out TValue value);
		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index);
		void ICollection.CopyTo(Array array, int index);
		IEnumerator IEnumerable.GetEnumerator();
		private static bool IsCompatibleKey(object key);
		void IDictionary.Add(object key, object value);
		bool IDictionary.Contains(object key);
		IDictionaryEnumerator IDictionary.GetEnumerator();
		void IDictionary.Remove(object key);
		public void TrimExcess();
	}
}
