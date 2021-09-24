/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class MultiPlayConst
	{
		// Fields
		public const int BattleTime = 180;
		public const int PreBattleTime = 0;
		public const int PointForWin = 10;
		public const float RespawnRadius = 5f;
		public const int CurrentMatchingCompatibleId = 29;
		public const int DefaultMatchingCompatibleId = 1;
		public const int powerSliderScale = 100;
		public const string prefsKeyIsAutoCreateRoom = "Multiplay/isAutoCreateRoom";
		public const string prefsKeyGpsLocationUseCheck = "Multiplay/gpsLocationCheck";
		public const string prefsKeyMatchCreateRequirePower = "Multiplay/matchConditionCreateRequirePower";
		public const string prefsKeyMatchSearchRequirePower = "Multiplay/matchConditionSearchRequirePower";
		public const string prefsKeyMatchCreateRequirePowerRaid = "Multiplay/matchConditionCreateRequirePowerRaid";
		public const string prefsKeyMatchSearchRequirePowerRaid = "Multiplay/matchConditionSearchRequirePowerRaid";
		public const string prefsKeyIsSkipCuttCheck = "Multiplay/isSkipRaidCutt/";
	
		// Nested types
		public static class MatchingKey
		{
			// Fields
			public const string QuestId = "C0";
			public const string EventSerializer = "C1";
			public const string AutoJoinEnabled = "C2";
			public const string AutoJoinPriority = "C3";
			public const string RoomEntryConditionAttributes = "C4";
			public const string RoomEntryConditionRequiredPower = "C5";
			public const string ChannelId = "C6";
		}
	
		public static class RoomPropertyKey
		{
			// Fields
			public const string MatchingType = "MatchingType";
			public const string InitialMatchingType = "InitialMatchingType";
			public const string RoomId = "RoomId";
			public const string GoToIngameInfo = "GoToIngameInfo";
			public const string Language = "Language";
			public const string Region = "Region";
			public const string ClusterName = "ClusterName";
			public const string CheatDetection = "CheatDetection";
			public const string RoomEntryCondition = "RoomEntryCondition";
			public const string MatchingCompatibleId = "MatchingCompatibleId";
			public const string RoomType = "RoomType";
			public const string Location = "Location";
			public const string ClientVersion = "ClientVersion";
			public const string CutsceneDisabled = "CutsceneDisabled";
			public const string ForceRecordTimeAttack = "ForceRecordTimeAttack";
			public const string RetryMode = "RetryMode";
			public const string IsBR = "IsBR";
			public const string DebugAutoJoinRoomSetting = "DebugAutoJoinRoomSetting";
			public const string BRMatchingWaitEndTime = "BRMatchingWaitEndTime";
			public const string IsBRTutorial = "BRIsTutorial";
			public const string IsSoloPlayWithPhoton = "IsSoloPlayWithPhoton";
			public const string RandomMatchingType = "RandomMatchingType";
			public const string DebugMatchingSetting = "DebugMatchingSetting";
		}
	
		public enum GoToIngameState
		{
			None = 0,
			TryGoToIngame = 1,
			PreCheckParty = 2,
			CheckParty = 3,
			PostCheckParty = 4
		}
	
		public enum RetryModeType
		{
			None = 0,
			Directly = 1,
			ViaMatchingRoom = 2
		}
	
		public static class PlayerPropertyKey
		{
			// Fields
			public const string ControlPlayer = "ControlPlayer";
			public const string ReadyToGo = "ReadyToGo";
			public const string UsePartySlot = "UsePartySlot";
			public const string RoomPlayerData = "RoomPlayerData";
			public const string PlayerName = "PlayerName";
			public const string PassCode = "PassCode";
			public const string ViewerId = "ViewerId";
			public const string PlayerId = "PlayerId";
			public const string GoToIngameState = "GoToIngameState";
			public const string ContinuedCount = "ContinuedCount";
			public const string BestRegion = "BestRegion";
			public const string MatchingCompatibleId = "MatchingCompatibleId";
			public const string AstralBetCount = "AstralBetCount";
			public const string RebornCharacterCount = "RebornCharacterCount";
			public const string RebornProcessCount = "RebornProcessCount";
			public const string IsFirstClear = "IsFirstClear";
			public const string IsUseClearParty = "IsUseClearParty";
			public const string BRSkinId = "BRSkinId";
			public const string BRWeaponSkinId = "BRWeaponSkinId";
			public const string IsLowestGraphicsQuality = "IsLowestGraphicsQuality";
		}
	
		public static class PluginErrorDataKey
		{
			// Fields
			public const byte Reason = 1;
		}
	
		public enum PluginErrorReasons : byte
		{
			Unknown = 0,
			InvalidCompatibleId = 1,
			InvalidPassCode = 2
		}
	}
}
