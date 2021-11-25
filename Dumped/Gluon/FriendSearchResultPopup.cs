using UnityEngine;

namespace Gluon
{
	public class FriendSearchResultPopup : CommonPopup
	{
		private const string prefabPath = "Prefabs/OutGame/Friend/Popup/FriendSearchResultPopup";

		[SerializeField]
		private CommonFriendListCell commonFriendListCell;

		public static FriendSearchResultPopup Create()
		{
			return null;
		}

		public void InitSetting()
		{
		}
	}
}
