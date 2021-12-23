using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public static class DmodePopupUtil
	{
		public class DmodeUnifiedActiveAbilityInfo
		{
			public int id;

			public string iconName;

			public string name;

			public string detail;

			public List<int> activatorList;
		}

		public static readonly string prefabPath;

		public static bool IsCurrentCharaUniqueTransform()
		{
			return default(bool);
		}

		public static int GetCurrentCharaId()
		{
			return default(int);
		}

		public static CharaDataElement GetCurrentCharaDataElem()
		{
			return null;
		}

		public static List<int> GetEquipped(DmodeDungeonItemType type)
		{
			return null;
		}

		public static List<int> GetInventory(DmodeDungeonItemType type)
		{
			return null;
		}

		public static List<int> GetCharaBag()
		{
			return null;
		}

		public static List<int> GetFafnirBag()
		{
			return null;
		}

		private static DmodeDungeonItem GetDmodeDungeonItem(int id)
		{
			return null;
		}

		public static List<DmodeDungeonItem> GetDmodeDragonRewardList(out List<int> priceList)
		{
			return null;
		}

		public static int GetDmodeDragonRewardAsDmodePoint()
		{
			return default(int);
		}

		public static bool GetDmodeDungeonItem(int id, out DmodeDungeonItem item)
		{
			return default(bool);
		}

		public static int DungeonItemIdToItemId(int id)
		{
			return default(int);
		}

		public static void SellItem(DmodeDungeonItemManager.ContainerType container, DmodeDungeonItemType type, int id)
		{
		}

		public static void SetInventory(List<int> charaItems, List<int> fafnirItems)
		{
		}

		public static int GetDragonStackNum(int id)
		{
			return default(int);
		}

		public static void SetEquipped(DmodeDungeonItemType type, List<int> ids, int sellId = 0)
		{
		}

		public static bool GetSkillMasterElement(int id, out SkillDataElement elem)
		{
			return default(bool);
		}

		public static bool GetAbilityMasterElement(int id, out AbilityDataElement elem)
		{
			return default(bool);
		}

		public static bool GetExAbilityMasterElement(int id, out ExAbilityDataElement elem)
		{
			return default(bool);
		}

		public static bool GetAbilityCrestMasterElement(int id, out AbilityCrestElement elem)
		{
			return default(bool);
		}

		public static bool GetStrength(int id, out int hp, out int attack, out List<int> abilities, out int skill)
		{
			return default(bool);
		}

		public static int GetDefaultWeaponItemId()
		{
			return default(int);
		}

		public static int GetDmodePoint()
		{
			return default(int);
		}

		public static int GetRareDmodePoint()
		{
			return default(int);
		}

		public static bool GetSellPrice(int id, out int normalPrice, out int rarePrice)
		{
			return default(bool);
		}

		public static bool GetWeaponSkinMasterElement(int id, out WeaponSkinElement elem)
		{
			return default(bool);
		}

		public static bool GetDragonMasterElement(int id, out DragonDataElement elem)
		{
			return default(bool);
		}

		public static Material SetSkillIcon(Graphic image, int id, IconLoader.Size size = IconLoader.Size.M)
		{
			return null;
		}

		public static int GetCharaRarity(CharaDataElement elem)
		{
			return default(int);
		}

		public static CharaDataElement GetSkillOwner(int skillId)
		{
			return null;
		}

		public static int GetSkillLevel(int skillId)
		{
			return default(int);
		}

		public static Material SetSkillOwnerIcon(Graphic image, int id, IconLoader.Size size = IconLoader.Size.M)
		{
			return null;
		}

		public static Material SetAbilityIcon(Graphic image, int id, IconLoader.Size size = IconLoader.Size.M)
		{
			return null;
		}

		public static Material SetAbilityIcon(Graphic image, string iconName, IconLoader.Size size = IconLoader.Size.M)
		{
			return null;
		}

		public static Material SetExAbilityIcon(Graphic image, int id, IconLoader.Size size = IconLoader.Size.M)
		{
			return null;
		}

		public static Material SetAbilityCrestIcon(Graphic image, int id, IconLoader.Size size = IconLoader.Size.M)
		{
			return null;
		}

		public static Material SetDragonIcon(Graphic image, int id, IconLoader.Size size = IconLoader.Size.M)
		{
			return null;
		}

		public static Material SetWeaponIcon(Graphic image, int id, IconLoader.Size size = IconLoader.Size.M)
		{
			return null;
		}

		public static bool IsEquipSuperiorThanCurrent(int id, bool checkRecord = true)
		{
			return default(bool);
		}

		public static int GetSkippedFloorNum()
		{
			return default(int);
		}

		public static List<(AbilityConst.UnitType, AbilityDataElement)> GetUnitActiveAbilityInfoList()
		{
			return null;
		}

		public static List<DmodeUnifiedActiveAbilityInfo> GetFafnirActiveAbilityInfoList()
		{
			return null;
		}

		public static Color GetCompareColor(int before, int after)
		{
			return default(Color);
		}
	}
}
