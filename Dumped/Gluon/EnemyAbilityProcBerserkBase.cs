using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcBerserkBase : EnemyAbilityProcBase
	{
		public override bool isBerserk => default(bool);

		public EnemyAbilityProcBerserkBase(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Play()
		{
		}

		public override void Stop()
		{
		}

		public override void PlayEffect(EffectObject.FollowPosType followPos = EffectObject.FollowPosType.POSITION_GROUND)
		{
		}

		public override void OnOverdrive(ref EnemyAbility.Argument arg)
		{
		}

		public override void OnBreakFinish()
		{
		}

		public override void OnCalcBaseDamageAttack(CharacterBase receiver, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnCalcModeDifense(CharacterBase attacker, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnOverdriveDamage(CollisionHitAttribute hitAttr, float od_rate, ref EnemyAbility.Argument arg)
		{
		}
	}
}
