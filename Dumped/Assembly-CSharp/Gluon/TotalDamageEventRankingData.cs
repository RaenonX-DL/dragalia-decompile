/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TotalDamageEventRankingData
	{
		// Fields
		public bool isRanking;
		public int eventId;
		public RankingInfo[] rankingInfoList;
		private static readonly int rankingTopShowCount;
	
		// Nested types
		public class RankingInfo
		{
			// Fields
			public int rank;
			public bool isNew;
			public long damageValue;
			public int charaId;
			public int charaRarity;
			public int charaLevel;
			public int charaMaxLevel;
	
			// Constructors
			public RankingInfo();
		}
	
		// Constructors
		public TotalDamageEventRankingData();
		static TotalDamageEventRankingData();
	
		// Methods
		public void Load();
	}
}
