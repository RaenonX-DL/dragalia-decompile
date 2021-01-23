/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		private Button clearPartyButton;
		[SerializeField]
		private Button normalPartyButton;
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
	
		// Properties
		public PartyCharacterPageCtrl pageCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsCompleteStartProcess { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__49 : IEnumerator<object>
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
			public _Start_d__49(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ActivateStatusDelay_d__51 : IEnumerator<object>
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
			public _ActivateStatusDelay_d__51(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_0
		{
			// Fields
			public ExAbilityDialog exAbilityDialog;
	
			// Constructors
			public __c__DisplayClass65_0();
	
			// Methods
			internal void _OnExAbilityButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass67_0
		{
			// Fields
			public AutoPartySelectDialog autoPartySelectDialog;
			public PartyCharacterUICanvas __4__this;
	
			// Constructors
			public __c__DisplayClass67_0();
	
			// Methods
			internal void _OnAutoButtonPressed_b__0();
			internal void _OnAutoButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _WaitLastAnimationInnerMoveEnd_d__73 : IEnumerator<object>
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
			public _WaitLastAnimationInnerMoveEnd_d__73(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0
		{
			// Fields
			public PartyChangePopup popup;
			public PartyCharacterUICanvas __4__this;
	
			// Constructors
			public __c__DisplayClass76_0();
	
			// Methods
			internal void _OnPartyChangeButtonPressed_b__0(int partyIndex, bool isOtherGroupLoad);
			internal void _OnPartyChangeButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_1
		{
			// Fields
			public int partyIndex;
			public __c__DisplayClass76_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass76_1();
	
			// Methods
			internal void _OnPartyChangeButtonPressed_b__2();
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
		public void OnPartyNameEditButtonPressed();
		protected override void SetStatusMode(bool isShowCrestStatus);
		[CompilerGenerated]
		private void _Start_b__49_0();
		[CompilerGenerated]
		private bool _WaitLastAnimationInnerMoveEnd_b__73_0();
		[CompilerGenerated]
		private void _OnPartyNameEditButtonPressed_b__77_0(string newName);
	}
}
