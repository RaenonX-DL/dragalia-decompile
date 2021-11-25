using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public abstract class CuttTimelineKeyTransformData : CuttTimelineKeyWithInterpolate
	{
		public Vector3 position;

		public Vector3 rotation;

		public Vector3 scale;

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}

		public Vector3 GetValuePosition(CuttTimelineControl timelineControl)
		{
			return default(Vector3);
		}

		public Vector3 GetValueRotation(CuttTimelineControl timelineControl)
		{
			return default(Vector3);
		}

		public Vector3 GetValueScale(CuttTimelineControl timelineControl)
		{
			return default(Vector3);
		}
	}
}
