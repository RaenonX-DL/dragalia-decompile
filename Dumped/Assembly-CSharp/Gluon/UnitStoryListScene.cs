/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitStoryListScene : SceneBase
	{
		// Fields
		public static SelectState selectState;
		public static TypeTab currentTypeTab;
		public static ReadTab currentReadTab;
		public static int selectGroupId;
		public static int autoScrollStoryId;
		public static bool isFromEventScene;
		public Camera mainCamera;
		public static bool isStoryReadConnected;
		public static int summonId;
		public static bool isBackToSummonShop;
		public static SummonType summonType;
		public static int summonGroupId;
		public static SummonTopItemView.SummonTopItemTabType lastSelectedSummonType;
		private SimpleAnimationButton _backButtonAnim;
		private ButtonPressedMark _backButtonMark;
		private UnitStoryListCanvas mainCanvas;
		private int[] unreadCount;
		private UnitStoryListController[] controllerList;
		private List<UnitStoryListCellData>[] cellDataList;
		private List<SampleStoryInfo> sampleStoryInfos;
		private string showedNewCastleStoryString;
		public static string prefabDir;
		public const int triggerItemId = 201008001;
		private const string prefsKeyShowedNewCastleStoryKey = "ShowedNewCastleStory";
		private string sampleBannerRootPath;
		private string defaultSampleBannerName;
	
		// Properties
		private SimpleAnimationButton BackButtonAnim { get; }
		private ButtonPressedMark BackButtonMark { get; }
	
		// Nested types
		public enum SelectState
		{
			None = -1,
			CharaUnreadStory = 0,
			SampleStory = 0,
			CharaAllStory = 1,
			CharaAllGroup = 2,
			DragonUnreadStory = 3,
			DragonAllStory = 4,
			CastleStoryUnreadStory = 5,
			CastleStoryAllStory = 6,
			Max = 7
		}
	
		public enum TypeTab
		{
			None = -1,
			Chara = 0,
			Dragon = 1,
			Castle = 2,
			Max = 3,
			Sample = 4
		}
	
		public enum ReadTab
		{
			Unread = 0,
			All = 1,
			Max = 2
		}
	
		private struct SampleStoryInfo
		{
			// Fields
			public UnitStoryElement storyData;
			public UnitStoryGroupElement groupData;
			public CharaDataElement charaData;
			public AtgenUnitList summonChara;
			public bool isPickup;
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public bool isLoded;
			public UnitStoryListScene __4__this;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _Start_b__0(UnityEngine.Object prefab);
			internal bool _Start_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UnitStoryListScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public UnitStoryElement nextStory;
			public UnityAction nextStoryConfirmCallback;
			public UnitStoryListScene __4__this;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _WaitPrevSceneExit_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_1
		{
			// Fields
			public UnitStoryRewardPopup popup;
			public __c__DisplayClass39_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass39_1();
	
			// Methods
			internal void _WaitPrevSceneExit_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_2
		{
			// Fields
			public UnitStoryRewardPopup popup;
	
			// Constructors
			public __c__DisplayClass39_2();
	
			// Methods
			internal void _WaitPrevSceneExit_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_3
		{
			// Fields
			public bool httpDone;
	
			// Constructors
			public __c__DisplayClass39_3();
	
			// Methods
			internal void _WaitPrevSceneExit_b__6(SummonGetOddsDataResponse res);
			internal bool _WaitPrevSceneExit_b__7();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__39_0;
			public static Func<bool> __9__39_2;
			public static UnityAction __9__49_0;
			public static Func<UnitStoryListCellData, int> __9__55_2;
			public static Func<UnitStoryListCellData, int> __9__55_3;
			public static Func<UnitStoryListCellData, int> __9__61_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _WaitPrevSceneExit_b__39_0();
			internal bool _WaitPrevSceneExit_b__39_2();
			internal void _OnButtonPressedStory_b__49_0();
			internal int _CreateStoryList_b__55_2(UnitStoryListCellData p);
			internal int _CreateStoryList_b__55_3(UnitStoryListCellData p);
			internal int _CreateCharaAllStoryListByGroupId_b__61_0(UnitStoryListCellData p);
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__39 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UnitStoryListScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__39(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadListData_d__40 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UnitStoryListScene __4__this;
			private int _stateNum_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadListData_d__40(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0
		{
			// Fields
			public UnityAction successCallback;
	
			// Constructors
			public __c__DisplayClass50_0();
	
			// Methods
			internal void _RequestUpdateRead_b__0(StoryReadResponse res);
			internal void _RequestUpdateRead_b__1(CastleStoryReadResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public UnitStoryElement nextStory;
			public UnitStoryListScene __4__this;
			public CommonPopup popup;
			public bool isNeedDownload;
			public DownloadOperation downloadOperation;
			public DownloadOperation downloadOperationWithoutVoice;
			public string title;
			public UnityAction completeCallback;
			public UnityAction __9__5;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal void _CreateReadNextStoryConfirmPopup_b__0();
			internal void _CreateReadNextStoryConfirmPopup_b__1();
			internal void _CreateReadNextStoryConfirmPopup_b__2();
			internal void _CreateReadNextStoryConfirmPopup_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_1
		{
			// Fields
			public SelectableDownloadPopup downloadPopup;
			public __c__DisplayClass54_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass54_1();
	
			// Methods
			internal void _CreateReadNextStoryConfirmPopup_b__3();
			internal void _CreateReadNextStoryConfirmPopup_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0
		{
			// Fields
			public TypeTab type;
			public UnitStoryListScene __4__this;
	
			// Constructors
			public __c__DisplayClass55_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_1
		{
			// Fields
			public bool isNew;
			public __c__DisplayClass55_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass55_1();
	
			// Methods
			internal void _CreateStoryList_b__0(int storyId);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_2
		{
			// Fields
			public UnitStoryListCellData cellData;
			public UnitStoryListScene __4__this;
	
			// Constructors
			public __c__DisplayClass55_2();
	
			// Methods
			internal void _CreateStoryList_b__1(int storyId);
		}
	
		// Constructors
		public UnitStoryListScene();
		static UnitStoryListScene();
	
		// Methods
		public static bool IsUnreadStory(TypeTab type);
		public static bool IsOpenCastleStory(bool withStepCheck = true);
		public static bool IsOverCurrentTimeByDateString(string dateStr);
		[IteratorStateMachine]
		private IEnumerator Start();
		private void SetEnableBackButtonExitAnimation(bool enable);
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		[IteratorStateMachine]
		private IEnumerator LoadListData();
		public void SetType(int tabIndex);
		public void SetRead(int tabIndex);
		private void SetUnitStoryList(TypeTab type, ReadTab read, int groupId = -1);
		private void SetUnitStoryList(SelectState state, bool isRecreate = true);
		private void LoadListDataSample();
		public void OnBackButtonPressed();
		public void CreateSortPopup();
		public static void OnError(ErrorType errorType, int resultCode);
		public void OnButtonPressedStory(TypeTab type, int storyId, bool needRequest);
		public static void RequestUpdateRead(int storyId, TypeTab type, UnityAction successCallback);
		private List<UnitStoryListCellData> SortCellDataListForUnitStory(List<UnitStoryListCellData> list, SelectState state);
		private void SetCaption();
		private UnitStoryElement GetNextStory(UnitStoryElement readedStory);
		private void CreateReadNextStoryConfirmPopup(UnitStoryElement nextStory, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice);
		private void CreateStoryList();
		private List<UnitStoryListCellData> CreateSampleStoryList();
		private List<SampleStoryInfo> GetSampleStoryInfoList(OddsUnitDetail[] summonCharas);
		private bool TryGetSampleStoryInfo(AtgenUnitList summonChara, bool isPickup, out SampleStoryInfo sampleStoryInfo);
		public override void OnPresentReceived();
		public static string[] GetShowedNewCastleStoryList();
		private void CreateCharaAllStoryListByGroupId(int groupId);
		public override void StartExitAnimation();
		protected override void OnExitAnimationCompleted();
		[CompilerGenerated]
		private bool _WaitPrevSceneExit_b__39_1();
		[CompilerGenerated]
		private void _CreateSampleStoryList_b__56_0(int storyId);
	}
}
