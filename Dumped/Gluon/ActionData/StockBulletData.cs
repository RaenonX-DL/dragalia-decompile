using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class StockBulletData : BulletData
	{
		[SerializeField]
		[HideInInspector]
		private float _aroundWaitTime;

		[SerializeField]
		[HideInInspector]
		private float _aroundDurationTime;

		[SerializeField]
		[HideInInspector]
		private AlignAxis _alignAxis;

		[SerializeField]
		[HideInInspector]
		private Vector3 _alignmentOriginOffset;

		[SerializeField]
		[HideInInspector]
		private bool _shouldDistributeEvenNumbers;

		[SerializeField]
		[HideInInspector]
		private bool _syncRotationWithOwner;

		[SerializeField]
		[HideInInspector]
		private bool _facingToTarget;

		[SerializeField]
		[HideInInspector]
		private float _autoFireInterval;

		[SerializeField]
		[HideInInspector]
		private int _autoFireActionId;

		[SerializeField]
		[HideInInspector]
		private int _autoFireEffectTrigger;

		[SerializeField]
		[HideInInspector]
		private float _autoFireEffectTriggerResetTime;

		[SerializeField]
		[HideInInspector]
		private float _autoFireAutoSearchEnemyRadius;

		public float aroundWaitTime => default(float);

		public float aroundDurationTime => default(float);

		public AlignAxis alignAxis => default(AlignAxis);

		public Vector3 alignmentOriginOffset => default(Vector3);

		public bool shouldDistributeEvenNumbers => default(bool);

		public bool syncRotationWithOwner => default(bool);

		public bool facingToTarget => default(bool);

		public float autoFireInterval => default(float);

		public int autoFireActionId => default(int);

		public int autoFireEffectTrigger => default(int);

		public float autoFireEffectTriggerResetTime => default(float);

		public float autoFireAutoSearchEnemyRadius => default(float);
	}
}
