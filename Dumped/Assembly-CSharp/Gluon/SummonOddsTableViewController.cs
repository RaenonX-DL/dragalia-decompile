/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonOddsTableViewController : TableViewController<Gluon.SummonOddsTableViewData>
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text topText;
		public GameObject topPart;
		[Header]
		[SerializeField]
		public RectTransform verticalLayout;
		[Header]
		[SerializeField]
		public SummonOddsPopupOverallTotalBlock ssrOverallTotal;
		public SummonOddsPopupOverallTotalBlock srOverallTotal;
		public SummonOddsPopupOverallTotalBlock rOverallTotal;
		public SummonOddsPopupTotalBlock ssrBlock;
		public SummonOddsPopupTotalBlock srBlock;
		public SummonOddsPopupTotalBlock rBlock;
		public SummonOddsPopupTotalBlock ssrPickupBlock;
		public SummonOddsPopupTotalBlock srPickupBlock;
		public SummonOddsPopupTotalBlock rPickupBlock;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text nextRateUpText;
		public GameObject rateUpParent;
		private const int rareIndex = 3;
		private const int srareIndex = 4;
		private const int ssrareIndex = 5;
	
		// Constructors
		public SummonOddsTableViewController();
	
		// Methods
		protected override void Awake();
		protected override float GetCellHeightAtIndex(int index);
		public void ReloadByData(List<SummonOddsTableViewData> data);
		public void SetTopPadding(float height);
		public void SetupTotalBlocks(OddsRate oddsRate);
		public void SetRateUp(int nextCount, SummonType summonType);
	}
}
