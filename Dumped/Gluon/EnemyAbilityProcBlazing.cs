using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcBlazing : EnemyAbilityProcBase
	{
		private CollisionHitAttribute _hitAttribute;

		private HitException _hitException;

		private float _interval;

		private float sqrRadius;

		private CharacterBase[] insideCharacters;

		public EnemyAbilityProcBlazing(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Setup()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnCheckExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg)
		{
		}
	}
}
