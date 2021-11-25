using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RaidEventInfoCtrl : EventInfoCtrlBase
	{
		[SerializeField]
		[Header("Raid Event")]
		private GameObject friendlyPointParent;

		[SerializeField]
		private Text friendlyPointText;

		[SerializeField]
		[Header("ã\u0083¬ã\u0082¤ã\u0083\u0089å\u008f\u0082å\u008a\u00a0ç\u0094\u00a8ã\u0082¢ã\u0082¤ã\u0083\u0086ã\u0083\u00a0")]
		private Image itemImage;

		[SerializeField]
		private Text itemCountText;

		[SerializeField]
		[Header("EXã\u0082¤ã\u0083\u0099ã\u0083³ã\u0083\u0088ç\u0094\u00a8ã\u0082¢ã\u0082¤ã\u0083\u0086ã\u0083\u00a0")]
		private Image exItemImage;

		[SerializeField]
		private Text exItemCountText;

		[SerializeField]
		[Header("æ\u0088¦è²\u00a8å\u008f¬å\u0096\u009aç\u0094\u00a8ã\u0082¢ã\u0082¤ã\u0083\u0086ã\u0083\u00a0")]
		private Image iconImage;

		[SerializeField]
		private Text iconCountText;

		[SerializeField]
		[Header("ã\u0083¬ã\u0082¤ã\u0083\u0089äº¤æ\u008f\u009bã\u0082¢ã\u0082¤ã\u0083\u0086ã\u0083\u00a01")]
		private Text exchangeItem1CountText;

		[SerializeField]
		[Header("ã\u0083¬ã\u0082¤ã\u0083\u0089äº¤æ\u008f\u009bã\u0082¢ã\u0082¤ã\u0083\u0086ã\u0083\u00a02")]
		private Text exchangeItem2CountText;

		[SerializeField]
		private Text hintText;

		[SerializeField]
		private Text hintTitleText;

		[SerializeField]
		private Text charaGrowItemCountText;

		[SerializeField]
		private Image charaGrowItemIcon;

		[SerializeField]
		private GameObject charaGrowItem;

		[SerializeField]
		private Gauge gauge;

		[SerializeField]
		private GameObject hintParent;

		[SerializeField]
		private GameObject itemsParent;

		[SerializeField]
		[Header("RaidBoost")]
		public GameObject raidBoostGO;

		public GameObject raidBoostSpecialHelpGO;

		public ButtonWithSelectedImage specialHelpButtonWithSelectImage;

		[SerializeField]
		[Header("Total Damage Event")]
		private Text updateTimeText;

		[SerializeField]
		private Text individualTotalDamageValueText;

		[SerializeField]
		private Text wholeTotalDamageValueText;

		[SerializeField]
		private ButtonWithSelectedImage totalDamageRewardButtonSelectedImage;

		[SerializeField]
		private Text aggregateUpdateTimeText;

		[SerializeField]
		private GameObject friendlyInfoPanel;

		private bool hasRaidBoost;

		private bool isTotalDamageEvent;

		private static readonly string totalDamageRaidEventInfoPrefabPath;

		private static readonly string raidEventInfoPrefabPath;

		public static RaidEventInfoCtrl Create(Transform parent, bool isTotalDamageEvent)
		{
			return null;
		}

		public override void SetEventInfo()
		{
		}

		private void SetEventHintText()
		{
		}

		public void OnRaidBoostButtonPressed()
		{
		}

		protected override void ResetSpecialHelpButtonPressedState()
		{
		}

		public void OnTotalDamageRewardButtonPressed()
		{
		}

		private void InitializeTotalDamageEventInfo()
		{
		}
	}
}
