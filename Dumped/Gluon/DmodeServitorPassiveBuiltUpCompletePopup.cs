using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeServitorPassiveBuiltUpCompletePopup : PopupBase
	{
		[SerializeField]
		private CommonIcon commonIcon;

		[SerializeField]
		private Text beforeText;

		[SerializeField]
		private Text afterText;

		public const string prefabPath = "Prefabs/OutGame/Dmode/DmodeServitor/DmodeServitorPassiveBuiltUpCompletePopup";

		private DmodeServitorPassiveLevelElement beforePassiveLevelElement;

		private DmodeServitorPassiveLevelElement afterPassiveLevelElement;

		public static DmodeServitorPassiveBuiltUpCompletePopup Create(DmodeServitorPassiveLevelElement beforeElement, DmodeServitorPassiveLevelElement afterElement)
		{
			return null;
		}

		public void SetContent(DmodeServitorPassiveLevelElement beforeElement, DmodeServitorPassiveLevelElement afterElement)
		{
		}

		public void OnPassiveLevelComplete()
		{
		}

		public void OnAbilityIcon()
		{
		}
	}
}
