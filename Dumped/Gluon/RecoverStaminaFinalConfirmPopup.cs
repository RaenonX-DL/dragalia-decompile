using System;
using Cute.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RecoverStaminaFinalConfirmPopup : PopupBase
	{
		[SerializeField]
		[Header("Contents")]
		public GameObject[] iconFrames;

		public CommonIcon[] icons;

		public Text commentText;

		[SerializeField]
		[Header("BeforeAfter")]
		public Text beforeStaminaText;

		public Text afterStaminaText;

		public Text staminaTabText;

		[SerializeField]
		private GameObject overText;

		[SerializeField]
		private Button okButton;

		private bool isStone;

		private bool isFreeStone;

		private bool isMulti;

		private bool isJuice;

		private EntityData[] usedItem;

		private Action onSuccessOrHttpFailed;

		public ItemListPopup itemListPopup;

		private bool isShowRecoverDonePopup;

		public static RecoverStaminaFinalConfirmPopup Create(int beforeStamina, int afterStamina, bool isMulti, EntityData[] usedItem, Action onSucessOrHttpFailed, bool isShowDonePopup, bool isFreeStone = true, int stoneValue = 50, bool isJuice = false)
		{
			return null;
		}

		private void Setup(int beforeStamina, int afterStamina, bool isMulti, EntityData[] usedItem, bool isFreeStone, int stoneValue, bool isJuice)
		{
		}

		private void OnSuccessOrHttpFailed()
		{
		}

		public void OnCancelButtonPressed()
		{
		}

		public void OnOkButtonPressed()
		{
		}

		public void RequestUseItem()
		{
		}

		public static void CallRequestUseStone(bool isFreeStone, bool isMulti, EntityData[] usedItem, Action onSuccessOrHttpFailed, bool isShowDonePopup)
		{
		}

		public void RequestUseStone()
		{
		}

		private static void OnHttpError(ErrorType errorType, int errorCode, Action onFailed)
		{
		}
	}
}
