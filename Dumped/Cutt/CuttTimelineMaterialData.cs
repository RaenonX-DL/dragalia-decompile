using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineMaterialData : ICuttTimelineGroupData
	{
		public CuttTimelineKeyMaterialDataList keys;

		public ICuttTimelineKeyDataList GetKeyList()
		{
			return null;
		}
	}
}
