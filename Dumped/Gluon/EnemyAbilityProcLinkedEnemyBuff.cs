using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcLinkedEnemyBuff : EnemyAbilityProcBase
	{
		public List<int> listLinkedId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public EnemyAbilityProcLinkedEnemyBuff(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Stop()
		{
		}

		public override void OnUpdate()
		{
		}

		private bool ApplyBuffDebuff()
		{
			return default(bool);
		}

		private bool ResetBuffDebuff()
		{
			return default(bool);
		}

		private int CountLinkedEnemy()
		{
			return default(int);
		}
	}
}
