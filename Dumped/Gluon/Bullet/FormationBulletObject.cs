using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Bullet
{
	public class FormationBulletObject : BulletObject
	{
		private class FormationDataCopy
		{
			public int childNum;

			public Vector3 rotationSpeed;

			public bool noCheckCollision;

			public bool destroyAlone;

			public FormationBulletData.FireTrigger fireTrigger;

			public FormationBulletData.SoundEffect se;

			public void Copy(FormationBulletData data)
			{
			}
		}

		private float rotationTime;

		private FormationBulletData.ChildParameter[] childParam;

		private BulletObject[] child;

		private FormationDataCopy copyData;

		protected override void OnDisable()
		{
		}

		protected override void ReleaseChild()
		{
		}

		public void GenerateChildBullet(FormationBulletData data, Vector3 parentPos, Quaternion parentRot)
		{
		}

		protected override bool OnUpdate()
		{
			return default(bool);
		}

		protected override bool UpdateFormation()
		{
			return default(bool);
		}

		protected override void PostUpdate()
		{
		}

		protected override bool CheckCollision()
		{
			return default(bool);
		}

		public Vector3 ChasePosition()
		{
			return default(Vector3);
		}

		public bool Fire(FormationBulletData.FireTrigger trigger)
		{
			return default(bool);
		}

		public void Release(bool onlyFormation)
		{
		}

		public void Hide(bool onlyFormation)
		{
		}

		public void Restart(bool onlyFormation)
		{
		}

		private void PlaySE(Vector3 position)
		{
		}

		protected override void StopSE()
		{
		}

		public bool OnReceiveFireBulletEvent(FireSpecialBullet recv)
		{
			return default(bool);
		}

		private void SendFireBulletEvent()
		{
		}
	}
}
