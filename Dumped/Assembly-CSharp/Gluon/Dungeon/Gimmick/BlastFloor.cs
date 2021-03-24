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
	public class BlastFloor : DelayedGimmickBase
	{
		// Fields
		public GimmickBlastFloor type;
		public string effectEnvironment;
		public string effectOmen;
		public string soundOmen;
		public string effectHit;
		public Vector3 blastPos;
		public Vector3 blastEuler;
		public int effectHitStopTrigger;
		protected EffectObject effect;
		protected EffectObject effectEnvironmentObject;
		private GimmickBlastFloorElement variation;
		private CollisionHitAttribute hitAttribute;
		private HashSet<int> victim;
		private BoxCollider hitCollider;
		private State _state;
	
		// Nested types
		public enum State
		{
			ActionRunning = 0,
			Waiting = 1
		}
	
		[CompilerGenerated]
		private sealed class _StartAction_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BlastFloor __4__this;
			public float delay;
			private Vector3 _pos_5__2;
			private Quaternion _quat_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartAction_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlaySE_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public string name;
			public BlastFloor __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlaySE_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BlastFloor();
	
		// Methods
		protected override void Awake();
		[IteratorStateMachine]
		private IEnumerator StartAction(float delay);
		[IteratorStateMachine]
		private IEnumerator PlaySE(string name, float delay);
		protected void OnActionEnd();
		private void OnTriggerEnter(Collider other);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
		public override void OnDisconnected();
		private void StartFirstAction();
	}
}
