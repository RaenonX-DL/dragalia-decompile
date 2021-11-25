using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class TutorialUIManager : MonoBehaviour
	{
		private enum SortingOrder
		{
			Character = 150,
			UIBackground,
			UIMain
		}

		public enum LockButtonType
		{
			None = -1,
			MultiPlay,
			Event,
			ManaCircle,
			DragonGrowth,
			DragonLimitBreak,
			WeaponGrowth,
			WeaponLimitBreak,
			DragonContact,
			DragonStory,
			CastleStory,
			DragonBattle,
			SummonStory,
			FortMenu,
			Growth,
			CastleStoryByClosed,
			Sell,
			AmuletGrowth,
			AmuletLimitBreak,
			CharaStory,
			Craft,
			DragonSell,
			ShopQuestBonus,
			InterceptionBattle,
			SecondAmulet,
			ResetPlus,
			Guild,
			EditSkill,
			DragonSphere
		}

		public CameraGroup characterCamera;

		public static Action onInitCompleted;

		public const float StartTutorialDelay = 1f;

		private TutorialUIMainCanvas mainCanvas;

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

		public Canvas mainCanvasCanvas
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static TutorialUIManager instance => null;

		public static void Run(Action onCompleted)
		{
		}

		private void Start()
		{
		}

		public void DryRun()
		{
		}

		private static void ProductionRun(Action onCompleted)
		{
		}

		public static IEnumerator WaitConnected(Action onCompleted)
		{
			return null;
		}

		public static void DestroyInstance()
		{
		}

		public void SetMainCanvasForce(TutorialUIMainCanvas canvas)
		{
		}

		public void CreateMainCanvas()
		{
		}

		public void DestroyMainCanvas()
		{
		}

		public void DestroyStoryCanvas()
		{
		}

		public void SetupStory()
		{
		}

		public void ExecScript(string scriptName, Action onCompleted, bool hideBlackTouchLayerOnCompeted = true, [Optional] Action touchWaitCallBack)
		{
		}

		public bool IsBlockMissionNotice()
		{
			return default(bool);
		}

		private IEnumerator RunActionAfterPopupClose(Action action)
		{
			return null;
		}

		public TutorialSimpleWindow ShowWindow(string text)
		{
			return null;
		}

		public TutorialDualWindow ShowDualWindows(string[] imagefilenames, string[] titleTexts, string[] descTexts, Action onWindowClosed, string skipConfirmText = "", [Optional] Action skipCallback)
		{
			return null;
		}

		public void ShowPointerOnFooter(Footer.MenuTab menuTab, bool useTouchGuard = true)
		{
		}

		public void SetTouchGuardExceptFooterActive(bool isActive)
		{
		}

		public void SetTouchGuardExceptBottomActive(bool isActive)
		{
		}

		public void ShowPointerInPosition(float x, float y)
		{
		}

		public void SetPointerAnchorePos(float x, float y)
		{
		}

		public void ShowPointerInAbsolutePosition(float x, float y)
		{
		}

		public void ResetPointerAbsolutePosition()
		{
		}

		public void HidePointer()
		{
		}

		public void SetBlackTouchGuardActive(bool isActive, bool isUseFooter = false, bool isClearColor = false)
		{
		}

		public bool IsBlackTouchGuardActive()
		{
			return default(bool);
		}

		public void ShowTutorialPop(string title, string text, UnityAction closeCallBack)
		{
		}

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		protected virtual void OnDestroy()
		{
		}

		public static GameObject SetLockButton(Button button, LockButtonType type, float lockScale = 1f, bool isForFooter = false)
		{
			return null;
		}

		public static GameObject SetLockButtonRect(RectTransform rect, LockButtonType type, float lockScale = 1f, bool isForFooter = false)
		{
			return null;
		}

		public static void RemoveLockButton(Button button)
		{
		}

		public static void RemoveLockButton(GameObject rootObj)
		{
		}

		public static void ShowLockPopup(LockButtonType type)
		{
		}

		public static Color GetTutorialLockColor()
		{
			return default(Color);
		}

		public static string GetLockData(LockButtonType type)
		{
			return null;
		}

		private static string GetFuncName(LockButtonType type)
		{
			return null;
		}

		private static QuestStoryElement GetTriggerQuestStory(LockButtonType type)
		{
			return null;
		}

		public bool TutorialBackKeyAction()
		{
			return default(bool);
		}

		public void SetObjectOnBlackTouchGuard(Transform objTransform)
		{
		}

		public void OutObjectOnBlackTouchGuard()
		{
		}
	}
}
