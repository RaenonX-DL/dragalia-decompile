using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestElementConfirmPopup : CommonPopup
	{
		private const string prefabPath = "Prefabs/OutGame/QuestPrepare/QuestElementConfirmPopup";

		[SerializeField]
		private GameObject lackOfPowerText;

		[SerializeField]
		private Text popupText;

		[SerializeField]
		private Image currentElementIcon;

		[SerializeField]
		private Text currentElementText;

		[SerializeField]
		private LocalizeTextLayoutPadding currentElementTextPadding;

		[SerializeField]
		private Image superiorElementIcon;

		[SerializeField]
		private Text superiorElementText;

		[SerializeField]
		private Toggle noReshowPopupCheckbox;

		private string currentElementStr;

		private const string FormatIconTagText = "{0}";

		private const string FormatIconTagReplaceText = "    ";

		private const string FormatIconTagReplaceText_ZH_TW = "     ";

		public static QuestElementConfirmPopup Create()
		{
			return null;
		}

		public void Initialize(ElementalType superiorElementType, ElementalType currentElementType, bool isLackOfPower, UnityAction cancelCallback, UnityAction okCallaback)
		{
		}

		private new void Start()
		{
		}

		private IEnumerator SetElementTextWithIconImage(string orgStr, Image icon)
		{
			return null;
		}

		private void ApplyReshowSetting()
		{
		}
	}
}
