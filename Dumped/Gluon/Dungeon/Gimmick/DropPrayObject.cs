using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class DropPrayObject : DungeonObjectBase
	{
		public struct PrayObjectAppearStaticDic
		{
			public Dictionary<int, int> appearCount;

			public Dictionary<int, int> reserveCount;
		}

		public struct WillAppearObjectStruct
		{
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
			public float lifeTime_NORMAL;

			public float lifeTime_VERYHARD;

			public float lifeTime_EXTREME;

			public float lifeTime_HELL;

			public float lifeTime_ULTIMATE;
		}

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

		protected override void Start()
		{
		}

		public void Initialize()
		{
		}

		public override void FastUpdate()
		{
		}

		public override void OnCollided(GameObject target, CollisionHitAttribute data)
		{
		}

		private void Appear(int index, bool isFromEvent, Vector3 position, Quaternion rotation, [Optional] CharacterBase owner, float lifeTime = 0f, bool showMarker = false)
		{
		}

		private IEnumerator AppearCoroutine(DropPrayObject appearObject, Vector3 targetPos, Quaternion rotation, float timer, float markerChargeTime, bool isFromEvent, bool showMarker, [Optional] CharacterBase owner)
		{
			return null;
		}

		private void Hit(bool fromEvent, bool naturallyDisappear, [Optional] CharacterBase owner)
		{
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}

		private IEnumerator Disappear()
		{
			return null;
		}

		public float GetLifeTime()
		{
			return default(float);
		}

		public static bool isDropPrayObjectAvailable()
		{
			return default(bool);
		}

		public static void setDropPrayObjectNoTarget()
		{
		}

		public void IgnoreEnemyAndObjectCollision(CharacterBase target)
		{
		}

		public static void AppearFromMultiBullet(CharacterBase owner, Transform transform, float lifeTime = 0f, bool showMarker = false)
		{
		}

		public bool CanAppear()
		{
			return default(bool);
		}

		protected override void OnDestroy()
		{
		}

		public static void DestoryAllActiveObject()
		{
		}

		public void ResetWillAppearObjectStruct()
		{
		}

		public static void AppearWillAppearObjectStruct()
		{
		}

		public static void OnDisconnectUser(int disconnectActorId)
		{
		}

		public static void ClearDropPrayObjectList()
		{
		}
	}
}
