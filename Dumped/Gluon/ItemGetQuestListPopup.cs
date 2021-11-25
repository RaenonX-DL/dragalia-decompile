using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ItemGetQuestListPopup : CommonPopup
	{
		private const string prefabPath = "Prefabs/OutGame/Item/ItemGetQuestListPopup";

		[SerializeField]
		private QuestDetailList questDetailList;

		[SerializeField]
		private Text helpText;

		private List<QuestCellData> cellDataList;

		public PopupCanvas parentPopupCanvas
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static ItemGetQuestListPopup Create()
		{
			return null;
		}

		public void InitSetting(int[] moveQuests, GiftType giftType, int itemId)
		{
		}

		private void LoadSceneQuestMenu(QuestCellData data)
		{
		}

		private void CreateNoOpenPopup(QuestCellData data)
		{
		}

		private void CreateNoReleasePopup(QuestCellData data)
		{
		}
	}
}
