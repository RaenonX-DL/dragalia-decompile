using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Bullet
{
	public class StockBulletObject : BulletObject
	{
		protected enum Phase
		{
			None,
			Start,
			Rotate,
			Fire,
			Hiding,
			Release,
			Restart
		}

		public class StockBulletDataCopy
		{
			public float aroundWaitTime;

			public float aroundDurationTime;

			public BulletData.AlignAxis alignAxis;

			public Vector3 alignmentOriginOffset;

			public bool shouldDistributeEvenNumbers;

			public bool syncRotationWithOwner;

			public bool facingToForward;

			public bool facingToTarget;

			public float autoFireInterval;

			public int autoFireActionId;

			public int autoFireEffectTrigger;

			public float autoFireEffectTriggerResetTime;

			public float autoFireAutoSearchEnemyRadius;

			public bool guarantee;

			public void Clear()
			{
			}
		}

		protected Phase phase;

		protected float timer;

		protected Vector3 directionRotation;

		protected int alignIndex;

		protected float autoFireTimer;

		protected float autoFireEffectTriggerResetTimer;

		private StockBulletDataCopy copyData;

		public bool onceSkipPlayEffectFlag
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetStockBulletData(StockBulletData data, [Optional] StockBulletDataCopy copyData)
		{
		}

		protected override void Clear()
		{
		}

		public override bool Initialize(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, Vector3 position, Quaternion rotation)
		{
			return default(bool);
		}

		protected override bool OnUpdate()
		{
			return default(bool);
		}

		protected override bool UpdateDurationTime()
		{
			return default(bool);
		}

		protected virtual void ProcessAutoFire()
		{
		}

		public override void PlayEffect()
		{
		}

		public void SetInitRotation(Quaternion rot)
		{
		}

		public void Reset(int index, int maxCount, Quaternion initRot)
		{
		}

		public void Fire()
		{
		}

		public virtual void Release()
		{
		}

		public virtual void Restart(bool refreshBulletState)
		{
		}

		public void Hide()
		{
		}

		private void ChangeTarget(CommonObjectStatus target)
		{
		}

		public override void OnReceiveBulletEvent(BulletEvent recvEvent)
		{
		}
	}
}
