/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageMapAnimations
	{
		// Nested types
		public enum Motion
		{
			None = 0,
			Walk = 1,
			Stand = 3,
			StandTalk = 4,
			StandBye = 5,
			Sit = 6,
			SitTalk = 7,
			SitQuiet = 10,
			StandByeQuiet = 14,
			SitDrinkQuiet = 15,
			SitDrink = 16,
			SitTalkQuiet = 17,
			SitKneeQuiet = 18,
			Run = 19,
			SitKnee = 20,
			WalkQuiet = 21,
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
	
		// Constructors
		public MyPageMapAnimations();
	
		// Methods
		public static Motion ConvertByPersonMotionType(Motion motion, int personMotionType);
		public static Motion GetByString(string motionName);
	}
}
