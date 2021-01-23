/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class SwitchDoor : DoorBase
	{
		// Fields
		private bool reserveOpen;
		private float openDelaySec;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DisableCollider_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SwitchDoor __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DisableCollider_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SwitchDoor();
	
		// Methods
		protected override void Awake();
		protected override void Start();
		public override void Open();
		public void SetDisableColliderDeleySec(float sec);
		[IteratorStateMachine]
		private IEnumerator DisableCollider();
	}
}
