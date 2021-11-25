using System.Collections.Generic;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcDrain : EnemyAbilityProcBase
	{
		private bool _reserveInfection;

		public List<CharacterBase> _drainTargets;

		private const float INFECTION_DELAY = 0.5f;

		private float _infectionTimer;

		public EnemyAbilityProcDrain(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Setup()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnDrain(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg)
		{
		}

		private void ProcVirus(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnPostDrain()
		{
		}

		public override void OnAttack(CharacterBase receiver, CollisionHitAttribute hitAttr)
		{
		}

		public override void OnFollowerAvoid(CharacterBase receiver)
		{
		}

		private void Infection()
		{
		}

		private void PlayDrainDirection(CharacterBase receiver)
		{
		}

		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData)
		{
		}
	}
}
