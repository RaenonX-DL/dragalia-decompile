using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcArena : EnemyAbilityProcBase
	{
		private float sqrRadius;

		public EnemyAbilityProcArena(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void OnCalcBaseDamageAttack(CharacterBase receiver, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnCalcAbnormalSlipDamage(CharacterBase attacker, ref EnemyAbility.Argument arg)
		{
		}
	}
}
