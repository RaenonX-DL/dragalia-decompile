using System.Runtime.InteropServices;
using Gluon.Http;

namespace Gluon
{
	public class TotalSupportData
	{
		public SupportData charaData;

		public SupportData dragonData;

		public SupportData weaponData;

		public SupportData[] abilityCrestData;

		public SupportData[] abilityCrestData2;

		public SupportData[] abilityCrestData3;

		public string playerName;

		public void CopyToData(QuestPrepareData baseData, [Optional] string playerName)
		{
		}

		public void CreateSupportTotalData(FriendGetSupportCharaDetailResponse data)
		{
		}

		private int GetBustAttackLevel(int charaId, int[] manacircleIds)
		{
			return default(int);
		}

		private int GetComboLevel(int charaId, int[] manacircleIds)
		{
			return default(int);
		}
	}
}
