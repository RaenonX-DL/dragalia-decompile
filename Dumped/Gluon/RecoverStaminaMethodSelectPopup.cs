using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RecoverStaminaMethodSelectPopup : PopupBase
	{
		[SerializeField]
		[Header("Contents")]
		public Text titleText;

		public Text commentText;

		public Text ownedStoneText;

		public Text ownedPaidStoneText;

		public Text itemRecoverCommentText;

		public Text insufficientStaminaCommentText;

		[SerializeField]
		[Header("Button")]
		public Button itemButton;

		public Button freeStoneButton;

		public Button paidStoneButton;

		[SerializeField]
		[Header("Texts")]
		public Text paidStoneText;

		public Text freeStoneText;

		public GameObject multiStaminaIconGO;

		private bool insufficientOfStone;

		private bool isCreateByQuest;

		public static bool IsInShopMaintenance()
		{
			return default(bool);
		}

		public static void CreateModule(GameObject destroyWatcherAttach, bool isMulti, int requiredStamina, Action onDoneWithAnyAction, Action onCancelled, bool isQuest = false)
		{
		}

		private static RecoverStaminaMethodSelectPopup Create()
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnUseFreeStoneButtonPressed()
		{
		}

		public void OnUseOrPurchaseStoneButtonPressed()
		{
		}

		public void ReCreatePopup()
		{
		}

		public void OnUIseItemButtonPressed()
		{
		}

		public void OnCloseButtonPressed()
		{
		}
	}
}
