using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonUnitIcon : MonoBehaviour
	{
		private enum RibbonTextState
		{
			Equipping,
			Target,
			InTeam,
			SupportEquipping,
			Max
		}

		[SerializeField]
		[Header("OutButton")]
		public GameObject outButtonGO;

		public GameObject normalGO;

		[SerializeField]
		[Header("Components")]
		public CommonIcon icon;

		public GameObject sortDecoAttachNode;

		public GameObject lockImageGO;

		public GameObject flagImageGO;

		public Text flagText;

		public GameObject newImageGO;

		public GameObject selectingImageGO;

		public GameObject selectCountImageGO;

		public GameObject skinImageGO;

		public GameObject spUpgradeWeaponImageGO;

		public GameObject useEventItemTextGo;

		public Text selectCountText;

		public CanvasGroup canvasGroup;

		public GameObject favorIcon;

		public Text plusText;

		public bool noExpanededIcon;

		public int maxLimitHpPlus;

		public int maxLimitAtkPlus;

		public GameObject selectedEquippedCountGO;

		public Text selectedEquippedCountText;

		public Badge IconBadge;

		public GameObject skinBlackMask;

		public GameObject favoriteImageGO;

		public GameObject notEquipCrestGO;

		public static readonly Vector2 expandedIconSize;

		public static readonly float expandedIconScale;

		private Coroutine waitForUpdateContentCoroutine;

		private bool isStarted;

		private Tweener ribbonTextBlinkTween;

		private const float ribbonTextBlinkTime = 1f;

		private void Start()
		{
		}

		public void SetLockState(bool locked)
		{
		}

		public void SetRibbonInfo(string text)
		{
		}

		public void SetRibbonState(bool isEquipping = false, bool isTarget = false, bool isInTeam = false, bool isSupportEquipping = false)
		{
		}

		public virtual void SetBlackMask(bool isOn)
		{
		}

		public void SetNew(bool isOn)
		{
		}

		public void SetAsSelecting(bool isOn)
		{
		}

		public void SetSkinIcon(bool isOn)
		{
		}

		public void SetSpUpgradeWeaponIcon(bool isOn)
		{
		}

		public void SetEventItem(bool isUsed)
		{
		}

		public void SetSelectCount(int count)
		{
		}

		public void SetEquippedCount(bool selected, int equippedCount, int equippableCount, bool isSupportFriend)
		{
		}

		public void SetActiveEquippedCount(bool active)
		{
		}

		public void UpdateByData(CommonIconListCellData data)
		{
		}

		private IEnumerator WaitForUpdateContentCoroutine(CommonIconListCellData data, GiftType giftType, IconLoader.Size iconSize)
		{
			return null;
		}

		public void UpdateByDataAlbum(CommonIconListCellData data)
		{
		}

		private IEnumerator WaitForUpdateContentCoroutineAlbum(CommonIconListCellData data, GiftType giftType, IconLoader.Size iconSize)
		{
			return null;
		}

		private int SetDecoTextColor(CommonIconListCellData data)
		{
			return default(int);
		}

		public void SetDecoInfoByManual(int num, GiftType giftType, CommonSortModel.Condition.SortCondition.SortType type)
		{
		}

		public void SetDecoInfoByManual(Color color, int value, GiftType giftType, CommonSortModel.Condition.SortCondition.SortType type)
		{
		}

		private void OnDestroy()
		{
		}

		private string GetRibbonText(RibbonTextState state)
		{
			return null;
		}

		public void SetRibbonInfoBlink(string[] blinkTexts)
		{
		}

		private void ReleaseRibbonTextBlinkTween()
		{
		}

		public void SetFavoriteIcon(bool enable, bool isSmallScale = false)
		{
		}
	}
}
