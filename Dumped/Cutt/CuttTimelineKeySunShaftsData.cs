using System;
using Gluon;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeySunShaftsData : CuttTimelineKeyWithInterpolate
	{
		public PostEffectSunShafts.SunShaftsParam keySunShaftsData;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}

		public CuttTimelineKey Interpolate(CuttTimelineKey interpKey, CuttTimelineKey prevKey, float t)
		{
			return null;
		}
	}
}
