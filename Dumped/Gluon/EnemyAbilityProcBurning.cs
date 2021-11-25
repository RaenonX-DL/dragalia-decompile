using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcBurning : EnemyAbilityProcBase
	{
		private EnemyAbilityProcPhoenix _phoenix;

		private int _burningResetCount;

		private Dictionary<int, int> _burningCountReservedMap;

		private bool _isPlayReserved;

		private bool _isPlayReceived;

		public int count
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public EnemyAbilityProcBurning(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Play()
		{
		}

		private void OnPlay(int burningCount)
		{
		}

		public override void Stop()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnAbnormalStatusProbability(int type, float probability, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnCalcAbnormalSlipDamage(CharacterBase attacker, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData)
		{
		}

		private int AddBurningResetCount()
		{
			return default(int);
		}

		public override void OnRecieveCharacterState(CharacterState recvEvent)
		{
		}
	}
}
