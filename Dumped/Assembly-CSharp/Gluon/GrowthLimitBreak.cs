/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthLimitBreak : SceneBase
	{
		// Fields
		public static ulong growBaseKeyId;
		public static bool isShowCaption;
		public Canvas mainCanvas;
		public Camera uiCamera;
		public Camera flashCamera;
		public GameObject effectBase;
		public Canvas bgCanvas;
		public Camera frontEffectCamera;
		public Camera backEffectCamera;
		private GrowthBaseType growthBaseType;
		private GrowthBaseInfoFrame growthBaseInfoFrame;
		private GrowResultBaseData oldGrowBaseData;
		private LimitBreakMaterialListBase materialListBase;
		private LimitBreakMaterialListController materialListController;
		private Dictionary<ulong, int> selectMaterialKeyList;
		private List<ulong> selectNumberKeyList;
		private GameObject limitBreakObj;
		private BaseCanvasContents baseCanvasContents;
		private BackButton backButton;
		private bool isVoiceLoadComplete;
		private string nowVoiceSheetName;
		private int limitbreakMargin;
		private int growStarIndex;
		private bool isStarAnimationEnd;
		private Coroutine setupEffectPopCoroutine;
		private Coroutine growAnimationDelayCoroutine;
		private Coroutine startStarGrowAnimationCoroutine;
		private Coroutine goResultCoroutine;
		private Coroutine waitLoadVoiceGroupCoroutine;
		private GameObject amuletAnimation;
		private GameObject amuletHeaderAnimation;
		private EffectObject frontEffectObject;
		private EffectObject backEffectObject;
		private EffectObject firstEffectObject;
		private bool isSkipButtonLocked;
		private SkipEffectStatus nowEffectStatus;
		private int effectSkipSortOderKey;
		private AudioPlayback amuletSePlayback;
		public const int materialTypeDragon = 7;
		public const int materialTypeWeapon = 3;
		public const int materialTypeAmulet = 12;
		public const int materialTypeItem = 8;
		public const int amuletEffectTriger = 10;
		private const string prefabPath = "Prefabs/OutGame/Growth/GrowthLimitBreak/";
	
		// Nested types
		public enum SkipEffectStatus
		{
			None = 0,
			LimitBreakText = 1,
			BeforeAmulet = 2,
			AfterAmulet = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__48_0;
			public static UnityAction __9__55_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _SwitchToScreenSpaceCamera_b__48_0();
			internal void _LimitBreakButtonPressed_b__55_0();
		}
	
		[CompilerGenerated]
		private sealed class _SwitchToScreenSpaceCamera_d__48 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthLimitBreak __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SwitchToScreenSpaceCamera_d__48(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ShowPointerDelay_d__53 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowPointerDelay_d__53(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0
		{
			// Fields
			public GrowthLimitBreak __4__this;
			public LimitConfirmDialog confirmDialog;
	
			// Constructors
			public __c__DisplayClass55_0();
	
			// Methods
			internal void _LimitBreakButtonPressed_b__1();
			internal void _LimitBreakButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0
		{
			// Fields
			public GrowthLimitBreak __4__this;
			public CommonIconListCellData data;
			public LimitBreakMaterialCellData equipData;
			public TableViewCell<CommonIconListCellData> cell;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _IconButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass56_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass56_1();
	
			// Methods
			internal void _IconButtonPressed_b__0();
			internal void _IconButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass58_0();
	
			// Methods
			internal void _ShowMissingItemPopup_b__0();
		}
	
		[CompilerGenerated]
		private struct _SendUnLockUintData_d__59 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthLimitBreak __4__this;
			public ulong keyId;
			public Action callBack;
			private TaskAwaiter<DragonSetLockResponse> __u__1;
			private TaskAwaiter<WeaponSetLockResponse> __u__2;
			private TaskAwaiter<AmuletSetLockResponse> __u__3;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0
		{
			// Fields
			public GrowthLimitBreak __4__this;
			public CommonIconListCellData data;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass60_0();
	
			// Methods
			internal void _IconButtonLongPressed_b__0();
			internal void _IconButtonLongPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadMaterialDataListCoroutine_d__62 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthLimitBreak __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadMaterialDataListCoroutine_d__62(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass66_0
		{
			// Fields
			public ulong itemId;
	
			// Constructors
			public __c__DisplayClass66_0();
	
			// Methods
			internal bool _SetupSendMaterialData_b__0(GrowMaterialList data);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_0
		{
			// Fields
			public GrowthLimitBreak __4__this;
			public bool isEffectLoadEnd;
	
			// Constructors
			public __c__DisplayClass71_0();
	
			// Methods
			internal void _ShowLimitBreakEffect_b__0();
			internal void _ShowLimitBreakEffect_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _SetupEffectPop_d__72 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthLimitBreak __4__this;
			private RectTransform _rectTransform_5__2;
			private Vector3 _canvasPos_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupEffectPop_d__72(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_0
		{
			// Fields
			public Image blackImage;
			public GrowthLimitBreak __4__this;
			public UnityAction fadeEndCallBack;
	
			// Constructors
			public __c__DisplayClass73_0();
	
			// Methods
			internal void _CloseEffectPop_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _GrowAnimationDelay_d__74 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float time;
			public GrowthLimitBreak __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GrowAnimationDelay_d__74(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass75_0
		{
			// Fields
			public FlMotion limitBreakMotion;
			public GrowthLimitBreak __4__this;
			public Action playEndCallBack;
	
			// Constructors
			public __c__DisplayClass75_0();
	
			// Methods
			internal void _PlayLimitBreakFlash_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _GoResult_d__76 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthLimitBreak __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GoResult_d__76(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitLoadVoiceGroup_d__77 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthLimitBreak __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitLoadVoiceGroup_d__77(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartStarGrowAnimation_d__78 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthLimitBreak __4__this;
			private int _nowStar_5__2;
			private int _i_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartStarGrowAnimation_d__78(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass79_0
		{
			// Fields
			public TouchGuardObject touchGuard;
			public GrowthLimitBreak __4__this;
	
			// Constructors
			public __c__DisplayClass79_0();
	
			// Methods
			internal void _SkipGrowEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _PlayDragonVoiceCoroutine_d__80 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthLimitBreak __4__this;
			public TouchGuardObject touchGuard;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayDragonVoiceCoroutine_d__80(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass81_0
		{
			// Fields
			public GrowResultBaseData updateBaseData;
	
			// Constructors
			public __c__DisplayClass81_0();
	
			// Methods
			internal void _ShowResultDialog_b__0(GrowResultDialogType endType);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_0
		{
			// Fields
			public FlRoot headerFlRoot;
			public GrowthLimitBreak __4__this;
	
			// Constructors
			public __c__DisplayClass83_0();
	
			// Methods
			internal void _ShowAmuletChangeEffect_b__0();
			internal void _ShowAmuletChangeEffect_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _AmuletAnimationDelay_d__84 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthLimitBreak __4__this;
			public FlMotion awakeAnimeMotion;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AmuletAnimationDelay_d__84(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GrowthLimitBreak();
		static GrowthLimitBreak();
	
		// Methods
		private void Awake();
		private void Start();
		private void OnPrevSceneExitDone();
		[IteratorStateMachine]
		private IEnumerator SwitchToScreenSpaceCamera();
		private void OnInitReady();
		private void OnDestroy();
		public override void OnPresentReceived();
		private void OnEnterScene();
		[IteratorStateMachine]
		private IEnumerator ShowPointerDelay();
		public void BackButtonPressed();
		private void LimitBreakButtonPressed();
		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void IconPressAction(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void ShowMissingItemPopup(LimitBreakMaterialCellData itemData);
		private async void SendUnLockUintData(ulong keyId, Action callBack);
		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void LoadMaterialDataList();
		[IteratorStateMachine]
		private IEnumerator LoadMaterialDataListCoroutine();
		public void OnSortButtonClicked();
		private ulong[] CreateDataIdList(out GiftType giftType);
		private void SendLimitBreakData();
		private GrowMaterialList[] SetupSendMaterialData();
		private LimitBreakGrowList[] SetupSendDragonMaterialData();
		private void SendDataOnSuccess(DragonLimitBreakResponse res);
		private void SendDataOnSuccess(WeaponLimitBreakResponse res);
		private void SendDataOnSuccess(AmuletLimitBreakResponse res);
		private void ShowLimitBreakEffect();
		[IteratorStateMachine]
		private IEnumerator SetupEffectPop();
		private void CloseEffectPop(UnityAction fadeEndCallBack);
		[IteratorStateMachine]
		private IEnumerator GrowAnimationDelay(float time);
		private void PlayLimitBreakFlash(Action playEndCallBack);
		[IteratorStateMachine]
		private IEnumerator GoResult();
		[IteratorStateMachine]
		private IEnumerator WaitLoadVoiceGroup();
		[IteratorStateMachine]
		private IEnumerator StartStarGrowAnimation();
		public void SkipGrowEffect();
		[IteratorStateMachine]
		private IEnumerator PlayDragonVoiceCoroutine(TouchGuardObject touchGuard);
		private void ShowResultDialog();
		public void SceneReload();
		private void ShowAmuletChangeEffect();
		[IteratorStateMachine]
		private IEnumerator AmuletAnimationDelay(FlMotion awakeAnimeMotion);
		private void CloseAmuletEffect();
		private void DeleteAmuletEffectObj();
		private void OnSkipButtonPressed(bool isBackKey = false);
		public static bool IsLimitBreakDragonBySphereMaterial(ulong dragonKeyId);
		public static bool IsLimitBreakDragonBySphereMaterial(int dragonMasterId, int nextLimitBreakCount);
		[CompilerGenerated]
		private void _SetupEffectPop_b__72_0();
		[CompilerGenerated]
		private void _SetupEffectPop_b__72_1();
		[CompilerGenerated]
		private void _GrowAnimationDelay_b__74_0();
		[CompilerGenerated]
		private bool _GoResult_b__76_0();
		[CompilerGenerated]
		private bool _WaitLoadVoiceGroup_b__77_0();
		[CompilerGenerated]
		private bool _PlayDragonVoiceCoroutine_b__80_0();
		[CompilerGenerated]
		private void _DeleteAmuletEffectObj_b__86_0();
	}
}
