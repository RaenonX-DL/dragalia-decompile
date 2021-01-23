/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class CurseBoxHit : GimmickBase
	{
		// Fields
		public GimmickCurseboxElement variation;
		public CollisionHitAttribute hitAttribute;
		private HashSet<int> victim;
		private SphereCollider hitCollider;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Action_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CurseBoxHit __4__this;
			public Vector3 pos;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Action_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CurseBoxHit();
	
		// Methods
		private void Start();
		public void StartAction(Vector3 pos);
		[IteratorStateMachine]
		private IEnumerator Action(Vector3 pos);
		private void OnTriggerEnter(Collider other);
	}
}
