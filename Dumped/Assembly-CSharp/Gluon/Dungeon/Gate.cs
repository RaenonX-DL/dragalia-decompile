/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Gluon;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class Gate : Wall
	{
		// Fields
		[SerializeField]
		protected string systemOpenSoundLabel;
		protected Animator anim;
		private NavMeshObstacle _navMeshObs;
		protected int idle;
		protected GameObject arrow;
		protected Collider gateCollider;
		[FormerlySerializedAs]
		[SerializeField]
		protected string loopEffectId;
		[SerializeField]
		protected float loopEffectDelaySec;
		[FormerlySerializedAs]
		[SerializeField]
		protected Vector3 loopEffectOffset;
		[SerializeField]
		protected string openEffectId;
		[SerializeField]
		protected float openEffectDelaySec;
		[SerializeField]
		protected Vector3 openEffectOffset;
		[Lock]
		[SerializeField]
		protected string openedEffectId;
		protected EffectObject loopEffectGameObject;
		protected EffectObject openEffectGameObject;
		[Lock]
		[SerializeField]
		protected string environmentSE;
		[SerializeField]
		protected string openSE;
		protected AudioPlayback environmentSEPlayback;
		[Lock]
		[SerializeField]
		protected float openWaitTime;
		[Lock]
		[SerializeField]
		protected float nextArrowWaitTime;
		protected Dictionary<string, Localize.TextId> textDictionary;
	
		// Nested types
		protected enum EffectKind
		{
			LoopEffect = 0,
			OpenEffect = 1
		}
	
		[CompilerGenerated]
		private sealed class _PlayEffect_d__27 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delaySec;
			public string label;
			public Gate __4__this;
			public Vector3 offset;
			public EffectKind kind;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayEffect_d__27(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public Gate();
	
		// Methods
		protected override void Start();
		protected override void OnDestroy();
		public override void Opened(bool sw);
		public virtual void Update();
		protected override void OnTriggerEvent();
		[IteratorStateMachine]
		protected IEnumerator PlayEffect(EffectKind kind, string label, float delaySec, Vector3 offset);
	}
}
