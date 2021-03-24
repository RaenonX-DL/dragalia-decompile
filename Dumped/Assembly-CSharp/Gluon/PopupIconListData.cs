/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PopupIconListData
	{
		// Fields
		public ItemIconInfo[] itemIconInfoArray;
		public PopupItemList rootScene;
		public static int ListIconMaxNum;
	
		// Nested types
		public class ItemIconInfo
		{
			// Fields
			public int inventoryId;
			public int lavel;
			public GiftType giftType;
			public int sortKey;
			public Sprite iconSprite;
	
			// Constructors
			public ItemIconInfo();
		}
	
		public struct IconListData
		{
			// Fields
			public int inventoryId;
			public int lavel;
			public GiftType giftType;
			public int key;
			public Sprite sprite;
	
			// Constructors
			public IconListData(int setId, int setLabel, GiftType setType, int setKey);
		}
	
		// Constructors
		public PopupIconListData();
		static PopupIconListData();
	
		// Methods
		public void SetRootScene(PopupItemList setroot);
		public bool SetData(IconListData listData);
	}
}
