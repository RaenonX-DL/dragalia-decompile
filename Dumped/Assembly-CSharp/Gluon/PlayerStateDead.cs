/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerStateDead : IState<Gluon.PlayerCtrl>
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _Revive_d__2 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlayerStateDead __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Revive_d__2(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public PlayerStateDead();
	
		// Methods
		public override void OnStateEnter();
		public override void OnStateUpdate();
		[IteratorStateMachine]
		private IEnumerator Revive();
		private void Reraise();
	}
}
