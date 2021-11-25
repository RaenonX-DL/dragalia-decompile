using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class BRItemManager : MonoBehaviour
	{
		private class TypeComparer : IEqualityComparer<BattleRoyalDungeonItem>
		{
			public bool Equals(BattleRoyalDungeonItem x, BattleRoyalDungeonItem y)
			{
				return default(bool);
			}

			public int GetHashCode(BattleRoyalDungeonItem obj)
			{
				return default(int);
			}
		}

		private Dictionary<BattleRoyalDungeonItem, GameObject> prefabDict;

		public List<BRItemBase> AliveItems
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

		private void Start()
		{
		}

		public void CreateItem(BRItemParam param, Vector3 pos, bool isSync)
		{
		}

		public void CreateItems(List<BRItemParam> createItemParams, Vector3 pos)
		{
		}

		private IEnumerator CreateItemsCoroutine(List<BRItemParam> createItemParams, Vector3 pos, float radius, uint seed)
		{
			return null;
		}

		private void CreateItemCore(GameObject go, BRItemParam param, Vector3 startPos, Vector3 endPos, bool ignoreSeFx)
		{
		}

		public void DeleteItem(BRItemBase item)
		{
		}

		public void DeleteAllItems()
		{
		}

		private void LoadPrefabs()
		{
		}

		private void AddPool(BattleRoyalDungeonItem type, int ct)
		{
		}

		private void ReleaseItemInstance(GameObject obj)
		{
		}

		private void SendCreateRandomPopItemEvent(List<BRItemParam> createItemParams, Vector3 pos, float radius, uint seed)
		{
		}

		private void SendCreateSilentPopItemEvent(BRItemParam param, Vector3 pos)
		{
		}

		public void OnReceiveEvent(BRCreateItemEvent recvEvent)
		{
		}

		public BRItemBase FindBRItem(BRItemId id)
		{
			return null;
		}

		public static BattleRoyalDungeonItem GetLotteryItem(int groupId)
		{
			return default(BattleRoyalDungeonItem);
		}
	}
}
