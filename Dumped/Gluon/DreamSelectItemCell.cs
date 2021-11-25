using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DreamSelectItemCell : TableViewCell<DreamSelectItemCtrl.DreamSelectItemCellData>
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
		private GameObject buyButtonObj;

		[SerializeField]
		private GameObject[] rarityObjs;

		public override void UpdateContent(DreamSelectItemCtrl.DreamSelectItemCellData itemData)
		{
		}

		private bool IsAlreadyGot()
		{
			return default(bool);
		}

		public void OnPurchaseButtonTouched()
		{
		}
	}
}
