using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCameraLookAtData : CuttTimelineKeyWithInterpolate
	{
		public CuttCameraLookAtType lookAtType;

		public CuttCharaPositionFlag lookAtCharaPos;

		public CuttCameraLookAtCharaParts lookAtCharaParts;

		[NonSerialized]
		public Transform lookAtTransform;

		public string lookAtTransformName;

		public Vector3 rotation;

		public float eyeLength;

		public Vector3 offset;

		public Vector3[] bezierPoints;

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

		public Vector3 GetBezierPoint(int index, CuttTimelineControl timelineControl, Vector3 camPos)
		{
			return default(Vector3);
		}

		public Vector3 GetValue(CuttTimelineControl timelineControl, Vector3 camPos)
		{
			return default(Vector3);
		}

		private Vector3 GetValue(CuttTimelineControl timelineControl, CuttCameraLookAtType type, Vector3 camPos, bool containOffset)
		{
			return default(Vector3);
		}
	}
}
