using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyColorAdjustmentData : CuttTimelineKeyWithInterpolate
	{
		public bool isEnableColorAdjustment;

		public float bright;

		public float saturation;

		public float contrast;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);
	}
}
