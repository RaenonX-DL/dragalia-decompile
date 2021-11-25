using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class GuildChatModel
	{
		public enum ContentType
		{
			None,
			Text,
			Stamp,
			System,
			MultiLink
		}

		public enum GuildSystemMessageType
		{
			TextOnly = 1,
			TextAndIcon,
			MultiLink
		}

		public enum ChatAnimationWaitMode
		{
			None,
			Set,
			Wait,
			Animation
		}

		public enum ChatUpdateState
		{
			None,
			NewMessage,
			LinkUpdate
		}

		public enum GuildSystemMessageLabel
		{
			AssignLeader = 3
		}

		public class ChatTableViewData
		{
			public enum RoomStatus
			{
				None,
				NoData,
				Available,
				Full,
				InvalidCompatibleId,
				Error
			}

			public ulong chatMessageId;

			public ulong viewerId;

			public GuildModel.ProfileIconData iconData;

			public string name;

			public ContentType contentType;

			public string text;

			public int stampId;

			public int systemMessageId;

			public int paramValue1;

			public int paramValue2;

			public int paramValue3;

			public int paramValue4;

			public DateTime time;

			public int roomId;

			public RoomStatus roomStatus;

			public int currentMemberCount;

			public int questId;

			public float roomUpdateWaitTime;

			public Vector2 cellSize;

			public bool isReportState;

			public bool isReportStateClear;

			public bool isChangeRoomStatus;

			public ChatAnimationWaitMode animationWaitState;

			public bool shouldShowDateChange;

			private Guid _guid;

			public Guid guid => default(Guid);

			public bool IsEnabledRoomStates()
			{
				return default(bool);
			}

			public bool IsTextOnly()
			{
				return default(bool);
			}
		}

		private static GuildChatModel instance;

		private Action updateAction;

		private List<ChatTableViewData> chatLog;

		public TextToSpeechPlayer textToSpeechPlayer;

		private const int maxChatCount = 500;

		public const string stampSE = "SE_OUT_COMMON_0028";

		private const float roomUpdateWaitTime = 3f;

		public static GuildChatModel Instance => null;

		public static void DeleteInstance()
		{
		}

		public static bool IsInstanceNull()
		{
			return default(bool);
		}

		private GuildChatModel()
		{
		}

		static GuildChatModel()
		{
		}

		public List<ChatTableViewData> GetChatLogList(List<ContentType> enableContentType)
		{
			return null;
		}

		private List<ChatTableViewData> GetTypeOfChatLogList(List<ChatTableViewData> chatList, ContentType type)
		{
			return null;
		}

		public List<ChatTableViewData> GetEnabledMultiLinkList()
		{
			return null;
		}

		private bool IsExistMatchingRoom()
		{
			return default(bool);
		}

		public void UpdateMultiLink(Action onFinished)
		{
		}

		private void UpdateRoomData(ChatTableViewData data, RoomList room)
		{
		}

		private void SetRoomStatus(ChatTableViewData data, ChatTableViewData.RoomStatus status)
		{
		}

		public ulong GetFirstChatMassageId()
		{
			return default(ulong);
		}

		public ulong GetCurrentChatMassageId()
		{
			return default(ulong);
		}

		public Task<GuildChatGetOldMessageListResponse> RequestGuildOldMessageList()
		{
			return null;
		}

		public Task<GuildChatGetNewMessageListResponse> RequestGuildNewMessageList()
		{
			return null;
		}

		public Task<GuildChatPostMessageTextResponse> RequestGuildChatPost(string text)
		{
			return null;
		}

		public Task<GuildChatPostMessageStampResponse> RequestGuildChatStampPost(int stampId)
		{
			return null;
		}

		public Task<MatchingGetRoomListByGuildResponse> RequestMatchingGetRoomListByGuildPost()
		{
			return null;
		}

		public ChatUpdateState ProcessChat(bool isNew, bool isFirst, bool isWaitAnime)
		{
			return default(ChatUpdateState);
		}

		private List<ChatTableViewData> CheckChatLogCountLimit(List<ChatTableViewData> dataList)
		{
			return null;
		}

		public bool IsChatLogCountOver()
		{
			return default(bool);
		}

		public bool IsChatLogEmpty()
		{
			return default(bool);
		}

		public void SetSpeech(string text, bool isAnimation)
		{
		}

		private List<ChatTableViewData> GetChatTableViewDataList(bool isNew, bool isFirst, bool isWaitAnime)
		{
			return null;
		}

		private bool IsExistData(ChatTableViewData data)
		{
			return default(bool);
		}

		private ChatTableViewData GetChatTableViewData(GuildChatMessageList chatMessage, bool isNew, bool isFirst, bool isWaitAnime)
		{
			return null;
		}

		public void SetUpdateAction(Action action)
		{
		}

		public void CallUpdateAction()
		{
		}

		public bool IsReportState()
		{
			return default(bool);
		}

		public void ClearReportState()
		{
		}

		public void ResetReportState()
		{
		}

		public void OpenReportDialog(ChatTableViewData data)
		{
		}

		public void ResetAnimationState(Guid guid)
		{
		}

		public void UpdateChatIcon()
		{
		}

		private void UpdateAllIcon()
		{
		}

		public void ClearData()
		{
		}
	}
}
