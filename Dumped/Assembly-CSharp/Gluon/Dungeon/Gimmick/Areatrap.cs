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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class Areatrap : DungeonObjectBase
	{
		// Fields
		private GimmickAreaTrapElement variation;
		public static readonly int SELF_TRAP_SETTING_MAX;
		private CollisionHitAttribute hitAttribute;
		private static Areatrap[] _areaTrapList;
		private static Areatrap selfAreaTrap;
		private int areaTrapIndex;
		private static int actorIndex;
		private int _activateIndex;
		private SphereCollider _collider;
		private HashSet<int> victim;
		private QuestSkillButtonBase questSkillButton;
		private Vector3 safePosition;
		private static PlayerCharacter currentChara;
		[SerializeField]
		private string SE_NAME;
		[SerializeField]
		private string BOMB_EFFECT_NAME;
		private float hitDuration;
		[CompilerGenerated]
		private static int _selfAreaTrapSettingCounter_k__BackingField;
		[CompilerGenerated]
		private static bool _selfAreaTrapCanSetting_k__BackingField;
		private ChargeMarker _marker;
	
		// Properties
		public static int selfAreaTrapSettingCounter { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static bool selfAreaTrapCanSetting { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _SettingAreaTrapCoroutine_d__31 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int index;
			public Vector3 settingPos;
			public Areatrap __4__this;
			public float settingCollisionDelay;
			public float checkCollisionDuration;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SettingAreaTrapCoroutine_d__31(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public Areatrap();
		static Areatrap();
	
		// Methods
		protected override void Awake();
		protected override void OnDisable();
		protected override void Start();
		public void Initialize();
		public void PutAreaTrap();
		public static void PutSelfAreaTrap();
		[IteratorStateMachine]
		private IEnumerator SettingAreaTrapCoroutine(float settingCollisionDelay, float checkCollisionDuration, Vector3 settingPos, int index);
		public static bool isAreaTrapAvailable();
		private void OnTriggerStay(Collider other);
		private void HitEnemy(Collider other, CharacterBase character, int id);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
		public override void OnCollided(GameObject target, CollisionHitAttribute data);
	}
}
