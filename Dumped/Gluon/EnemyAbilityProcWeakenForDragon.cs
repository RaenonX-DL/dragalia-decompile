using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcWeakenForDragon : EnemyAbilityProcBase
	{
		public EnemyAbilityProcWeakenForDragon(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnCalcAbnormalSlipDamage(CharacterBase attacker, ref EnemyAbility.Argument arg)
		{
		}

		private float GetAttackDownRate(CharacterBase attacker, CollisionHitAttribute attr)
		{
			return default(float);
		}
	}
}
