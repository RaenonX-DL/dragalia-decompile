/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Dungeon;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class CurseBox : DungeonObjectBase
	{
		// Fields
		public float dropTime;
		private GimmickCurseboxElement variation;
		private CurseBoxHit curseBoxHit;
		protected bool hitted;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DropCurse_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CurseBox __4__this;
			public Vector3 pos;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DropCurse_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Disppear_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CurseBox __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Disppear_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CurseBox();
	
		// Methods
		protected override void Awake();
		public override void OnCollided(GameObject target, CollisionHitAttribute data);
		[IteratorStateMachine]
		protected IEnumerator DropCurse(Vector3 pos);
		[IteratorStateMachine]
		private IEnumerator Disppear();
		private void OnCollided(GameObject target, bool fromEvent);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
	}
}
