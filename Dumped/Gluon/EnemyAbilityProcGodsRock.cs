using System.Collections.Generic;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcGodsRock : EnemyAbilityProcBase
	{
		public enum TargetType
		{
			CenterChara,
			MyPartyUnit
		}

		private EnemyCharacter _center;

		private List<CharacterBase> _listTarget;

		public EnemyAbilityProcGodsRock(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
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

		public override void OnCheckExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg)
		{
		}

		private void SetTargetList()
		{
		}

		private void MatchBuffDebuff(CharacterBase target)
		{
		}
	}
}
