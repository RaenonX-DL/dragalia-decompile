using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class AnotherNameCell : TableViewCell<AnotherNameCellData>
	{
		public Image rarityIcon;

		public Text rubyText;

		public Text nameText;

		public Image newIcon;

		public Image selectIcon;

		public Text notObtainedText;

		[SerializeField]
		public UnityAction<int> buttonPressed;

		public override void UpdateContent(AnotherNameCellData data)
		{
		}

		public void OnButtonPressed()
		{
		}
	}
}
