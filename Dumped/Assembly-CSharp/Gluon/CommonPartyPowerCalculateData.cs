/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonPartyPowerCalculateData
	{
		// Fields
		public int charaId;
		public int charaAtk;
		public int charaDef;
		public int charaHp;
		public int charaHpPlus;
		public int charaAtkPlus;
		public int charaSkillLvTotal;
		public int[] charaHasAbility;
		public int exAbilityLv;
		public int exAbility2Lv;
		public int burstLv;
		public int comboLv;
		public int charaRarity;
		public int skill3CharaId;
		public int skill4CharaId;
		public int dragonId;
		public int dragonLv;
		public int dragonLimitBreak;
		public int dragonPlus;
		public int dragonHpPlus;
		public int dragonAtkPlus;
		public int dragonSkillLv;
		public int dragonAbilityLv1;
		public int dragonAbilityLv2;
		public int dragonReliabilityLv;
		public int weaponId;
		public int weaponBuildupCount;
		public int weaponSkillLv;
		public int weaponLimitBreak;
		public int weaponLimitOver;
		public int amuletId;
		public int amuletLv;
		public int amuletPlus;
		public int amuletHpPlus;
		public int amuletAtkPlus;
		public int[] amuletHasAbility;
		public int amuletId2;
		public int amuletLv2;
		public int amuletPlus2;
		public int amuletHpPlus2;
		public int amuletAtkPlus2;
		public int[] amuletHasAbility2;
		public CommonPartyPowerCalculateAbilityCrestData[] crestType1List;
		public CommonPartyPowerCalculateAbilityCrestData[] crestType2List;
		public CommonPartyPowerCalculateAbilityCrestData[] crestType3List;
	
		// Constructors
		public CommonPartyPowerCalculateData();
	
		// Methods
		public void SetData(CommonPartyPowerCalculateData baseData);
		public void SetCrestData(AbilityCrestList abilityCrestData, int typeNo, int num);
		public void SetAmuletData(UnitDetailModel.AmuletDetailData amuletDetailData, int typeNo, int num);
		public CommonPartyPowerCalculateAbilityCrestData GetCrestData(int typeNo, int num);
	}
}
