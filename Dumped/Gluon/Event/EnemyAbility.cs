using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class EnemyAbility : EventBase<EnemyAbility>
	{
		public enum States
		{
			None,
			Show,
			Hide,
			Rampage,
			PlayDirection,
			CancelGoldenBarrier,
			ChildPlay,
			BookOfGenesis,
			BookOfDoomCount,
			ScapegoatTarget,
			TuningCount,
			TuningSwitch,
			TuningReset,
			PhoenixWallStop,
			BurningCount,
			BurningPlay
		}

		[Key(1)]
		public int dataId;

		[Key(2)]
		public States state;

		[Key(3)]
		public int value;

		[Key(4)]
		public CharacterId target;

		[Key(5)]
		public CharacterId owner;

		[Key(6)]
		public int intParam;

		[Key(7)]
		public string strParam;

		[Key(8)]
		public float[] floatParams;
	}
}
