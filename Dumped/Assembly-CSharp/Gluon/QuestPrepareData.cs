/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

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
		public ulong amuletKeyId;
		public ulong amulet2KeyId;
		public ulong[] abilityCrest1;
		public ulong[] abilityCrest2;
		public int amuletLimitBreak;
		public int amulet2LimitBreak;
		public int skinWeaponId;
		public int[] abilityCrest1LimitBreak;
		public int[] abilityCrest2LimitBreak;
		public int charaExp;
		public int dragonExp;
		public int charaManaCircleCount;
	
		// Constructors
		public QuestPrepareData();
	
		// Methods
		public void CopyFromData(CommonPartyPowerCalculateData baseData);
		public void CopyFromData(QuestPrepareData baseData);
		public void CopyFromData(UnitDetailModel.CharaDetailData charaData, UnitDetailModel.DragonDetailData dragonData, UnitDetailModel.WeaponDetailData weaponData);
		public static QuestPrepareData[] CreateClearPartyData(PartySettingList[] partyData);
		public void SetData(PartySettingList destData);
	}
}
