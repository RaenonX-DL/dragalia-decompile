using System.Collections.Generic;

namespace Gluon
{
	public class MatchingRoomDetailData : UnitDetailDataWithEquip
	{
		public ulong viewerId;

		public List<int> passiveAbility;

		public void CopyFromData(MatchingRoomDetailData data)
		{
		}

		public QuestPrepareData ConvertToQuestPrepareData()
		{
			return null;
		}
	}
}
