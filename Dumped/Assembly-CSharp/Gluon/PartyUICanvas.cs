/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyUICanvas : PartyUICanvasBase
	{
		// Fields
		public PartyScene scene;
		public RawImage render3dImage;
		public Button showListButton;
		public Button exAbilityButton;
		public Button organizeButton;
		public Button autoButton;
		public PageViewBase pageView;
		[CompilerGenerated]
		private PartyPageCtrl _pageCtrl_k__BackingField;
		public PartyUIStatus[] partyStatus;
		public Image leadImage;
		public GameObject statusBase;
		public GameObject partyInfoAnimeBase;
		public RectTransform scrollLockRect;
		public CanvasGroup canvasGroup;
		public UnityEngine.UI.Text partyNameText;
		[Header]
		[SerializeField]
		public RectTransform partyBaseMoveTo;
		public RectTransform learderImageMoveTo;
		public RectTransform statusMoveTo;
		public RectTransform switchButtonMoveTo;
		[Header]
		[SerializeField]
		public UIAnimationPublisher enterExitPublisherPublisher;
		public UIAnimationPublisher goCharacterPublisher1;
		public UIAnimationPublisher goCharacterPublisher2;
		public UIAnimationPublisher goEquipPublisher1;
		public UIAnimationPublisher goEquipPublisher2;
		private SceneUICanvas sceneUiCanvas;
		private float fromMyPageDelay;
	
		// Properties
		public PartyPageCtrl pageCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isEditSkillTutorialRunning { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__31 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyUICanvas __4__this;
			private GameObject _prefab_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__31(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ActivateStatusDelay_d__32 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyUICanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ActivateStatusDelay_d__32(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public ExAbilityDialog exAbilityDialog;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _OnExAbilityButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public AutoPartySelectDialog autoPartySelectDialog;
			public PartyUICanvas __4__this;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal void _OnAutoButtonPressed_b__0();
			internal void _OnAutoButtonPressed_b__1();
			internal void _OnAutoButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_1
		{
			// Fields
			public AutoPartyConfigData selectData;
			public __c__DisplayClass40_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass40_1();
	
			// Methods
			internal void _OnAutoButtonPressed_b__3();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<ErrorType, int> __9__40_4;
			public static Action __9__41_1;
			public static Action<ErrorType, int> __9__53_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnAutoButtonPressed_b__40_4(ErrorType type, int resultCode);
			internal void _Tutorial_1_1_b__41_1();
			internal void _OnPartyChangeButtonPressed_b__53_3(ErrorType error, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_1_d__41 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyUICanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_1_d__41(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayEnterAnimation_d__47 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public PartyUICanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayEnterAnimation_d__47(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitLastAnimationInnerMoveEnd_d__50 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyUICanvas __4__this;
			public Action onFinished;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitLastAnimationInnerMoveEnd_d__50(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0
		{
			// Fields
			public PartyChangePopup popup;
			public PartyUICanvas __4__this;
	
			// Constructors
			public __c__DisplayClass53_0();
	
			// Methods
			internal void _OnPartyChangeButtonPressed_b__0(int partyIndex, bool isOtherGroupLoad);
			internal void _OnPartyChangeButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_1
		{
			// Fields
			public bool isOtherGroupLoad;
			public __c__DisplayClass53_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass53_1();
	
			// Methods
			internal void _OnPartyChangeButtonPressed_b__2();
		}
	
		// Constructors
		public PartyUICanvas();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		[IteratorStateMachine]
		private IEnumerator ActivateStatusDelay();
		private void SetPageContent(GameObject page, int index);
		public void CharaModelPressed(int tag);
		public void CharaModelLongPressed(int tag);
		public void Reload();
		public void OnExAbilityButtonPressed();
		public void OnListButtonPressed();
		public void OnOrganizeButtonPressed();
		public void OnAutoButtonPressed();
		[IteratorStateMachine]
		public IEnumerator Tutorial_1_1();
		public void LoadPowerParam();
		public void AbleAllButton();
		public void DisableAllButton();
		public void DisableAllButtonExceptAuto();
		public void DisableAllButtonExceptFirstEquip();
		[IteratorStateMachine]
		private IEnumerator PlayEnterAnimation(float delay);
		public void StartGoCharacterSceneAnimation(Action onFinished, Action onHalfFinished = null);
		public void StartGoEquipSceneAnimation(Action onFinished, Action onHalfFinished = null);
		[IteratorStateMachine]
		private IEnumerator WaitLastAnimationInnerMoveEnd(Action onFinished);
		public void AdjustInnerAnimationOffset();
		private void SetVisibleCanvas(bool enable);
		public void OnPartyChangeButtonPressed();
		public void OnPartyNameEditButtonPressed();
		protected override void SetStatusMode(bool isShowCrestStatus);
		[CompilerGenerated]
		private void _Start_b__31_1();
		[CompilerGenerated]
		private void _Start_b__31_0();
		[CompilerGenerated]
		private void _Tutorial_1_1_b__41_0();
		[CompilerGenerated]
		private bool _WaitLastAnimationInnerMoveEnd_b__50_0();
		[CompilerGenerated]
		private void _OnPartyNameEditButtonPressed_b__54_0(string newName);
	}
}
