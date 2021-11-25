using Gluon.Http;
using UnityEngine.Events;

namespace Gluon
{
	public class FriendListCellData
	{
		public UserSupportList friendData;

		public FriendModel.PanelType type;

		public UnityAction<FriendListCellData> rightButtonPressedCallback;

		public UnityAction<FriendListCellData> leftButtonPressedCallback;

		public UnityAction<FriendListCellData> joinButtonPressedCallback;

		public CommonFriendListCellData GetCommonData()
		{
			return null;
		}
	}
}
