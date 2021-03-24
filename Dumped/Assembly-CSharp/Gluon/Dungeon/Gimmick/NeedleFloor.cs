/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class NeedleFloor : DelayedGimmickBase
	{
		// Fields
		protected Animator anim;
		protected int idle;
		private GimmickNeedleFloorElement variation;
		private CollisionHitAttribute hitAttribute;
		private HashSet<int> victim;
		private State _state;
	
		// Nested types
		public enum State
		{
			ActionRunning = 0,
			Waiting = 1
		}
	
		[CompilerGenerated]
		private sealed class _StartAction_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NeedleFloor __4__this;
			public float delay;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartAction_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlaySE_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public string name;
			public NeedleFloor __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlaySE_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public NeedleFloor();
	
		// Methods
		protected override void Awake();
		[IteratorStateMachine]
		private IEnumerator StartAction(float delay);
		[IteratorStateMachine]
		private IEnumerator PlaySE(string name, float delay);
		public void OnActionEnd();
		private void OnTriggerEnter(Collider other);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
		public override void OnDisconnected();
		private void StartFirstAction();
	}
}
