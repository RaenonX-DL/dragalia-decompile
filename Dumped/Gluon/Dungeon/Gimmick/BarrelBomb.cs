using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class BarrelBomb : DungeonObjectBase
	{
		private GimmickBarrelBombElement variation;

		public static readonly int SELF_BOMB_SETTING_MAX;

		private float originRadius;

		[SerializeField]
		private float MarkerRadiusScale;

		private static PlayerCharacter currentChara;

		private CollisionHitAttribute hitAttribute;

		private bool hasHit;

		private bool canExplode;

		private static BarrelBomb[] _barrelbombList;

		private static BarrelBomb selfBomb;

		private int bombIndex;

		private static int actorIndex;

		private int _explosionIndex;

		private Vector3 _reservedSettingPos;

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

		public static bool selfBombCanSetting
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

		public static int selfBombSettingCounter
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

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void Initialize()
		{
		}

		private void Explosion(bool isFromEvent, int explosionIndex)
		{
		}

		private IEnumerator ExplosionCoroutine()
		{
			return null;
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}

		public override void FastUpdate()
		{
		}

		private void UpdateBarrelBombTimer()
		{
		}

		public override void OnDisconnected()
		{
		}

		public void PutBarrelBomb()
		{
		}

		private IEnumerator SettingBarrelBombCoroutine(float delay, Vector3 settingPos, int index)
		{
			return null;
		}

		public override void OnCollided(GameObject target, CollisionHitAttribute data)
		{
		}

		private void OnCollided(GameObject target, bool fromEvent)
		{
		}

		protected override void OnDestroy()
		{
		}

		private void HitEnemy(Collider other, CharacterBase character, int id)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void AppearBarrel(int index, Vector3 settingPos)
		{
		}

		public static void PutSelfBomb()
		{
		}

		public static bool isBarrelBombAvailable()
		{
			return default(bool);
		}

		public static void ClearBarreBombList()
		{
		}
	}
}
