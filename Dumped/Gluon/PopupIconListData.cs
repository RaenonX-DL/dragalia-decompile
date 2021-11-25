using UnityEngine;

namespace Gluon
{
	public class PopupIconListData
	{
		public class ItemIconInfo
		{
			public int inventoryId;

			public int lavel;

			public GiftType giftType;

			public int sortKey;

			public Sprite iconSprite;
		}

		public struct IconListData
		{
			public int inventoryId;

			public int lavel;

			public GiftType giftType;

			public int key;

			public Sprite sprite;

			public IconListData(int setId, int setLabel, GiftType setType, int setKey)
			{
			}
		}

		public ItemIconInfo[] itemIconInfoArray;

		public PopupItemList rootScene;

		public static int ListIconMaxNum;

		public void SetRootScene(PopupItemList setroot)
		{
		}

		public bool SetData(IconListData listData)
		{
			return default(bool);
		}
	}
}
