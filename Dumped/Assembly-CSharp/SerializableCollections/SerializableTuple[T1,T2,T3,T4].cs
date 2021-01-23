/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SerializableCollections
{
	[Serializable]
	public abstract class SerializableTuple<T1, T2, T3, T4> : IEquatable<SerializableCollections.SerializableTuple<T1, T2, T3, T4>>
	{
		// Fields
		[SerializeField]
		private T1 item1;
		[SerializeField]
		private T2 item2;
		[SerializeField]
		private T3 item3;
		[SerializeField]
		private T4 item4;
	
		// Properties
		public T1 Item1 { get; }
		public T2 Item2 { get; }
		public T3 Item3 { get; }
		public T4 Item4 { get; }
	
		// Constructors
		public SerializableTuple();
		public SerializableTuple(T1 item1, T2 item2, T3 item3, T4 item4);
	
		// Methods
		public bool Equals(SerializableTuple<T1, T2, T3, T4> other);
		public override int GetHashCode();
		public override string ToString();
	}
}
