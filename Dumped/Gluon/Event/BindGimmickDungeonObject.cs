using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BindGimmickDungeonObject : DungeonObjectParameterBase
	{
		public enum BindGimmickEventType : byte
		{
			StartAction,
			Fire,
			CtrlBind
		}

		[Key(0)]
		public BindGimmickEventType type;

		[Key(1)]
		public long bindEventId;

		[Key(2)]
		public BindEvent ctrlBindData;
	}
}
