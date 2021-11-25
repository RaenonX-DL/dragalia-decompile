using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcIgnoreAtkOnAction : EnemyAbilityProcBase
	{
		private const string METOOL_EFF = "EFF_ENM_0490301_002";

		private const int BUSTER_EFF_TRIG = 8;

		private const int CHARGE_EFF_TRIG = 9;

		private const int LEAF_EFF_TRIG = 10;

		private const int METAL_EFF_TRIG = 11;

		private bool _isMetool;

		public EnemyAbilityProcIgnoreAtkOnAction(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Setup()
		{
		}

		public override void OnCheckExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg)
		{
		}

		private bool IsRockBusterHit(CollisionHitAttribute hitAttr)
		{
			return default(bool);
		}
	}
}
