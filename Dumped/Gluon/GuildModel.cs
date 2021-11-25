using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cute.Http;
using Gluon.Http;

namespace Gluon
{
	public class GuildModel
	{
		public enum Occupation
		{
			None,
			Master,
			SubMaster,
			Member
		}

		public enum InviteMessageType
		{
			Message1 = 1,
			Message2,
			Message3
		}

		public enum InviteReplyType
		{
			Reject,
			Approve
		}

		public struct GuildOption
		{
			public enum GuildApprovalRequirement
			{
				AutoApprove,
				ApprovalRequired,
				AutoBlock
			}

			public enum GuildActivityPreference
			{
				None,
				Novice,
				MyPace,
				Community,
				Hardcore
			}

			public enum GuildPushNotificationOption
			{
				On,
				Off
			}

			public const int guildNameMaxLength = 20;

			public const int guildMottoMaxLength = 70;

			public const int guildNoticeMaxLength = 48;

			public static int memberMaxCount;

			public string guildName;

			public string guildMotto;

			public string guildNotice;

			public int emblemId;

			public bool shouldAutoPlayChatVoice;

			private const string prefsShouldAutoPlayChatVoice = "GuildOption_ShouldAutoPlayChatVoice";

			public GuildApprovalRequirement approvalRequirement;

			public GuildActivityPreference activityPreference;

			public GuildPushNotificationOption gamePushNotificationOption;

			public GuildPushNotificationOption nativePushNotificationOption;

			public bool getInviteOption;

			public bool isGuildNameDeleted
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool isGuildMottoDeleted
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool isGuildNoticeDeleted
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public static GuildApprovalRequirement ConvertApprovalType(int t)
			{
				return default(GuildApprovalRequirement);
			}

			public static int ConvertApprovalType(GuildApprovalRequirement t)
			{
				return default(int);
			}

			public static GuildActivityPreference ConvertActivityType(int t)
			{
				return default(GuildActivityPreference);
			}

			public static int ConvertActivityType(GuildActivityPreference t)
			{
				return default(int);
			}

			public static GuildPushNotificationOption ConvertNotificationType(int t)
			{
				return default(GuildPushNotificationOption);
			}

			public static int ConvertNotificationType(GuildPushNotificationOption t)
			{
				return default(int);
			}

			public void ApplyShouldAutoPlayChatVoice(bool v)
			{
			}

			public void ConvertToDeletedRaw()
			{
			}

			public bool IsGuildNameChanged(string oldName)
			{
				return default(bool);
			}

			public bool IsGuildMottoChanged(string oldMotto)
			{
				return default(bool);
			}

			public bool IsGuildNoticeChanged(string oldNotice)
			{
				return default(bool);
			}

			public GuildOption(GuildData data, UserGuildData userData)
			{
			}
		}

		public struct ProfileIconData
		{
			public GiftType giftType;

			public int id;

			public Rarity rarity;

			public int limitBreak;

			public int level;

			public bool EqualsForUpdate(ProfileIconData o)
			{
				return default(bool);
			}

			public bool EqualsForCheck(ProfileIconData o)
			{
				return default(bool);
			}

			public ProfileIconData(GiftType giftType, int id, Rarity rarity = Rarity.NONE, int limitBreak = 0, int level = 1)
			{
			}

			public void SetupForCommonIcon(CommonIcon icon, IconLoader.Size size = IconLoader.Size.M)
			{
			}

			public void SetupBySupport()
			{
			}
		}

		public struct MemberInfo
		{
			public enum OnlineStatus
			{
				InGuildScene,
				Online,
				Offline
			}

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

			public OnlineStatus onlineStatus => default(OnlineStatus);

			public bool IsValid()
			{
				return default(bool);
			}

			public MemberInfo(ulong viewerId, ulong applyId, ulong inviteId, ProfileIconData iconData, string playerName, int playerLevel, int maxPower, Occupation occupation, DateTime lastLoginUTCTime, DateTime lastGuildUTCTime, DateTime lastCheckinUTCTime, DateTime temporaryEndUTCTime)
			{
			}

			public MemberInfo(GuildMemberList data)
			{
			}

			public MemberInfo(GuildInviteSendList data)
			{
			}

			public MemberInfo(GuildApplyList data)
			{
			}

			public MemberInfo(CommonFriendListCellData data)
			{
			}

			public MemberInfo(UserSupportList data)
			{
			}

			public static List<MemberInfo> ConvertFromList(DataManager.GameData<GuildApplyList> dataList)
			{
				return null;
			}

			public static List<MemberInfo> ConvertFromList(DataManager.GameData<GuildInviteSendList> dataList)
			{
				return null;
			}

			public static List<MemberInfo> ConvertFromList(DataManager.GameData<GuildMemberList> dataList)
			{
				return null;
			}
		}

		private static GuildModel instance;

		public const string GuildSceneName = "Guild";

		public const string prefabPath = "Prefabs/OutGame/Guild/";

		public const int guildIdIdLength = 8;

		public const int inviteMax = 30;

		private List<EntityData> pendingLoginBonusData;

		private bool pendingOccupationUpdated;

		public static GuildModel Instance => null;

		public int guildId => default(int);

		public int applyingGuildId => default(int);

		public GuildData guildData => null;

		public GuildData applyingGuildData => null;

		public Occupation myOccupation => default(Occupation);

		public GuildOption guildOption => default(GuildOption);

		public List<MemberInfo> members => null;

		private MemberInfo myInfo => default(MemberInfo);

		public ProfileIconData myProfileIconData => default(ProfileIconData);

		public static void DeleteInstance()
		{
		}

		public static bool IsInstanceNull()
		{
			return default(bool);
		}

		private GuildModel()
		{
		}

		static GuildModel()
		{
		}

		public static Occupation ConvertOccupationType(int t)
		{
			return default(Occupation);
		}

		public static int ConvertOccupationType(Occupation t)
		{
			return default(int);
		}

		public Task<GuildIndexResponse> RequestGuildTopInfoAsync([Optional] Action<ErrorType, int> onError)
		{
			return null;
		}

		public void RequestGuildTopInfo(Action onSuccess)
		{
		}

		private void UpdateGuildIndex(GuildIndexResponse res)
		{
		}

		private void RecordLoginBonus(AtgenBuildEventRewardEntityList[] dataList)
		{
		}

		private void RecordOccupationUpdated(bool shouldUpdate)
		{
		}

		public void RecordOccupationUpdated()
		{
		}

		public List<EntityData> GetPendingLoginBonusData()
		{
			return null;
		}

		public bool GetPendingOccupationUpdated()
		{
			return default(bool);
		}
	}
}
