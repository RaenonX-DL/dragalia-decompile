using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class NameInfoPopup : CommonPopup
	{
		[SerializeField]
		private Image selectNameRarity;

		[SerializeField]
		private Text selectName;

		[SerializeField]
		private Text selectNameRuby;

		[SerializeField]
		private Text conditionTitle;

		[SerializeField]
		private Text notObtainedText;

		[SerializeField]
		private GameObject nameBaseObj;

		[SerializeField]
		private Text ConditionText;

		private static readonly string popupPath;

		public static NameInfoPopup Create(AnotherNameCellData data, bool showBlackLayer)
		{
			return null;
		}

		private void SetPopup(AnotherNameCellData data)
		{
		}
	}
}
