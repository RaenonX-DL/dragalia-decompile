using Gluon.Http;

namespace Gluon
{
	public class SummonOddsTableViewData
	{
		public int id;

		public string rate;

		public bool isRateUp;

		public ElementalType elementalType;

		public WeaponType weaponType;

		public string displayName;

		public Rarity rarity;

		public GiftType giftType;

		public SummonOddsTableViewData()
		{
		}

		public SummonOddsTableViewData(AtgenUnitList unitInfo, Rarity rarity, bool isPickup, GiftType giftType)
		{
		}
	}
}
