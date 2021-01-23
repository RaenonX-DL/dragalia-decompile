/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildModel
	{
		// Fields
		private static GuildModel instance;
		public const string GuildSceneName = "Guild";
		public const string prefabPath = "Prefabs/OutGame/Guild/";
		public const int guildIdIdLength = 8;
		public const int inviteMax = 30;
		private List<EntityData> pendingLoginBonusData;
		private bool pendingOccupationUpdated;
	
		// Properties
		public static GuildModel Instance { get; }
		public int guildId { get; }
		public int applyingGuildId { get; }
		public GuildData guildData { get; }
		public GuildData applyingGuildData { get; }
		public Occupation myOccupation { get; }
		public GuildOption guildOption { get; }
		public List<MemberInfo> members { get; }
		private MemberInfo myInfo { get; }
		public ProfileIconData myProfileIconData { get; }
	
		// Nested types
		public enum Occupation
		{
			None = 0,
			Master = 1,
			SubMaster = 2,
			Member = 3
		}
	
		public enum InviteMessageType
		{
			Message1 = 1,
			Message2 = 2,
			Message3 = 3
		}
	
		public enum InviteReplyType
		{
			Reject = 0,
			Approve = 1
		}
	
		public struct GuildOption
		{
			// Fields
			public const int guildNameMaxLength = 20;
			public const int guildMottoMaxLength = 70;
			public const int guildNoticeMaxLength = 48;
			public static int memberMaxCount;
			public string guildName;
			public string guildMotto;
			public string guildNotice;
			[CompilerGenerated]
			private bool _isGuildNameDeleted_k__BackingField;
			[CompilerGenerated]
			private bool _isGuildMottoDeleted_k__BackingField;
			[CompilerGenerated]
			private bool _isGuildNoticeDeleted_k__BackingField;
			public int emblemId;
			public bool shouldAutoPlayChatVoice;
			private const string prefsShouldAutoPlayChatVoice = "GuildOption_ShouldAutoPlayChatVoice";
			public GuildApprovalRequirement approvalRequirement;
			public GuildActivityPreference activityPreference;
			public GuildPushNotificationOption gamePushNotificationOption;
			public GuildPushNotificationOption nativePushNotificationOption;
			public bool getInviteOption;
	
			// Properties
			public bool isGuildNameDeleted { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool isGuildMottoDeleted { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool isGuildNoticeDeleted { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Nested types
			public enum GuildApprovalRequirement
			{
				AutoApprove = 0,
				ApprovalRequired = 1,
				AutoBlock = 2
			}
	
			public enum GuildActivityPreference
			{
				None = 0,
				Novice = 1,
				MyPace = 2,
				Community = 3,
				Hardcore = 4
			}
	
			public enum GuildPushNotificationOption
			{
				On = 0,
				Off = 1
			}
	
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Func<GuildEmblemElement, bool> __9__41_0;
				public static Func<GuildEmblemElement, Guid> __9__41_1;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal bool _.ctor_b__41_0(GuildEmblemElement x);
				internal Guid _.ctor_b__41_1(GuildEmblemElement x);
			}
	
			// Constructors
			public GuildOption(GuildData data, UserGuildData userData);
			static GuildOption();
	
			// Methods
			public static GuildApprovalRequirement ConvertApprovalType(int t);
			public static int ConvertApprovalType(GuildApprovalRequirement t);
			public static GuildActivityPreference ConvertActivityType(int t);
			public static int ConvertActivityType(GuildActivityPreference t);
			public static GuildPushNotificationOption ConvertNotificationType(int t);
			public static int ConvertNotificationType(GuildPushNotificationOption t);
			public void ApplyShouldAutoPlayChatVoice(bool v);
			public void ConvertToDeletedRaw();
			public bool IsGuildNameChanged(string oldName);
			public bool IsGuildMottoChanged(string oldMotto);
			public bool IsGuildNoticeChanged(string oldNotice);
		}
	
		public struct ProfileIconData
		{
			// Fields
			public GiftType giftType;
			public int id;
			public Rarity rarity;
			public int limitBreak;
			public int level;
	
			// Constructors
			public ProfileIconData(GiftType giftType, int id, Rarity rarity = Rarity.NONE, int limitBreak = 0, int level = 1);
	
			// Methods
			public bool EqualsForUpdate(ProfileIconData o);
			public bool EqualsForCheck(ProfileIconData o);
			public void SetupForCommonIcon(CommonIcon icon, IconLoader.Size size = IconLoader.Size.M);
			public void SetupBySupport();
		}
	
		public struct MemberInfo
		{
			// Fields
			public ulong viewerId;
			public ulong applyId;
			public ulong inviteId;
			public ProfileIconData iconData;
			public string playerName;
			public int playerLevel;
			public int maxPower;
			public Occupation occupation;
			public DateTime lastLoginUTCTime;
			public DateTime lastGuildUTCTime;
			public DateTime lastCheckinUTCTime;
			public DateTime temporaryEndUTCTime;
			public static int inGuildStatusSecond;
			public static int onlineStatusSecond;
	
			// Properties
			public OnlineStatus onlineStatus { get; }
	
			// Nested types
			public enum OnlineStatus
			{
				InGuildScene = 0,
				Online = 1,
				Offline = 2
			}
	
			// Constructors
			public MemberInfo(ulong viewerId, ulong applyId, ulong inviteId, ProfileIconData iconData, string playerName, int playerLevel, int maxPower, Occupation occupation, DateTime lastLoginUTCTime, DateTime lastGuildUTCTime, DateTime lastCheckinUTCTime, DateTime temporaryEndUTCTime);
			public MemberInfo(GuildMemberList data);
			public MemberInfo(GuildInviteSendList data);
			public MemberInfo(GuildApplyList data);
			public MemberInfo(CommonFriendListCellData data);
			public MemberInfo(UserSupportList data);
			static MemberInfo();
	
			// Methods
			public bool IsValid();
			public static List<MemberInfo> ConvertFromList(DataManager.GameData<GuildApplyList> dataList);
			public static List<MemberInfo> ConvertFromList(DataManager.GameData<GuildInviteSendList> dataList);
			public static List<MemberInfo> ConvertFromList(DataManager.GameData<GuildMemberList> dataList);
		}
	
		[CompilerGenerated]
		private struct _RequestGuildTopInfoAsync_d__39 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<GuildIndexResponse> __t__builder;
			public Action<ErrorType, int> onError;
			public GuildModel __4__this;
			private TaskAwaiter<GuildIndexResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public GuildModel __4__this;
			public Action onSuccess;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal void _RequestGuildTopInfo_b__0(GuildIndexResponse res);
		}
	
		// Constructors
		private GuildModel();
		static GuildModel();
	
		// Methods
		public static void DeleteInstance();
		public static bool IsInstanceNull();
		public static Occupation ConvertOccupationType(int t);
		public static int ConvertOccupationType(Occupation t);
		public async Task<GuildIndexResponse> RequestGuildTopInfoAsync(Action<ErrorType, int> onError = null);
		public void RequestGuildTopInfo(Action onSuccess);
		private void UpdateGuildIndex(GuildIndexResponse res);
		private void RecordLoginBonus(AtgenBuildEventRewardEntityList[] dataList);
		private void RecordOccupationUpdated(bool shouldUpdate);
		public void RecordOccupationUpdated();
		public List<EntityData> GetPendingLoginBonusData();
		public bool GetPendingOccupationUpdated();
	}
}
