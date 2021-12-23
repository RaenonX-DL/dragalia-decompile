using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class DmodeDungeonItem
	{
		public class SelectDragonData
		{
			public int selectDragonNo;

			public bool isRare;

			public int payDmodePoint;

			public int payRareDmodePoint;
		}

		protected DmodeDungeonItemDataElement dataElemCache;

		private int strengthParamId;

		private int strengthAbilityId;

		private int strengthSkillId;

		private DmodeDungeonItemType _itemType;

		public bool hasDropped;

		public int id
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int dataId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int stackNum
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int normalSellPrice => default(int);

		public int rareSellPrice => default(int);

		public int rarity => default(int);

		public DmodeDungeonItemType itemType => default(DmodeDungeonItemType);

		public int abilityExpireCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public SelectDragonData selectDragonData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DmodeDungeonItem(int id, int dataId, int strengthParamId, int strengthAbilityId, int strengthSkillId, int stackNum = 0, int abilityExpireCount = 0)
		{
		}

		public bool GetStrength(out int hp, out int atk, out List<int> abilities, out int skill)
		{
			return default(bool);
		}

		public int GetSkillId()
		{
			return default(int);
		}

		public int GetSkillIndex(out CharaDataElement srcShareChara)
		{
			return default(int);
		}

		public int GetWeaponSkinId()
		{
			return default(int);
		}

		public static int GetDefaultWeaponSkinId(WeaponType type)
		{
			return default(int);
		}

		public int GetAbilityCrestId()
		{
			return default(int);
		}

		public int GetDragonId()
		{
			return default(int);
		}

		public bool IsStackable()
		{
			return default(bool);
		}

		public bool UseStack()
		{
			return default(bool);
		}

		public void SetSelectDragonData(DmodeGameDataManager.DmodeSelectDragon data)
		{
		}
	}
}
