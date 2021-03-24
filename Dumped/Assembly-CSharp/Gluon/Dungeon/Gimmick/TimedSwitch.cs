/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class TimedSwitch : GimmickBase
	{
		// Fields
		public GimmickTimedSwitch type;
		[Lock]
		public TimedSwitchColor color;
		private GimmickTimedSwitchElement variation;
		private HashSet<int> triggerHistory;
		private bool hitted;
		private Animator anim;
		private TimedSwitch[] timedSwitch;
		private TimedDoor[] timedDoor;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Action_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TimedSwitch __4__this;
			public float time;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Action_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _DisplayCloseMessage_d__14 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float time;
			public TimedSwitch __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DisplayCloseMessage_d__14(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TimedSwitch();
	
		// Methods
		protected override void Awake();
		[IteratorStateMachine]
		public IEnumerator Action(float time);
		public void StartAction(float time);
		private void OnTriggerEnter(Collider other);
		private void OnTriggerExit(Collider other);
		private void OnCollided(GameObject target, bool fromEvent);
		[IteratorStateMachine]
		private IEnumerator DisplayCloseMessage(float time);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
		public override bool CanDetectedForAutoPlayMode();
	}
}
