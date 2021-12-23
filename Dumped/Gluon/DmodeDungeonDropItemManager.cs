using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class DmodeDungeonDropItemManager : MonoBehaviour
	{
		private class TypeComparer : IEqualityComparer<DmodeDungeonItemType>
		{
			public bool Equals(DmodeDungeonItemType x, DmodeDungeonItemType y)
			{
				return default(bool);
			}

			public int GetHashCode(DmodeDungeonItemType obj)
			{
				return default(int);
			}
		}

		private GameObject originalPrefab;

		public static readonly int iconTextureNameArray;

		public static readonly int frameTextureNameArray;

		private Texture[] iconTextureArray;

		private Texture[] frameTextureArray;

		public static readonly int textureIdOffset;

		private static readonly int createItemObjectCount;

		public static readonly string effectLabel;

		private static readonly float defaultItemPopRadius;

		public List<DmodeDungeonDropItemBase> AliveItems
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

		private IEnumerator Start()
		{
			return null;
		}

		public float GetItemPopRadius()
		{
			return default(float);
		}

		public void CreateItem(DmodeDungeonDropItemParam param, Vector3 startPos, Vector3 moveDir, bool isSync)
		{
		}

		public void CreateItems(List<DmodeDungeonDropItemParam> createItemParams, Vector3 startPos, Action onEndFunc)
		{
		}

		public void CreateItems(List<DmodeDungeonDropItemParam> createItemParams, Vector3 startPos, Action onEndFunc, Vector3 moveDir, float angleRange)
		{
		}

		private IEnumerator CreateItemsCoroutine(List<DmodeDungeonDropItemParam> createItemParams, Vector3 startPos, Vector3 moveDir, float radius, float angleRange, uint seed, Action onEndFunc)
		{
			return null;
		}

		private string GetSoundLabel(DmodeDungeonDropItemParam itemParam)
		{
			return null;
		}

		private void CreateItemCore(GameObject go, DmodeDungeonDropItemParam param, Vector3 startPos, Vector3 endPos, bool ignoreSeFx, string soundLabel)
		{
		}

		public void DeleteItem(DmodeDungeonDropItemBase item)
		{
		}

		public void DeleteAllItems()
		{
		}

		private void LoadPrefabs(int poolCount)
		{
		}

		private void ReleaseItemInstance(GameObject obj)
		{
		}

		public DmodeDungeonDropItemBase FindItem(int instanceId)
		{
			return null;
		}
	}
}
