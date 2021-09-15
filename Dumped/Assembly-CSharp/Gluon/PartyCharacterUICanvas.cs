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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyCharacterUICanvas : PartyUICanvasBase
	{
		// Fields
		[SerializeField]
		public PartyCharacterScene scene;
		public CommonIconListBase iconListFrame;
		public GameObject statusBase;
		public PartyCharacterUIStatus[] partyStatus;
		public Image leadImage;
		public GameObject partyInfoAnimeBase;
		public Image[] selectedImages;
		public PartyPageViewBase pageView;
		[CompilerGenerated]
		private PartyCharacterPageCtrl _pageCtrl_k__BackingField;
		public float runAnimationDistance;
		public UnityEngine.UI.Text clearPartyText;
		public UnityEngine.UI.Text autoEquipButtonText;
		public Sprite addPartySprite;
		public Sprite selectPartySprite;
		public RectTransform edgeToEdgeFrame;
		public UnityEngine.UI.Text partyNameText;
		[SerializeField]
		private GameObject powerBack;
		[SerializeField]
		private GameObject raidPowerBack;
		public CanvasGroup canvasGroup;
		public UnityAction<int> characterPressCallBack;
		public UnityAction<int> characterLongPressCallBack;
		[SerializeField]
		private GameObject clearPartyButtonObj;
		[SerializeField]
		private GameObject normalPartyButtonObj;
		[SerializeField]
		private GameObject[] oneUnitNonActiveObjects;
		[Header]
		[SerializeField]
		public RectTransform topPartyBaseMoveTo;
		public RectTransform topLearderImageMoveTo;
		public RectTransform topStatusMoveTo;
		public RectTransform topSwitchButtonMoveTo;
		[Header]
		[SerializeField]
		public RectTransform questPartyBaseMoveTo;
		public RectTransform questLearderImageMoveTo;
		public RectTransform questStatusMoveTo;
		public RectTransform questSwitchButtonMoveTo;
		[Header]
		[SerializeField]
		public UIAnimationPublisher fromTopPublisher1;
		public UIAnimationPublisher fromEquipPublisher;
		public UIAnimationPublisher toEquipPublisher;
		[Header]
		[SerializeField]
		public PointerEventHandler[] characterTransparentButtonsEventHandler;
		public GameObject partyNameBaseObject;
		public GameObject partyChangeButtonObject;
		private PartyCharacterListController partyListController;
		private SceneUICanvas sceneUiCanvas;
		private int questId;
		private bool isEnableRaidBoost;
		[SerializeField]
		private GameObject dragonOnlyIcon;
		private bool isCompleteStartProcess;
		private bool isShowEquipOverPopup;
		private bool isBreakApplyEquipSetLoop;
	
		// Properties
		public PartyCharacterPageCtrl pageCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsCompleteStartProcess { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__51 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyCharacterUICanvas __4__this;
			private GameObject _prefab_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__51(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ActivateStatusDelay_d__53 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyCharacterUICanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ActivateStatusDelay_d__53(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass67_0
		{
			// Fields
			public ExAbilityDialog exAbilityDialog;
	
			// Constructors
			public __c__DisplayClass67_0();
	
			// Methods
			internal void _OnExAbilityButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass69_0
		{
			// Fields
			public AutoPartySelectDialog autoPartySelectDialog;
			public PartyCharacterUICanvas __4__this;
	
			// Constructors
			public __c__DisplayClass69_0();
	
			// Methods
			internal void _OnAutoButtonPressed_b__0();
			internal void _OnAutoButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _WaitLastAnimationInnerMoveEnd_d__75 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyCharacterUICanvas __4__this;
			public Action onFinished;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitLastAnimationInnerMoveEnd_d__75(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_0
		{
			// Fields
			public PartyChangePopup popup;
			public PartyCharacterUICanvas __4__this;
	
			// Constructors
			public __c__DisplayClass78_0();
	
			// Methods
			internal void _OnPartyChangeButtonPressed_b__0(int partyIndex, bool isOtherGroupLoad);
			internal void _OnPartyChangeButtonPressed_b__1(int partyIndex, bool isOtherGroupLoad);
			internal void _OnPartyChangeButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_1
		{
			// Fields
			public int partyIndex;
			public __c__DisplayClass78_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass78_1();
	
			// Methods
			internal void _OnPartyChangeButtonPressed_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_0
		{
			// Fields
			public PartyEquipSetPopup popup;
	
			// Constructors
			public __c__DisplayClass82_0();
	
			// Methods
			internal void _OnPartyEquipSetButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_1
		{
			// Fields
			public int charaId;
	
			// Constructors
			public __c__DisplayClass82_1();
	
			// Methods
			internal bool _OnPartyEquipSetButtonPressed_b__1(PartySettingList e);
		}
	
		[CompilerGenerated]
		private struct _OnPartyEquipSetButtonPressed_d__82 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public PartyCharacterUICanvas __4__this;
			private __c__DisplayClass82_0 __8__1;
			private TaskAwaiter<CharaGetCharaUnitSetResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ApplyEquipSetData_d__83 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public PartyCharacterUICanvas __4__this;
			public int charaIndex;
			public int setIndex;
			private PartyList _partyInfo_5__2;
			private int _weaponId_5__3;
			private ulong _dragonKeyId_5__4;
			private int[] _crestIds_5__5;
			private int _i_5__6;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass84_0
		{
			// Fields
			public PartyEquipOverPopup popup;
			public PartyCharacterUICanvas __4__this;
	
			// Constructors
			public __c__DisplayClass84_0();
	
			// Methods
			internal void _ApplyEquipSetWeaponData_b__0();
			internal void _ApplyEquipSetWeaponData_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass84_1
		{
			// Fields
			public int charaId;
	
			// Constructors
			public __c__DisplayClass84_1();
	
			// Methods
			internal bool _ApplyEquipSetWeaponData_b__3(PartySettingList e);
		}
	
		[CompilerGenerated]
		private struct _ApplyEquipSetWeaponData_d__84 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int charaIndex;
			public int weaponId;
			public PartyCharacterUICanvas __4__this;
			private PartySettingList _targetCharaData_5__2;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass85_0
		{
			// Fields
			public PartyCharacterUICanvas __4__this;
			public int equipCharaId;
			public Func<PartySettingList, bool> __9__3;
	
			// Constructors
			public __c__DisplayClass85_0();
	
			// Methods
			internal bool _ApplyEquipSetDragonData_b__3(PartySettingList e);
			internal bool _ApplyEquipSetDragonData_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass85_1
		{
			// Fields
			public AlreadyEquipedDialog popup;
			public __c__DisplayClass85_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass85_1();
	
			// Methods
			internal void _ApplyEquipSetDragonData_b__0();
			internal void _ApplyEquipSetDragonData_b__1();
		}
	
		[CompilerGenerated]
		private struct _ApplyEquipSetDragonData_d__85 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public PartyCharacterUICanvas __4__this;
			public int charaIndex;
			public ulong dragonKeyId;
			private PartySettingList _targetCharaData_5__2;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass86_0
		{
			// Fields
			public PartyCharacterUICanvas __4__this;
			public PartySettingList targetCharaData;
			public Func<bool> __9__2;
	
			// Constructors
			public __c__DisplayClass86_0();
	
			// Methods
			internal bool _ApplyEquipSetCrestData_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass86_1
		{
			// Fields
			public int crestId;
			public __c__DisplayClass86_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass86_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass86_2
		{
			// Fields
			public PartyEquipOverPopup popup;
			public __c__DisplayClass86_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass86_2();
	
			// Methods
			internal void _ApplyEquipSetCrestData_b__0();
			internal void _ApplyEquipSetCrestData_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass86_3
		{
			// Fields
			public int charaId;
	
			// Constructors
			public __c__DisplayClass86_3();
	
			// Methods
			internal bool _ApplyEquipSetCrestData_b__3(PartySettingList e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass86_4
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass86_4();
	
			// Methods
			internal void _ApplyEquipSetCrestData_b__4();
		}
	
		[CompilerGenerated]
		private struct _ApplyEquipSetCrestData_d__86 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public PartyCharacterUICanvas __4__this;
			public int charaIndex;
			private __c__DisplayClass86_0 __8__1;
			public int[] crestIds;
			private __c__DisplayClass86_1 __8__2;
			private PartyList _partyInfo_5__2;
			private bool _isShowDuplicateErrorPop_5__3;
			private WeaponBodyList _userWeaponBodyData_5__4;
			private List<int> _charaIdList_5__5;
			private int _j_5__6;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass87_0
		{
			// Fields
			public EventBonusPopup popup;
	
			// Constructors
			public __c__DisplayClass87_0();
	
			// Methods
			internal void _OnEventBonusIconPressed_b__0();
		}
	
		// Constructors
		public PartyCharacterUICanvas();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		private void UpdateClearPartyButton();
		[IteratorStateMachine]
		private IEnumerator ActivateStatusDelay();
		public void ConfirmChangePageCallBack();
		public void ConfirmMovePagerPage(int index);
		private void SetPageContent(GameObject page, int index);
		public void CharacterPressed(int tag);
		public void CharacterLongPressed(int tag);
		public void ShowClearParty();
		public void ShowNormalParty();
		public void Reload();
		public void OnEquipChangeButtonPressed();
		public void OnBackButtonPressed();
		private void SetUseClearParty();
		public void OnClearPartyButtonTouched();
		public void OnNormalPartyButtonTouched();
		public void OnExAbilityButtonPressed();
		public void LoadPowerParam();
		public void OnAutoButtonPressed();
		public void HideCharacterStateUI();
		public void AdjustInnerAnimationOffset();
		public void StartGoTopSceneAnimation(Action onFinished, Action onHalfFinished = null);
		public void StartGoEquipSceneAnimation(Action onFinished, Action onHalfFinished = null);
		public void StartExitAnimation();
		[IteratorStateMachine]
		private IEnumerator WaitLastAnimationInnerMoveEnd(Action onFinished);
		private void SetVisibleCanvas(bool enable);
		private void OneUnitQuestSetting(bool isOneUnit);
		public void OnPartyChangeButtonPressed();
		private void ReloadPartyView();
		public void OnPartyNameEditButtonPressed();
		protected override void SetStatusMode(PartyModel.PartySceneUnitStatusMode statusMode);
		public async void OnPartyEquipSetButtonPressed();
		private async void ApplyEquipSetData(int charaIndex, int setIndex);
		private async void ApplyEquipSetWeaponData(int charaIndex, int weaponId);
		private async void ApplyEquipSetDragonData(int charaIndex, ulong dragonKeyId);
		private async void ApplyEquipSetCrestData(int charaIndex, int[] crestIds);
		public override void OnEventBonusIconPressed();
		protected override bool IsRaidBoostOn(int questId);
		[CompilerGenerated]
		private void _Start_b__51_0();
		[CompilerGenerated]
		private bool _WaitLastAnimationInnerMoveEnd_b__75_0();
		[CompilerGenerated]
		private void _OnPartyNameEditButtonPressed_b__80_0(string newName);
		[CompilerGenerated]
		private bool _ApplyEquipSetData_b__83_0();
		[CompilerGenerated]
		private bool _ApplyEquipSetWeaponData_b__84_2();
	}
}
