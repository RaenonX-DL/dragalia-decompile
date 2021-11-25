using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ExcludeSummonCell : TableViewCell<ExcludeSummonCellData>
	{
		[SerializeField]
		private Transform unitIconTrans;

		[SerializeField]
		private Text unitNameText;

		[SerializeField]
		private Text detailText;

		[SerializeField]
		public Toggle excludeToggle;

		[SerializeField]
		public PointerEventHandler pointerToggle;

		[SerializeField]
		public CheckBoxAnimation checkBoxAnimation;

		private ExcludeSummonCellData excludeSummonCellData;

		public override void UpdateContent(ExcludeSummonCellData itemData)
		{
		}

		public void UpdateToggle()
		{
		}

		public void UnitGetButtonSetting(bool isSetting)
		{
		}

		public void OnUnitGetButtonSetting()
		{
		}
	}
}
