using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcDragonBuster : EnemyAbilityProcBase
	{
		private CharacterBase _linked;

		private bool _isStopAbilityActionReserved;

		private bool _isStopAbilityActionReceived;

		public EnemyAbilityProcDragonBuster(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Play()
		{
		}

		public override void Stop()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnAttack(CharacterBase receiver, CollisionHitAttribute hitAttr)
		{
		}

		public override void OnRecieveCharacterState(CharacterState characterState)
		{
		}
	}
}
