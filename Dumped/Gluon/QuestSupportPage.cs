using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class QuestSupportPage : PageBase, ICustomMessage
	{
		public class PageBecomeActiveData
		{
			public bool isShowRoomList;

			public bool isFromQuestPrepare;
		}

		[SerializeField]
		private GameObject mainCamera;

		[SerializeField]
		private QuestSupportCanvas questSupportCanvas;

		[SerializeField]
		private QuestSupportList questSupportList;

		[SerializeField]
		private QuestElementFilter questElementFilter;

		private readonly int supportListUpdateIntervalSec;

		private bool isFromQuestPrepare;

		private Action onPageBecomeActive;

		private Action<bool> onEnterAnimation;

		private Action onExitAnimation;

		private Action onPageEnterAnimationEnded;

		private Action onBackButtonPressed;

		private int questId;

		protected override void Awake()
		{
		}

		public void Initialize(Action onPageBecomeActive, Action<bool> onEnterAnimation, Action onExitAnimation, Action onPageEnterAnimationEnded, Action onBackButtonPressed)
		{
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageBecomeInActive()
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		private void StartTutorial()
		{
		}

		private IEnumerator TutorialStep_1_1_SupportSelect()
		{
			return null;
		}

		private void LoadAndOpenSupportUserList()
		{
		}

		private void GetSupportList()
		{
		}

		private void GetDataOnSuccess(QuestGetSupportUserListResponse res)
		{
		}

		private IEnumerator WaitSupportListOpenAnimationCoroutine()
		{
			return null;
		}

		public void OnError(ErrorType errorType, int resultCode)
		{
		}

		public void BackButtonPressed()
		{
		}

		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1)
		{
			return default(bool);
		}

		private void CellButtonPressed()
		{
		}

		public void GotoPrepareScene()
		{
		}

		public void GotoPrepareSceneForMulti(bool fromRoomList)
		{
		}

		private void SetParentUiQuestPrepareMode()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
