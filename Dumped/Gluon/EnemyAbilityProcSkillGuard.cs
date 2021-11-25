using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcSkillGuard : EnemyAbilityProcBase
	{
		public EnemyAbilityProcSkillGuard(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref EnemyAbility.Argument arg)
		{
		}
	}
}
