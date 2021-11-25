using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcBlocking : EnemyAbilityProcBase
	{
		public EnemyAbilityProcBlocking(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
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

		public override void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnCalcAbnormalSlipDamage(CharacterBase attacker, ref EnemyAbility.Argument arg)
		{
		}

		private bool IsStopAbnormal()
		{
			return default(bool);
		}

		private bool UnisonPlay()
		{
			return default(bool);
		}

		private bool UnisonStop()
		{
			return default(bool);
		}
	}
}
