using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcAttackRangeTolerance : EnemyAbilityProcBase
	{
		public EnemyAbilityProcAttackRangeTolerance(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnCalcAbnormalSlipDamage(CharacterBase attacker, ref EnemyAbility.Argument arg)
		{
		}

		private float GetAttackDownRate(CharacterBase attacker)
		{
			return default(float);
		}
	}
}
