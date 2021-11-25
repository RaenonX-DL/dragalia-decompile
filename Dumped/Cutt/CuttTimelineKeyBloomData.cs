using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyBloomData : CuttTimelineKeyWithInterpolate
	{
		public bool isEnableBloom;

		public float bloomWeight;

		public float bloomThreshold;

		public float bloomIntensity;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);
	}
}
