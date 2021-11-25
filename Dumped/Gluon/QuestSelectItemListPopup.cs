using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSelectItemListPopup : PopupBase
	{
		[SerializeField]
		private QuestSelectItemListController itemListCtrl;

		[SerializeField]
		private Text resetText;

		public MaterialType materialType;

		private List<ItemListCellData> cellDataList;

		private const string prefabPath = "Prefabs/OutGame/QuestSelect/Popup/QuestSelectItemListPopup";

		public static QuestSelectItemListPopup Create()
		{
			return null;
		}

		public void InitContent()
		{
		}

		private void CreateItemDetailPopup(ItemListCellData data)
		{
		}
	}
}
