using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RetryVoteEvent : EventBase<RetryVoteEvent>
	{
		public enum RetryVoteEventTypes : byte
		{
			ChangeVoteState,
			GoToRetry,
			SetIsLastVote,
			GoToContinueImpossible,
			LostStartVoteRight
		}

		[Key(1)]
		public RetryVoteEventTypes type;

		[Key(2)]
		public int value;
	}
}
