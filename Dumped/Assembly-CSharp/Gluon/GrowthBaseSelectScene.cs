/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthBaseSelectScene : SceneBase
	{
		// Fields
		public static GrowthBaseType growthBaseType;
		public static GrowthActionType growthActionType;
		public static bool isShowCaption;
		public static bool isPlayWakeStory;
		public bool isShowIcon;
		public Canvas mainCanvas;
		public Camera uiCamera;
		public Camera flashCamera;
		public Camera textFlashCamera;
		public Camera frontEffectCamera;
		public Camera backEffectCamera;
		public Canvas bgCanvas;
		public SimpleStoryManager storyManager;
		public GrowthBaseSelectListBase listBase;
		private ulong awakeKeyId;
		private BackButton backButton;
		private GameObject awakeAnimation;
		private GameObject awakeTextAnimation;
		private CommonSortModel.Preset growthPreset;
		private BaseCanvasContents baseCanvasContents;
		private bool endAwakeEffectFlag;
		private bool tapAndBackKeyLockFlag;
		private string startEffectName;
		private string nextEffectName;
		private string endEffectName;
		private int effectTriggerNumber;
		private EffectObject frontEffectObject;
		private EffectObject backEffectObject;
		private EffectObject firstEffectObject;
		private int effectSkipSortOderKey;
		private bool isLoadScene;
		private const string basePrefabPath = "Prefabs/OutGame/Growth/GrowthBaseSelect/";
		private bool isFirstTabSelected;
		private bool isPlayCaptionAnimation;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _ShowPointerDelay_d__39 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowPointerDelay_d__39(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0
		{
			// Fields
			public GrowthBaseSelectScene __4__this;
			public CommonIconListCellData data;
	
			// Constructors
			public __c__DisplayClass45_0();
	
			// Methods
			internal void _IconButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_1
		{
			// Fields
			public CommonPopup limitPop;
	
			// Constructors
			public __c__DisplayClass45_1();
	
			// Methods
			internal void _IconButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_2
		{
			// Fields
			public GrowthAwakeConfirmPop confirmPop;
			public __c__DisplayClass45_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass45_2();
	
			// Methods
			internal void _IconButtonPressed_b__2();
			internal void _IconButtonPressed_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_3
		{
			// Fields
			public GrowthResetPlusConfirmPop confirmPopup;
			public __c__DisplayClass45_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass45_3();
	
			// Methods
			internal void _IconButtonPressed_b__4();
			internal void _IconButtonPressed_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_4
		{
			// Fields
			public GrowthResetPlusConfirmPop confirmPopup;
			public __c__DisplayClass45_0 CS___8__locals3;
	
			// Constructors
			public __c__DisplayClass45_4();
	
			// Methods
			internal void _IconButtonPressed_b__6();
			internal void _IconButtonPressed_b__7();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public GrowthBaseSelectScene __4__this;
			public CommonIconListCellData data;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal void _IconButtonLongPressed_b__0();
			internal void _IconButtonLongPressed_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<CommonListCustomSortData, CommonListCustomSortData> __9__47_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal CommonListCustomSortData _LoadBaseListData_b__47_2(CommonListCustomSortData data);
		}
	
		[CompilerGenerated]
		private sealed class _CreateListBaseCells_d__48 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthBaseSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CreateListBaseCells_d__48(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0
		{
			// Fields
			public GrowthBaseCommonData commonData;
	
			// Constructors
			public __c__DisplayClass52_0();
	
			// Methods
			internal bool _GetLimitBreakKeyIds_b__0(GrowthBaseCommonData data);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0
		{
			// Fields
			public bool isFirstLoaded;
			public GrowthBaseSelectScene __4__this;
	
			// Constructors
			public __c__DisplayClass55_0();
	
			// Methods
			internal void _SendDataOnSuccess_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0
		{
			// Fields
			public GrowthBaseSelectScene __4__this;
			public FlRoot textFlRoot;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _ShowAwakeEffect_b__0();
			internal void _ShowAwakeEffect_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _AwakeAnimationDelay_d__57 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthBaseSelectScene __4__this;
			public FlMotion awakeAnimeMotion;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AwakeAnimationDelay_d__57(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0
		{
			// Fields
			public GrowthAwakeResultPop resultPop;
			public GrowthBaseSelectScene __4__this;
	
			// Constructors
			public __c__DisplayClass58_0();
	
			// Methods
			internal void _ShowAwakeReslt_b__0();
			internal void _ShowAwakeReslt_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0
		{
			// Fields
			public Image blackImage;
			public GrowthBaseSelectScene __4__this;
	
			// Constructors
			public __c__DisplayClass61_0();
	
			// Methods
			internal void _PlayNextEffect_b__2();
		}
	
		[CompilerGenerated]
		private struct _SendResetPlusData_d__72 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ulong targetKeyId;
			public GrowthBaseSelectScene __4__this;
			private TaskAwaiter<CharaResetPlusCountResponse> __u__1;
			private TaskAwaiter<DragonResetPlusCountResponse> __u__2;
			private TaskAwaiter<AbilityCrestResetPlusCountResponse> __u__3;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_0
		{
			// Fields
			public CommonPopup resetCompletePopup;
			public GrowthBaseSelectScene __4__this;
	
			// Constructors
			public __c__DisplayClass73_0();
	
			// Methods
			internal void _ShowPlusResetCompletePopup_b__0();
		}
	
		// Constructors
		public GrowthBaseSelectScene();
		static GrowthBaseSelectScene();
	
		// Methods
		private void Awake();
		private void Start();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		private void OnEnterScene();
		[IteratorStateMachine]
		private IEnumerator ShowPointerDelay();
		public override void OnPresentReceived();
		private void OnDestroy();
		private void SetupTutorial();
		private void SetupTutorialGrowAmuletUI();
		public void BackButtonPressed();
		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void LoadBaseListData();
		[IteratorStateMachine]
		private IEnumerator CreateListBaseCells();
		private void SetEmptyListCount();
		public void OnSortButtonClicked();
		private ulong[] CreateDataIdList(out GiftType giftType);
		private ulong[] GetLimitBreakKeyIds(List<GrowthBaseCommonData> dataList);
		private void TabSelected(int index);
		private void SendCharadAwakingData();
		private void SendDataOnSuccess(CharaAwakeResponse res);
		private void ShowAwakeEffect();
		[IteratorStateMachine]
		private IEnumerator AwakeAnimationDelay(FlMotion awakeAnimeMotion);
		private void ShowAwakeReslt();
		private void SetupAwakeEffect();
		private void CloseAwakeEffect();
		private void PlayNextEffect(bool isBackKey = false);
		private CommonListCustomSortData CharaAwakeSort(CommonListCustomSortData data);
		private CommonListCustomSortData EquipUnitLimitBreakSort(CommonListCustomSortData data);
		private CommonListCustomSortData UnitGrowthLimitSort(CommonListCustomSortData data);
		public static bool CheckGrowthLimit(CommonIconListType type, ulong keyId);
		private CommonListCustomSortData ResetHpPlusSort(CommonListCustomSortData data);
		private CommonListCustomSortData ResetAtkPlusSort(CommonListCustomSortData data);
		public static CommonListCustomSortData ManacircleSort(CommonListCustomSortData data);
		public static bool CheckGrowManacircle(ulong keyId);
		public void OnListChangeButtonPressed();
		public void OnResetPlusButtonPressed();
		private async void SendResetPlusData(ulong targetKeyId);
		private void ShowPlusResetCompletePopup();
		[CompilerGenerated]
		private CommonListCustomSortData _LoadBaseListData_b__47_0(CommonListCustomSortData data);
		[CompilerGenerated]
		private CommonListCustomSortData _LoadBaseListData_b__47_1(CommonListCustomSortData data);
		[CompilerGenerated]
		private void _TabSelected_b__53_0();
		[CompilerGenerated]
		private void _SetupAwakeEffect_b__59_0();
		[CompilerGenerated]
		private void _SetupAwakeEffect_b__59_1();
		[CompilerGenerated]
		private void _PlayNextEffect_b__61_0();
		[CompilerGenerated]
		private void _PlayNextEffect_b__61_1();
	}
}
