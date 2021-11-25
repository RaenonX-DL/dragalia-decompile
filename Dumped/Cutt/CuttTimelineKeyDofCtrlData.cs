using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyDofCtrlData : CuttTimelineKeyWithInterpolate
	{
		public bool isEnableDof;

		public float focalSize;

		public float focalLength;

		public float smoothness;

		public float smoothStepMin;

		public float smoothStepMax;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
