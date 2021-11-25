using System.Collections.Generic;

namespace Gluon
{
	public class MultiPlayErrorEventService
	{
		public class Event
		{
			public enum Types
			{
				DisconnectOtherPlayer,
				DisconnectOwn,
				DisableRanking,
				DisableInstructorBonus
			}

			public Types type;

			public MultiPlayError error;

			public int disconnectedActorId;
		}

		private List<Event> _queue;

		public bool HasEvent()
		{
			return default(bool);
		}

		public void Enqueue(Event e)
		{
		}

		public Event Dequeue()
		{
			return null;
		}

		public bool CanProcessMultiPlayErrorEvent()
		{
			return default(bool);
		}

		public static Event CreateDisconnectOtherPlayerEvent(int disconnectedActorId)
		{
			return null;
		}

		public static Event CreateDisconnectOwnEvent(MultiPlayError error)
		{
			return null;
		}

		public static Event CreateDisableRankingEvent()
		{
			return null;
		}

		public static Event CreateDisableInstructorBonusEvent()
		{
			return null;
		}
	}
}
