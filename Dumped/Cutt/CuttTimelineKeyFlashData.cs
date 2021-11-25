using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyFlashData : CuttTimelineKeyTransformData
	{
		public string callLabel;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);
	}
}
