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
using Gluon.Master;
using UnityEngine;
using UnityEngine.AI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class Down : DelayedGimmickBase
	{
		// Fields
		public GimmickDown type;
		public Vector3 hitCenter;
		public Vector3 hitSize;
		[SerializeField]
		private string effectName;
		[SerializeField]
		private Color effectColor;
		[SerializeField]
		private int effectTrigger;
		[SerializeField]
		private Vector3 effectPosition;
		[SerializeField]
		private float effectDelayTime;
		[SerializeField]
		private string soundCueNameAction;
		[SerializeField]
		private string soundCueName;
		[SerializeField]
		private float soundDelayTime;
		[SerializeField]
		private string dragonDestroyEffectName;
		[SerializeField]
		private int dragonDestroyEffectTrigger;
		[SerializeField]
		private float dragonDestroyEffectPosY;
		[SerializeField]
		private string dragonDestroySeName;
		[SerializeField]
		private float bodyHitCloseTime;
		[SerializeField]
		private bool attachFakeTopModel;
		[SerializeField]
		private bool hitAndDisableColliderFlag;
		private List<Collider> hitAndDisableColliderList;
		private List<NavMeshObstacle> hitAndDisableNavMeshList;
		protected Animator anim;
		protected int idle;
		private GimmickDownElement variation;
		private BoxCollider hitCollider;
		private BoxCollider sensingRangeCollider;
		private DownHit downHit;
		private List<GameObject> downHitPartsList;
		private AudioPlayback playback;
		private EffectObject effect;
		private ChargeMarker chargeMarker;
		private bool isHit;
		private DownBody downBody;
		private Transform topModel;
		private Transform fakeTopModel;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _StartAction_d__36 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Down __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartAction_d__36(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlaySE_d__42 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public Down __4__this;
			public string name;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlaySE_d__42(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayEffect_d__43 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public Down __4__this;
			public Vector3 pos;
			public string name;
			public int trigger;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayEffect_d__43(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public Down();
	
		// Methods
		private void Update();
		protected override void Awake();
		[IteratorStateMachine]
		private IEnumerator StartAction();
		public void DisableHitCollider();
		public void ClearChargeMarker();
		public void BreakObject();
		public void BreakObject(Vector3 pos, Quaternion rot);
		public void SetHitAndEnd();
		[IteratorStateMachine]
		private IEnumerator PlaySE(string name, float delay);
		[IteratorStateMachine]
		private IEnumerator PlayEffect(string name, int trigger, Vector3 pos, float delay);
		private void OnTriggerEnter(Collider other);
		public bool GetSensingRangeColliderEnabled();
	}
}
