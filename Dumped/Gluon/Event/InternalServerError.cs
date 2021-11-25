using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class InternalServerError : EventBase<InternalServerError>
	{
		[Key(1)]
		public bool isAppError;

		[Key(2)]
		public int resultCode;

		[Key(3)]
		public string debugMessage;
	}
}
