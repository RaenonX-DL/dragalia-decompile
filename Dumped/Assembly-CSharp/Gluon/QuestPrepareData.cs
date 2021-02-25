/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestPrepareData : CommonPartyPowerCalculateData
	{
		// Fields
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
	
		// Constructors
		public QuestPrepareData();
	
		// Methods
		public void CopyFromData(CommonPartyPowerCalculateData baseData);
		public void CopyFromData(QuestPrepareData baseData);
		public void CopyFromData(UnitDetailModel.CharaDetailData charaData, UnitDetailModel.DragonDetailData dragonData, UnitDetailModel.WeaponDetailData weaponData);
		public static QuestPrepareData[] CreateClearPartyData(PartySettingList[] partyData);
		public void SetData(PartySettingList destData);
		public void SetOrderPartyData([IsReadOnly] in QuestOrderPartyElement orderPartyData);
		private void SetParameterByReleaseManaCircleCount();
		private void AddHpAndAtkByReleaseManaCircleCount([IsReadOnly] in MC mcData, [IsReadOnly] in CharaDataElement charaData);
		public static PartyList QuestPrepareData2PartyList(QuestPrepareData[] prepareDatas);
	}
}
