using Gluon.Master;

namespace Gluon
{
	public static class CollectEventUtil
	{
		public enum EventStoryGroupType
		{
			Normal = 1,
			UnlockByEventStory,
			EventStory
		}

		public static bool IsEventMenuGroupDummyQuest(QuestEventMenuElement questEventMenuElement)
		{
			return default(bool);
		}

		public static int GetCollectToalReleaseEventStoryCount(int eventId)
		{
			return default(int);
		}

		public static QuestUtil.QuestState IsCollectEventAllReadStory(int eventId)
		{
			return default(QuestUtil.QuestState);
		}
	}
}
