using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QRFriendApplyCell : MonoBehaviour
	{
		[SerializeField]
		public Transform movingPart;

		public CommonFriendListCell cell;

		public GameObject alreadyFriendLabel;

		public Button applyButton;

		private QuestResultModel.FriendApplyModel.SingleFriendApplyInfo info;

		public static QRFriendApplyCell Create(QuestResultModel.FriendApplyModel.SingleFriendApplyInfo info, Transform parent, GameObject originCell)
		{
			return null;
		}

		private void Start()
		{
		}

		public void OnApplyPressed()
		{
		}

		private void OnClose(bool onClose)
		{
		}

		public void SetUnitDetailModelOnCreated(UnityAction onCreated)
		{
		}

		public void SetUnitDetailModelBackButtonOnClick(UnityAction onCreated)
		{
		}
	}
}
