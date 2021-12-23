using System.Runtime.InteropServices;
using Gluon.Http;
using Gluon.Master;

namespace Gluon
{
	public class QuestPrepareData : CommonPartyPowerCalculateData
	{
		public int charaLevel;

		public int charaAdditionalMaxLevel;

		public int charaPlus;

		public int[] charaSkillLv;

		public ulong dragonKeyId;

		public ulong[] abilityCrest1;

		public ulong[] abilityCrest2;

		public ulong[] abilityCrest3;

		public int skinWeaponId;

		public int[] abilityCrest1LimitBreak;

		public int[] abilityCrest2LimitBreak;

		public int[] abilityCrest3LimitBreak;

		public int charaExp;

		public int dragonExp;

		public int charaManaCircleCount;

		public int skill3Level;

		public int skill4Level;

		public ulong talismanKeyId;

		public void CopyFromData(CommonPartyPowerCalculateData baseData)
		{
		}

		public void CopyFromData(QuestPrepareData baseData)
		{
		}

		public void CopyFromData(UnitDetailModel.CharaDetailData charaData, UnitDetailModel.DragonDetailData dragonData, UnitDetailModel.WeaponDetailData weaponData)
		{
		}

		public static QuestPrepareData[] CreateClearPartyData(PartySettingList[] partyData)
		{
			return null;
		}

		public void SetData(PartySettingList destData)
		{
		}

		public void SetOrderPartyData([In] ref QuestOrderPartyElement orderPartyData)
		{
		}

		private void SetParameterByReleaseManaCircleCount()
		{
		}

		private void AddHpAndAtkByReleaseManaCircleCount([In] ref MC mcData, [In] ref CharaDataElement charaData)
		{
		}

		public static PartyList QuestPrepareData2PartyList(QuestPrepareData[] prepareDatas)
		{
			return null;
		}
	}
}
