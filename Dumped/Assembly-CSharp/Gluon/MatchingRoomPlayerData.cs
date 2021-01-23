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
	public class MatchingRoomPlayerData
	{
		// Fields
		public string playerName;
		public int playerAnotherNameId;
		public int partySlot;
		public MatchingRoomDetailData[] detailData;
		public int teamPower;
		public ulong viewerId;
		public List<RaidBoostSyncData> raidBoostSyncDatas;
	
		// Nested types
		public struct RaidBoostSyncData
		{
			// Fields
			public int masterId;
			public int progress;
	
			// Constructors
			public RaidBoostSyncData(int masterId, int progress);
		}
	
		// Constructors
		public MatchingRoomPlayerData();
	
		// Methods
		public void CopyFromData(MatchingRoomPlayerData data);
	}
}
