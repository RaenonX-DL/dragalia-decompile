/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectUiCanvas : AnimationUICanvas
	{
		// Fields
		[SerializeField]
		private Canvas _uiCanvas;
		private UnityAction backButtonSoundAction;
		private BackButton _backButton;
		private UnityAction _unityAction;
		private bool _isOpen;
		[SerializeField]
		private Button[] uiDifficultyButtons;
		[SerializeField]
		private Image[] uiDifficultyNormalArrow;
		[SerializeField]
		private GameObject uiDiffcultyAndAchievementRoot;
		[SerializeField]
		private GameObject _uiFlashTrans;
		[SerializeField]
		private GameObject uiCampaignParent;
		[SerializeField]
		private PointerEventHandler uiCampaignButton;
		[SerializeField]
		private PointerEventHandler uiDragonSphereButton;
		[SerializeField]
		private GameObject uiToChapterButton;
		[SerializeField]
		private GameObject uiScrollChapter;
		[SerializeField]
		private UnityEngine.UI.Text uiScrollChapterNumberText;
		[SerializeField]
		private GameObject uiBannerParent;
		[SerializeField]
		private GameObject leftAreaChangeButton;
		[SerializeField]
		private GameObject rightAreaChangeButton;
		[SerializeField]
		private CanvasGroup canvasGroup;
		[SerializeField]
		private FlashPosScaleInfo dragonFlashInfo;
		[SerializeField]
		private GameObject uiStoryButton;
		[SerializeField]
		private GameObject uiStorySkipButton;
		[SerializeField]
		private GameObject uiLastedChapterButton;
		[SerializeField]
		private CanvasGroup mapCanvasGroup;
		[SerializeField]
		private CanvasGroup titleCanvasGroup;
		[SerializeField]
		private GameObject notOpenchapterLockObj;
		[SerializeField]
		private UnityEngine.UI.Text notOpenchapterLockText;
		[SerializeField]
		private CanvasGroup notOpenchapterLockObjCanvasGroup;
		public UnityAction onClickRightArrow;
		public UnityAction onClickLeftArrow;
		public UnityAction onToChapter;
		public UnityAction onBanner;
		private SimpleAnimationButton animButton;
		private QuestSelectScene.QuestSelectSceneType nowType;
		[SerializeField]
		private int _locationId;
		[SerializeField]
		private QuestMapImage _questMapImage;
		[SerializeField]
		private QuestMenuListTitle questListTitle;
		private static bool _isOpenOnCreated;
		[SerializeField]
		private QuestSelectScene.Difficulty _difficulty;
		public QuestSelectScene questSelectScene;
		private AnimationUIPart[] animationUIParts;
		private UnityAction onOpenCallback;
		private UnityAction onCloseCallback;
		public FlashPlayer[] flashPlayerDragonlr;
		private bool isDragonAnimation;
		[SerializeField]
		private PointerEventHandler chapterMovePointerEventHander;
		private Vector2 vec;
	
		// Properties
		public Canvas uiCanvas { get; set; }
		public BackButton backButton { get; set; }
		public UnityAction unityAction { get; }
		public bool isOpen { get; private set; }
		public GameObject uiFlashTrans { get; }
		public int locationId { get; set; }
		public QuestMapImage questMapImage { get; }
		public static bool isOpenOnCreated { get; set; }
		public QuestSelectScene.Difficulty difficulty { get; set; }
	
		// Nested types
		[Serializable]
		public struct FlashPosScaleInfo
		{
			// Fields
			public Vector3 localPos;
			public float localScale;
			public int sortingOrder;
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_0
		{
			// Fields
			public SimpleAnimationButton animButton;
	
			// Constructors
			public __c__DisplayClass78_0();
	
			// Methods
			internal bool _WaitForExitingAndStartEnteringCoroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForExitingAndStartEnteringCoroutine_d__78 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectUiCanvas __4__this;
			public bool isImageToText;
			private __c__DisplayClass78_0 __8__1;
			public bool isAfterAnimStop;
			public QuestSelectScene.QuestSelectSceneType type;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForExitingAndStartEnteringCoroutine_d__78(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_0
		{
			// Fields
			public QuestSelectUiCanvas __4__this;
			public CampaignListPopup popup;
	
			// Constructors
			public __c__DisplayClass95_0();
	
			// Methods
			internal void _OnCampaignButtonPressed_b__0();
			internal void _OnCampaignButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass96_0
		{
			// Fields
			public QuestSelectUiCanvas __4__this;
			public QuestSelectItemListPopup popup;
	
			// Constructors
			public __c__DisplayClass96_0();
	
			// Methods
			internal void _OnSphereButton_b__0();
			internal void _OnSphereButton_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _WaitBgAndOpen_d__101 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectUiCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitBgAndOpen_d__101(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitCloseCompleted_d__109 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isCloseTouchGuard;
			public QuestSelectUiCanvas __4__this;
			public bool isDestroyOnCompleted;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitCloseCompleted_d__109(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SetActiveDragonCorutine_d__115 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectUiCanvas __4__this;
			public bool enable;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetActiveDragonCorutine_d__115(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass116_0
		{
			// Fields
			public QuestSelectUiCanvas __4__this;
			public Action action;
			public string str;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass116_0();
	
			// Methods
			internal void _PlayDragonFlash_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass116_1
		{
			// Fields
			public int i;
			public __c__DisplayClass116_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass116_1();
	
			// Methods
			internal void _PlayDragonFlash_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _DelayMethod_d__117 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int delayCount;
			public Action callback;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayMethod_d__117(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass120_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass120_0();
	
			// Methods
			internal void _OnStorySkipButtonPressed_b__0();
			internal void _OnStorySkipButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass120_1
		{
			// Fields
			public CommonPopup toTitolPopup;
			public Action<StorySkipSkipResponse> __9__3;
	
			// Constructors
			public __c__DisplayClass120_1();
	
			// Methods
			internal void _OnStorySkipButtonPressed_b__2();
			internal void _OnStorySkipButtonPressed_b__3(StorySkipSkipResponse res);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__121_0;
			public static Action __9__124_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnAdvStoryButtonPressed_b__121_0();
			internal void _OnLastedChapterButton_b__124_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass124_0
		{
			// Fields
			public QuestSelectChapterPage chapterPage;
	
			// Constructors
			public __c__DisplayClass124_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass124_1
		{
			// Fields
			public int lastedChapterNumber;
			public __c__DisplayClass124_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass124_1();
	
			// Methods
			internal void _OnLastedChapterButton_b__1();
		}
	
		// Constructors
		public QuestSelectUiCanvas();
		static QuestSelectUiCanvas();
	
		// Methods
		protected override void Awake();
		public void CheckReleaseFunction();
		protected override void OnDestroy();
		public void SetBackButtonCallback(QuestSelectScene.QuestSelectSceneType type, UnityAction unityAction, bool isAnimStop = true);
		public void StartEnterAnimation();
		public void StartExitAnimation();
		private void StartEnterAnimationAfterExitingCompleted(bool isImageToText, QuestSelectScene.QuestSelectSceneType type, bool isAfterAnimStop = false);
		[IteratorStateMachine]
		private IEnumerator WaitForExitingAndStartEnteringCoroutine(bool isImageToText, QuestSelectScene.QuestSelectSceneType type, bool isAfterAnimStop);
		public void AnimationFlagStop();
		public void DeleteBackButtonCallback();
		public void SetDifficultButtonCallBack(UnityAction unityAction = null);
		public void SetChangeStatus(QuestSelectScene.QuestSelectSceneType type);
		public void SetButtonAllOff();
		public void SetUIAll(bool enable);
		public void SetButtonActive();
		public void OnEnableDifficultyButtonFromTutorial();
		public void ChangeDifficultyButton(QuestSelectScene.Difficulty difficulty);
		public void SetNormalDifficultyArrowss();
		public void SetAllButtonsEnabled(bool isEnabled);
		public void OnClickRightArrow();
		public void OnClickLeftArrow();
		public void SetArrowEnable(bool enable);
		public void OnToChapter();
		public void OnBanner();
		public void OnCampaignButtonPressed();
		public void OnSphereButton();
		public void SetToChapterNumber(int index);
		public void OnSwipeChangeChapter(float pointEventData);
		public void MapOpen(int locationId);
		[IteratorStateMachine]
		private IEnumerator WaitBgAndOpen();
		private void Appear();
		private void Open();
		public void OnHide();
		protected void Hide();
		private void InitializeParts(bool isInitializeLandmarkPosAndBg = true);
		public void MapClose(bool isDestroyOnCompleted = false, bool isCloseTouchGuard = false);
		private void Close();
		[IteratorStateMachine]
		private IEnumerator WaitCloseCompleted(bool isDestroyOnCompleted, bool isCloseTouchGuard);
		public void SetOpenCallback(UnityAction onOpen = null);
		public void SetCloseCallback(UnityAction onClose = null);
		public void MapNotClose(bool isDestroyOnCompleted = false, bool isCloseTouchGuard = false);
		public void CreateDragon();
		public void SetActiveDragon(bool enable);
		[IteratorStateMachine]
		private IEnumerator SetActiveDragonCorutine(bool enable);
		public void PlayDragonFlash(string str, int delayCount = 0, Action action = null);
		[IteratorStateMachine]
		private IEnumerator DelayMethod(Action callback, int delayCount);
		private void OnDragonAnimationEnd();
		public bool IsDragonAnimation();
		public void OnStorySkipButtonPressed();
		public void OnAdvStoryButtonPressed();
		private int GetMaxChapter();
		public void SetButtonStateTutorial_2_2_Tutorial_ToBackButton(UnityAction callback);
		public void OnLastedChapterButton();
		[CompilerGenerated]
		private void _SetBackButtonCallback_b__74_0();
		[CompilerGenerated]
		private void _CreateDragon_b__113_0(int index);
		[CompilerGenerated]
		private bool _SetActiveDragonCorutine_b__115_0();
	}
}
