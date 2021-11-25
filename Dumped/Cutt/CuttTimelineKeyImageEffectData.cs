using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyImageEffectData : CuttTimelineKeyWithInterpolate
	{
		public enum ImageEffectType
		{
			None,
			ChronosStopProduction
		}

		public ImageEffectType imageEffectType;

		public bool isFadeIn;

		public float fadeValue;

		public bool isStopProduction;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);
	}
}
