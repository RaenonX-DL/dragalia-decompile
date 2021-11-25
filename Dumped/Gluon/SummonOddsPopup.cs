using System.Collections;
using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class SummonOddsPopup : CommonPopup
	{
		[SerializeField]
		[Header("Tab")]
		public TabBase tabController;

		public TabBase tabControllerWithPrize;

		[SerializeField]
		[Header("Positions")]
		public Transform normalTableViewParent;

		public Transform guaranteedTableViewParent;

		public Transform prizeTableViewParent;

		[SerializeField]
		[Header("ContentAlpha")]
		public CanvasGroup contentAlphaGroup;

		[SerializeField]
		[Header("SingleView")]
		public GameObject tabParent;

		public RectTransform contentRect;

		private const float singleViewContentRectTop = -2f;

		private List<SummonOddsTableViewData> sortedNormalData;

		private List<SummonOddsTableViewData> sortedGuaranteedData;

		private List<SummonPrizeOddsTableViewData> sortedPrizeData;

		private OddsRateList oddsData;

		private SummonPrizeOddsRateList prizeData;

		private RedoableSummonOddsRateList redoableSummonoddsData;

		private SummonOddsTableViewController normalTableView;

		private SummonOddsTableViewController guaranteedTableView;

		private SummonPrizeOddsTableViewController prizeTableView;

		private const float listSpaceOffset = 16f;

		private bool isTutorialSummon;

		private SummonType summonType;

		private bool isExcludeSelected;

		public static SummonOddsPopup Create(Canvas uiCanvas, OddsRateList oddsData, SummonType summonType)
		{
			return null;
		}

		public static SummonOddsPopup Create(Canvas uiCanvas, RedoableSummonOddsRateList oddsData, SummonType summonType)
		{
			return null;
		}

		public static SummonOddsPopup CreateWithPrize(Canvas uiCanvas, OddsRateList oddsData, SummonPrizeOddsRateList prizeData, SummonType summonType, bool isExcludeSelected = false)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private void InitTableViews()
		{
		}

		private void InitTableViewWithPrize()
		{
		}

		private IEnumerator LateSetLayout()
		{
			return null;
		}

		private void SetupByOddsData(OddsRateList oddsData, SummonType summonType)
		{
		}

		private void SetupByOddsData(OddsRateList oddsData, SummonPrizeOddsRateList prizeData, SummonType summonType)
		{
		}

		private void SetupByOddsData(RedoableSummonOddsRateList oddsData, SummonType summonType)
		{
		}

		private void SetupByItemData(OddsRate oddsData, bool isNormal)
		{
		}

		private void SetupByPrizeData(SummonPrizeOddsRateList prizeData)
		{
		}

		private void SetupBunch(OddsUnitDetail[] odds, Rarity rarity, bool isNormal, string countTemplate, GiftType giftType)
		{
		}

		public void OnCloseButtonClicked()
		{
		}

		public void ClosePopup()
		{
		}
	}
}
