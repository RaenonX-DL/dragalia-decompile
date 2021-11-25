using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BulletEvent : EventBase<BulletEvent>
	{
		public enum BulletEventTypes : byte
		{
			None,
			HitProcess,
			TargetChanged,
			ShikigamiLevelUp,
			ShikigamiRemove,
			ShikigamiDuration,
			SyncMove
		}

		[Key(1)]
		public BulletEventTypes type;

		[Required]
		[Key(2)]
		public CharacterId character;

		[Key(3)]
		public int bulletId;

		[Key(4)]
		public byte flags;

		[Key(5)]
		public CharacterId target;

		[Key(6)]
		public int level;

		[Key(7)]
		public float duration;

		[Key(8)]
		public BulletEventParamBase param;
	}
}
