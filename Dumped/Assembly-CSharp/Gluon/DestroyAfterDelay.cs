/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DestroyAfterDelay : MonoBehaviour
	{
		// Fields
		public float delay;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DestroyCoroutine_d__2 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DestroyAfterDelay __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DestroyCoroutine_d__2(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DestroyAfterDelay();
	
		// Methods
		private void Start();
		[IteratorStateMachine]
		private IEnumerator DestroyCoroutine();
	}
}
