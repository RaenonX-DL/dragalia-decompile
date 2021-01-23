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
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class DropPrayObject : DungeonObjectBase
	{
		// Fields
		private static DropPrayObject[] dropPrayArray;
		private int dropPrayIndex;
		public string effectName;
		public Vector3 effectOffset;
		private EffectObject effect;
		private int effectTriggerKill1;
		private int effectTriggerKill2;
		private int effectTriggerLoop;
		private float lifeTimer;
		private float lifeTimerInitialValue;
		private bool destroyed;
		private Collider _collider;
		private Vector3 safePosition;
		private bool isBeforeStart;
		private static bool isFirstTimeDestroyed;
		private bool isAppearing;
		private bool collisionOffFinished;
		private QuestSkillTalk _talk;
		[SerializeField]
		private LifeTime lifeTime;
		private bool isInvincible;
		private ChargeMarker _marker;
		private bool isDestoryDone;
		private static PrayObjectAppearStaticDic prayObjectAppearStatusDic;
		public WillAppearObjectStruct willAppearObjectStruct;
	
		// Nested types
		public struct PrayObjectAppearStaticDic
		{
			// Fields
			public Dictionary<int, int> appearCount;
			public Dictionary<int, int> reserveCount;
		}
	
		public struct WillAppearObjectStruct
		{
			// Fields
			public bool reserved;
			public int index;
			public Vector3 position;
			public Quaternion rotation;
			public CharacterBase owner;
			public float lifeTime;
			public bool showMarker;
		}
	
		[Serializable]
		public class LifeTime
		{
			// Fields
			public float lifeTime_NORMAL;
			public float lifeTime_VERYHARD;
			public float lifeTime_EXTREME;
			public float lifeTime_HELL;
			public float lifeTime_ULTIMATE;
	
			// Constructors
			public LifeTime();
		}
	
		[CompilerGenerated]
		private sealed class _AppearCoroutine_d__32 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DropPrayObject __4__this;
			public DropPrayObject appearObject;
			public float markerChargeTime;
			public Vector3 targetPos;
			public CharacterBase owner;
			public bool isFromEvent;
			public Quaternion rotation;
			public bool showMarker;
			public float timer;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AppearCoroutine_d__32(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Disappear_d__35 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DropPrayObject __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Disappear_d__35(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DropPrayObject();
		static DropPrayObject();
	
		// Methods
		protected override void Start();
		public void Initialize();
		public override void FastUpdate();
		public override void OnCollided(GameObject target, CollisionHitAttribute data);
		private void Appear(int index, bool isFromEvent, Vector3 position, Quaternion rotation, CharacterBase owner = null, float lifeTime = 0f, bool showMarker = false);
		[IteratorStateMachine]
		private IEnumerator AppearCoroutine(DropPrayObject appearObject, Vector3 targetPos, Quaternion rotation, float timer, float markerChargeTime, bool isFromEvent, bool showMarker, CharacterBase owner = null);
		private void Hit(bool fromEvent, bool naturallyDisappear, CharacterBase owner = null);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
		[IteratorStateMachine]
		private IEnumerator Disappear();
		public float GetLifeTime();
		public static bool isDropPrayObjectAvailable();
		public static void setDropPrayObjectNoTarget();
		public void IgnoreEnemyAndObjectCollision(CharacterBase target);
		public static void AppearFromMultiBullet(CharacterBase owner, Transform transform, float lifeTime = 0f, bool showMarker = false);
		public bool CanAppear();
		protected override void OnDestroy();
		public static void DestoryAllActiveObject();
		public void ResetWillAppearObjectStruct();
		public static void AppearWillAppearObjectStruct();
		public static void OnDisconnectUser(int disconnectActorId);
	}
}
