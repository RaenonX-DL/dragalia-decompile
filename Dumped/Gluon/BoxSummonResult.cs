using System.Collections;
using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BoxSummonResult : MonoBehaviour, ICustomMessage
	{
		[SerializeField]
		public GameObject resultItemTemplate;

		[SerializeField]
		private GameObject captionObj;

		[SerializeField]
		private GameObject bottomObj;

		[SerializeField]
		private Button resetButton;

		[SerializeField]
		private Button summonButton;

		[SerializeField]
		private Text summonButtonText;

		[SerializeField]
		private Button nextButton;

		[SerializeField]
		private Text nextButtonText;

		[SerializeField]
		private Button skipButton;

		[SerializeField]
		private Text pointRemain;

		[SerializeField]
		private Text pointCost;

		[SerializeField]
		private Text captionText;

		[SerializeField]
		private Image captionImage;

		[SerializeField]
		private Transform[] resultItemParents;

		[SerializeField]
		private BackButton backButton;

		[SerializeField]
		private UIAnimationPublisher enterPublisher;

		private List<GameObject> resultItems;

		public static readonly float NEXT_SUMMON_DELAY_START_TIME;

		public static readonly float NEXT_SUMMON_DELAY_WAIT_TIME;

		public static readonly float NEXT_SUMMON_DELAY_END_TIME;

		private BoxSummonAnimPage animPage;

		private Coroutine resultPopupCorutine;

		private BoxSummonResultPopup summonResultPopup;

		private bool summonContentsFromResult;

		public void Show(bool toShow)
		{
		}

		public void SetContent(BoxSummonAnimPage animPage, bool isFadingOut)
		{
		}

		private IEnumerator ShowResultPopup()
		{
			return null;
		}

		private void ShowReceivedOverLimitPopup()
		{
		}

		private bool IsShowingResultPopup()
		{
			return default(bool);
		}

		protected void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		public void ResetSummonData()
		{
		}

		private void SetupContents()
		{
		}

		private void SetupCaption()
		{
		}

		private void SetupItemList()
		{
		}

		private void SetupItemListSub(AtgenDrawDetails drawInfo, int index, int total)
		{
		}

		private void SetupPointRemain()
		{
		}

		private void SetupPointCost()
		{
		}

		private void SetupResetButton()
		{
		}

		private void UpdateNextItems()
		{
		}

		private void TeardownContents()
		{
		}

		public void OnContentButtonTouched()
		{
		}

		public void OnBackButtonTouched()
		{
		}

		public void OnSummonButtonTouched()
		{
		}

		public void OnNextButtonTouched()
		{
		}

		public void OnSkipButtonTouched()
		{
		}

		private void ShowNextItems()
		{
		}

		private IEnumerator nextSummon()
		{
			return null;
		}

		private void StopResultPopupCorutine()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
