using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class CtrlLightSatelliteData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private float _degreePerSec;

		[SerializeField]
		[HideInInspector]
		private bool _useTimeCurve;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _timeCurveToAngle;

		[SerializeField]
		[HideInInspector]
		private bool _isFollowCenter;

		[SerializeField]
		[HideInInspector]
		private bool _isSub;

		[SerializeField]
		[HideInInspector]
		private bool _isYinYang;

		[SerializeField]
		[HideInInspector]
		private float _yinyangDuration;

		[SerializeField]
		[HideInInspector]
		private float _iconOffsetY;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public float degreePerSec => default(float);

		public bool useTimeCurve => default(bool);

		public AnimationCurve timeCurveToAngle => null;

		public bool isFollowCenter => default(bool);

		public bool isSub => default(bool);

		public bool isYinYang => default(bool);

		public float yinyangDuration => default(float);

		public float iconOffsetY => default(float);

		public bool guarantee => default(bool);
	}
}
