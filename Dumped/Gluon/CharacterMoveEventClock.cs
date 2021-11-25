namespace Gluon
{
	public class CharacterMoveEventClock
	{
		public class Timestamp
		{
			public static readonly int MaxSequenceNum;

			public int actorId;

			public int sequenceNum;

			public Timestamp(Timestamp ts)
			{
			}

			public Timestamp(int actorId, int sequenceNum)
			{
			}

			public static int Serialize(Timestamp ts)
			{
				return default(int);
			}

			public static Timestamp Deserialize(int value)
			{
				return null;
			}

			public bool IsHappenedBefore(Timestamp ts)
			{
				return default(bool);
			}
		}

		private CharacterBase _owner;

		private int _nextOwnSequenceNum;

		private Timestamp _current;

		public Timestamp current => null;

		public Timestamp Advance()
		{
			return null;
		}

		public void SetTimestamp(Timestamp ts)
		{
		}

		public bool IsHappenedBefore(Timestamp ts)
		{
			return default(bool);
		}

		private int GetOwnActorId()
		{
			return default(int);
		}
	}
}
