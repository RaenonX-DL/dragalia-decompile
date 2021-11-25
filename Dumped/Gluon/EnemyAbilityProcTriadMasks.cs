using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcTriadMasks : EnemyAbilityProcBase
	{
		private enum MaskType
		{
			Heartless,
			Distress,
			Wrath
		}

		private EnemyAbilityProcTriadMasks _mask0;

		private EnemyAbilityProcTriadMasks _mask1;

		private EnemyAbilityProcTriadMasks _mask2;

		private const string HEARTLESS_MASK_MESH_NAME = "mFace_01";

		private const string DISTRESS_MASK_MESH_NAME = "mFace_02";

		private const string WRATH_MASK_MESH_NAME = "mFace_03";

		private float _timer;

		public EnemyAbilityProcTriadMasks(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Play()
		{
		}

		public override void Stop()
		{
		}

		public override void OnEntry()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnAttack(CharacterBase receiver, CollisionHitAttribute hitAttr)
		{
		}

		private void SwitchMaskMesh(bool onoff)
		{
		}
	}
}
