using System.Collections.Generic;
using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ChangeAbnormalStatus : EventBase<ChangeAbnormalStatus>
	{
		[Required]
		[Key(1)]
		public CharacterId character;

		[Required]
		[Key(2)]
		public List<AbnormalStatusSyncData> abnormalStatus;

		[Key(3)]
		public byte[] dummy;

		[Key(4)]
		public short[] abnormalResists;
	}
}
