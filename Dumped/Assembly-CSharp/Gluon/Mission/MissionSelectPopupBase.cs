/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon;
using Gluon.Http;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Mission
{
	public abstract class MissionSelectPopupBase : CommonPopup
	{
		// Fields
		private const float ScrollbarDefaultValue = 1f;
		[Header]
		[SerializeField]
		public TabBase tab;
		[Header]
		[SerializeField]
		public MissionTableViewController[] scrollViewList;
		private List<MissionTableViewData> receivableRewardList;
		public UnityEngine.UI.Text textNoCellEntry;
		[SerializeField]
		protected Badge[] badges;
		[SerializeField]
		protected GameObject pagerRoot;
		[SerializeField]
		protected GameObject pagerLayout;
		[SerializeField]
		protected GameObject orignailPager;
		[SerializeField]
		protected GameObject pageFrameLeftArrow;
		[SerializeField]
		protected GameObject pageFrameRightArrow;
		protected bool isReloadingByExpired;
		public UnityAction updateBadgeCallback;
		protected int currentDataCount;
		protected int currentPageIndex;
		protected int pagesCount;
		protected int currentPageFrameIndex;
		protected int pageFramesCount;
		protected List<GameObject> pagers;
		protected List<int> pageTopIndexList;
		protected const int maxCellsPerPage = 100;
		protected const int maxPagersPerFrame = 6;
		protected MissionTableViewData[][] datas;
		protected int selectedTabIndex;
		private bool isGoChallengeMissionScene;
	
		// Properties
		public bool IsGoChallengeMissionScene { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0
		{
			// Fields
			public MissionSelectPopupBase __4__this;
			public int indexInList;
	
			// Constructors
			public __c__DisplayClass43_0();
	
			// Methods
			internal void _OpenDetailPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public int value;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal void _GoChallengeMissionScene_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_1
		{
			// Fields
			public bool forceLoadSameScene;
	
			// Constructors
			public __c__DisplayClass46_1();
	
			// Methods
			internal void _GoChallengeMissionScene_b__3();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__46_0;
			public static Action __9__46_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _GoChallengeMissionScene_b__46_0();
			internal void _GoChallengeMissionScene_b__46_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0
		{
			// Fields
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass49_0();
	
			// Methods
			internal void _RequestGetMissionList_b__0(MissionGetMissionListResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0
		{
			// Fields
			public int j;
			public MissionSelectPopupBase __4__this;
	
			// Constructors
			public __c__DisplayClass55_0();
	
			// Methods
			internal void _CreatePagersForCurrentPageFrame_b__0();
		}
	
		// Constructors
		protected MissionSelectPopupBase();
	
		// Methods
		protected abstract void UpdateBadge();
		public static int GetReceivableRewardCount(TabCategory category);
		public virtual void ReloadData();
		public override void StartShowAnimation(UnityEvent onCompleted = null);
		public abstract void InitializeTabButton();
		protected int CountReceivableRewardList();
		protected abstract void InitializeMissionTab();
		public void SwitchMissionTab(int tabIndex);
		public virtual void SwitchMissionTab();
		private void UpdateMissionContents(bool createPagers);
		public override void OnCancelButtonPressed();
		public override void OnCloseButtonPressed();
		public override void OnOkButtonPressed();
		public void OnValueChangedScrollView();
		public void OnListButtonPressed(int indexInList);
		protected abstract TabCategory GetSelectedMissionCategory();
		protected virtual void OpenDetailPopup(int indexInList, int dataIndex);
		public void OnCellChallengeButtonPressed(int indexInList);
		private static bool CheckMaintenance(MissionTransportType type, int value);
		public static bool GoChallengeMissionScene(MissionTransportType type, int value);
		protected abstract void SetCellDatas();
		private List<MissionTableViewData> MakeAllRewardList(MissionTableViewData[] dataList);
		public static void RequestGetMissionList(Action successCallback);
		public static void OnError(ErrorType errorType, int resultCode);
		public abstract void ReloadWithRequestGetList();
		public void OnToShopButtonPressed();
		protected abstract void SetVisibleNoCellEntry(bool isNoEntry);
		private void CalcDataNumAndCreatePager(MissionTableViewData[] dataList, bool createPagers);
		private void CreatePagersForCurrentPageFrame();
		private MissionTableViewData[] GetDataListForPage(MissionTableViewData[] srcDataList, int pageIndex, int pageFrameIndex);
		private void OnPagerButtonPressed(int index);
		public void OnPageFrameLeftButtonPressed();
		public void OnPageFrameRightButtonPressed();
		[CompilerGenerated]
		private void _OnToShopButtonPressed_b__52_0();
		[CompilerGenerated]
		private void _OnToShopButtonPressed_b__52_1();
	}
}
