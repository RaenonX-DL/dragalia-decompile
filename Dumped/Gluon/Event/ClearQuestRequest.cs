using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ClearQuestRequest : EventBase<ClearQuestRequest>
	{
		[Required]
		[Key(1)]
		public byte[] recordMultiRequest;
	}
}
