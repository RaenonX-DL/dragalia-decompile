/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TimeAttackRanking
	{
		// Fields
		public bool isRanking;
		public int eventId;
		public RankingInfo[] rankingInfoList;
	
		// Nested types
		public class RankingInfo
		{
			// Fields
			public int rank;
			public bool isNew;
			public int eventId;
			public ulong viewerId;
			public int questId;
			public int clearTime;
			public int startTime;
			public int endTime;
			public string partyHash;
			public PartyInfo[] partyInfoList;
	
			// Constructors
			public RankingInfo();
		}
	
		public class PartyInfo
		{
			// Fields
			public ulong viewerId;
			public int charaId;
			public int charaRarity;
			public int charaLevel;
	
			// Constructors
			public PartyInfo();
		}
	
		// Constructors
		public TimeAttackRanking();
	
		// Methods
		public void Load();
	}
}
