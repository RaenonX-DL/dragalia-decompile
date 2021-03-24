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
	public class SeaAnemoneBullet : GimmickBase
	{
		// Fields
		private GimmickSeaAnemoneElement variationData;
		private static readonly int effectTriggerMove;
		private static readonly int effectTriggerBreak;
		private EffectObject effectObj;
		private CollisionHitAttribute hitAttribute;
		private GameObject effectParentObj;
		private bool hitFlag;
		private SphereCollider hitCollider;
		private HashSet<int> victim;
		[CompilerGenerated]
		private bool _isAction_k__BackingField;
		public static readonly float bulletFirstWaitSec;
		private static readonly float sinWaveCycle;
		private static readonly float sinWaveHeight;
		public static readonly float heightStartOffset;
		public static readonly float heightMoveSec;
	
		// Properties
		public bool isAction { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Action_d__20 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SeaAnemoneBullet __4__this;
			public Vector3 startPos;
			public Vector3 targetPos;
			private Vector3 _targetDir_5__2;
			private float _subHeight_5__3;
			private float _moveSec_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Action_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SeaAnemoneBullet();
		static SeaAnemoneBullet();
	
		// Methods
		public void Initialize(GimmickSeaAnemoneElement data);
		public void StartAction(Vector3 startPos, Vector3 targetPos);
		[IteratorStateMachine]
		private IEnumerator Action(Vector3 startPos, Vector3 targetPos);
		private void OnTriggerEnter(Collider other);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
	}
}
