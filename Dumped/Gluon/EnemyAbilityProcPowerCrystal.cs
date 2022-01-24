using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class EnemyAbilityProcPowerCrystal : EnemyAbilityProcBase
	{
		public enum ConditionType
		{
			Surge,
			Dormant,
			Fragile
		}

		private enum DangerZoneVisibleTiming
		{
			None,
			Always,
			InSurge,
			Criticality
		}

		private ConditionType _reservedCondition;

		private const string SURGE_MESH_NAME = "mRockA";

		private const string DORMANT_MESH_NAME = "mRockB";

		private const string FRAGILE_MESH_NAME = "mRockC";

		private Transform _surgeMesh;

		private Transform _dormantMesh;

		private Transform _fragileMesh;

		private bool _isExplosion;

		private bool _hasCharge;

		private float _timer;

		private CollisionHitAttribute _hitAttribute;

		private const string EFF_DANGER_ZONE = "EFF_BOS_HBS_0130101_011";

		private const string EFF_EXPLOSION = "EFF_BOS_HBS_0130101_008";

		private const string EFF_LEAVE = "EFF_BOS_HBS_0130101_009";

		private const string EFF_TRANSITION = "EFF_BOS_HBS_0130101_015";

		private EffectObject _eoDangerZone;

		private Vector3 _zoneEffScale;

		private const string SE_TRANS_SURGE = "SE_ENE_HBS_0130101_01_0002";

		private const string SE_CRITICALITY = "SE_ENE_HBS_0130101_01_0003";

		private const string SE_EXPLOSION = "SE_ENE_HBS_0130101_01_0004";

		public ConditionType conditionType
		{
			[CompilerGenerated]
			get
			{
				return default(ConditionType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public EnemyAbilityProcPowerCrystal(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Setup()
		{
		}

		public override void Play()
		{
		}

		public override void Stop()
		{
		}

		public override void OnCharacterDead()
		{
		}

		public override void OnCharacterLeave()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnCheckExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnDamage(CollisionHitAttribute attr, int damage)
		{
		}

		public override void OnFatalAttack(ref EnemyAbility.Argument arg)
		{
		}

		private void SwitchCondition()
		{
		}

		private void SetVisibleAllMesh(bool onoff)
		{
		}

		public override void PlayEffect(EffectObject.FollowPosType followPos = EffectObject.FollowPosType.POSITION_GROUND)
		{
		}

		private EffectObject PlayEffect2(string effName, Vector3 scale, int effTrigger = 8)
		{
			return null;
		}

		public void StopEffect2(ref EffectObject eo)
		{
		}
	}
}
