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
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthMaterialSelectScene : SceneBase
	{
		// Fields
		public Canvas mainCanvas;
		public static ulong growBaseKeyId;
		public static bool isShowCaption;
		public Camera uiCamera;
		public Camera flashCamera;
		public GameObject effectBase;
		public Canvas bgCanvas;
		public Button effectSkipButton;
		private GrowthBaseType growthBaseType;
		private GrowthBaseInfoFrame growthBaseInfoFrame;
		private GrowResultBaseData oldGrowBaseData;
		private GrowMaterialListBase growMaterialListBase;
		private Dictionary<int, int> useItemInfoDict;
		private List<ulong> selectMaterialList;
		private bool isAllListIconLock;
		private GameObject levelUpObj;
		private GameObject hpPlusUpObj;
		private GameObject atkPlusUpObj;
		private bool isShowHpPlusEffect;
		private bool isShowAtkPlusEffect;
		private FlRoot levelUpFlRoot;
		private FlRoot hpPlusUpFlRoot;
		private FlRoot atkPlusUpFlRoot;
		private FlRoot manaUnleashFlRoot;
		private BaseCanvasContents baseCanvasContents;
		private BackButton backButton;
		private AudioPlayback seSoundPlayBack;
		private bool isSkipLevelup;
		private Coroutine growAnimationCoroutine;
		private Coroutine restartGrowAnimationCoroutine;
		private EffectObject growthEffect;
		private UseMaterialType receiveReloadType;
		private Coroutine closeEffectCoroutine;
		private GrowthManaCircleManaCircleData circleData;
		private GameObject manaUnleashObj;
		private GrowthAwakeResultPop.BeforeData beforeUsePlatinumCrystalData;
		private int storyIndex;
		private string voiceSoundGroup;
		public const string prefabPath = "Prefabs/OutGame/Growth/GrowthMaterialSelect/";
		private const int maxGrowMaterialCount = 20;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__43_0;
			public static UnityAction __9__52_0;
			public static Func<GrowthManaCircleManaPieceData, bool> __9__62_0;
			public static Func<GrowthManaCircleManaPieceData, int> __9__62_1;
			public static Func<GrowthManaCircleManaPieceData, int> __9__62_2;
			public static Action __9__62_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _SwitchToScreenSpaceCamera_b__43_0();
			internal void _GrowButtonPressed_b__52_0();
			internal bool _ShowStoryPopupIfNeeded_b__62_0(GrowthManaCircleManaPieceData p);
			internal int _ShowStoryPopupIfNeeded_b__62_1(GrowthManaCircleManaPieceData p);
			internal int _ShowStoryPopupIfNeeded_b__62_2(GrowthManaCircleManaPieceData p);
			internal void _ShowStoryPopupIfNeeded_b__62_3();
		}
	
		[CompilerGenerated]
		private sealed class _SwitchToScreenSpaceCamera_d__43 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthMaterialSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SwitchToScreenSpaceCamera_d__43(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadMaterialListDataCoroutine_d__45 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthMaterialSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadMaterialListDataCoroutine_d__45(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ShowPointerDelay_d__47 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowPointerDelay_d__47(int __1__state);
	
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
			public GrowthConfirmDialog confirmDialog;
			public GrowthMaterialSelectScene __4__this;
	
			// Constructors
			public __c__DisplayClass52_0();
	
			// Methods
			internal void _GrowButtonPressed_b__1();
			internal void _GrowButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0
		{
			// Fields
			public GrowthMaterialSelectScene __4__this;
			public CharaDataElement masterCharaData;
	
			// Constructors
			public __c__DisplayClass55_0();
	
			// Methods
			internal void _ManaButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0
		{
			// Fields
			public bool isMaxLevel;
			public GrowthMaterialSelectScene __4__this;
	
			// Constructors
			public __c__DisplayClass59_0();
	
			// Methods
			internal void _ShowUsePlatinumEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0
		{
			// Fields
			public GrowthAwakeResultPop resultPop;
			public GrowthMaterialSelectScene __4__this;
	
			// Constructors
			public __c__DisplayClass61_0();
	
			// Methods
			internal void _FinishUsePlatinumEffectCoroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_1
		{
			// Fields
			public CharaDataElement masterCharaData;
			public __c__DisplayClass61_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass61_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_2
		{
			// Fields
			public GrowthManaCircleAllReleaseRewardPopup popup;
			public __c__DisplayClass61_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass61_2();
	
			// Methods
			internal void _FinishUsePlatinumEffectCoroutine_b__1();
			internal void _FinishUsePlatinumEffectCoroutine_b__2();
			internal void _FinishUsePlatinumEffectCoroutine_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _FinishUsePlatinumEffectCoroutine_d__61 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthMaterialSelectScene __4__this;
			private __c__DisplayClass61_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _FinishUsePlatinumEffectCoroutine_d__61(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0
		{
			// Fields
			public bool isPopupShowing;
	
			// Constructors
			public __c__DisplayClass62_0();
	
			// Methods
			internal void _ShowStoryPopupIfNeeded_b__4();
			internal bool _ShowStoryPopupIfNeeded_b__5();
		}
	
		[CompilerGenerated]
		private sealed class _ShowStoryPopupIfNeeded_d__62 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UnityAction onCompleted;
			public GrowthMaterialSelectScene __4__this;
			private int _charaId_5__2;
			private int _storyPopupCount_5__3;
			private bool _isTemporary_5__4;
			private int _rarity_5__5;
			private int _i_5__6;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowStoryPopupIfNeeded_d__62(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass72_0
		{
			// Fields
			public GrowthMaterialSelectScene __4__this;
			public CommonIconListCellData data;
			public TableViewCell<CommonIconListCellData> cell;
	
			// Constructors
			public __c__DisplayClass72_0();
	
			// Methods
			internal void _UnitMaterialIconLongPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_0
		{
			// Fields
			public CommonIconListCellData data;
			public GrowthMaterialSelectScene __4__this;
	
			// Constructors
			public __c__DisplayClass73_0();
	
			// Methods
			internal void _UpdateEquipIconLock_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass96_0
		{
			// Fields
			public GrowthMaterialSelectScene __4__this;
			public UnityAction afterSkipAction;
	
			// Constructors
			public __c__DisplayClass96_0();
	
			// Methods
			internal void _SetupEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _SetupEffect_d__96 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthMaterialSelectScene __4__this;
			public UnityAction afterSkipAction;
			public UnityAction<bool, bool> growAnimationEndCallBack;
			private RectTransform _rectTransform_5__2;
			private Vector3 _canvasPos_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupEffect_d__96(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CloseEffectPopCoroutine_d__98 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthMaterialSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CloseEffectPopCoroutine_d__98(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass99_0
		{
			// Fields
			public bool isMaxLevel;
			public GrowthMaterialSelectScene __4__this;
	
			// Constructors
			public __c__DisplayClass99_0();
	
			// Methods
			internal void _ShowLevelupEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass101_0
		{
			// Fields
			public Action playEndCallBack;
	
			// Constructors
			public __c__DisplayClass101_0();
	
			// Methods
			internal void _PlayLevelUpFlash_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass102_0
		{
			// Fields
			public Action playEndCallBack;
	
			// Constructors
			public __c__DisplayClass102_0();
	
			// Methods
			internal void _PlayHpPlusUpFlash_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass103_0
		{
			// Fields
			public Action playEndCallBack;
	
			// Constructors
			public __c__DisplayClass103_0();
	
			// Methods
			internal void _PlayAtkPlusUpFlash_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass104_0
		{
			// Fields
			public Action playEndCallBack;
	
			// Constructors
			public __c__DisplayClass104_0();
	
			// Methods
			internal void _PlayManaUnleashFlash_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _GrowAnimationCoroutine_d__106 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float time;
			public GrowthMaterialSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GrowAnimationCoroutine_d__106(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _RestartGrowAnimationCoroutine_d__107 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthMaterialSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _RestartGrowAnimationCoroutine_d__107(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass109_0
		{
			// Fields
			public GrowResultStatusDialog resultDialog;
			public GrowthMaterialSelectScene __4__this;
			public GrowResultBaseData updateBaseData;
			public UnityAction __9__3;
	
			// Constructors
			public __c__DisplayClass109_0();
	
			// Methods
			internal void _ShowResultDialog_b__0();
			internal void _ShowResultDialog_b__1();
			internal void _ShowResultDialog_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass109_1
		{
			// Fields
			public GrowResultDialogType resultType;
			public NeedLimitMaterialType needLimitMaterialType;
			public __c__DisplayClass109_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass109_1();
	
			// Methods
			internal void _ShowResultDialog_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _FinishGrowEffect_d__110 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthMaterialSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _FinishGrowEffect_d__110(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GrowthMaterialSelectScene();
		static GrowthMaterialSelectScene();
	
		// Methods
		private void Awake();
		private void Start();
		private void OnPrevSceneExitDone();
		[IteratorStateMachine]
		private IEnumerator SwitchToScreenSpaceCamera();
		private void OnInitReady();
		[IteratorStateMachine]
		private IEnumerator LoadMaterialListDataCoroutine();
		private void OnEnterScene();
		[IteratorStateMachine]
		private IEnumerator ShowPointerDelay();
		private void OnDestroy();
		public override void OnBeforeLeaving();
		public override void OnPresentReceived();
		public void BackButtonPressed();
		private void GrowButtonPressed();
		private int MatTargetListSort(ConfigDialogSortData currCell, ConfigDialogSortData nextCell);
		private void ConfigButtonPressed();
		private void ManaButtonPressed();
		private void LoadMaterialListData();
		private void PlatinumCrystalPressed();
		private void PlayUsePlatinumCrystalDirection();
		private void ShowUsePlatinumEffect(bool isLevelUp, bool isMaxLevel = false);
		public void FinishUsePlatinumEffect();
		[IteratorStateMachine]
		public IEnumerator FinishUsePlatinumEffectCoroutine();
		[IteratorStateMachine]
		private IEnumerator ShowStoryPopupIfNeeded(UnityAction onCompleted);
		private void UpdatePlatinumCrystalState();
		private void LoadItemListData();
		private void LoadUnitMaterialListData();
		public void OnSortButtonClicked();
		public void OnSortApplied();
		private ulong[] CreateDataIdList(out GiftType giftType);
		private void ListChangeCallBack();
		private void UpdateUseItem(int materialId, int count);
		private void UnitMaterialIconPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void UnitMaterialIconLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void UpdateEquipIconLock(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void UnSelectIcon(ulong targetKey);
		private void UpdateSelectIconNumber();
		private void UpdateTotalExp();
		private int GetMaterialExp(int materialLevel, int rarity);
		private void UpeteGetExpPlus(int allExp, int hpPlus, int atkPlus);
		private void AutoSelectButtonPressed();
		private void ItemsAutoSelect(ItemMaterialCellData[] itemDatas, int expMargin);
		private void CountUpUseItem(int materialId, int addCount);
		private void UnitMaterialAutoSelect(GrowMaterialCellData[] materialDatas, int expMargin);
		public int CheckSelectIcon(ulong keyId);
		private void SendGrowData();
		private GrowMaterialList[] SetupSendMaterialData();
		private AtgenEnemyPiece[] SetupSendMaterialDataByChara();
		private void SendDataOnSuccess(CharaBuildupResponse res);
		private void SendDataOnSuccess(DragonBuildupResponse res);
		private void SendDataOnSuccess(WeaponBuildupResponse res);
		private void SendDataOnSuccess(AmuletBuildupResponse res);
		private void ShowGrowthEffect();
		private void SetupGrowthEffectBg(UnityAction backKeyAction);
		private void PlayCharaIconEffect();
		private void LoadStrengthenLevelupPrefab();
		private void LoadManaUnleashPrefab();
		[IteratorStateMachine]
		private IEnumerator SetupEffect(UnityAction<bool, bool> growAnimationEndCallBack, UnityAction afterSkipAction);
		private void CloseEffectPop();
		[IteratorStateMachine]
		private IEnumerator CloseEffectPopCoroutine();
		private void ShowLevelupEffect(bool isLevelUp, bool isMaxLevel = false);
		private void PlayPlusupEffect();
		private void PlayLevelUpFlash(Action playEndCallBack);
		private void PlayHpPlusUpFlash(Action playEndCallBack);
		private void PlayAtkPlusUpFlash(Action playEndCallBack);
		private void PlayManaUnleashFlash(Action playEndCallBack);
		public void StopGaugeUpSe();
		[IteratorStateMachine]
		private IEnumerator GrowAnimationCoroutine(float time);
		[IteratorStateMachine]
		private IEnumerator RestartGrowAnimationCoroutine();
		public void SkipGrowEffect();
		private void ShowResultDialog();
		[IteratorStateMachine]
		private IEnumerator FinishGrowEffect();
		private void GoOtherScene(GrowResultDialogType type, NeedLimitMaterialType needLimitMaterialType);
		private void SetupTutorial(GrowMaterialListBase listBase);
		public void SceneReload();
		[CompilerGenerated]
		private int _ConfigButtonPressed_b__54_0();
		[CompilerGenerated]
		private void _PlatinumCrystalPressed_b__57_0();
		[CompilerGenerated]
		private void _PlayUsePlatinumCrystalDirection_b__58_0();
		[CompilerGenerated]
		private void _ShowGrowthEffect_b__91_0();
		[CompilerGenerated]
		private void _PlayPlusupEffect_b__100_0();
		[CompilerGenerated]
		private void _PlayPlusupEffect_b__100_2();
		[CompilerGenerated]
		private void _PlayPlusupEffect_b__100_1();
	}
}
