using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcRiptide : EnemyAbilityProcBase
	{
		private CollisionHitAttribute _hitAttribute;

		private HitException _hitException;

		private CharacterBase[] insideCharacters;

		public EnemyAbilityProcRiptide(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Setup()
		{
		}

		public override void Stop()
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
