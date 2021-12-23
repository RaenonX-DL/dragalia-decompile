using UnityEngine;

namespace Gluon
{
	public class DmodeServitorPassiveListPopup : PopupBase
	{
		[SerializeField]
		private DmodeServitorPassiveListPopupListController ctrl;

		public const string prefabPath = "Prefabs/OutGame/Dmode/DmodeServitor/DmodeServitorPassiveListPopup";

		public static DmodeServitorPassiveListPopup Create()
		{
			return null;
		}

		protected void SetContent()
		{
		}
	}
}
