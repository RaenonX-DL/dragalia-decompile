using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SummonOddsTableViewController : TableViewController<SummonOddsTableViewData>
	{
		[SerializeField]
		[Header("TypeText")]
		public Text topText;

		public Text bottomText;

		public GameObject topPart;

		[SerializeField]
		[Header("TopContents")]
		public RectTransform verticalLayout;

		[SerializeField]
		[Header("TotalBlocks")]
		public GameObject totalBlocksLabel;

		public SummonOddsPopupOverallTotalBlock ssrOverallTotal;

		public SummonOddsPopupOverallTotalBlock srOverallTotal;

		public SummonOddsPopupOverallTotalBlock rOverallTotal;

		public SummonOddsPopupTotalBlock ssrBlock;

		public SummonOddsPopupTotalBlock srBlock;

		public SummonOddsPopupTotalBlock rBlock;

		public SummonOddsPopupTotalBlock ssrPickupBlock;

		public SummonOddsPopupTotalBlock srPickupBlock;

		public SummonOddsPopupTotalBlock rPickupBlock;

		[SerializeField]
		[Header("RateUp")]
		public Text nextRateUpText;

		public GameObject rateUpParent;

		public GameObject oddsListLabel;

		private const int rareIndex = 3;

		private const int srareIndex = 4;

		private const int ssrareIndex = 5;

		protected override void Awake()
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		public void ReloadByData(List<SummonOddsTableViewData> data)
		{
		}

		public void SetTopPadding(float height)
		{
		}

		public void SetBottomPadding(float height)
		{
		}

		public void SetupTotalBlocks(OddsRate oddsRate)
		{
		}

		public void SetRateUp(int nextCount, SummonType summonType)
		{
		}
	}
}
