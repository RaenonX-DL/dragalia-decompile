namespace Gluon
{
	public class MyPageMapAnimations
	{
		public enum Motion
		{
			None = 0,
			Walk = 1,
			WalkQuiet = 21,
			Stand = 3,
			StandTalk = 4,
			StandBye = 5,
			StandByeQuiet = 14,
			Sit = 6,
			SitQuiet = 10,
			SitTalk = 7,
			SitTalkQuiet = 17,
			SitDrink = 0x10,
			SitDrinkQuiet = 0xF,
			SitKnee = 20,
			SitKneeQuiet = 18,
			Run = 19,
			RunQuiet = 22,
			Training1 = 99,
			Master = 100,
			Event_1 = 101,
			Event_2 = 102,
			Event_3 = 103,
			Event_4 = 104,
			Event_5 = 105,
			Event_6 = 106,
			Event_7 = 107,
			Event_8 = 108,
			Event_9 = 109,
			Event_10 = 110,
			Event_11 = 111,
			Event_12 = 112
		}

		public static Motion ConvertByPersonMotionType(Motion motion, int personMotionType)
		{
			return default(Motion);
		}

		public static Motion GetByString(string motionName)
		{
			return default(Motion);
		}
	}
}
