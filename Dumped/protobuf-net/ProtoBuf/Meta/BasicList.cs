/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 39: protobuf-net.dll - Assembly: protobuf-net, Version=2.0.0.668, Culture=neutral, PublicKeyToken=257b51d87d2e4d67

namespace ProtoBuf.Meta
{
	[DefaultMember]
	internal class BasicList : IEnumerable
	{
		// Fields
		private static readonly Node nil;
		protected Node head;
	
		// Properties
		public int Count { get; }
	
		// Nested types
		public struct NodeEnumerator : IEnumerator
		{
			// Fields
			private int position;
			private readonly Node node;
	
			// Properties
			public object Current { get; }
	
			// Constructors
			internal NodeEnumerator(Node node);
	
			// Methods
			void IEnumerator.Reset();
			public bool MoveNext();
		}
	
		internal sealed class Node
		{
			// Fields
			private readonly object[] data;
			private int length;
	
			// Properties
			public object this[int index] { get => default; set {} }
			public int Length { get; }
	
			// Constructors
			internal Node(object[] data, int length);
	
			// Methods
			public void RemoveLastWithMutate();
			public Node Append(object value);
			internal int IndexOfReference(object instance);
			internal void Clear();
		}
	
		// Constructors
		public BasicList();
		static BasicList();
	
		// Methods
		public int Add(object value);
		IEnumerator IEnumerable.GetEnumerator();
		internal int IndexOfReference(object instance);
	}
}
