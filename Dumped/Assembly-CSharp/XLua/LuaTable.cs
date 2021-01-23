/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	public class LuaTable : LuaBase
	{
		// Properties
		[Obsolete]
		public object this[string field] { get => default; set {} }
		[Obsolete]
		public object this[object field] { get => default; set {} }
		public int Length { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetKeys_d__15 : IEnumerable<object>, IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			private int __l__initialThreadId;
			public LuaTable __4__this;
			private IntPtr _L_5__2;
			private ObjectTranslator _translator_5__3;
			private int _oldTop_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetKeys_d__15(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated]
		private sealed class _GetKeys_d__16<T> : IEnumerable<T>, IEnumerator<T>
		{
			// Fields
			private int __1__state;
			private T __2__current;
			private int __l__initialThreadId;
			public LuaTable __4__this;
			private IntPtr _L_5__2;
			private ObjectTranslator _translator_5__3;
			private int _oldTop_5__4;
	
			// Properties
			T IEnumerator<T>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetKeys_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		// Constructors
		public LuaTable(int reference, LuaEnv luaenv);
	
		// Methods
		public void Get<TKey, TValue>(TKey key, out TValue value);
		public bool ContainsKey<TKey>(TKey key);
		public void Set<TKey, TValue>(TKey key, TValue value);
		public T GetInPath<T>(string path);
		public void SetInPath<T>(string path, T val);
		public void ForEach<TKey, TValue>(Action<TKey, TValue> action);
		[IteratorStateMachine]
		public IEnumerable GetKeys();
		[IteratorStateMachine]
		public IEnumerable<T> GetKeys<T>();
		[Obsolete]
		public T Get<T>(object key);
		public TValue Get<TKey, TValue>(TKey key);
		public TValue Get<TValue>(string key);
		public void SetMetaTable(LuaTable metaTable);
		public T Cast<T>();
		internal override void push(IntPtr L);
		public override string ToString();
	}
}
