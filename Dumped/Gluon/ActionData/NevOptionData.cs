using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class NevOptionData : StockBulletData
	{
		[SerializeField]
		[HideInInspector]
		private int _burstAttackActionId;

		[SerializeField]
		[HideInInspector]
		private int _actionConditionId;

		[SerializeField]
		[HideInInspector]
		private float _burstAttachResetEffectTime;

		[SerializeField]
		[HideInInspector]
		private int _burstAttackEffectTrigger;

		public int burstAttackActionId => default(int);

		public int actionConditionId => default(int);

		public float burstAttachResetEffectTime => default(float);

		public int burstAttackEffectTrigger => default(int);
	}
}
