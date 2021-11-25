using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestRoomList : TableViewCell<RoomListData>
	{
		[SerializeField]
		private QuestRoomListUI shortRoomUI;

		[SerializeField]
		private QuestRoomListUI longRoomUI;

		[SerializeField]
		private GameObject shortRoot;

		[SerializeField]
		private GameObject longRoot;

		[SerializeField]
		private Text roomPurposeText;

		[SerializeField]
		private Text requirePowerText;

		[SerializeField]
		private Text requirePowerTitle;

		[SerializeField]
		private Image[] enableElementals;

		[SerializeField]
		private GameObject[] enableWeaponRoots;

		[SerializeField]
		private Image[] enableWeaponTypes;

		[SerializeField]
		private GameObject requirePowerRedRoot;

		[SerializeField]
		private Text requirePowerRedText;

		[SerializeField]
		private Text requirePowerRedTitle;

		[SerializeField]
		private Image[] enableElementalRedImages;

		[SerializeField]
		private Image[] enableWeaponTypeRedImages;

		[SerializeField]
		public float shortHeight;

		[SerializeField]
		public float longHeight;

		public UnityAction<int> buttonPressedAction;

		protected QuestDetailInfoPopup detailInfoPopup;

		private const int MAX_MEMBER_NUM = 4;

		private int questId;

		private string questNumberStr;

		private QuestSelectScene.Difficulty difficult;

		private const float eventElementIconYPos = -8f;

		public override void UpdateContent(RoomListData itemData)
		{
		}

		public void SetDisablePress()
		{
		}

		public void OnButtonPressed()
		{
		}

		public void OnDetailButtonPressed()
		{
		}

		protected void OnClickDetailPopupClose()
		{
		}

		public static bool IsPowerFullfilled(int questId, AtgenEntryConditions entryConditions)
		{
			return default(bool);
		}

		public static bool IsElementFullfilled(int questId, bool isLimitedElementalQuest, AtgenEntryConditions entryConditions)
		{
			return default(bool);
		}

		public static bool IsWeaponTypeFullfilled(int questId, AtgenEntryConditions entryConditions)
		{
			return default(bool);
		}
	}
}
