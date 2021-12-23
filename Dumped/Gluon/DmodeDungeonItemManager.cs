using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class DmodeDungeonItemManager : MonoBehaviour
	{
		public enum ContainerType
		{
			None,
			EquipWeapon,
			EquipAbilityCrest,
			CharaBag,
			FafnirBag,
			Dragon,
			DmodeSkill,
			Floor
		}

		private class TypeComparer : IEqualityComparer<ContainerType>
		{
			public bool Equals(ContainerType x, ContainerType y)
			{
				return default(bool);
			}

			public int GetHashCode(ContainerType obj)
			{
				return default(int);
			}
		}

		private static DmodeDungeonItemManager instance;

		private Dictionary<ContainerType, List<DmodeDungeonItem>> containerDict;

		public const int maxWeaponCount = 1;

		public const int maxAbilityCrestCount = 3;

		public const int maxEquipCount = 4;

		public const int maxCharaBagCount = 10;

		public const int maxDragonKindCount = 8;

		public const int maxDmodeSkillCount = 8;

		public const int maxDropDmodeSkillCount = 10;

		public const int maxDropWeaponCount = 10;

		private Dictionary<int, DmodeDungeonItem> instancedItemDict;

		private Dictionary<int, DmodeDungeonItem> identicalItemDict;

		private int itemIdCount;

		private Dictionary<int, int> instanceIdToItemIdDict;

		public static DmodeDungeonItemManager Instance => null;

		public static bool HasInstance => default(bool);

		private void OnDestroy()
		{
		}

		public void Initialize(Transform parent)
		{
		}

		public void SetupAreaItems()
		{
		}

		public void ClearRegisteredItems()
		{
		}

		private void RemoveItem(DmodeDungeonItem item)
		{
		}

		public void UseSkillItem(DmodeDungeonItem item)
		{
		}

		public void UseDragonItem(DmodeDungeonItem item)
		{
		}

		public void AddAbilityExpireCount(int itemId)
		{
		}

		public void SellItem(DmodeDungeonItem item)
		{
		}

		public DmodeDungeonItem GetEquipWeapon()
		{
			return null;
		}

		public int GetEquipWeaponSkillIndex()
		{
			return default(int);
		}

		public List<DmodeDungeonItem> GetEquipAbilityCrest()
		{
			return null;
		}

		public List<DmodeDungeonItem> GetCharaBagItems()
		{
			return null;
		}

		public List<DmodeDungeonItem> GetCharaBagItems(DmodeDungeonItemType itemType)
		{
			return null;
		}

		public List<DmodeDungeonItem> GetFafnirBagItems()
		{
			return null;
		}

		public List<DmodeDungeonItem> GetDragonItems()
		{
			return null;
		}

		public List<DmodeDungeonItem> GetDmodeSkillItems()
		{
			return null;
		}

		public List<DmodeDungeonItem> GetSelectDragonItems()
		{
			return null;
		}

		public List<DmodeDungeonItem> GetFloorItems()
		{
			return null;
		}

		public List<DmodeDungeonItem> GetFloorItems(DmodeDungeonItemType itemType)
		{
			return null;
		}

		public void MoveItemsBetweenCharaBagAndFafnirBag(List<DmodeDungeonItem> charaBagItems, List<DmodeDungeonItem> fafnirBagItems)
		{
		}

		public void MoveItemsBetweenEquipAndCharaBagAndFafnirBag(DmodeDungeonItem equipWeapon, List<DmodeDungeonItem> equipAbilityCrests, List<DmodeDungeonItem> charaBagItems, List<DmodeDungeonItem> fafnirBagItems, DmodeDungeonItem prevEquipWeapon, List<DmodeDungeonItem> prevEquipAbilityCrests)
		{
		}

		public void MoveItemsBetweenDmodeSkillAndFafnirBag(List<DmodeDungeonItem> dmodeSkillItems, List<DmodeDungeonItem> fafnirBagItems)
		{
		}

		public bool MoveItemFromFloor(int instanceId, ContainerType container = ContainerType.None)
		{
			return default(bool);
		}

		private bool MoveItemFromFloor(DmodeDungeonItem item, ContainerType container)
		{
			return default(bool);
		}

		public void SelectDragon(DmodeDungeonItem selectedItem, int price)
		{
		}

		public void SetDropped(int instanceId, int dataId)
		{
		}

		public void MoveDroppedItems(ContainerType container)
		{
		}

		public List<DmodeDungeonItem> GetDroppedItems()
		{
			return null;
		}

		public static DmodeDungeonItemDataElement GetDmodeDungeonItemDragon(int dragonId)
		{
			return null;
		}

		public DmodeDungeonDropItemBase GetDDDItem(DmodeDungeonItem item)
		{
			return null;
		}

		private void DeleteDDDItem(DmodeDungeonItem item)
		{
		}

		public void SetSortItemNoList()
		{
		}

		private void AddItem(int instanceId, DmodeDungeonItem item, ContainerType container)
		{
		}

		private List<DmodeDungeonItem> GetContainerItems(ContainerType container)
		{
			return null;
		}

		private bool IsFull(ContainerType container)
		{
			return default(bool);
		}

		private void ReflectChangedEquipment(DmodeDungeonItem prevWeapon, List<DmodeDungeonItem> prevAbilityCrests)
		{
		}

		private int GetInstanceId(DmodeDungeonItem item)
		{
			return default(int);
		}

		private void OnAddedItem(ContainerType container, DmodeDungeonItem item)
		{
		}
	}
}
