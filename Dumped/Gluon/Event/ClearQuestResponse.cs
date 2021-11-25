using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ClearQuestResponse : EventBase<ClearQuestResponse>
	{
		[Required]
		[Key(1)]
		public byte[] recordMultiResponse;

		[Required]
		[Key(2)]
		public int clearTime;

		[Key(3)]
		public bool isIgnoreRanking;
	}
}
