namespace Gluon
{
	public class QuestBonusData
	{
		public enum Status
		{
			NotPurchased,
			Claimable,
			Claimed
		}

		public const int crystalBonusTotalCounts = 7;

		public const int staminaBonusTotalDays = 30;

		public const int questBonusTotalDays = 7;

		public int remainDays;

		public Status status;

		public long endUnixTime;
	}
}
