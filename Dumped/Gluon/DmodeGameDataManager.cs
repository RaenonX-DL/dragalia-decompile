using System.Collections.Generic;
using Gluon.Event;
using Gluon.Http;

namespace Gluon
{
	public class DmodeGameDataManager
	{
		public class DmodeDungeonItemParts
		{
			public int itemNo;

			public int itemId;

			public int strengthParamId;

			public int strengthAbilityId;

			public int strengthSkillId;

			public int abnormalStatusInvalidCount;
		}

		public class DmodeDropObj
		{
			public int objId;

			public int objType;

			public List<EntityData> dmodeDropList;
		}

		public class DmodeEnemy
		{
			public int enemyIdx;

			public int isPop;

			public int level;

			public int paramId;

			public List<EntityData> dmodeDropList;
		}

		public class DmodeSelectDragon
		{
			public int selectDragonNo;

			public int dragonId;

			public bool isRare;

			public int payDmodePoint;

			public int payRareDmodePoint;
		}

		public class DmodeFloorRecord
		{
			public float resultQuestTime;

			public int selectDragonNo;

			public List<int> brokenObjIdList;

			public List<int> smashEnemyIdxList;

			public List<int> equipCrestItemNoSortList;

			public List<int> bagItemNoSortList;

			public List<int> skillBagItemNoSortList;

			public void Initialize()
			{
			}
		}

		public enum DmodeDungeonItemState
		{
			None = 0,
			Take = 1,
			Sell = 2,
			UseSkill = 3,
			Bag = 11,
			EquipWeapon = 12,
			EquipCrest = 13,
			SkillBag = 14
		}

		public const int bagHoldCountMax = 10;

		public const int skillBagHoldCountMax = 8;

		public const int equipCrestCountMax = 3;

		public const int selectDragonNoMax = 4;

		private DmodeFloorRecord _dmodeFloorRecord;

		private DmodeGameSettingData gameSetting;

		private DmodeServitorPassiveParam[] _servitorPassiveList;

		private Dictionary<int, DmodeHoldDragon> _holdDragonMap;

		private List<DmodeSelectDragon> _dmodeSelectDragonList;

		private Dictionary<int, int> _holdDragonUseMap;

		private Dictionary<int, DmodeDungeonItemParts> _dmodeDungeonItemAllList;

		private Dictionary<int, DmodeDropObj> _dungeonObjList;

		private List<DmodeEnemy> _dungeonEnemyList;

		private Dictionary<int, DmodeDungeonItemState> _dmodeDungeonItemStateList;

		private Dictionary<int, int> _dmodeAbnormalStatusInvalidCountList;

		private int _equipWeaponItemNo;

		private int[] _bagItemNoList;

		private int[] _skillBagItemNoList;

		private int[] _equipCrestItemNoList;

		private int _currentRecoveryCount;

		public void Initialize(GameDataManager.InGameDataMode mode)
		{
		}

		public void InitializeParam()
		{
		}

		public void Clear()
		{
		}

		public void UpdateDmodeFloorData()
		{
		}

		private void UpdateDungeonItemList()
		{
		}

		private void UpdateDungeonDrop()
		{
		}

		public HeroParam CreateHeroParam()
		{
			return null;
		}

		public DmodePlayRecord CreateDmodePlayRecord(bool isIncomplete = false)
		{
			return null;
		}

		public int GetExp()
		{
			return default(int);
		}

		public int GetServitorId()
		{
			return default(int);
		}

		public int GetTargetFloorNum()
		{
			return default(int);
		}

		public bool IsDmodeQuestPlayEnd()
		{
			return default(bool);
		}

		public bool IsViewAreaStartEquipment()
		{
			return default(bool);
		}

		public int GetRecoveryCount()
		{
			return default(int);
		}

		public DmodeServitorPassiveParam[] GetDmodeServitorPassiveList()
		{
			return null;
		}

		public int GetCurrentDmodeAreaId()
		{
			return default(int);
		}

		public int GetCurrentDmodeAreaThemeId()
		{
			return default(int);
		}

		public int GetFloorNum()
		{
			return default(int);
		}

		public string GetFloorKey()
		{
			return null;
		}

		public float GetQuestTime()
		{
			return default(float);
		}

		public int GetDmodeScore()
		{
			return default(int);
		}

		public DmodeSelectDragon[] GetSelectDragonList()
		{
			return null;
		}

		public DmodeHoldDragon[] GetHoldDragonList()
		{
			return null;
		}

		public int GetTakeDmodePoint()
		{
			return default(int);
		}

		public int GetTakeRareDmodePoint()
		{
			return default(int);
		}

		public DmodeDungeonItemParts GetDmodeDungeonItem(int itemNo)
		{
			return null;
		}

		public int GetEquipDmodeWeaponId(out DmodeDungeonItemParts item)
		{
			return default(int);
		}

		public DmodeDungeonItemParts[] GetBagItemList()
		{
			return null;
		}

		public DmodeDungeonItemParts[] GetEquipCrestItemList()
		{
			return null;
		}

		public DmodeDungeonItemParts[] GetSkillBagItemList()
		{
			return null;
		}

		public List<EntityData> GetObjDrop(int objId)
		{
			return null;
		}

		public int GetEnemyParamId(int enemyIdx)
		{
			return default(int);
		}

		public int GetEnemyLevel(int enemyIdx)
		{
			return default(int);
		}

		public List<EntityData> GetEnemyDrop(int enemyIdx)
		{
			return null;
		}

		public DmodeDungeonItemParts[] GetAllDmodeDungeonItem()
		{
			return null;
		}

		public DmodeFloorRecord GetDmodeFloorRecord()
		{
			return null;
		}

		public void SetDmodeDungeonItemDiscard(int itemNo)
		{
		}

		public void SetDmodeDungeonItemTaking(int itemNo)
		{
		}

		public void SetDmodeDungeonItemSelling(int itemNo)
		{
		}

		public void SetDmodeDungeonItemUseSkill(int itemNo)
		{
		}

		public void SetDmodeDungeonItemToBag(int itemNo)
		{
		}

		public void SetDmodeDungeonEquipWeapon(int itemNo)
		{
		}

		public void SetDmodeDungeonEquipCrest(int itemNo)
		{
		}

		public void SetDmodeDungeonSkillBag(int itemNo)
		{
		}

		private bool SetDungeonItemState(int itemNo, DmodeDungeonItemState state)
		{
			return default(bool);
		}

		public void SetSmashEnemy(int enemyIdx)
		{
		}

		public void SetBreakObject(int objId)
		{
		}

		public void SetQuestTime(float time)
		{
		}

		public void SetAbnormalStatusInvalidCountList(int itemNo)
		{
		}

		public void SetDragonTransformCount(int dragonId)
		{
		}

		public void SetSelectDragonNo(int selectNo)
		{
		}

		public void SetSortItemNoList(List<int> equipCrestItemNoList, List<int> bagItemNoList, List<int> skillBagItemNoList)
		{
		}
	}
}
