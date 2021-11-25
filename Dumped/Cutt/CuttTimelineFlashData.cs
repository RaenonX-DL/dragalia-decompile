using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineFlashData : ICuttTimelineGroupData
	{
		public CuttTimelineKeyFlashDataList keys;

		public ICuttTimelineKeyDataList GetKeyList()
		{
			return null;
		}
	}
}
