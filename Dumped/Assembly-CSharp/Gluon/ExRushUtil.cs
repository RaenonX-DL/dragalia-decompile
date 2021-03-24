/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class ExRushUtil
	{
		// Fields
		public const int rushCharaMasterId = 10750102;
		public const int rushDragonMasterId = 29900003;
	
		// Nested types
		public enum ExRushTopCharaTalkHintMessageCategory1
		{
			FriendShip = 1,
			End = 2
		}
	
		public enum ExRushCharaTalkCategory0
		{
			Result = 1,
			HintMessage = 2,
			QuestDescription = 3
		}
	
		public enum ExRushCharaTalkResultCategory1
		{
			Friendship = 1,
			Max = 2
		}
	
		public enum ExRushCharaTalkCategory1
		{
			FriendShip = 1,
			Reward = 2,
			End = 3,
			BeforeJoin = 4
		}
	
		// Methods
		public static int GetExRushEventItemValue(int eventItemId);
		public static int GetExRushEventItemValueByType(ExRushEventItemType type);
		public static string GetHintMessage();
		public static void EnableRushArm(GameObject go, bool enable = true);
	}
}
