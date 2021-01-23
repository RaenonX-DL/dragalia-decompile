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
	public class SummonPrizeOddsTableViewController : TableViewController<Gluon.SummonPrizeOddsTableViewData>
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
		public SummonPrizeOddsPopupOverallTotalBlock[] normalOverallTotal;
		public SummonPrizeOddsPopupOverallTotalBlock[] guaranteedOverallTotal;
	
		// Constructors
		public SummonPrizeOddsTableViewController();
	
		// Methods
		protected override void Awake();
		protected override float GetCellHeightAtIndex(int index);
		public void ReloadByData(List<SummonPrizeOddsTableViewData> data);
		public void SetTopPadding(float height);
		public void SetupTotalBlocks(SummonPrizeOddsRateList oddsRate);
	}
}
