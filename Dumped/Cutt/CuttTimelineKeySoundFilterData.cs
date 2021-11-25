using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeySoundFilterData : CuttTimelineKeyWithInterpolate
	{
		public enum FilterType
		{
			None,
			DspBusEq
		}

		public FilterType filterType;

		public bool isFadeIn;

		public float fadeValue;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);
	}
}
