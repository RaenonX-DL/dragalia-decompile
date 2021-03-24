/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Mission.ListView;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopCommonMissionIcon : MissionTableViewCell
	{
		// Fields
		private MissionTableViewData data;
		private static List<MissionTableViewData> specialMissionDataList;
		public Action<MissionTableViewData> onChallengeButtonCallback;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public Action onDone;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _LoadAllSpecialMissions_b__0();
		}
	
		// Constructors
		public ShopCommonMissionIcon();
	
		// Methods
		public static void LoadAllSpecialMissions(Action onDone);
		public void SetupByShopContentData(ShopTradeProductData.CommonShopItemContentData contentData);
		public void OnIconPressed();
		private void OpenDetailPopup();
		[CompilerGenerated]
		private void _OpenDetailPopup_b__6_0();
	}
}
