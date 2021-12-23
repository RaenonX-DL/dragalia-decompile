using System.Collections.Generic;
using Gluon.Http;

namespace Gluon
{
	public class DmodeGameSettingData
	{
		public class CharaData
		{
			private AtgenUnitData unitData;

			private int _level;

			private int _exp;

			public int CharaId => default(int);

			public int Level => default(int);

			public int Exp => default(int);

			public int ExAbilityLv => default(int);

			public int ExAbility2Lv => default(int);

			public int Ability1Lv => default(int);

			public int Ability2Lv => default(int);

			public int Ability3Lv => default(int);

			public int Skill1Lv => default(int);

			public int Skill2Lv => default(int);

			public int BurstAttackLv => default(int);

			public int ComboBuildupCount => default(int);

			public CharaData(AtgenUnitData data)
			{
			}

			public void SetCurrentParam(int level, int exp)
			{
			}
		}

		private DmodeIngameData _dmodeIngameData;

		private DmodeFloorData _dmodeFloorData;

		private CharaData _charaData;

		public int ServitorId => default(int);

		public int TargetFloorNum => default(int);

		public int RecoveryCount => default(int);

		public int RecoveryTime => default(int);

		public string UniqueKey => null;

		public string FloorKey => null;

		public bool IsViewAreaStartEquipment => default(bool);

		public bool IsPlayEnd => default(bool);

		public int CurrentAreaId => default(int);

		public int CurrentAreaThemeId => default(int);

		public float QuestTime => default(float);

		public int DmodeScore => default(int);

		public int FloorNum => default(int);

		public int CharaLevel => default(int);

		public int CharaExp => default(int);

		public int TakeDmodePoint1 => default(int);

		public int TakeDmodePoint2 => default(int);

		public void Clear()
		{
		}

		public void Initialize()
		{
		}

		public CharaData GetCharaData()
		{
			return null;
		}

		public DmodeServitorPassiveParam[] GetDmodeServitorPassiveParamList()
		{
			return null;
		}

		public List<DmodeGameDataManager.DmodeSelectDragon> GetSelectDragonList()
		{
			return null;
		}

		public Dictionary<int, int> GetHoldDragonUseMap()
		{
			return null;
		}

		public Dictionary<int, DmodeHoldDragon> GetInitHoldDragonMap()
		{
			return null;
		}

		public void UpdateDmodeFloorData()
		{
		}

		public DmodeDungeonItemList[] GetDmodeDungeonItemList()
		{
			return null;
		}

		public int[] GetDmodeDungeonItemEquipCrestSortList()
		{
			return null;
		}

		public int[] GetDmodeDungeonItemBagSortList()
		{
			return null;
		}

		public int[] GetDmodeDungeonItemSkillBagSortList()
		{
			return null;
		}

		public DmodeOddsInfo GetDmodeOddsInfo()
		{
			return null;
		}

		public void InitializeDummy()
		{
		}
	}
}
