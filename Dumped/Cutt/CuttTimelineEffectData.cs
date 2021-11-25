using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineEffectData : ICuttTimelineGroupData
	{
		public CuttTimelineKeyEffectDataList keys;

		public ICuttTimelineKeyDataList GetKeyList()
		{
			return null;
		}
	}
}
