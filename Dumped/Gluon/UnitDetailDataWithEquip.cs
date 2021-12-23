using Gluon.Http;

namespace Gluon
{
	public class UnitDetailDataWithEquip
	{
		public UnitDetailModel.CharaDetailData charaData;

		public UnitDetailModel.DragonDetailData dragonData;

		public UnitDetailModel.WeaponDetailData weaponData;

		public UnitDetailModel.AmuletDetailData[] abilityCrestData1;

		public UnitDetailModel.AmuletDetailData[] abilityCrestData2;

		public UnitDetailModel.AmuletDetailData[] abilityCrestData3;

		public UnitDetailModel.TalismanDetailData talismanData;

		public UnitDetailDataWithEquip()
		{
		}

		public UnitDetailDataWithEquip(UnitDetailModel model)
		{
		}

		public UnitDetailDataWithEquip(PartySettingList partyInfo)
		{
		}
	}
}
