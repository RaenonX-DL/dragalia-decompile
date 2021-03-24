/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DrawSummonPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text okButtonText;
		[Header]
		[SerializeField]
		public GameObject[] drawSummonPages;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text legendTitleText;
		[Header]
		[SerializeField]
		private GameObject[] insufficientTextGOs;
		[SerializeField]
		private GameObject purchaseStoneImage;
		[SerializeField]
		private GameObject usePaidStoneImage;
		[SerializeField]
		private UnityEngine.UI.Text[] insufficientTexts;
		[Header]
		[SerializeField]
		public GameObject stonePriceLine;
		public GameObject paidStonePriceLine;
		public GameObject ticketPriceLine;
		[SerializeField]
		private GameObject singleTicketIcon;
		[SerializeField]
		private GameObject multiTicketIcon;
		[SerializeField]
		private GameObject startDashTicketIcon;
		[SerializeField]
		private GameObject dragonSsrTicketIcon;
		[Header]
		[SerializeField]
		public Button cancelButton;
		public Button closeButton;
		public Button stoneButton;
		public Button paidStoneButton;
		public Button ticketsButton;
		public Button tenTicketsButton;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text priceText;
		public UnityEngine.UI.Text selectableText;
		public UnityEngine.UI.Text[] onButtonStonePriceTexts;
		public GameObject insufficientStonePriceGO;
		public GameObject insufficientPaidStonePriceGO;
		public GameObject normalStonePriceGO;
		public GameObject normalPaidStonePriceGO;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text[] ownedCountTexts;
		[SerializeField]
		private UnityEngine.UI.Text[] ownedPaidCountTexts;
		[SerializeField]
		private UnityEngine.UI.Text[] afterCountTexts;
		[SerializeField]
		private GameObject ownedUIBase;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text[] summonCeilingItemTexts;
		[SerializeField]
		private UnityEngine.UI.Text summonExchangeLimit;
		[SerializeField]
		private Transform exchangeSummonIconTrans;
		[SerializeField]
		private GameObject[] exchangeNode;
		[SerializeField]
		private Image summonExchangeDoubleImage;
		[SerializeField]
		private CommonSliderSelection ticketSlider;
		private SummonScene scene;
		private int summonId;
		private SummonTopItemData.ButtonType buttonType;
		private SummonTopItemData itemData;
		private bool isNormalPage;
		private bool isPaidStone;
		private bool isUsingTicket;
		private int multiSingleTicketCount;
		private const int summonCount10 = 10;
	
		// Nested types
		private enum DrawSummonPage
		{
			normalPage = 0,
			stoneSelectPage = 1,
			ticketSelectPage = 2,
			overSummonPointPage = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0
		{
			// Fields
			public Action onFinished;
	
			// Constructors
			public __c__DisplayClass63_0();
	
			// Methods
			internal void _ClosePopup_b__0();
		}
	
		// Constructors
		public DrawSummonPopup();
	
		// Methods
		public static DrawSummonPopup Create(SummonScene scene, SummonTopItemData itemData, SummonTopItemData.ButtonType buttonType);
		public static DrawSummonPopup CreateOverSummonpopup();
		private void SwitchToSelectPage();
		private void SwitchToTicketSelectPage();
		private void SwitcPages(DrawSummonPage pages);
		private void SetupByItemData(SummonTopItemData itemData, SummonTopItemData.ButtonType buttonType);
		public void SetContentOverSummonPoint();
		private void DisplayInsufficientInfo(bool hasEnoughStone, bool hasEnoughPaidStone, bool isSelectable, bool isUsingTicket, int afterCount, int afterPaidCount, bool isExchangeSummon);
		public void SummonPointIcon();
		private void OnStoneOKButtonClicked();
		private void OnTicketOKButtonClicked();
		public void OnOKButtonClicked();
		public void OnStoneOKButtonPressed();
		public void OnPaidStoneOKButtonPressed();
		public void OnCloseButtonClicked();
		public void ClosePopup(Action onFinished = null);
		public void OnValueChanged(float f);
		public void OnMaxValueChange();
		public void OnSummonSingleTicketsButtonPressed();
		public void OnSummonMultiTicketsButtonPressed();
		public void OnSummonPointExchangeButtonPressed();
		[CompilerGenerated]
		private void _OnStoneOKButtonClicked_b__57_0();
		[CompilerGenerated]
		private void _OnTicketOKButtonClicked_b__58_0();
		[CompilerGenerated]
		private void _OnSummonSingleTicketsButtonPressed_b__66_0();
		[CompilerGenerated]
		private void _OnSummonMultiTicketsButtonPressed_b__67_0();
		[CompilerGenerated]
		private void _OnSummonPointExchangeButtonPressed_b__68_0();
	}
}
