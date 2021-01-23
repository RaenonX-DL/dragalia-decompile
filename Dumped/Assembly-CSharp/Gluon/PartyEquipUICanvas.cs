/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UniRx.Async;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyEquipUICanvas : AnimationUICanvas
	{
		// Fields
		[HideInInspector]
		public PartyEquipScene scene;
		public CommonIconListBase equipUnitListBase;
		public EquipUnitListController equipUnitListController;
		public UnityEngine.UI.Text characterNameText;
		public UnityEngine.UI.Text plusValueText;
		public Image charaElementIcon;
		public Image charaWeaponTypeIcon;
		public GameObject[] rarityIcons;
		public UnityEngine.UI.Text charaLvText;
		public UnityEngine.UI.Text totalPowerText;
		public UnityEngine.UI.Text totalPowerDeltaText;
		public UnityEngine.UI.Text charaCostText;
		public DragEventScrollRect dragScroll;
		public UnityEngine.UI.Text autoEquipButtonText;
		public bool isDragEventActive;
		public UIAnimationPublisher enterExitPublisher;
		public CanvasGroup attributeMatchParentGroup;
		[SerializeField]
		private GameObject charaChangeArrowParent;
		[SerializeField]
		private TabBase typeTab;
		[SerializeField]
		private GameObject listButtonObj;
		[SerializeField]
		private GameObject skinButtonObj;
		[SerializeField]
		private PartyEquipCrestList crestList;
		[SerializeField]
		private GameObject unionBonusButton;
		[SerializeField]
		private GameObject crestSetButton;
		[SerializeField]
		private GameObject weaponAndDragonListGameObject;
		[SerializeField]
		private PartyEquipWeaponStatus weaponStatusUI;
		[SerializeField]
		private PartyEquipDragonStatus dragonStatusUI;
		[SerializeField]
		private PartyEquipCrestStatus crestStatusUI;
		private bool partyChangeFlg;
		private bool isLeftDrag;
		private int oldTotalPowerParam;
		private int nowTotalPowerParam;
		private SceneUICanvas sceneUiCanvas;
		private Color positiveFontColor;
		private Color negativeFontColor;
		private Color blackFontColor;
		private StepChangeParam totalPowerParam;
		private bool isFirstReload;
		private bool isPlayingEditSkillTutorial;
		private bool isUniqueWeaponChara;
		private float delayTime;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public PartyEquipUICanvas __4__this;
			public PartySceneState prevState;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal void _Start_b__0();
			internal void _Start_b__1();
			internal void _Start_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _SetStatusModeDelayed_d__42 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delayTime;
			public PartyEquipUICanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetStatusModeDelayed_d__42(int __1__state);
	
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
			public AnimationUIFade fade;
	
			// Constructors
			public __c__DisplayClass55_0();
	
			// Methods
			internal void _ShowDiffParam_b__0(bool isReverse);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0
		{
			// Fields
			public PartyEquipUICanvas __4__this;
			public ulong keyId;
	
			// Constructors
			public __c__DisplayClass63_0();
	
			// Methods
			internal void _ShowUnitDetail_b__0();
		}
	
		[CompilerGenerated]
		private struct _EquipListReload_d__65 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public PartyEquipUICanvas __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass68_0
		{
			// Fields
			public PartyEquipUICanvas __4__this;
			public AutoPartySelectDialog autoPartySelectDialog;
	
			// Constructors
			public __c__DisplayClass68_0();
	
			// Methods
			internal void _OnAutoButtonPressed_b__0();
			internal void _OnAutoButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0
		{
			// Fields
			public WeaponSkinSelectPopup popup;
			public PartyEquipUICanvas __4__this;
	
			// Constructors
			public __c__DisplayClass76_0();
	
			// Methods
			internal void _OnSkinButtonPressed_b__0();
			internal void _OnSkinButtonPressed_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__76_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnSkinButtonPressed_b__76_2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass80_0
		{
			// Fields
			public PartyCrestSetPopup popup;
	
			// Constructors
			public __c__DisplayClass80_0();
	
			// Methods
			internal void _OnCrestSetButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private struct _OnCrestSetButtonPressed_d__80 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			private __c__DisplayClass80_0 __8__1;
			public PartyEquipUICanvas __4__this;
			private TaskAwaiter<AbilityCrestGetAbilityCrestSetListResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass81_0
		{
			// Fields
			public int crestId;
	
			// Constructors
			public __c__DisplayClass81_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass81_1
		{
			// Fields
			public PartyEquipOverPopup popup;
			public bool isShowEquipOverPopup;
			public bool isBreakApplyLoop;
			public __c__DisplayClass81_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass81_1();
	
			// Methods
			internal void _ApplyCrestSetData_b__0();
			internal void _ApplyCrestSetData_b__1();
			internal bool _ApplyCrestSetData_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass81_2
		{
			// Fields
			public int charaId;
	
			// Constructors
			public __c__DisplayClass81_2();
	
			// Methods
			internal bool _ApplyCrestSetData_b__3(PartySettingList e);
		}
	
		[CompilerGenerated]
		private struct _ApplyCrestSetData_d__81 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int setIndex;
			private __c__DisplayClass81_1 __8__1;
			private __c__DisplayClass81_0 __8__2;
			public PartyEquipUICanvas __4__this;
			private PartyList _partyInfo_5__2;
			private PartySettingList _targetCharaData_5__3;
			private WeaponBodyList _userWeaponBodyData_5__4;
			private List<int> _charaIdList_5__5;
			private AbilityCrestSetList _userSetData_5__6;
			private int _j_5__7;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public PartyEquipUICanvas();
	
		// Methods
		private void Start();
		[IteratorStateMachine]
		private IEnumerator SetStatusModeDelayed(float delayTime);
		public void OnUnionBonusButtonPressed();
		private void InitActiveTab(int activeIndex);
		public void UpdateWeaponStatus();
		public void UpdateDragonStatus();
		public void UpdateCrestStatus();
		private void Update();
		protected override void OnDestroy();
		private void SetStaticText();
		private void OmitTextAfterBestFit(UnityEngine.UI.Text text);
		public void Reload();
		public static bool IsEnablePeriodAbility(int abilityId);
		public void SetEquipUnitDiffParam();
		private void ShowDiffParam(UnityEngine.UI.Text text, int diffValue);
		private void SetCountUpDownParam();
		private void OnSelectedTypeTab(int typeIndex);
		private void SetTabMode(PartyModel.EquipMode nextMode);
		public void SetEquipListOutButton(PartyModel.EquipMode equipMode);
		public void OnWeaponBarPressed();
		public void OnAmulet2BarPressed();
		public void OnDragonBarPressed();
		private void ShowUnitDetail(UnitDetailModel.UnitDetailType type, ulong keyId);
		public void OnArrowButtonPressed(bool isRightButton);
		private async void EquipListReload();
		public void ReloadCrestList();
		public void OnBackButtonPressed();
		public void OnAutoButtonPressed();
		public void OnCharacterLongPressed();
		private void ShowSkillDetailDialog(PartyEquipSkillAbilityData data);
		private void ShowAbilityDetailDialog(PartyEquipSkillAbilityData data);
		private void ShowExAbilityDetailDialog(PartyEquipSkillAbilityData data, int index);
		public void StartExitAnimation(Action onFinished, Action onHalfFinished);
		private bool IsEnableCharacterChange();
		public void OnListChangeButtonPressed();
		public void OnSkinButtonPressed();
		public void DisableAllButton();
		public void OnDetailButtonPressed();
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public async void OnCrestSetButtonPressed();
		private async void ApplyCrestSetData(int setIndex);
		[CompilerGenerated]
		private void _EquipListReload_b__65_0();
		[CompilerGenerated]
		private void _OnCharacterLongPressed_b__69_0();
		[CompilerGenerated]
		private void _ShowSkillDetailDialog_b__70_0();
		[CompilerGenerated]
		private void _ShowAbilityDetailDialog_b__71_0();
	}
}
