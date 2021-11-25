using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class AbilitySyncData
	{
		[Key(0)]
		public ushort requireCnt;

		[Key(1)]
		public ushort activateNum;

		[Key(2)]
		public ushort expireCnt;

		[Key(3)]
		public bool isChanged;

		[Key(4)]
		public bool triggerCoolTime;

		[Key(5)]
		public float coolTime;
	}
}
