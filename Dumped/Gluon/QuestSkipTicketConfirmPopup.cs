using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSkipTicketConfirmPopup : CommonPopup
	{
		[SerializeField]
		private Text questItemTitle;

		[SerializeField]
		private Text questItemBefore;

		[SerializeField]
		private Text questItemAfter;

		[SerializeField]
		private GameObject questItemRoot;

		[SerializeField]
		private Text staminaTitle;

		[SerializeField]
		private Text staminaBefore;

		[SerializeField]
		private Text staminaAfter;

		[SerializeField]
		private Text skipTicketRequiredNum;

		[SerializeField]
		private Text skipTicketIconTitle;

		[SerializeField]
		private Text skipTicketBefore;

		[SerializeField]
		private Text skipTicketAfter;

		[SerializeField]
		[Header("Buttons")]
		private Button minusButton;

		[SerializeField]
		private Button plusButton;

		[SerializeField]
		private Button maxButton;

		[SerializeField]
		private CommonSliderSelection ticketCountSlider;

		[SerializeField]
		private int ticketUseMaxNum;

		[SerializeField]
		private Text staminaShortageText;

		private List<QuestDataElement> questDataList;

		private static readonly int groupSkipPlayableCount;

		private bool isGroupSkip;

		public static QuestSkipTicketConfirmPopup Create(QuestDataElement qde, UnityAction onOkCallback, UnityAction onCancelCallback, bool showBlackLayer = true)
		{
			return null;
		}

		public static QuestSkipTicketConfirmPopup Create(List<QuestDataElement> qdeList, UnityAction onOkCallback, UnityAction onCancelCallback, bool showBlackLayer = true)
		{
			return null;
		}

		private static QuestSkipTicketConfirmPopup CreatePopup(List<QuestDataElement> qdeList, UnityAction onOkCallback, UnityAction onCancelCallback, bool showBlackLayer)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private void ReflectParam(List<QuestDataElement> qdeList)
		{
		}

		private void InitializeTitleAndDescriptionText()
		{
		}

		private void SetAfterValue()
		{
		}

		public override void OnCancelButtonPressed()
		{
		}

		public void OnMaxPressed()
		{
		}

		public int GetSkipCount()
		{
			return default(int);
		}

		private int GetUseTicketMaxNum()
		{
			return default(int);
		}

		private void RefreshSliderInfo()
		{
		}
	}
}
