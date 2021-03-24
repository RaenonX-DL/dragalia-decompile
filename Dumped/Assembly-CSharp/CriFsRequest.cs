/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriFsRequest : CriDisposable
{
	// Fields
	[CompilerGenerated]
	private DoneDelegate _doneDelegate_k__BackingField;
	[CompilerGenerated]
	private bool _isDone_k__BackingField;
	[CompilerGenerated]
	private string _error_k__BackingField;
	[CompilerGenerated]
	private bool _isDisposed_k__BackingField;

	// Properties
	public DoneDelegate doneDelegate { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	public bool isDone { [CompilerGenerated] get; [CompilerGenerated] private set; }
	public string error { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	public bool isDisposed { [CompilerGenerated] get; [CompilerGenerated] protected set; }

	// Nested types
	public delegate void DoneDelegate(CriFsRequest request);

	[CompilerGenerated]
	private sealed class _CheckDone_d__23 : IEnumerator<object>
	{
		// Fields
		private int __1__state;
		private object __2__current;
		public CriFsRequest __4__this;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
		object IEnumerator.Current { [DebuggerHidden] get; }

		// Constructors
		[DebuggerHidden]
		public _CheckDone_d__23(int __1__state);

		// Methods
		[DebuggerHidden]
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden]
		void IEnumerator.Reset();
	}

	// Constructors
	public CriFsRequest();

	// Methods
	public override void Dispose();
	public virtual void Stop();
	public YieldInstruction WaitForDone(MonoBehaviour mb);
	protected virtual void Dispose(bool disposing);
	public virtual void Update();
	protected void Done();
	[IteratorStateMachine]
	private IEnumerator CheckDone();
	~CriFsRequest();
}

