using System.Collections.Generic;
using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RebornEvent : EventBase<RebornEvent>
	{
		public enum RebornEventTypes : byte
		{
			Wait,
			Reborn
		}

		[Key(1)]
		public RebornEventTypes type;

		[Key(2)]
		public List<CharacterId> targetCharas;

		[Key(3)]
		public List<float> rebornHpRatios;

		[Key(4)]
		public bool isAbilityReborn;
	}
}
