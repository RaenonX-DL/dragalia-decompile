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
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class BarrelBomb : DungeonObjectBase
	{
		// Fields
		private GimmickBarrelBombElement variation;
		public static readonly int SELF_BOMB_SETTING_MAX;
		private float originRadius;
		[SerializeField]
		private float MarkerRadiusScale;
		private static PlayerCharacter currentChara;
		private CollisionHitAttribute hitAttribute;
		private bool hasHit;
		private bool canExplode;
		[CompilerGenerated]
		private static bool _selfBombCanSetting_k__BackingField;
		private static BarrelBomb[] _barrelbombList;
		private static BarrelBomb selfBomb;
		private int bombIndex;
		private static int actorIndex;
		private int _explosionIndex;
		private Vector3 _reservedSettingPos;
		[CompilerGenerated]
		private static int _selfBombSettingCounter_k__BackingField;
		private SphereCollider _collider;
		private HashSet<int> victim;
		private List<GameObject> barrelBombRendererObjects;
		private bool isUpdateBarrelBombTimer;
		private BarrelBombGaugeUI barrelBombGaugeUI;
		private float putBombElapsed;
		private float putBombDuration;
		[SerializeField]
		private string SE_NAME;
		[SerializeField]
		private string BOMB_EFFECT_NAME;
		[SerializeField]
		private int EXPLOSION_EFFECT_TRIGGER;
		[SerializeField]
		private int SETTING_EFFECT_TRIGGER;
		private readonly float effect_duration;
		private QuestSkillButtonBase questSkillButton;
		private Vector3 safePosition;
	
		// Properties
		public static bool selfBombCanSetting { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static int selfBombSettingCounter { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _ExplosionCoroutine_d__40 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BarrelBomb __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ExplosionCoroutine_d__40(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SettingBarrelBombCoroutine_d__46 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BarrelBomb __4__this;
			public Vector3 settingPos;
			public float delay;
			public int index;
			private ChargeMarker __marker_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SettingBarrelBombCoroutine_d__46(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BarrelBomb();
		static BarrelBomb();
	
		// Methods
		protected override void Awake();
		protected override void Start();
		public void Initialize();
		private void Explosion(bool isFromEvent, int explosionIndex);
		[IteratorStateMachine]
		private IEnumerator ExplosionCoroutine();
		public override void OnEvent(DungeonObject eventObject, GameObject target);
		public override void FastUpdate();
		private void UpdateBarrelBombTimer();
		public override void OnDisconnected();
		public void PutBarrelBomb();
		[IteratorStateMachine]
		private IEnumerator SettingBarrelBombCoroutine(float delay, Vector3 settingPos, int index);
		public override void OnCollided(GameObject target, CollisionHitAttribute data);
		private void OnCollided(GameObject target, bool fromEvent);
		protected override void OnDestroy();
		private void HitEnemy(Collider other, CharacterBase character, int id);
		private void OnTriggerStay(Collider other);
		private void AppearBarrel(int index, Vector3 settingPos);
		public static void PutSelfBomb();
		public static bool isBarrelBombAvailable();
		public static void ClearBarreBombList();
	}
}
