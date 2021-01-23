/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventRankingListCellData
	{
		// Fields
		public int rank;
		public int clearTime;
		public List<RankingPartyMemberInfo> rankingMemberList;
	
		// Nested types
		public class RankingPartyMemberInfo
		{
			// Fields
			public int userId;
			public string name;
			public int level;
			public int emblemId;
			public int charaId;
			public int charaLevel;
			public ulong dragonId;
			public ulong weaponId;
	
			// Constructors
			public RankingPartyMemberInfo(int userId, string name, int level, int emblemId, int charaId, int charaLevel);
		}
	
		// Constructors
		public EventRankingListCellData();
	}
}
