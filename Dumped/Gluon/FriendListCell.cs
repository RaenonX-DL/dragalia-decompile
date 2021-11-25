using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FriendListCell : TableViewCell<FriendListCellData>
	{
		[SerializeField]
		private CommonFriendListCell commonFriendListCell;

		[SerializeField]
		private Image newIconImage;

		[SerializeField]
		private Button listOnButtonRightNormal;

		[SerializeField]
		private Button listOnButtonRightBlue;

		[SerializeField]
		private Text listOnButtonRightText;

		[SerializeField]
		private Button listOnButtonLeft;

		[SerializeField]
		private Text listOnButtonLeftText;

		[SerializeField]
		private Button listOnButtonJoin;

		[SerializeField]
		private Text listOnButtonJoinText;

		[SerializeField]
		private Shader exchangeShader;

		private FriendListCellData data;

		public override void UpdateContent(FriendListCellData data)
		{
		}

		public void OnRightButtonPressed()
		{
		}

		public void OnLeftButtonPressed()
		{
		}

		public void OnJoinButtonPressed()
		{
		}
	}
}
