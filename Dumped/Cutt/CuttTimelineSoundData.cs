using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineSoundData : ICuttTimelineGroupData
	{
		public CuttTimelineKeySoundDataList keys;

		public ICuttTimelineKeyDataList GetKeyList()
		{
			return null;
		}
	}
}
