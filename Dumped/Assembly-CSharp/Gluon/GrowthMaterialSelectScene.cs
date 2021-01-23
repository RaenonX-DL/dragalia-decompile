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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		private BaseCanvasContents baseCanvasContents;
		private BackButton backButton;
		private AudioPlayback seSoundPlayBack;
		private bool isSkipLevelup;
		private Coroutine growAnimationCoroutine;
		private Coroutine restartGrowAnimationCoroutine;
		private EffectObject growthEffect;
		private UseMaterialType receiveReloadType;
		private Coroutine closeEffectCoroutine;
		public const string prefabPath = "Prefabs/OutGame/Growth/GrowthMaterialSelect/";
		private const int maxGrowMaterialCount = 20;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__37_0;
			public static UnityAction __9__45_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _SwitchToScreenSpaceCamera_b__37_0();
			internal void _GrowButtonPressed_b__45_0();
		}
	
		[CompilerGenerated]
		private sealed class _SwitchToScreenSpaceCamera_d__37 : IEnumerator<object>
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
			public _SwitchToScreenSpaceCamera_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadMaterialListDataCoroutine_d__39 : IEnumerator<object>
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
			public _LoadMaterialListDataCoroutine_d__39(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ShowPointerDelay_d__41 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowPointerDelay_d__41(int __1__state);
	
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
			public GrowthConfirmDialog confirmDialog;
			public GrowthMaterialSelectScene __4__this;
	
			// Constructors
			public __c__DisplayClass45_0();
	
			// Methods
			internal void _GrowButtonPressed_b__1();
			internal void _GrowButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0
		{
			// Fields
			public GrowthMaterialSelectScene __4__this;
			public CharaDataElement masterCharaData;
	
			// Constructors
			public __c__DisplayClass48_0();
	
			// Methods
			internal void _ManaButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0
		{
			// Fields
			public GrowthMaterialSelectScene __4__this;
			public CommonIconListCellData data;
			public TableViewCell<CommonIconListCellData> cell;
	
			// Constructors
			public __c__DisplayClass58_0();
	
			// Methods
			internal void _UnitMaterialIconLongPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0
		{
			// Fields
			public CommonIconListCellData data;
			public GrowthMaterialSelectScene __4__this;
	
			// Constructors
			public __c__DisplayClass59_0();
	
			// Methods
			internal void _UpdateEquipIconLock_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _SetupEffect_d__78 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthMaterialSelectScene __4__this;
			private RectTransform _rectTransform_5__2;
			private Vector3 _canvasPos_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupEffect_d__78(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CloseEffectPopCoroutine_d__80 : IEnumerator<object>
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
			public _CloseEffectPopCoroutine_d__80(int __1__state);
	
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
			public bool isMaxLevel;
			public GrowthMaterialSelectScene __4__this;
	
			// Constructors
			public __c__DisplayClass81_0();
	
			// Methods
			internal void _ShowLevelupEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_0
		{
			// Fields
			public Action playEndCallBack;
	
			// Constructors
			public __c__DisplayClass83_0();
	
			// Methods
			internal void _PlayLevelUpFlash_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass84_0
		{
			// Fields
			public Action playEndCallBack;
	
			// Constructors
			public __c__DisplayClass84_0();
	
			// Methods
			internal void _PlayHpPlusUpFlash_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass85_0
		{
			// Fields
			public Action playEndCallBack;
	
			// Constructors
			public __c__DisplayClass85_0();
	
			// Methods
			internal void _PlayAtkPlusUpFlash_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _GrowAnimationCoroutine_d__87 : IEnumerator<object>
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
			public _GrowAnimationCoroutine_d__87(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _RestartGrowAnimationCoroutine_d__88 : IEnumerator<object>
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
			public _RestartGrowAnimationCoroutine_d__88(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass90_0
		{
			// Fields
			public GrowResultStatusDialog resultDialog;
			public GrowthMaterialSelectScene __4__this;
			public GrowResultBaseData updateBaseData;
			public UnityAction __9__3;
	
			// Constructors
			public __c__DisplayClass90_0();
	
			// Methods
			internal void _ShowResultDialog_b__0();
			internal void _ShowResultDialog_b__1();
			internal void _ShowResultDialog_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass90_1
		{
			// Fields
			public GrowResultDialogType resultType;
			public __c__DisplayClass90_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass90_1();
	
			// Methods
			internal void _ShowResultDialog_b__2();
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
		public override void OnPresentReceived();
		public void BackButtonPressed();
		private void GrowButtonPressed();
		private int MatTargetListSort(ConfigDialogSortData currCell, ConfigDialogSortData nextCell);
		private void ConfigButtonPressed();
		private void ManaButtonPressed();
		private void LoadMaterialListData();
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
		[IteratorStateMachine]
		private IEnumerator SetupEffect();
		private void CloseEffectPop();
		[IteratorStateMachine]
		private IEnumerator CloseEffectPopCoroutine();
		private void ShowLevelupEffect(bool isLevelUp, bool isMaxLevel = false);
		private void PlayPlusupEffect();
		private void PlayLevelUpFlash(Action playEndCallBack);
		private void PlayHpPlusUpFlash(Action playEndCallBack);
		private void PlayAtkPlusUpFlash(Action playEndCallBack);
		public void StopGaugeUpSe();
		[IteratorStateMachine]
		private IEnumerator GrowAnimationCoroutine(float time);
		[IteratorStateMachine]
		private IEnumerator RestartGrowAnimationCoroutine();
		public void SkipGrowEffect();
		private void ShowResultDialog();
		private void GoOtherScene(GrowResultDialogType type);
		private void SetupTutorial(GrowMaterialListBase listBase);
		public void SceneReload();
		[CompilerGenerated]
		private int _ConfigButtonPressed_b__47_0();
		[CompilerGenerated]
		private void _ShowGrowthEffect_b__77_0();
		[CompilerGenerated]
		private void _SetupEffect_b__78_0();
		[CompilerGenerated]
		private void _PlayPlusupEffect_b__82_0();
		[CompilerGenerated]
		private void _PlayPlusupEffect_b__82_2();
		[CompilerGenerated]
		private void _PlayPlusupEffect_b__82_1();
	}
}
