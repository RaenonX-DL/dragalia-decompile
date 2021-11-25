using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace SerializableCollections
{
	[Serializable]
	public class SerializableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection
	{
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable, IDictionaryEnumerator
		{
			private SerializableDictionary<TKey, TValue> dictionary;

			private int version;

			private int index;

			private KeyValuePair<TKey, TValue> current;

			private int getEnumeratorRetType;

			internal const int DictEntry = 1;

			internal const int KeyValuePair = 2;

			public KeyValuePair<TKey, TValue> Current => default(KeyValuePair<TKey, TValue>);

			object IEnumerator.Current => null;

			DictionaryEntry IDictionaryEnumerator.Entry => default(DictionaryEntry);

			object IDictionaryEnumerator.Key => null;

			object IDictionaryEnumerator.Value => null;

			internal Enumerator(SerializableDictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			public void Dispose()
			{
			}

			void IEnumerator.Reset()
			{
			}
		}

		[DebuggerDisplay("Count = {Count}")]
		public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection
		{
			public struct Enumerator : IEnumerator<TKey>, IEnumerator, IDisposable
			{
				private SerializableDictionary<TKey, TValue> dictionary;

				private int index;

				private int version;

				private TKey currentKey;

				public TKey Current => (TKey)null;

				object IEnumerator.Current => null;

				internal Enumerator(SerializableDictionary<TKey, TValue> dictionary)
				{
				}

				public void Dispose()
				{
				}

				public bool MoveNext()
				{
					return default(bool);
				}

				void IEnumerator.Reset()
				{
				}
			}

			private SerializableDictionary<TKey, TValue> dictionary;

			public int Count => default(int);

			public TKey this[int index] => (TKey)null;

			bool ICollection<TKey>.IsReadOnly => default(bool);

			bool ICollection.IsSynchronized => default(bool);

			object ICollection.SyncRoot => null;

			public KeyCollection(SerializableDictionary<TKey, TValue> dictionary)
			{
			}

			public Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}

			public void CopyTo(TKey[] array, int index)
			{
			}

			void ICollection<TKey>.Add(TKey item)
			{
			}

			void ICollection<TKey>.Clear()
			{
			}

			bool ICollection<TKey>.Contains(TKey item)
			{
				return default(bool);
			}

			bool ICollection<TKey>.Remove(TKey item)
			{
				return default(bool);
			}

			IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			void ICollection.CopyTo(Array array, int index)
			{
			}
		}

		[DebuggerDisplay("Count = {Count}")]
		public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection
		{
			public struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
			{
				private SerializableDictionary<TKey, TValue> dictionary;

				private int index;

				private int version;

				private TValue currentValue;

				public TValue Current => (TValue)null;

				object IEnumerator.Current => null;

				internal Enumerator(SerializableDictionary<TKey, TValue> dictionary)
				{
				}

				public void Dispose()
				{
				}

				public bool MoveNext()
				{
					return default(bool);
				}

				void IEnumerator.Reset()
				{
				}
			}

			private SerializableDictionary<TKey, TValue> dictionary;

			public int Count => default(int);

			public TValue this[int index] => (TValue)null;

			bool ICollection<TValue>.IsReadOnly => default(bool);

			bool ICollection.IsSynchronized => default(bool);

			object ICollection.SyncRoot => null;

			public ValueCollection(SerializableDictionary<TKey, TValue> dictionary)
			{
			}

			public Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}

			public void CopyTo(TValue[] array, int index)
			{
			}

			void ICollection<TValue>.Add(TValue item)
			{
			}

			bool ICollection<TValue>.Remove(TValue item)
			{
				return default(bool);
			}

			void ICollection<TValue>.Clear()
			{
			}

			bool ICollection<TValue>.Contains(TValue item)
			{
				return default(bool);
			}

			IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			void ICollection.CopyTo(Array array, int index)
			{
			}
		}

		private static class SR
		{
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

			public static string Format(string f, object[] args)
			{
				return null;
			}
		}

		private static class HashHelpers
		{
			public static readonly int[] primes;

			public const int MaxPrimeArrayLength = 2146435069;

			public static int GetPrime(int min)
			{
				return default(int);
			}

			public static int GetMinPrime()
			{
				return default(int);
			}

			public static int ExpandPrime(int oldSize)
			{
				return default(int);
			}
		}

		[SerializeField]
		[HideInInspector]
		private int[] buckets;

		[SerializeField]
		[HideInInspector]
		private int count;

		[SerializeField]
		[HideInInspector]
		private int[] entriesHashCode;

		[SerializeField]
		[HideInInspector]
		private int[] entriesNext;

		[SerializeField]
		[HideInInspector]
		private TKey[] entriesKey;

		[SerializeField]
		[HideInInspector]
		private TValue[] entriesValue;

		[SerializeField]
		[HideInInspector]
		private int freeCount;

		[SerializeField]
		[HideInInspector]
		private int freeList;

		private int version;

		private KeyCollection keys;

		private ValueCollection values;

		private object _syncRoot;

		public virtual IEqualityComparer<TKey> Comparer => null;

		public int Count => default(int);

		public KeyCollection Keys => null;

		ICollection<TKey> IDictionary<TKey, TValue>.Keys => null;

		public ValueCollection Values => null;

		ICollection<TValue> IDictionary<TKey, TValue>.Values => null;

		public TValue this[TKey key]
		{
			get
			{
				return (TValue)null;
			}
			set
			{
			}
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => default(bool);

		bool ICollection.IsSynchronized => default(bool);

		object ICollection.SyncRoot => null;

		bool IDictionary.IsFixedSize => default(bool);

		bool IDictionary.IsReadOnly => default(bool);

		ICollection IDictionary.Keys => null;

		ICollection IDictionary.Values => null;

		object IDictionary.this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected SerializableDictionary()
		{
		}

		protected SerializableDictionary(int initialCapacity)
		{
		}

		private SerializableDictionary(int staticCapacity, bool forceSize)
		{
		}

		public void Add(TKey key, TValue value)
		{
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return default(bool);
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return default(bool);
		}

		public void Clear()
		{
		}

		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		public bool ContainsValue(TValue value)
		{
			return default(bool);
		}

		private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
		{
			return null;
		}

		public int FindEntry(TKey key)
		{
			return default(int);
		}

		private void Initialize(int capacity)
		{
		}

		private void Initialize(int capacity, bool forceSize)
		{
		}

		private void Insert(TKey key, TValue value, bool add)
		{
		}

		private void Resize()
		{
		}

		private void Resize(int newSize, bool forceNewHashCodes)
		{
		}

		public bool Remove(TKey key)
		{
			return default(bool);
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private static bool IsCompatibleKey(object key)
		{
			return default(bool);
		}

		void IDictionary.Add(object key, object value)
		{
		}

		bool IDictionary.Contains(object key)
		{
			return default(bool);
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		void IDictionary.Remove(object key)
		{
		}

		public void TrimExcess()
		{
		}
	}
}
