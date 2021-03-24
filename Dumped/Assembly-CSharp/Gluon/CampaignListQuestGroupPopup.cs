/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CampaignListQuestGroupPopup : CommonPopup
	{
		// Fields
		public CampaignListController listController;
		private List<CampaignCellData> cellDataList;
		private List<CampaignDataWrapper> campaignDataList;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<CampaignCellData> __9__5_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _Start_b__5_0(CampaignCellData a, CampaignCellData b);
		}
	
		// Constructors
		public CampaignListQuestGroupPopup();
	
		// Methods
		public static CampaignListQuestGroupPopup CreateCampaignListPopup(List<CampaignDataWrapper> grogroup);
		protected override void Awake();
		protected override void Start();
	}
}
