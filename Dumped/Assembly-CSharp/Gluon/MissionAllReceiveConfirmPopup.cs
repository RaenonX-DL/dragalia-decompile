/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Mission;
using Gluon.Mission.ListView;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MissionAllReceiveConfirmPopup : CommonPopup
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Mission/Popup/MissionAllReceiveConfirmPopup";
		private List<MyPagePresentGroupListCellData> groupCellDataList;
		[SerializeField]
		private MyPagePresentGroupListController groupListController;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public List<MissionTableViewData> missionList;
			public MissionAllReceiveConfirmPopup __4__this;
			public Action onReceivedCallback;
			public Action onPressedSceneButtonCallback;
			public TabCategory category;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _InitSetting_b__0();
			internal void _InitSetting_b__1();
		}
	
		// Constructors
		public MissionAllReceiveConfirmPopup();
	
		// Methods
		public static MissionAllReceiveConfirmPopup Create();
		public void InitSetting(TabCategory category, List<MissionTableViewData> missionList, Action onReceivedCallback, Action onPressedSceneButtonCallback);
		public static void CreateReceiveGroupList(List<MissionTableViewData> missionList, List<MyPagePresentGroupListCellData> refGroupCellDataList, bool isConfirm = false);
		private static MyPagePresentGroupListCellData CreateCellDataWithDuplicateText(GiftType entityType, int entityId, int entityQuantity, Reward reward, MyPagePresentListPopup.ItemCategory itemCategory, Localize.TextId textId);
	}
}
