using System;
using UnityEngine;

namespace SerializableCollections
{
	[Serializable]
	public abstract class SerializableTuple<T1, T2> : IEquatable<SerializableTuple<T1, T2>>
	{
		[SerializeField]
		private T1 item1;

		[SerializeField]
		private T2 item2;

		public T1 Item1 => (T1)null;

		public T2 Item2 => (T2)null;

		public SerializableTuple()
		{
		}

		public SerializableTuple(T1 item1, T2 item2)
		{
		}

		public bool Equals(SerializableTuple<T1, T2> other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	public abstract class SerializableTuple<T1, T2, T3> : IEquatable<SerializableTuple<T1, T2, T3>>
	{
		[SerializeField]
		private T1 item1;

		[SerializeField]
		private T2 item2;

		[SerializeField]
		private T3 item3;

		public T1 Item1 => (T1)null;

		public T2 Item2 => (T2)null;

		public T3 Item3 => (T3)null;

		public SerializableTuple()
		{
		}

		public SerializableTuple(T1 item1, T2 item2, T3 item3)
		{
		}

		public bool Equals(SerializableTuple<T1, T2, T3> other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	public abstract class SerializableTuple<T1, T2, T3, T4> : IEquatable<SerializableTuple<T1, T2, T3, T4>>
	{
		[SerializeField]
		private T1 item1;

		[SerializeField]
		private T2 item2;

		[SerializeField]
		private T3 item3;

		[SerializeField]
		private T4 item4;

		public T1 Item1 => (T1)null;

		public T2 Item2 => (T2)null;

		public T3 Item3 => (T3)null;

		public T4 Item4 => (T4)null;

		public SerializableTuple()
		{
		}

		public SerializableTuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
		}

		public bool Equals(SerializableTuple<T1, T2, T3, T4> other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
