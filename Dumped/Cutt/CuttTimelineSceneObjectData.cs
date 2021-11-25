using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineSceneObjectData : ICuttTimelineGroupData
	{
		public CuttTimelineKeySceneObjectDataList keys;

		public ICuttTimelineKeyDataList GetKeyList()
		{
			return null;
		}
	}
}
