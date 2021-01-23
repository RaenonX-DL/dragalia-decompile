/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingRoomSearchCondition
	{
		// Fields
		[CompilerGenerated]
		private int _QuestId_k__BackingField;
		[CompilerGenerated]
		private int _Priority_k__BackingField;
		[CompilerGenerated]
		private List<MatchingRoomPlayerData> _AllPartyRoomData_k__BackingField;
	
		// Properties
		public int QuestId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int Priority { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<MatchingRoomPlayerData> AllPartyRoomData { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public MatchingRoomSearchCondition();
	
		// Methods
		public void Clear();
		public string ToSql();
		public static string GetSqlFromPartyData(MatchingRoomPlayerData partyData, bool isRaid);
		public static bool IsSameElementalParty(MatchingRoomPlayerData partyData);
		public static RoomEntryCondition GetRoomEntryCondition(RoomList room);
		public static bool CanJoinConditionalRoom(int questId, RoomEntryCondition condition, MatchingRoomPlayerData partyData);
	}
}
