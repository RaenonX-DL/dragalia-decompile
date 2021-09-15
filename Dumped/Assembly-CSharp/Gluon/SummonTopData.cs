/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonTopData
	{
		// Fields
		public List<SummonTopItemData> starlegendSummonItems;
		public List<SummonTopItemData> normalSummonItems;
		public List<SummonTopItemData> charaSsrSummonItems;
		public List<SummonTopItemData> platinumSummonItems;
		public List<SummonTopItemData> dragonSsrSummonItems;
		public List<SummonTopItemData> campaginSsrSummonItems;
		public List<SummonTopItemData> charaSsrUpdateSummonItems;
		public List<SummonTopItemData> dragonSsrUpdateSummonItems;
		public List<SummonTopItemData> excludeSsrSummonItems;
		public List<SummonTopItemData> csStarlegendSummonItems;
		public List<SummonTopItemData> csNormalSummonItems;
		public List<SummonTopItemData> csPlatinumSummonItems;
		public List<SummonTopItemData> csCampaginSsrSummonItems;
		public List<SummonTopItemData> csExcludeSsrSummonItems;
		public SummonTopItemData topItemDataForPointTrade;
		public bool isCSSummonExist;
	
		// Properties
		public int ownedPaidStoneCount { get; }
		public int ownedFreeStoneCount { get; }
		public int ownedSingleTicketCount { get; }
		public int ownedMultiTicketCount { get; }
	
		// Nested types
		public class SwitchableSummonInfo
		{
			// Fields
			public int summonId;
	
			// Constructors
			public SwitchableSummonInfo();
		}
	
		// Constructors
		public SummonTopData();
	
		// Methods
		public void UpdateDataFromResponse();
		public void ClearAllTopItemDataLists();
		public List<SwitchableSummonInfo> CreateCSSummonList(int currentSummonId);
		public void RefreshSummonList();
		public void UpdateDataFromResponse(SummonRequestResponse res);
	}
}
