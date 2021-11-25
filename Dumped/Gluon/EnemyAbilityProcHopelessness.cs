using System.Collections.Generic;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcHopelessness : EnemyAbilityProcBase
	{
		private CharacterBase _linked;

		private List<CharacterBase> _listReceiver;

		private bool _isStopAbilityActionReserved;

		private bool _isStopAbilityActionReceived;

		public EnemyAbilityProcHopelessness(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
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
