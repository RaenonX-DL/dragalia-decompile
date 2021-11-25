using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class SceneBase : MonoBehaviour
	{
		[SerializeField]
		public bool hasHeader;

		[SerializeField]
		public bool hasFooter;

		[SerializeField]
		public bool isDateChangeCheckDisableOnTransition;

		[SerializeField]
		public bool isDateChangeCheckDisableOnResume;

		[SerializeField]
		private MaintenanceFunctionType[] funcTypes;

		[SerializeField]
		public bool hasExitAnimation;

		[SerializeField]
		public bool multiTouchEnabled;

		[SerializeField]
		[Header("AnimationUIã\u0081®é\u0080\u0080å\u0087ºã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0æ\u0095°")]
		public int sceneExitFrameCount;

		public static bool isInitialSceneForDevelopment;

		private int defaultCanvasPlaneDistance;

		[HideInInspector]
		public GameObject backButtonObject;

		private int popupCount;

		protected bool isPopupOpened;

		public bool isPageControlNeeded;

		public bool isCalledDateChangeEvent;

		public bool isCalledMaihtenanceEvent;

		private bool isOptionalScene;

		protected bool isPlayTutorial;

		public UnityAction webViewCloseCallback;

		private static bool _isPromotedItemOnPending;

		private const int constPromotedItemOKStatusWaitCount = 2;

		private static int promotedItemOKStatusCount;

		public PageController pageCtrl
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

		public PageBase curPage => null;

		public SceneNameDefine.PageName nextPageName
		{
			[CompilerGenerated]
			get
			{
				return default(SceneNameDefine.PageName);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public SceneNameDefine.PageName previousPageName
		{
			[CompilerGenerated]
			get
			{
				return default(SceneNameDefine.PageName);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool isPromotedItemOnPending
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		protected SceneModelBase StartSceneBase(bool isAddedScene = false, bool isInitGraphicParam = false)
		{
			return null;
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		private void LoadBaseScenes()
		{
		}

		protected IEnumerator ResetHeaderCanvasSettings(int waitframe)
		{
			return null;
		}

		private IEnumerator ResetFooterCanvasSettings(int waitframe)
		{
			return null;
		}

		public void SetHeaderFooterCanvasPlaneDistance(int distance)
		{
		}

		private IEnumerator SetHeaderFooterCanvasPlaneDistanceCoroutine(int distance)
		{
			return null;
		}

		private void SetHeaderFooterCanvasPlaneDistanceImpl(int distance)
		{
		}

		public BackButton SetupBackSceneButton(Canvas canvas, UnityAction prevAction, bool isFromEventPage = false)
		{
			return null;
		}

		public void CreateTouchGuard(float duration = -1f)
		{
		}

		private IEnumerator TouchGuardWaitCoroutine(float duration)
		{
			return null;
		}

		public void RemoveAllTouchGuard()
		{
		}

		public void RemoveTouchGuard()
		{
		}

		private IEnumerator RemoveTouchGuardWaitCoroutine()
		{
			return null;
		}

		public TouchGuardObject CreateTouchGuardObject(string label, float duration = -1f)
		{
			return null;
		}

		public void RemoveTouchGuardObject(TouchGuardObject touchGuardObject)
		{
		}

		public bool IsTouchGuard()
		{
			return default(bool);
		}

		public void UpdateHeaderInfo()
		{
		}

		public void SetBackButtonActive(bool isActive)
		{
		}

		public void SetBackButtonInteractable(bool interactable)
		{
		}

		public virtual void OnPopupOpened()
		{
		}

		public virtual void OnPopupClosed()
		{
		}

		public bool IsPopupOpened()
		{
			return default(bool);
		}

		public static void CloseScenePopup(string sceneName)
		{
		}

		public virtual void StartExitAnimation()
		{
		}

		private IEnumerator ExitAnimationCoroutine()
		{
			return null;
		}

		protected virtual void OnExitAnimationCompleted()
		{
		}

		public virtual void ChangePage(SceneNameDefine.PageName pageName, Transform parentTransform, AnimationUICanvas.AnimationPattern exitPattern = AnimationUICanvas.AnimationPattern.Pattern_1, AnimationUICanvas.AnimationPattern enterPattern = AnimationUICanvas.AnimationPattern.Pattern_1, [Optional] Action<PageBase> onLoaded, [Optional] object data, bool allowSamePageReload = true, bool delayEnterAnimation = true, bool deactivateLastPage = true)
		{
		}

		public virtual void OnBeforeLeaving()
		{
		}

		public virtual void OnPresentReceived()
		{
		}

		public virtual void OnItemUsed()
		{
		}

		public bool SkipCheckDateChangeForTutorial()
		{
			return default(bool);
		}

		public bool CheckDateChange(bool withCallEvent = false)
		{
			return default(bool);
		}

		protected virtual void OnDateChanged()
		{
		}

		public bool CheckMaintenance(bool withCallEvent = false)
		{
			return default(bool);
		}

		protected virtual void OnMaintenance(MaintenanceFunctionType type)
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void CheckForPromotedItem()
		{
		}

		public static void CreatePromotedIAPCommonNGPopup()
		{
		}

		public static void CreatePromotedIAPTutorialNGPopup()
		{
		}

		private void CreatePromotedIAP()
		{
		}
	}
}
