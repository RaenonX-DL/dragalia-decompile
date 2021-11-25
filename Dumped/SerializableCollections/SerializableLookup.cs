using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SerializableCollections
{
	[Serializable]
	public class SerializableLookup<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
	{
		private class Grouping : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
		{
			private readonly SerializableLookup<TKey, TElement> lookup;

			public TKey Key
			{
				[CompilerGenerated]
				get
				{
					return (TKey)null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public Grouping(SerializableLookup<TKey, TElement> lookup, TKey key)
			{
			}

			public IEnumerator<TElement> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private class LookupCollection : ICollection<TElement>, IEnumerable<TElement>, IEnumerable
		{
			private readonly SerializableLookup<TKey, TElement> lookup;

			private readonly int version;

			private readonly List<int> indexes;

			public int Count => default(int);

			public bool IsReadOnly => default(bool);

			public LookupCollection(SerializableLookup<TKey, TElement> lookup, TKey key)
			{
			}

			public void Add(TElement item)
			{
			}

			public void Clear()
			{
			}

			public bool Contains(TElement item)
			{
				return default(bool);
			}

			public void CopyTo(TElement[] array, int arrayIndex)
			{
			}

			public IEnumerator<TElement> GetEnumerator()
			{
				return null;
			}

			public bool Remove(TElement item)
			{
				return default(bool);
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
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
		private TElement[] entriesValue;

		private int version;

		public virtual IEqualityComparer<TKey> Comparer => null;

		public int Count => default(int);

		public IEnumerable<TElement> this[TKey key] => null;

		protected SerializableLookup()
		{
		}

		protected SerializableLookup(int initialCapacity)
		{
		}

		private SerializableLookup(int staticCapacity, bool forceSize)
		{
		}

		public void Add(TKey key, TElement value)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(TKey key)
		{
			return default(bool);
		}

		private int FindEntry(TKey key)
		{
			return default(int);
		}

		private IEnumerable<int> FindEntries(TKey key)
		{
			return null;
		}

		private void Initialize(int capacity)
		{
		}

		private void Initialize(int capacity, bool forceSize)
		{
		}

		private void Insert(TKey key, TElement value)
		{
		}

		private void Resize()
		{
		}

		private void Resize(int newSize, bool forceNewHashCodes)
		{
		}

		public bool TryGetValue(TKey key, out TElement value)
		{
			return default(bool);
		}

		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void TrimExcess()
		{
		}
	}
}
