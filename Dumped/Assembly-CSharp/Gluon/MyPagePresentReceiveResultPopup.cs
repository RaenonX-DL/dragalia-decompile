/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPagePresentReceiveResultPopup : CommonPopup
	{
		// Fields
		public MyPagePresentListPopup presentListPopup;
		[SerializeField]
		private MyPagePresentGroupListController successGroupListController;
		[SerializeField]
		private GameObject failedRoot;
		[SerializeField]
		private UnityEngine.UI.Text failedText;
		[SerializeField]
		private MyPagePresentGroupListController failedGroupListController;
		[SerializeField]
		private GameObject failedOneItemCell;
		[SerializeField]
		private CommonIcon failedOneItem;
		[SerializeField]
		private UnityEngine.UI.Text failedOneItemNameText;
		private List<MyPagePresentGroupListCellData> groupCellDataList;
		private MyPagePresentGroupListController groupListController;
		private State popupState;
		private bool isTransition;
		private const string prefabPath = "Prefabs/OutGame/Present/MyPagePresentReceiveResultPopup";
	
		// Nested types
		private enum State
		{
			None = -1,
			Delete = 0,
			NoReceive = 1,
			LimitOver = 2,
			Converted = 3,
			Receive = 4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public MyPagePresentReceiveResultPopup __4__this;
			public List<ulong> noReceiveIds;
			public List<ulong> deleteIds;
			public List<ulong> limitOverIds;
			public List<ulong> receiveIds;
			public List<ConvertedEntityList> convertedList;
			public List<MyPagePresentListCellData> reqCellDataList;
			public MyPagePresentListPopup.TypeTab tabType;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _InitSetting_b__0();
		}
	
		// Constructors
		public MyPagePresentReceiveResultPopup();
	
		// Methods
		public static MyPagePresentReceiveResultPopup Create();
		public void InitSetting(List<ulong> noReceiveIds, List<ulong> deleteIds, List<ulong> limitOverIds, List<ulong> receiveIds, List<MyPagePresentListCellData> reqCellDataList, MyPagePresentListPopup.TypeTab tabType, List<ConvertedEntityList> convertedList);
		private MyPagePresentListCellData[] GetCellDataListFromPresentIds(List<ulong> resPresentIds, List<MyPagePresentListCellData> reqCellDataList);
		private MyPagePresentListCellData[] GetCellDataListFromConvertedList(List<ConvertedEntityList> convertedList, List<ulong> resPresentIds, List<MyPagePresentListCellData> reqCellDataList);
		private MyPagePresentListCellData CreateReceivedCellData(ConvertedEntityList convertedItem);
		private void LoadNoReceivePresentList(MyPagePresentListCellData[] presentCellDataList);
		private void LoadReceivePresentList(MyPagePresentListCellData[] presentCellDataList);
		private void OnPressedSceneButtonCallback(MyPagePresentListPopup.NextScenePattern nextScenePattern);
		[CompilerGenerated]
		private void _OnPressedSceneButtonCallback_b__21_0();
	}
}
