using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcGrudge : EnemyAbilityProcBase
	{
		private CollisionHitAttribute _hitAttribute;

		public EnemyAbilityProcGrudge(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Setup()
		{
		}

		public override void OnAttack(CharacterBase receiver, CollisionHitAttribute hitAttr)
		{
		}

		private void CreateHitAttribute()
		{
		}
	}
}
