using UnityEngine;

namespace Gluon.Bullet
{
	public class ButterflyBulletObject : BulletObject
	{
		public static readonly int generateMax;

		private static readonly int DeleteCountMax;

		private int deleteCounter;

		public override bool Initialize(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, Vector3 position, Quaternion rotation)
		{
			return default(bool);
		}

		protected override bool OnUpdate()
		{
			return default(bool);
		}

		private bool IsLostTarget()
		{
			return default(bool);
		}

		public void AddDeleteCounter(int add)
		{
		}

		public void HitEnd()
		{
		}
	}
}
