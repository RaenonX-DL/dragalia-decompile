/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CampaignListPopup : CommonPopup
	{
		// Fields
		public CampaignListController listController;
		private List<CampaignCellData> cellDataList;
		private List<TmpListData> tmpList;
	
		// Nested types
		private class TmpListData
		{
			// Fields
			public CampaignType type;
			public int questGroupId;
	
			// Constructors
			public TmpListData(CampaignType type, int questGroupId);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<CampaignCellData> __9__6_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _Start_b__6_0(CampaignCellData a, CampaignCellData b);
		}
	
		// Constructors
		public CampaignListPopup();
	
		// Methods
		public static CampaignListPopup CreateCampaignListPopup();
		protected override void Awake();
		protected override void Start();
	}
}
