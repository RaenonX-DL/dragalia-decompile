using Gluon.ActionData;

namespace Gluon.Bullet
{
	public class RoseTokenBulletObject : BulletObject
	{
		private enum Phase
		{
			Bloom,
			Wither
		}

		public class RoseTokenDataCopy
		{
			public float bloomSec;

			public float attackInterval;

			public int witherTrigger;

			public float witherActionRange;

			public int killCount;

			public HitData attackData;

			public HitData healData;

			public void Clear()
			{
			}
		}

		public class HitData
		{
			public string label;

			public CollisionHitAttribute attr;

			public HitException hitException;

			public Gluon.ActionData.EffectData effData;

			public string seName;

			public void Clear()
			{
			}
		}

		private Phase phase;

		private RoseTokenDataCopy copyData;

		private float attackInterval;

		public void SetRoseTokenBulletData(RoseTokenData data)
		{
		}

		protected override void Clear()
		{
		}

		protected override bool UpdateMove()
		{
			return default(bool);
		}

		public void SetCollisionLabel(string lbAttack, string lbHeal)
		{
		}

		public void SetupCollisionHitAttribute(RoseTokenData data)
		{
		}

		private void SetupCollisionHitAttribute(HitData hitData, Gluon.ActionData.HitData data)
		{
		}

		private void SetupCollisionParameter(CollisionHitAttribute attr, Gluon.ActionData.HitData data)
		{
		}

		private void CheckHitCollision(HitData hitData, CommonObjectStatus fixedTarget)
		{
		}

		private int GetKillActionId(CharacterBase chara)
		{
			return default(int);
		}
	}
}
