using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class RecoverStaminaMultiItemListController : TableViewController<RecoverStaminaMultiItemData>
	{
		[SerializeField]
		[Header("Control")]
		public RecoverStaminaMultipleItemConfirmPopup popup;

		private float cellWidth;

		private float cellHeight;

		protected override void Awake()
		{
		}

		public void LoadData(List<RecoverStaminaMultiItemData> data)
		{
		}

		protected override TableViewCell<RecoverStaminaMultiItemData> CreateCellForIndex(int index)
		{
			return null;
		}

		public bool IsAnyItemSelectable(out bool isAnySliderAvailable)
		{
			return default(bool);
		}

		public void OnAnySliderValueChanged(int diffVal)
		{
		}

		public EntityData[] GetSelectedItems()
		{
			return null;
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected override float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}
	}
}
