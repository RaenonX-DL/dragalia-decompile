using UnityEngine;

namespace Gluon
{
	public class QuestEventShortCutButton : MonoBehaviour
	{
		public enum QuestEventShortCutType
		{
			ExpQuest,
			MoneyQuest,
			RemainsQuest,
			DragonQuest,
			EmpireQuest
		}

		[SerializeField]
		private QuestEventShortCutType shortCutType;

		private const int firstReleaseQuest = 1000202;

		private const int secondReleaseQuest = 1000311;

		private const int thirdReleaseQuest = 1000607;

		private const int moneyQuestGroupId = 20206;

		private const int expQuestGroupId = 20101;

		private const int remainsQuestGroupId = 20201;

		private const int dragonQuestGroupId = 20301;

		private const int empireQuestGroupId = 21101;

		private const int expQuestEventId = 20101;

		private const int moneyQuestEventId = 20206;

		private const int remainsQuestEventId = 20200;

		private const int dragonQuestEventId = 20300;

		private const int empireQuestEventId = 21100;

		private void Awake()
		{
		}

		public void OnShortCutButton()
		{
		}

		public static QuestEventShortCutType GetShortCutType(int eventId)
		{
			return default(QuestEventShortCutType);
		}

		public void SetEnabled(bool isEnabled)
		{
		}
	}
}
