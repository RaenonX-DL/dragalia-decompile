/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TutorialUIManager : MonoBehaviour
	{
		// Fields
		public CameraGroup characterCamera;
		public static Action onInitCompleted;
		public const float StartTutorialDelay = 1f;
		private TutorialUIMainCanvas mainCanvas;
		[CompilerGenerated]
		private Canvas _mainCanvasCanvas_k__BackingField;
		private GameObject storyCanvasObject;
		private GameObject storyBgCanvasObject;
		private GameObject storyCharaCanvasObject;
		private TutorialDualWindow showDualWindows;
		private bool isShowPointer;
		public bool isShowExceptionPop;
		public bool isShowCloseAppPop;
		public bool isForceBackkeyAction;
		private Transform objectTransform;
		private Transform parentTransform;
		private Vector2 parentPos;
		private CommonPopup closeAppPopup;
		private RubySupportedPopup showTutorialPop;
		public static bool isShowLockIcon;
		private static TutorialUIManager _instance;
	
		// Properties
		public Canvas mainCanvasCanvas { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static TutorialUIManager instance { get; }
	
		// Nested types
		private enum SortingOrder
		{
			Character = 150,
			UIBackground = 151,
			UIMain = 152
		}
	
		public enum LockButtonType
		{
			None = -1,
			MultiPlay = 0,
			Event = 1,
			ManaCircle = 2,
			DragonGrowth = 3,
			DragonLimitBreak = 4,
			WeaponGrowth = 5,
			WeaponLimitBreak = 6,
			DragonContact = 7,
			DragonStory = 8,
			CastleStory = 9,
			DragonBattle = 10,
			SummonStory = 11,
			FortMenu = 12,
			Growth = 13,
			CastleStoryByClosed = 14,
			Sell = 15,
			AmuletGrowth = 16,
			AmuletLimitBreak = 17,
			CharaStory = 18,
			Craft = 19,
			DragonSell = 20,
			ShopQuestBonus = 21,
			InterceptionBattle = 22,
			SecondAmulet = 23,
			ResetPlus = 24,
			Guild = 25,
			EditSkill = 26,
			DragonSphere = 27
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__28_0;
			public static Func<bool> __9__28_1;
			public static Func<bool> __9__37_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _WaitConnected_b__28_0();
			internal bool _WaitConnected_b__28_1();
			internal bool _RunActionAfterPopupClose_b__37_0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitConnected_d__28 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Action onCompleted;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitConnected_d__28(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0
		{
			// Fields
			public TutorialUIManager __4__this;
			public Action onCompleted;
			public bool hideBlackTouchLayerOnCompeted;
			public Action touchWaitCallBack;
	
			// Constructors
			public __c__DisplayClass35_0();
	
			// Methods
			internal void _ExecScript_b__0(StoryScriptFunctionManager.State state, StoryScriptFunctionManager.ScriptFunction index);
		}
	
		[CompilerGenerated]
		private sealed class _RunActionAfterPopupClose_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Action action;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _RunActionAfterPopupClose_d__37(int __1__state);
	
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
			public TutorialUIManager __4__this;
			public Action onWindowClosed;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _ShowDualWindows_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0
		{
			// Fields
			public TutorialUIManager __4__this;
			public UnityAction closeCallBack;
	
			// Constructors
			public __c__DisplayClass49_0();
	
			// Methods
			internal void _ShowTutorialPop_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0
		{
			// Fields
			public LockButtonType type;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _SetLockButtonRect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass59_0();
	
			// Methods
			internal void _ShowLockPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_0
		{
			// Fields
			public bool isTouchGuard;
			public TutorialUIManager __4__this;
	
			// Constructors
			public __c__DisplayClass64_0();
	
			// Methods
			internal void _TutorialBackKeyAction_b__0();
		}
	
		// Constructors
		public TutorialUIManager();
		static TutorialUIManager();
	
		// Methods
		public static void Run(Action onCompleted);
		private void Start();
		public void DryRun();
		private static void ProductionRun(Action onCompleted);
		[IteratorStateMachine]
		public static IEnumerator WaitConnected(Action onCompleted);
		public static void DestroyInstance();
		public void SetMainCanvasForce(TutorialUIMainCanvas canvas);
		public void CreateMainCanvas();
		public void DestroyMainCanvas();
		public void DestroyStoryCanvas();
		public void SetupStory();
		public void ExecScript(string scriptName, Action onCompleted, bool hideBlackTouchLayerOnCompeted = true, Action touchWaitCallBack = null);
		public bool IsBlockMissionNotice();
		[IteratorStateMachine]
		private IEnumerator RunActionAfterPopupClose(Action action);
		public TutorialSimpleWindow ShowWindow(string text);
		public TutorialDualWindow ShowDualWindows(string[] imagefilenames, string[] titleTexts, string[] descTexts, Action onWindowClosed, string skipConfirmText = "", Action skipCallback = null);
		public void ShowPointerOnFooter(Footer.MenuTab menuTab, bool useTouchGuard = true);
		public void SetTouchGuardExceptFooterActive(bool isActive);
		public void SetTouchGuardExceptBottomActive(bool isActive);
		public void ShowPointerInPosition(float x, float y);
		public void SetPointerAnchorePos(float x, float y);
		public void ShowPointerInAbsolutePosition(float x, float y);
		public void ResetPointerAbsolutePosition();
		public void HidePointer();
		public void SetBlackTouchGuardActive(bool isActive, bool isUseFooter = false, bool isClearColor = false);
		public void ShowTutorialPop(string title, string text, UnityAction closeCallBack);
		public static bool IsInstanceEmpty();
		protected virtual void OnDestroy();
		public static GameObject SetLockButton(Button button, LockButtonType type, float lockScale = 1f, bool isForFooter = false);
		public static GameObject SetLockButtonRect(RectTransform rect, LockButtonType type, float lockScale = 1f, bool isForFooter = false);
		public static void RemoveLockButton(Button button);
		public static void RemoveLockButton(GameObject rootObj);
		public static void ShowLockPopup(LockButtonType type);
		public static Color GetTutorialLockColor();
		public static string GetLockData(LockButtonType type);
		private static string GetFuncName(LockButtonType type);
		private static QuestStoryElement GetTriggerQuestStory(LockButtonType type);
		public bool TutorialBackKeyAction();
		public void SetObjectOnBlackTouchGuard(Transform objTransform);
		public void OutObjectOnBlackTouchGuard();
		[CompilerGenerated]
		private void _TutorialBackKeyAction_b__64_1();
	}
}
