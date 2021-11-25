using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcAtkGuard : EnemyAbilityProcBase
	{
		public EnemyAbilityProcAtkGuard(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref EnemyAbility.Argument arg)
		{
		}
	}
}
