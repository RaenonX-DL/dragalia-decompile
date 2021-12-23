using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeScene : SceneBase
	{
		[SerializeField]
		private Camera _uiCamera;

		[SerializeField]
		private Camera _flashCamera;

		[SerializeField]
		private Canvas commonUICanvas;

		[SerializeField]
		private RectTransform screenShotCanvas;

		[SerializeField]
		private Image screenShotImage;

		[SerializeField]
		private Image screenShotBlackPanel;

		[SerializeField]
		private CanvasGroup screenShotCanvasGroup;

		private SceneNameDefine.PageName firstPageName;

		private UnityAction backButtonSoundAction;

		private DmodeStatusInfoCtrl _statusInfo;

		private QuestResultModel.DmodeQuestResultModel.SceneModelFromResult sceneDataFromResult;

		private readonly string pathDmodeStatusInfo;

		private readonly string showDmodeEventInfoKey;

		private TouchGuardObject enterTouchGuard;

		public Camera uiCamera => null;

		public Camera flashCamera => null;

		public Button backButton
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

		public DmodeStatusInfoCtrl statusInfo => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void OnInitReadyRequestHttp()
		{
		}

		private IEnumerator WaitPrevSceneExitAndInit()
		{
			return null;
		}

		private void OnEnterScene()
		{
		}

		public override void OnBeforeLeaving()
		{
		}

		private void FooterButtonPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		private void FooterButtonLongPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		private void DetachFooterCallback()
		{
		}

		public void BindBackButtonCallback(UnityAction callback, bool showExitAnimationWhenClick)
		{
		}

		private void LoadEventStatus()
		{
		}

		public override void StartExitAnimation()
		{
		}

		public void ForceMoveBackButton(bool isIn)
		{
		}

		public override void OnPresentReceived()
		{
		}
	}
}
