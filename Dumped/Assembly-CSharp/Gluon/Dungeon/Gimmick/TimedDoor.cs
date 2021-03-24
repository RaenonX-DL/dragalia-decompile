/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class TimedDoor : DoorBase
	{
		// Fields
		[Lock]
		public TimedSwitchColor color;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Action_d__1 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TimedDoor __4__this;
			public float time;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Action_d__1(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TimedDoor();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Action(float time);
		public void StartAction(float time);
		[CompilerGenerated]
		[DebuggerHidden]
		private void __n__0();
		[CompilerGenerated]
		[DebuggerHidden]
		private void __n__1();
	}
}
