/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class UsGeneric
{
	// Nested types
	[CompilerGenerated]
	private sealed class _Slice_d__0<T> : IEnumerable<List<T>>, IEnumerator<List<T>>
	{
		// Fields
		private int __1__state;
		private List<T> __2__current;
		private int __l__initialThreadId;
		private List<T> objList;
		public List<T> __3__objList;
		private int slice;
		public int __3__slice;
		private int _i_5__2;

		// Properties
		List<T> IEnumerator<System.Collections.Generic.List<T>>.Current { [DebuggerHidden] get; }
		object IEnumerator.Current { [DebuggerHidden] get; }

		// Constructors
		[DebuggerHidden]
		public _Slice_d__0(int __1__state);

		// Methods
		[DebuggerHidden]
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden]
		void IEnumerator.Reset();
		[DebuggerHidden]
		IEnumerator<List<T>> IEnumerable<List<T>>.GetEnumerator();
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator();
	}

	// Constructors
	public UsGeneric();

	// Methods
	[IteratorStateMachine]
	public static IEnumerable<List<T>> Slice<T>(List<T> objList, int slice);
	public static byte[] Convert<T>(T value);
	public static object Convert<T>(byte[] buffer, int startIndex);
}

