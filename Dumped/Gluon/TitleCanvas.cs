using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TitleCanvas : MonoBehaviour, ICustomMessage
	{
		public TitleScene scene;

		public GameObject copyright;

		public GameObject criMark;

		public GameObject suggestionBoxButton;

		public GameObject menuButton;

		public Badge menuButtonBadge;

		public GameObject suggestionBoxButtonPressedMark;

		public GameObject menuButtonPressedMark;

		public GameObject company1;

		public GameObject company1X;

		public GameObject company2;

		public GameObject company2X;

		public GameObject topBgForLongDevice;

		public GameObject bottomBgForLongDevice;

		public GameObject touchGuard;

		public Text suggestionBoxText;

		public Text menuText;

		public Text titleVersionText;

		public Text titleViewerIdText;

		public GameObject showDebugButton;

		public CanvasGroup frontBlackCG;

		public bool isStartAnimationDone;

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		public void StartEnterAnimation()
		{
		}

		private IEnumerator StartEnterAnimationCoroutine()
		{
			return null;
		}

		public void EnableTouchGurad(bool enable)
		{
		}

		public void DoFade(float duration)
		{
		}

		public void OnTouchGuardPressed()
		{
		}

		public void OnTitleButtonPressed()
		{
		}

		public void OnMenuButtonPressed()
		{
		}

		public void OnSuggestionBoxButtonPressed()
		{
		}

		public void UnloadFont()
		{
		}

		public void UpdateInquireBadge(bool isHavingUnreadComments)
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		private bool IsTooLongDevice()
		{
			return default(bool);
		}
	}
}
