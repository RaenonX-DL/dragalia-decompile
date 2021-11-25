using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class DebugInspectionRequest : EventBase<DebugInspectionRequest>
	{
		public enum RequestTypes
		{
			IngameState,
			LeaveReason,
			AutoFailTimeout,
			PlayQuestStartProcTime,
			ChangedCharaOwner,
			AiCheckReport
		}

		[Required]
		[Key(1)]
		public RequestTypes requestType;
	}
}
