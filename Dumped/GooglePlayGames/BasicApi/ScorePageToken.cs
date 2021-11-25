namespace GooglePlayGames.BasicApi
{
	public class ScorePageToken
	{
		private string mId;

		private object mInternalObject;

		private LeaderboardCollection mCollection;

		private LeaderboardTimeSpan mTimespan;

		private ScorePageDirection mDirection;

		public LeaderboardCollection Collection => default(LeaderboardCollection);

		public LeaderboardTimeSpan TimeSpan => default(LeaderboardTimeSpan);

		public ScorePageDirection Direction => default(ScorePageDirection);

		public string LeaderboardId => null;

		internal object InternalObject => null;

		internal ScorePageToken(object internalObject, string id, LeaderboardCollection collection, LeaderboardTimeSpan timespan, ScorePageDirection direction)
		{
		}
	}
}
