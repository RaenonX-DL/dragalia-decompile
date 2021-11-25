using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DreamSelectTicketCell : TableViewCell<DreamSelectTicketCtrl.DreamSelectItemCellData>
	{
		[SerializeField]
		private CommonIcon icon;

		[SerializeField]
		private Text alreadyHadText;

		[SerializeField]
		private Text nameText;

		[SerializeField]
		private Text countText;

		[SerializeField]
		private GameObject summonButtonObj;

		[SerializeField]
		private GameObject[] rarityObjs;

		public Action<GiftType, int> onSummonButtonClick;

		public override void UpdateContent(DreamSelectTicketCtrl.DreamSelectItemCellData itemData)
		{
		}

		private bool IsAlreadyGot()
		{
			return default(bool);
		}

		public void OnSummonButtonClick()
		{
		}
	}
}
