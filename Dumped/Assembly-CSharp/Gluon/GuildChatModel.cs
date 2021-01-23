/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Gluon.Http;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildChatModel
	{
		// Fields
		private static GuildChatModel instance;
		private Action updateAction;
		private List<ChatTableViewData> chatLog;
		public TextToSpeechPlayer textToSpeechPlayer;
		private const int maxChatCount = 500;
		public const string stampSE = "SE_OUT_COMMON_0028";
		private const float roomUpdateWaitTime = 3f;
	
		// Properties
		public static GuildChatModel Instance { get; }
	
		// Nested types
		public enum ContentType
		{
			None = 0,
			Text = 1,
			Stamp = 2,
			System = 3,
			MultiLink = 4
		}
	
		public enum GuildSystemMessageType
		{
			TextOnly = 1,
			TextAndIcon = 2,
			MultiLink = 3
		}
	
		public enum ChatAnimationWaitMode
		{
			None = 0,
			Set = 1,
			Wait = 2,
			Animation = 3
		}
	
		public enum ChatUpdateState
		{
			None = 0,
			NewMessage = 1,
			LinkUpdate = 2
		}
	
		public enum GuildSystemMessageLabel
		{
			AssignLeader = 3
		}
	
		public class ChatTableViewData
		{
			// Fields
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
	
			// Properties
			public Guid guid { get; }
	
			// Nested types
			public enum RoomStatus
			{
				None = 0,
				NoData = 1,
				Available = 2,
				Full = 3,
				InvalidCompatibleId = 4,
				Error = 5
			}
	
			// Constructors
			public ChatTableViewData();
	
			// Methods
			public bool IsEnabledRoomStates();
			public bool IsTextOnly();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public List<ContentType> enableContentType;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal bool _GetChatLogList_b__0(ChatTableViewData x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public ContentType type;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal bool _GetTypeOfChatLogList_b__0(ChatTableViewData x);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<ChatTableViewData> __9__21_0;
			public static Comparison<ChatTableViewData> __9__38_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _GetEnabledMultiLinkList_b__21_0(ChatTableViewData x);
			internal int _GetChatTableViewDataList_b__38_0(ChatTableViewData a, ChatTableViewData b);
		}
	
		[CompilerGenerated]
		private struct _UpdateMultiLink_d__23 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildChatModel __4__this;
			public Action onFinished;
			private List<ChatTableViewData> _multiLinkList_5__2;
			private TaskAwaiter<MatchingGetRoomListByGuildResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _RequestGuildOldMessageList_d__28 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<GuildChatGetOldMessageListResponse> __t__builder;
			public GuildChatModel __4__this;
			private TaskAwaiter<GuildChatGetOldMessageListResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _RequestGuildNewMessageList_d__29 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<GuildChatGetNewMessageListResponse> __t__builder;
			public GuildChatModel __4__this;
			private TaskAwaiter<GuildChatGetNewMessageListResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _RequestGuildChatPost_d__30 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<GuildChatPostMessageTextResponse> __t__builder;
			public GuildChatModel __4__this;
			public string text;
			private TaskAwaiter<GuildChatPostMessageTextResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _RequestGuildChatStampPost_d__31 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<GuildChatPostMessageStampResponse> __t__builder;
			public GuildChatModel __4__this;
			public int stampId;
			private TaskAwaiter<GuildChatPostMessageStampResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _RequestMatchingGetRoomListByGuildPost_d__32 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<MatchingGetRoomListByGuildResponse> __t__builder;
			private TaskAwaiter<MatchingGetRoomListByGuildResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public ChatTableViewData data;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal bool _IsExistData_b__0(ChatTableViewData x);
		}
	
		// Constructors
		private GuildChatModel();
		static GuildChatModel();
	
		// Methods
		public static void DeleteInstance();
		public static bool IsInstanceNull();
		public List<ChatTableViewData> GetChatLogList(List<ContentType> enableContentType);
		private List<ChatTableViewData> GetTypeOfChatLogList(List<ChatTableViewData> chatList, ContentType type);
		public List<ChatTableViewData> GetEnabledMultiLinkList();
		private bool IsExistMatchingRoom();
		public async void UpdateMultiLink(Action onFinished);
		private void UpdateRoomData(ChatTableViewData data, RoomList room);
		private void SetRoomStatus(ChatTableViewData data, ChatTableViewData.RoomStatus status);
		public ulong GetFirstChatMassageId();
		public ulong GetCurrentChatMassageId();
		public async Task<GuildChatGetOldMessageListResponse> RequestGuildOldMessageList();
		public async Task<GuildChatGetNewMessageListResponse> RequestGuildNewMessageList();
		public async Task<GuildChatPostMessageTextResponse> RequestGuildChatPost(string text);
		public async Task<GuildChatPostMessageStampResponse> RequestGuildChatStampPost(int stampId);
		public async Task<MatchingGetRoomListByGuildResponse> RequestMatchingGetRoomListByGuildPost();
		public ChatUpdateState ProcessChat(bool isNew, bool isFirst, bool isWaitAnime);
		private List<ChatTableViewData> CheckChatLogCountLimit(List<ChatTableViewData> dataList);
		public bool IsChatLogCountOver();
		public bool IsChatLogEmpty();
		public void SetSpeech(string text, bool isAnimation);
		private List<ChatTableViewData> GetChatTableViewDataList(bool isNew, bool isFirst, bool isWaitAnime);
		private bool IsExistData(ChatTableViewData data);
		private ChatTableViewData GetChatTableViewData(GuildChatMessageList chatMessage, bool isNew, bool isFirst, bool isWaitAnime);
		public void SetUpdateAction(Action action);
		public void CallUpdateAction();
		public bool IsReportState();
		public void ClearReportState();
		public void ResetReportState();
		public void OpenReportDialog(ChatTableViewData data);
		public void ResetAnimationState(Guid guid);
		public void UpdateChatIcon();
		private void UpdateAllIcon();
		public void ClearData();
		[CompilerGenerated]
		private void _OpenReportDialog_b__46_0(bool isSend);
	}
}
