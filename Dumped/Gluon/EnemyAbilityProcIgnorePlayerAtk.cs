using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcIgnorePlayerAtk : EnemyAbilityProcBase
	{
		public EnemyAbilityProcIgnorePlayerAtk(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void OnCheckExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg)
		{
		}
	}
}
