using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcBlackFlame : EnemyAbilityProcBase
	{
		private const int EFF_TRIG_PARTS_DEAD = 9;

		public EnemyAbilityProcBlackFlame(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Play()
		{
		}

		public override void OnCalcBaseDamageAttack(CharacterBase receiver, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnAbnormalStatusProbability(int type, float probability, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnDeadParts(EnemyCharacter parts)
		{
		}

		public override void PlayEffect(EffectObject.FollowPosType followPos = EffectObject.FollowPosType.POSITION_GROUND)
		{
		}
	}
}
