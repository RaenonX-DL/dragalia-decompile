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
	public class PopupItemList : CommonPopup
	{
		// Fields
		public PopupIconListView popupIconListView;
		public GiftType showGiftType;
		public Canvas canvas;
		private PopupIconListData.IconListData[] iconDataList;
		public PopupItemList rootScene;
		public ContactToParent callBack;
	
		// Nested types
		public delegate void ListIconTapCall(GiftType buttonType, int inventoryId);
	
		public delegate void ContactToParent(int inventoryId, GiftType buttonType);
	
		// Constructors
		public PopupItemList();
	
		// Methods
		public void Initialize(PopupIconListData.IconListData[] list);
		public static PopupItemList CreateList(PopupIconListData.IconListData[] dataList);
		public void DataSetup();
		public void SetRootScene();
		public void SetCallBack(ContactToParent setCallBack);
		public void ListIconPush(GiftType buttonType, int inventoryId);
		public void CallBackToParent(int inventoryId, GiftType buttonType);
	}
}
