using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcRampage : EnemyAbilityProcBase
	{
		private int _level;

		private int _lastSendLevel;

		private float _interval;

		public EnemyAbilityProcRampage(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnCalcBaseDamageAttack(CharacterBase receiver, ref EnemyAbility.Argument arg)
		{
		}

		private void SendRampageLevel(int level)
		{
		}

		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData)
		{
		}
	}
}
