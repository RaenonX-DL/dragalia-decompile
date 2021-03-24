/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LotteryResultPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private ItemListController listController;
		private List<ItemListCellData> cellDataList;
		private const string prefabPath = "Prefabs/OutGame/NEWYEAR2020_LETTER/LetterCampaignResultPopup";
		private readonly Dictionary<LetterGrade, Localize.TextId> LetterGradeTextId;
		private Action onCloseAction;
	
		// Nested types
		private enum LetterGrade
		{
			First = 1,
			Second = 2,
			Third = 3,
			Fourth = 4,
			Fifth = 5,
			Sixth = 6,
			Seventh = 7
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public int eventId;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _RequestAndCreate_b__0(LotteryResultResponse res);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<AtgenLotteryResultList> __9__9_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _SetListData_b__9_0(AtgenLotteryResultList a, AtgenLotteryResultList b);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public CommonPopup errorPopup;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _CreateItemUseLimitOverPopup_b__0();
		}
	
		// Constructors
		public LotteryResultPopup();
	
		// Methods
		public static LotteryResultPopup Create();
		public static void RequestAndCreate(int eventId);
		public void InitSetting(AtgenLotteryResultList[] lotteryOddsRateList, Action onCloseAction = null);
		public void SetListData(AtgenLotteryResultList[] lotteryOddsRateList);
		private void CreateItemDetailPopup(ItemListCellData data);
		public void CreateItemUseLimitOverPopup();
		private void AddCaptionCellData(LetterGrade grade, int num);
		private void OnClose();
	}
}
