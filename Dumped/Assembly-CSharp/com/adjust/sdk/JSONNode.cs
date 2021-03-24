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
	public class JSONNode
	{
		// Properties
		public virtual JSONNode this[int aIndex] { get => default; set {} }
		public virtual JSONNode this[string aKey] { get => default; set {} }
		public virtual string Value { get; set; }
		public virtual int Count { get; }
		public virtual IEnumerable<JSONNode> Childs { [IteratorStateMachine] get; }
		public IEnumerable<JSONNode> DeepChilds { [IteratorStateMachine] get; }
		public virtual int AsInt { get; set; }
		public virtual float AsFloat { get; set; }
		public virtual double AsDouble { get; set; }
		public virtual bool AsBool { get; set; }
		public virtual JSONArray AsArray { get; }
		public virtual JSONClass AsObject { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _get_Childs_d__17 : IEnumerable<JSONNode>, IEnumerator<JSONNode>
		{
			// Fields
			private int __1__state;
			private JSONNode __2__current;
			private int __l__initialThreadId;
	
			// Properties
			JSONNode IEnumerator<com.adjust.sdk.JSONNode>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _get_Childs_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated]
		private sealed class _get_DeepChilds_d__19 : IEnumerable<JSONNode>, IEnumerator<JSONNode>
		{
			// Fields
			private int __1__state;
			private JSONNode __2__current;
			private int __l__initialThreadId;
			public JSONNode __4__this;
			private IEnumerator<JSONNode> __7__wrap1;
			private IEnumerator<JSONNode> __7__wrap2;
	
			// Properties
			JSONNode IEnumerator<com.adjust.sdk.JSONNode>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _get_DeepChilds_d__19(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			private void __m__Finally2();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		// Constructors
		public JSONNode();
	
		// Methods
		public virtual void Add(string aKey, JSONNode aItem);
		public virtual void Add(JSONNode aItem);
		public virtual JSONNode Remove(string aKey);
		public virtual JSONNode Remove(int aIndex);
		public virtual JSONNode Remove(JSONNode aNode);
		public override string ToString();
		public virtual string ToString(string aPrefix);
		public static implicit operator JSONNode(string s);
		public static implicit operator string(JSONNode d);
		public static bool operator ==(JSONNode a, object b);
		public static bool operator !=(JSONNode a, object b);
		public override bool Equals(object obj);
		public override int GetHashCode();
		internal static string Escape(string aText);
		public static JSONNode Parse(string aJSON);
		public virtual void Serialize(BinaryWriter aWriter);
		public void SaveToStream(Stream aData);
		public void SaveToCompressedStream(Stream aData);
		public void SaveToCompressedFile(string aFileName);
		public string SaveToCompressedBase64();
		public static JSONNode Deserialize(BinaryReader aReader);
		public static JSONNode LoadFromCompressedFile(string aFileName);
		public static JSONNode LoadFromCompressedStream(Stream aData);
		public static JSONNode LoadFromCompressedBase64(string aBase64);
		public static JSONNode LoadFromStream(Stream aData);
		public static JSONNode LoadFromBase64(string aBase64);
	}
}
