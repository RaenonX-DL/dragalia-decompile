using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class LotteryResultPopup : CommonPopup
	{
		private enum LetterGrade
		{
			First = 1,
			Second,
			Third,
			Fourth,
			Fifth,
			Sixth,
			Seventh
		}

		[SerializeField]
		private ItemListController listController;

		private List<ItemListCellData> cellDataList;

		private const string prefabPath = "Prefabs/OutGame/NEWYEAR2020_LETTER/LetterCampaignResultPopup";

		private readonly Dictionary<LetterGrade, Localize.TextId> LetterGradeTextId;

		private Action onCloseAction;

		public static LotteryResultPopup Create()
		{
			return null;
		}

		public static void RequestAndCreate(int eventId)
		{
		}

		public void InitSetting(AtgenLotteryResultList[] lotteryOddsRateList, [Optional] Action onCloseAction)
		{
		}

		public void SetListData(AtgenLotteryResultList[] lotteryOddsRateList)
		{
		}

		private void CreateItemDetailPopup(ItemListCellData data)
		{
		}

		public void CreateItemUseLimitOverPopup()
		{
		}

		private void AddCaptionCellData(LetterGrade grade, int num)
		{
		}

		private void OnClose()
		{
		}
	}
}
