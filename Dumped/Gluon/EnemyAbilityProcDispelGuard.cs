using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcDispelGuard : EnemyAbilityProcBase
	{
		private CharacterBase _linked;

		private bool _isStopAbilityActionReserved;

		private bool _isStopAbilityActionReceived;

		public EnemyAbilityProcDispelGuard(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
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

		public override void OnDispel(ref EnemyAbility.Argument arg)
		{
		}

		public override void OnRecieveCharacterState(CharacterState characterState)
		{
		}
	}
}
