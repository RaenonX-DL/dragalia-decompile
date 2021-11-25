using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public abstract class CuttTimelineKeyWithInterpolate : CuttTimelineKey
	{
		public CuttCameraInterpolateType interpolateType;

		public AnimationCurve curve;

		public CuttTimelineEasing.Type easingType;

		public override bool IsInterpolateKey()
		{
			return default(bool);
		}
	}
}
