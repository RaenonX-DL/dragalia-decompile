using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class DebugInspectionResponse : EventBase<DebugInspectionResponse>
	{
		[Required]
		[Key(1)]
		public DebugInspectionRequest.RequestTypes requestType;

		[Required]
		[Key(2)]
		public string report;
	}
}
