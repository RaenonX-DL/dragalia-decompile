using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class DispBuffCaptionEvent : EventBase<DispBuffCaptionEvent>
	{
		[Required]
		[Key(1)]
		public CharacterId sender;

		[Key(2)]
		public int type;

		[Key(3)]
		public string iconName;

		[Key(4)]
		public float rate;

		[Key(5)]
		public string text;

		[Key(6)]
		public int iconType;

		[Key(7)]
		public bool isDisplayCheck;

		[Key(8)]
		public int conditionId;
	}
}
