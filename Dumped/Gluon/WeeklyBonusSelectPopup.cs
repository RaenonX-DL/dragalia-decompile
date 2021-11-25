using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class WeeklyBonusSelectPopup : PopupBase
	{
		public CommonIcon icon;

		public GameObject prevWeekWarningGO;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text bodyText;

		[SerializeField]
		private Text warningText;

		private const string prefabPath = "Prefabs/OutGame/QuestResult/Popup/WeeklyBonusSelectPopup";

		private const string multiplePrefabPath = "Prefabs/OutGame/QuestResult/Popup/WeeklyBonusMultipleSelectPopup";

		protected int count;

		private int eventId;

		private int bonusReserveTime;

		private QuestResetIntervalType bonusResetType;

		public static WeeklyBonusSelectPopup Create(int count, int eventId, int bonusReserveTime, QuestResetIntervalType bonusResetType)
		{
			return null;
		}

		protected override void Start()
		{
		}

		protected virtual int GetReceiveCount()
		{
			return default(int);
		}

		public void OnRedeemButtonPressed()
		{
		}

		public void OnCancelButtonPressed()
		{
		}
	}
}
