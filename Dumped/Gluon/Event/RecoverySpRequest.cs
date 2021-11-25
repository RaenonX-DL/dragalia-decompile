using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RecoverySpRequest : EventBase<RecoverySpRequest>
	{
		[Key(1)]
		public CharacterId character;

		[Key(2)]
		public float healRatio;

		[Key(3)]
		public int healSkillIndex;

		[Key(4)]
		public bool isHumanOnly;

		[Key(5)]
		public int healValue;

		[Key(6)]
		public bool isDragonOnly;
	}
}
