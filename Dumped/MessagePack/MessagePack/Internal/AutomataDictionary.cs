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
using System.Text;

// Image 51: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Internal
{
	public class AutomataDictionary : IEnumerable<KeyValuePair<string, int>>
	{
		// Fields
		private readonly AutomataNode root;
	
		// Nested types
		private class AutomataNode : IComparable<AutomataNode>
		{
			// Fields
			private static readonly AutomataNode[] emptyNodes;
			private static readonly long[] emptyKeys;
			public long Key;
			public int Value;
			public string originalKey;
			private AutomataNode[] nexts;
			private long[] nextKeys;
			private int count;
	
			// Nested types
			[CompilerGenerated]
			private sealed class _YieldChildren_d__17 : IEnumerable<AutomataNode>, IEnumerator<AutomataNode>
			{
				// Fields
				private int __1__state;
				private AutomataNode __2__current;
				private int __l__initialThreadId;
				public AutomataNode __4__this;
				private int _i_5__1;
	
				// Properties
				AutomataNode IEnumerator<MessagePack.Internal.AutomataDictionary.AutomataNode>.Current { [DebuggerHidden] get; }
				object IEnumerator.Current { [DebuggerHidden] get; }
	
				// Constructors
				[DebuggerHidden]
				public _YieldChildren_d__17(int __1__state);
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose();
				private bool MoveNext();
				[DebuggerHidden]
				void IEnumerator.Reset();
				[DebuggerHidden]
				IEnumerator<AutomataNode> System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode>.GetEnumerator();
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator();
			}
	
			// Constructors
			public AutomataNode(long key);
			static AutomataNode();
	
			// Methods
			public AutomataNode Add(long key);
			public AutomataNode Add(long key, int value, string originalKey);
			public AutomataNode SearchNextSafe(byte[] p, ref int offset, ref int rest);
			internal static int BinarySearch(long[] array, int index, int length, long value);
			public int CompareTo(AutomataNode other);
			public IEnumerable<AutomataNode> YieldChildren();
		}
	
		[CompilerGenerated]
		private sealed class _YieldCore_d__8 : IEnumerable<KeyValuePair<string, int>>, IEnumerator<KeyValuePair<string, int>>
		{
			// Fields
			private int __1__state;
			private KeyValuePair<string, int> __2__current;
			private int __l__initialThreadId;
			private IEnumerable<AutomataNode> nexts;
			public IEnumerable<AutomataNode> __3__nexts;
			private AutomataNode _item_5__1;
			private IEnumerator<AutomataNode> __7__wrap1;
	
			// Properties
			KeyValuePair<string, int> IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Int32>>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _YieldCore_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		// Constructors
		public AutomataDictionary();
	
		// Methods
		public void Add(string str, int value);
		public bool TryGetValueSafe(ArraySegment<byte> key, out int value);
		public override string ToString();
		private static void ToStringCore(IEnumerable<AutomataNode> nexts, StringBuilder sb, int depth);
		IEnumerator IEnumerable.GetEnumerator();
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator();
		private static IEnumerable<KeyValuePair<string, int>> YieldCore(IEnumerable<AutomataNode> nexts);
	}
}
