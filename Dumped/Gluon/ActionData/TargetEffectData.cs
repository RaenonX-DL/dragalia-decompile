using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class TargetEffectData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private float _reachSec;

		[SerializeField]
		[HideInInspector]
		private float _topOffset;

		[SerializeField]
		[HideInInspector]
		private float _range;

		[SerializeField]
		[HideInInspector]
		private TargetEffectCtrl.TargetType _targetType;

		public float reachSec => default(float);

		public float topOffset => default(float);

		public float range => default(float);

		public TargetEffectCtrl.TargetType targetType => default(TargetEffectCtrl.TargetType);
	}
}
