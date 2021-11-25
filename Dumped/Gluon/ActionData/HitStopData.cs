using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class HitStopData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private float _stopMotionPositionSec;

		[SerializeField]
		[HideInInspector]
		private float _stopTimeSpanSec;

		[SerializeField]
		[HideInInspector]
		private bool _isRepeat;

		[SerializeField]
		[HideInInspector]
		private bool _isOverridePlaySpeed;

		[SerializeField]
		[HideInInspector]
		private float _playSpeed;

		[SerializeField]
		[HideInInspector]
		private bool _isOwnerOnly;

		[SerializeField]
		[HideInInspector]
		private bool _includeNoDamage;

		public float stopMotionPositionSec => default(float);

		public float stopTimeSpanSec => default(float);

		public bool isRepeat => default(bool);

		public bool isOverridePlaySpeed => default(bool);

		public float playSpeed => default(float);

		public bool isOwnerOnly => default(bool);

		public bool includeNoDamage => default(bool);
	}
}
