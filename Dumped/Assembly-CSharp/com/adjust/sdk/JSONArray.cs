/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace com.adjust.sdk
{
	public class JSONArray : JSONNode, IEnumerable
	{
		// Fields
		private List<JSONNode> m_List;
	
		// Properties
		public override JSONNode this[int aIndex] { get => default; set {} }
		public override JSONNode this[string aKey] { get => default; set {} }
		public override int Count { get; }
		public override IEnumerable<JSONNode> Childs { [IteratorStateMachine] get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _get_Childs_d__13 : IEnumerable<JSONNode>, IEnumerator<JSONNode>
		{
			// Fields
			private int __1__state;
			private JSONNode __2__current;
			private int __l__initialThreadId;
			public JSONArray __4__this;
			private List<JSONNode> __7__wrap1;
	
			// Properties
			JSONNode IEnumerator<com.adjust.sdk.JSONNode>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _get_Childs_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__14 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public JSONArray __4__this;
			private List<JSONNode> __7__wrap1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetEnumerator_d__14(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public JSONArray();
	
		// Methods
		public override void Add(string aKey, JSONNode aItem);
		public override JSONNode Remove(int aIndex);
		public override JSONNode Remove(JSONNode aNode);
		[IteratorStateMachine]
		public IEnumerator GetEnumerator();
		public override string ToString();
		public override string ToString(string aPrefix);
		public override void Serialize(BinaryWriter aWriter);
	}
}
