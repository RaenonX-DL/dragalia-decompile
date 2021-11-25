using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineCharaMotSeqData : ICuttTimelineGroupData
	{
		public CuttTimelineKeyCharaMotionSeqDataList keys;

		public ICuttTimelineKeyDataList GetKeyList()
		{
			return null;
		}
	}
}
