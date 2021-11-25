using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcElectrify : EnemyAbilityProcBase
	{
		private CollisionHitAttribute[] _hitAttribute;

		private float[] _dmgRate;

		public EnemyAbilityProcElectrify(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
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

		private void CreateDamageReduce()
		{
		}
	}
}
