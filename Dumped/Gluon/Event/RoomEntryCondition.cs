using System.Collections.Generic;
using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RoomEntryCondition
	{
		[MessagePackObject(false)]
		public struct Objective
		{
			[Key(0)]
			public int textId;

			public static Objective GetEmptyObjective()
			{
				return default(Objective);
			}

			public bool IsEmpty()
			{
				return default(bool);
			}
		}

		[Key(0)]
		public HashSet<ElementalType> unacceptedElementals;

		[Key(1)]
		public HashSet<WeaponType> unacceptedWeapons;

		[Key(2)]
		public int requiredPower;

		[Key(3)]
		public Objective objective;

		public RoomEntryCondition()
		{
		}

		public RoomEntryCondition(RoomEntryCondition c)
		{
		}

		public static RoomEntryCondition Anyone()
		{
			return null;
		}
	}
}
