using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCameraPositionData : CuttTimelineKeyWithInterpolate
	{
		public CuttCameraPositionType setType;

		public Vector3 posDirect;

		[NonSerialized]
		public Transform posTransform;

		public string posTransformName;

		public Vector3 offset;

		public Vector3[] bezierPoints;

		public CuttCharaPositionFlag charaRelativeBase;

		public CuttCameraLookAtCharaParts charaRelativeParts;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}

		public bool IsDelay()
		{
			return default(bool);
		}

		public bool IsDelayContinuous()
		{
			return default(bool);
		}

		public bool HasBezier()
		{
			return default(bool);
		}

		public int GetBezierPointCount()
		{
			return default(int);
		}

		public Vector3 GetBezierPoint(int index, CuttTimelineControl timelineControl)
		{
			return default(Vector3);
		}

		public Vector3 GetValue(CuttTimelineControl timelineControl)
		{
			return default(Vector3);
		}

		private Vector3 GetValue(CuttTimelineControl timelineControl, CuttCameraPositionType type, bool containOffset)
		{
			return default(Vector3);
		}
	}
}
