using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class Areatrap : DungeonObjectBase
	{
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

		private ChargeMarker _marker;

		public static int selfAreaTrapSettingCounter
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static bool selfAreaTrapCanSetting
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void Start()
		{
		}

		public void Initialize()
		{
		}

		public void PutAreaTrap()
		{
		}

		public static void PutSelfAreaTrap()
		{
		}

		private IEnumerator SettingAreaTrapCoroutine(float settingCollisionDelay, float checkCollisionDuration, Vector3 settingPos, int index)
		{
			return null;
		}

		public static bool isAreaTrapAvailable()
		{
			return default(bool);
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void HitEnemy(Collider other, CharacterBase character, int id)
		{
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}

		public override void OnCollided(GameObject target, CollisionHitAttribute data)
		{
		}

		public static void ClearAreaTrapList()
		{
		}
	}
}
