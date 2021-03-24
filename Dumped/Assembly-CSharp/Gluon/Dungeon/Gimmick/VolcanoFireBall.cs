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
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class VolcanoFireBall : GimmickBase
	{
		// Fields
		private static List<VolcanoFireBall> allFireBallList;
		private bool ignoreClearListFlag;
		[SerializeField]
		private DungeonManager.eStageDifficulty enableVariation;
		[SerializeField]
		private int targetWaveId;
		[SerializeField]
		private float targetWaveDelaySec;
		[SerializeField]
		private float waitSecEffectToHit;
		private SphereCollider triggerCollider;
		[SerializeField]
		private string effectLabelMarker;
		[SerializeField]
		private int effectTriggerMarker;
		private EffectObject effectObjMarker;
		[SerializeField]
		private float markerOrthoSize;
		[SerializeField]
		public AnimationCurve markerScaleCurve;
		[SerializeField]
		private string effectLabelFall;
		[SerializeField]
		private int effectTriggerFall;
		[SerializeField]
		private int effectTriggerBreak;
		private EffectObject effectObjFall;
		[SerializeField]
		private Vector3 fallDirRot;
		[SerializeField]
		private string soundLabelFall;
		[SerializeField]
		private string soundLabelBreakl;
		[SerializeField]
		private string hitAttrLabel;
		private CollisionHitAttribute hitAttribute;
		[SerializeField]
		private List<BushClip> targetBushList;
		[SerializeField]
		private List<FieldHitCulling> targetHouseList;
		[SerializeField]
		[Tooltip]
		private int itemGroupId;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CoLoadFx_d__25 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public VolcanoFireBall __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoLoadFx_d__25(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CoFall_d__29 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public VolcanoFireBall __4__this;
			private float _waitSec_5__2;
			private float _endSec_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoFall_d__29(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public VolcanoFireBall();
		static VolcanoFireBall();
	
		// Methods
		protected override void Awake();
		[IteratorStateMachine]
		protected IEnumerator CoLoadFx();
		protected override void OnDestroy();
		public static void SetEruption(int id);
		private void StartFall(int id);
		[IteratorStateMachine]
		private IEnumerator CoFall();
		private void OnTriggerEnter(Collider other);
	}
}
