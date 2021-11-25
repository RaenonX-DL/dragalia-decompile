namespace Gluon
{
	public class SeitentaiseiUniqueCtrl : EnemyUniqueCtrl
	{
		private int _checkEnemyId;

		private string _hitAttributeLabel;

		private float _healIntervalSec;

		private float _healElapseSec;

		private string _auraEffectName;

		private EffectObject _effectObject;

		private HitException _hitException;

		private int _oldLiveCnt;

		private int _healHitAttributeElementIndex;

		public override void Initialize()
		{
		}

		public void InitHeal(int checkEnemyId, string auraEffectName, string hitAttrLabel, float healInterSec)
		{
		}

		public void CheckHeal(int liveCnt)
		{
		}

		public override void FastUpdate()
		{
		}

		public void OnDamaged(CollisionHitAttribute hitAttr)
		{
		}
	}
}
