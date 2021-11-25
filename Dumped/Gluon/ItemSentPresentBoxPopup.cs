using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ItemSentPresentBoxPopup : PopupBase
	{
		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text descriptionText;

		[SerializeField]
		private ItemSentPresentBoxCtrl cellController;

		private static string puPrefabPath;

		public static ItemSentPresentBoxPopup Create()
		{
			return null;
		}

		public void SetText(string title, string description)
		{
		}

		public void SetContent(List<ItemSentPresentBoxCellData> itemDataList)
		{
		}
	}
}
