using System;
using System.Collections;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultRetryPopup : PopupBase
	{
		[SerializeField]
		[Header("Callbacks")]
		public UnityEvent ticketRetryButtonPressed;

		[SerializeField]
		private Button ticketRetryButton;

		[SerializeField]
		public UnityEvent bgButtonPressed;

		[SerializeField]
		public UnityEvent retryButtonPressed;

		[SerializeField]
		private Button staminaRetryButton;

		[SerializeField]
		private Button itemRetryButton;

		[SerializeField]
		private Image questSkipDisabledImage;

		[SerializeField]
		private Image questSkipNotSatisfyConditionsImage;

		[SerializeField]
		private Text questSkipTicketNumText;

		[SerializeField]
		private Text questStaminaNumText;

		[SerializeField]
		private GameObject questStaminaButtonObjext;

		[SerializeField]
		private GameObject questItemButtonObjext;

		[SerializeField]
		private Image questItemButtonItemImage;

		[SerializeField]
		private Text[] questUseSkipTicketNumText;

		[SerializeField]
		private Text[] questUseStaminaNumText;

		[SerializeField]
		private Text[] questUseItemNumText;

		[SerializeField]
		private GameObject staminaGuageParent;

		[SerializeField]
		private Gauge staminaGuage;

		[SerializeField]
		private float intervalTime;

		private int givenQuestId;

		private DateTime prevUpdateTime;

		private const float updateInterval = 1f;

		public static QuestResultRetryPopup Create([Optional] Transform parentTransform)
		{
			return null;
		}

		public void Init(int questId)
		{
		}

		public void Update()
		{
		}

		private void SetStamina()
		{
		}

		public void SetUseStaminaText(int questStaminaUse, bool isStaminaCampaign)
		{
		}

		private void SetRetryButton(int questStaminaUse, QuestDataElement qde)
		{
		}

		public void SetUseTicketText(int questSkipTicketUse, bool isLackOfTicket)
		{
		}

		public void OnSkipDisabledButton()
		{
		}

		public void OnSkipNotSatisfyConditions()
		{
		}

		public void OnTicketRetryButtonPressed()
		{
		}

		private IEnumerator OnTicketRetryButtonPressedCorutine()
		{
			return null;
		}

		public void OnRetryButtonPressed()
		{
		}

		private IEnumerator OnRetryButtonPressedCorutine()
		{
			return null;
		}

		public void OnBgButtonPressed()
		{
		}
	}
}
