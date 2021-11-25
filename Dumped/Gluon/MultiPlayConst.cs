namespace Gluon
{
	public static class MultiPlayConst
	{
		public static class MatchingKey
		{
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
			None,
			TryGoToIngame,
			PreCheckParty,
			CheckParty,
			PostCheckParty
		}

		public enum RetryModeType
		{
			None,
			Directly,
			ViaMatchingRoom
		}

		public static class PlayerPropertyKey
		{
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
			public const byte Reason = 1;
		}

		public enum PluginErrorReasons : byte
		{
			Unknown,
			InvalidCompatibleId,
			InvalidPassCode
		}

		public const int BattleTime = 180;

		public const int PreBattleTime = 0;

		public const int PointForWin = 10;

		public const float RespawnRadius = 5f;

		public const int CurrentMatchingCompatibleId = 31;

		public const int DefaultMatchingCompatibleId = 1;

		public const int powerSliderScale = 100;

		public const string prefsKeyIsAutoCreateRoom = "Multiplay/isAutoCreateRoom";

		public const string prefsKeyGpsLocationUseCheck = "Multiplay/gpsLocationCheck";

		public const string prefsKeyMatchCreateRequirePower = "Multiplay/matchConditionCreateRequirePower";

		public const string prefsKeyMatchSearchRequirePower = "Multiplay/matchConditionSearchRequirePower";

		public const string prefsKeyMatchCreateRequirePowerRaid = "Multiplay/matchConditionCreateRequirePowerRaid";

		public const string prefsKeyMatchSearchRequirePowerRaid = "Multiplay/matchConditionSearchRequirePowerRaid";

		public const string prefsKeyIsSkipCuttCheck = "Multiplay/isSkipRaidCutt/";
	}
}
