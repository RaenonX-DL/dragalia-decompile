/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestBonusData
	{
		// Fields
		public const int crystalBonusTotalCounts = 7;
		public const int staminaBonusTotalDays = 30;
		public const int questBonusTotalDays = 7;
		public int remainDays;
		public Status status;
		public long endUnixTime;
	
		// Nested types
		public enum Status
		{
			NotPurchased = 0,
			Claimable = 1,
			Claimed = 2
		}
	
		// Constructors
		public QuestBonusData();
	}
}
