using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RecoverStaminaMultiItemListCell : TableViewCell<RecoverStaminaMultiItemData>
	{
		[SerializeField]
		[Header("Contents")]
		public CommonIcon icon;

		public Text itemName;

		public CommonSliderSelection slider;

		[HideInInspector]
		public RecoverStaminaMultiItemListController controller;

		private void Start()
		{
		}

		public void OnSliderValueChanged(float val)
		{
		}

		public override void UpdateContent(RecoverStaminaMultiItemData itemData)
		{
		}

		private void LateUpdate()
		{
		}
	}
}
