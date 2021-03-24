/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using Gluon.Mission;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MissionReceiveResultPopup : CommonPopup
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Mission/Popup/MissionReceiveResultPopup";
		[SerializeField]
		private MyPagePresentGroupListController successGroupListController;
		[SerializeField]
		private UnityEngine.UI.Text successText;
		[SerializeField]
		private MyPagePresentGroupListController failedGroupListController;
		[SerializeField]
		private UnityEngine.UI.Text failedText;
		private MyPagePresentGroupListController groupListController;
		private static bool isSingleReceive;
		public static List<ConvertedEntityList> convertedList;
		private Action onPressedSceneButtonCallback;
	
		// Nested types
		public enum State
		{
			None = -1,
			Discard = 0,
			ToPresent = 1,
			Receive = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public MissionReceiveResultPopup __4__this;
			public List<MyPagePresentGroupListCellData> receiveCellDataList;
			public State state;
			public Action onReceivedCallback;
			public Action onPressedSceneButtonCallback;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _InitSetting_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_1
		{
			// Fields
			public bool isDiscard;
			public __c__DisplayClass11_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass11_1();
	
			// Methods
			internal void _InitSetting_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public Action successCallback;
			public Action downloadCallback;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _RequestMissionReceiveReward_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_1
		{
			// Fields
			public List<int> beginnerList;
			public __c__DisplayClass17_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass17_1();
	
			// Methods
			internal void _RequestMissionReceiveReward_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _RequestMissionReceiveDailyReward_b__0(MissionReceiveDailyRewardResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _RequestMissionReceivePeriodReward_b__0(MissionReceivePeriodRewardResponse res);
		}
	
		[CompilerGenerated]
		private struct _RequestMissionReceiveNormalReward_d__20 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int[] normalList;
			public int[] storyMissionList;
			public int[] eventMissionList;
			public int[] albumMissionList;
			public Action successCallback;
			private List<ConvertedEntityList> _convertedEntityLists_5__2;
			private TaskAwaiter<MissionReceiveNormalRewardResponse> __u__1;
			private TaskAwaiter<MissionReceiveMainStoryRewardResponse> __u__2;
			private TaskAwaiter<MissionReceiveMemoryEventRewardResponse> __u__3;
			private TaskAwaiter<MissionReceiveAlbumRewardResponse> __u__4;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _RequestMissionReceiveBeginnerReward_b__0(MissionReceiveBeginnerRewardResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _RequestMissionReceiveSpecialReward_b__0(MissionReceiveSpecialRewardResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _RequestMissionReceiveDrillReward_b__0(MissionReceiveDrillRewardResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass25_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_1
		{
			// Fields
			public DuplicateConfirmPopup popup;
			public __c__DisplayClass25_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass25_1();
	
			// Methods
			internal void _ShowConvertConfirmPop_b__0();
		}
	
		// Constructors
		public MissionReceiveResultPopup();
		static MissionReceiveResultPopup();
	
		// Methods
		public static MissionReceiveResultPopup Create();
		public void InitSetting(List<MyPagePresentGroupListCellData> receiveCellDataList, Action onReceivedCallback, Action onPressedSceneButtonCallback, State state = State.None);
		private void LoadReceiveList(List<MyPagePresentGroupListCellData> groupCellDataList, bool isReceived);
		private void OnPressedSceneButtonCallback(MyPagePresentListPopup.NextScenePattern nextScenePattern);
		private void CreateNoReceivedList(List<MyPagePresentGroupListCellData> groupCellDataList, State state);
		private void RemoveNoReceivedList(List<MyPagePresentGroupListCellData> groupCellDataList, State state);
		private MyPagePresentGroupListCellData GetGroupCellDataForTargetItem(List<MyPagePresentGroupListCellData> groupCellDataList, GiftType type, int id);
		public static void RequestMissionReceiveReward(TabCategory category, MissionTableViewData[] dataList, Action successCallback, bool isSingle = false);
		private static void RequestMissionReceiveDailyReward(AtgenMissionParamsList[] list, Action successCallback);
		private static void RequestMissionReceivePeriodReward(int[] list, Action successCallback);
		private static async void RequestMissionReceiveNormalReward(int[] normalList, int[] storyMissionList, int[] eventMissionList, int[] albumMissionList, Action successCallback);
		private static void RequestMissionReceiveBeginnerReward(int[] list, Action successCallback);
		private static void RequestMissionReceiveSpecialReward(int[] list, Action successCallback);
		private static void RequestMissionReceiveDrillReward(int[] missionDrillIdList, int[] missionDrillGroupIdList, Action successCallback);
		private static void OnError(ErrorType errorType, int resultCode);
		private static void ShowConvertConfirmPop(ConvertedEntityList[] converted_entity_list, Action successCallback);
		[CompilerGenerated]
		private void _OnPressedSceneButtonCallback_b__13_0();
	}
}
