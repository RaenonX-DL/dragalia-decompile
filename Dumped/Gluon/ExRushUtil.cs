namespace Gluon
{
	public static class ExRushUtil
	{
		public enum ExRushTopCharaTalkHintMessageCategory1
		{
			FriendShip = 1,
			End
		}

		public enum ExRushCharaTalkCategory0
		{
			Result = 1,
			HintMessage,
			QuestDescription
		}

		public enum ExRushCharaTalkResultCategory1
		{
			Friendship = 1,
			Max
		}

		public enum ExRushCharaTalkCategory1
		{
			FriendShip = 1,
			Reward,
			End,
			BeforeJoin
		}

		public static int GetExRushEventItemValue(int eventItemId)
		{
			return default(int);
		}

		public static int GetExRushEventItemValueByType(ExRushEventItemType type)
		{
			return default(int);
		}

		public static string GetHintMessage()
		{
			return null;
		}
	}
}
