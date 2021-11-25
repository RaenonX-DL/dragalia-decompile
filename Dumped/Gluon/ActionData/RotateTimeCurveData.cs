using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class RotateTimeCurveData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private AnimationCurve _timeCurveToAngle;

		public AnimationCurve timeCurveToAngle => null;
	}
}
