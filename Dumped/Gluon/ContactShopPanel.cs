using System.Collections;
using System.Collections.Generic;
using Cute.Http;
using DG.Tweening;
using Gluon.Http;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ContactShopPanel : MonoBehaviour
	{
		private enum tabType
		{
			shop,
			gift
		}

		[SerializeField]
		[Header("Panel")]
		public DragonStrokeMain contactMain;

		public RectMask2D maskPanel;

		public PageViewBase pageView;

		public GameObject pagerArrowParent;

		public Text noOwnedItemText;

		public TabBase tabController;

		[SerializeField]
		private AnimationUIBase presentButton;

		[SerializeField]
		[Header("IconParent")]
		public Transform[] shopIconParent;

		private List<ContactGiftIcon> shopIcons;

		private List<ContactGiftIcon> selectShopIcons;

		[SerializeField]
		[Header("Coin")]
		public Text ownedCoinText;

		public AnimationUIBase ownedCoinAnimation;

		[SerializeField]
		[Header("Description")]
		public GameObject descriptionPanel;

		public CommonIcon descriptionIcon;

		public Text descriptionTitle;

		public Text descriptionText;

		public Text shopRestockText;

		[SerializeField]
		[Header("Control")]
		public Transform consumeBorderLine;

		public Transform consumeEndingPosition;

		private PageScrollViewRect pageViewScrollRect;

		private float maskPanelInitialHeight;

		private const float maskExpansionDuration = 0.2f;

		private const float descriptionPanelMoveDistance = 120f;

		private const float descriptionPanelMoveTime = 0.3f;

		public UnityEvent onExit;

		private Sequence runningPanelSequence;

		private bool firstOwnedSimpleAnimationDone;

		private const string ownedPagePrefabPath = "Prefabs/OutGame/DragonContact/Top/ContactOwnedGiftPage";

		private const string contactGiftIconPrefabPath = "Prefabs/OutGame/DragonContact/Top/ContactShopGiftIcon";

		[HideInInspector]
		public ContactGiftIcon beginDragGiftIcon;

		private ContactGiftIcon potentialBeginDragGiftIcon;

		private bool isVerticalDragging;

		private List<DragonGiftList> dragonGiftList;

		private tabType tabIndex;

		public void Awake()
		{
		}

		private void Start()
		{
		}

		private void InitializeShopIcons()
		{
		}

		private ContactGiftIcon CreateShopIcon(Transform parent)
		{
			return null;
		}

		private void SetIconAnimation(ContactGiftIcon icon, int index)
		{
		}

		private void OnCustomVerticalEndDrag(PointerEventData eventData)
		{
		}

		private void OnCustomVerticalPotentialBeginDrag(PointerEventData eventData)
		{
		}

		public void OnCustomVerticalDrag(PointerEventData eventData)
		{
		}

		public void OnTabSwitched(int index, bool fromUI)
		{
		}

		private void PutInCoinAndButton()
		{
		}

		private void PutOutCoinAndButton()
		{
		}

		private void ResetPresentButtonInteractable()
		{
		}

		public void RefreshPanel()
		{
		}

		private void OnPageChanged(int index)
		{
		}

		private void SetOwnedGiftPageContent(GameObject pageGO, int index)
		{
		}

		private void SetExtraGiftPageContent(GameObject pageGO, int index)
		{
		}

		public void EnterPanel()
		{
		}

		private void EnterExtraPanel()
		{
		}

		private void ResetExtraPanel()
		{
		}

		public void ExitPanelWithDelay(float delayTime)
		{
		}

		private IEnumerator ExitPanelWithDelayCoroutine(float delayTime)
		{
			return null;
		}

		public void ExitPanel()
		{
		}

		public void showItemDescription(int id)
		{
		}

		public void hideItemDescription()
		{
		}

		public bool IsOpenDescription(int id)
		{
			return default(bool);
		}

		public void OnGiftSent(bool favorite)
		{
		}

		public void OnBeforeSendGift()
		{
		}

		public void DeselectAll()
		{
		}

		public void AddSelectIcon(ContactGiftIcon icon)
		{
		}

		public void RemoveSelectIcon(ContactGiftIcon icon)
		{
		}

		private void ResettingSelectImages()
		{
		}

		private void RemoveAllSelectIcon()
		{
		}

		public void OnPresentButtonPressed()
		{
		}

		private void SendPresent()
		{
		}

		private IEnumerator SendItemsAnimation()
		{
			return null;
		}

		public void ApiBuyGiftToSendMultiple(int[] idList)
		{
		}

		public void ApiOnBuyGiftToSendMultipleError(ErrorType errorType, int errorCode)
		{
		}

		private void ApiOnBuyGiftToSendMultipleSuccess(DragonBuyGiftToSendMultipleResponse res)
		{
		}

		private bool HasFavoriteGift(AtgenDragonGiftRewardList[] rewardList)
		{
			return default(bool);
		}

		private void ImportReturnGiftData(AtgenDragonGiftRewardList[] rewardList)
		{
		}

		public List<DragonGiftList> GetDragonGiftList()
		{
			return null;
		}

		public long GetRemainingCoin()
		{
			return default(long);
		}

		private void ResetShopState()
		{
		}

		private void ResetIconsColor()
		{
		}

		private void ResetSlider()
		{
		}

		public bool IsSelectMultipleIcons()
		{
			return default(bool);
		}
	}
}
