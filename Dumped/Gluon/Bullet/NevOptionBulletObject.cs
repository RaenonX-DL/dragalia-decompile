using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon.Bullet
{
	public class NevOptionBulletObject : StockBulletObject
	{
		public enum NevPhase
		{
			None,
			Searching,
			Attaching
		}

		protected class NevOptionBulletDataCopy : StockBulletDataCopy
		{
			public int actionConditionId;

			public int burstAttackActionId;

			public int burstAttackEffectTrigger;

			public float burstAttachResetEffectTime;
		}

		private NevOptionBulletDataCopy copyData;

		public CharacterBuff.Parameter associatedBuff
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CharacterBuff.Parameter enemyDebuff
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CharacterBase attachedTarget
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public NevPhase nevPhase
		{
			[CompilerGenerated]
			get
			{
				return default(NevPhase);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int searchingProductId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void SetNevBulletData(NevOptionData data)
		{
		}

		protected override void Clear()
		{
		}

		public void OnRemoved()
		{
		}

		protected override bool OnUpdate()
		{
			return default(bool);
		}

		protected override void ProcessAutoFire()
		{
		}

		public void OnBurstAttack(int newSearchingProductId)
		{
		}

		public bool OnAttachedToTarget(CharacterBase target, int productId)
		{
			return default(bool);
		}

		public void OnReturnedFromTarget()
		{
		}

		public override bool Initialize(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, Vector3 position, Quaternion rotation)
		{
			return default(bool);
		}

		private void ApplyNevOptionBuff(bool applyActionId = true)
		{
		}

		public override void Restart(bool refreshBulletState)
		{
		}

		public override void Release()
		{
		}
	}
}
