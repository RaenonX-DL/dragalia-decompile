using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcHealBlock : EnemyAbilityProcBase
	{
		private CharacterBase _linked;

		private bool _isStopAbilityActionReserved;

		private bool _isStopAbilityActionReceived;

		public EnemyAbilityProcHealBlock(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Setup()
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

		public override void OnRecieveCharacterState(CharacterState characterState)
		{
		}
	}
}
