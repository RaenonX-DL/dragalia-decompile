using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class WarpEvent : EventBase<WarpEvent>
	{
		public enum WarpEventTypes : byte
		{
			LockRequest,
			UnlockRequest,
			Lock,
			Unlock
		}

		[Key(1)]
		public WarpEventTypes type;

		[Key(2)]
		public int roomGroup;

		[Key(3)]
		public int doorKind;

		[Key(4)]
		public bool checkIsDead;

		[Key(5)]
		public bool isForceReturn;

		[Key(6)]
		public int lockActorId;

		[Key(7)]
		public CharacterId lockMultiPlayId;

		[Key(8)]
		public bool isSuccess;
	}
}
