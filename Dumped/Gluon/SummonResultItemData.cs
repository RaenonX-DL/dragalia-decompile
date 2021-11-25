using Gluon.Http;

namespace Gluon
{
	public class SummonResultItemData
	{
		public GiftType giftType;

		public int id;

		public bool isNew;

		public Rarity rarity;

		public Rarity viewRarityForBoxSummon;

		public int moonCount;

		public int originalCharaId;

		public int priority;

		public void UpdateDataFromResponse(AtgenResultUnitList resultUnitData)
		{
		}

		public void UpdateDataFromResponse(AtgenDrawDetails detail)
		{
		}

		public bool IsNewCharaOrAwakening()
		{
			return default(bool);
		}

		public void UpdateDataFromResponse(AtgenRedoableSummonResultUnitList resultUnitData)
		{
		}
	}
}
