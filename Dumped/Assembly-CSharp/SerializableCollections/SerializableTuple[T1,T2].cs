/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SerializableCollections
{
	[Serializable]
	public abstract class SerializableTuple<T1, T2> : IEquatable<SerializableCollections.SerializableTuple<T1, T2>>
	{
		// Fields
		[SerializeField]
		private T1 item1;
		[SerializeField]
		private T2 item2;
	
		// Properties
		public T1 Item1 { get; }
		public T2 Item2 { get; }
	
		// Constructors
		public SerializableTuple();
		public SerializableTuple(T1 item1, T2 item2);
	
		// Methods
		public bool Equals(SerializableTuple<T1, T2> other);
		public override int GetHashCode();
		public override string ToString();
	}
}
