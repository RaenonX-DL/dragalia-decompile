using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCameraRollData : CuttTimelineKeyWithInterpolate
	{
		public float degree;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);
	}
}
