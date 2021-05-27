/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using ExitGames.Client.Photon.LoadBalancing;
using Gluon.Event;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingService : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private static MatchingService _instance_k__BackingField;
		private static PhotonClusterRttResult _rttCache;
		[CompilerGenerated]
		private static int _reBattleCount_k__BackingField;
		private MultiPlayErrorEventService _errorEventService;
		private StateTypeChangeCallback onMatchingServiceStateChanged;
		private StateType _state;
		private MultiPlayError _lastError;
		[CompilerGenerated]
		private DisconnectCauseType _LastDisconnectCause_k__BackingField;
		[CompilerGenerated]
		private Action JoinEvent;
		[CompilerGenerated]
		private Action LeaveEvent;
		[CompilerGenerated]
		private Action<int, int> StampEvent;
		[CompilerGenerated]
		private Action UpdateRoomPlayerDataEvent;
		private Room _myRoom;
		private Room _myRoomOnGameStarted;
		private Player myPlayer;
		[CompilerGenerated]
		private int _actorIdSelf_k__BackingField;
		private Stamp eventStamp;
		private MatchingRoomProperties _createRoomProperties;
		private MatchingRoomSearchCondition _searchRoomCondition;
		private string joinRoomName;
		private MatchingContext _matchingContext;
		private bool rejoiningNow;
		private string rejoiningRoomName;
		private int rejoiningActorId;
		private int rejoiningTryCount;
		private float _rejoinIntervalTimer;
		private const int DefaultRejoinIntervalTime = 1;
		private const int maxRejoiningTryCount = 3;
		private Dictionary<string, object> offlineModificationOfPlayerProperties;
		private int reauthTryCount;
		private const int maxReauthTryCount = 1;
		private PhotonSearchBestRegionService _searchBestRegionService;
		private static string _lastConnectClusterName;
		private MatchingAutoJoinService _autoJoinService;
		private bool _isJoiningWithRejoin;
		private bool _isConnecting;
		private static readonly float InRoomTimeoutSec;
		private float _inRoomTimeoutTimer;
		private bool _isInRoomTimeoutTimerRunning;
		private MatchingModes _mode;
		private Action<string> _bestRegionFoundCallback;
		private MultiPlaySettings settings;
		private TypedLobby typedLobby;
		private AutoJoinPriorityValue autoJoinPriorityRange;
		private DateTime autoJoinPriorityLowerTime;
		private SleepTimeoutCtrl _sleepTimeoutCtrl;
		private int _reservedAstralBetCount;
	
		// Properties
		public static MatchingService instance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static PhotonClusterRttResult RttCache { get; }
		public static int reBattleCount { [CompilerGenerated] get; [CompilerGenerated] set; }
		public StateType State { get; private set; }
		public MultiPlayError LastError { get; private set; }
		public DisconnectCauseType LastDisconnectCause { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Room MyRoom { get; }
		public Player MyPlayer { get; }
		public int actorIdSelf { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isHost { get; }
		public bool IsBR { get; }
	
		// Events
		public event Action JoinEvent {
			add;
			remove;
		}
		public event Action LeaveEvent {
			add;
			remove;
		}
		public event Action<int, int> StampEvent {
			add;
			remove;
		}
		public event Action UpdateRoomPlayerDataEvent {
			add;
			remove;
		}
	
		// Nested types
		public enum StateType
		{
			Initialized = 0,
			SearchBestRegion = 1,
			CreatingRoom = 2,
			JoiningRoom = 3,
			InRoom = 4,
			GameStarting = 5,
			GameStarted = 6,
			GameCanSucceed = 7,
			GameSucceeding = 8,
			Disconnected = 9,
			Error = 10,
			DebugRandomRoom = 11
		}
	
		public enum DisconnectCauseType
		{
			Unknown = 0,
			Canceled = 1,
			NetworkError = 2,
			RoomBroken = 3
		}
	
		public class StateTypeChangeCallback : UnityEvent<StateType>
		{
			// Constructors
			public StateTypeChangeCallback();
		}
	
		public class Room
		{
			// Fields
			private MatchingService parent;
			private ExitGames.Client.Photon.LoadBalancing.Room room;
			private bool snapshot;
			private string name;
			private int playerCount;
			private int maxPlayerCount;
			[CompilerGenerated]
			private Player[] _Players_k__BackingField;
			private int myIndex;
			private int questId;
			private MatchingType matchingType;
			private MatchingType initialMatchingType;
			private RoomType roomType;
			private RoomEntryCondition condition;
			private static RoomEntryCondition defaultCondition;
			private int roomId;
			private GoToIngameInfo gotoIngameInfo;
			private bool cutsceneDisabled;
			private MultiPlayConst.RetryModeType retryMode;
			private DateTime brMatchingWaitEndTime;
	
			// Properties
			public string Name { get; }
			public int PlayerCount { get; }
			public int MaxPlayerCount { get; }
			public Player[] Players { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int MyIndex { get; }
			public int QuestId { get; }
			public MatchingType MatchingType { get; set; }
			public MatchingType InitialMatchingType { get; }
			public RoomType RoomType { get; }
			public RoomEntryCondition RoomEntryCondition { get; set; }
			public int RoomId { get; }
			public GoToIngameInfo GoToIngameInfo { get; }
			public bool CutsceneDisabled { get; set; }
			public MultiPlayConst.RetryModeType RetryMode { get; set; }
			public float BRMatchingWaitSec { get; }
	
			// Nested types
			public class PackedRoomCharacterStatusInfo
			{
				// Fields
				public int actorId;
				public int charaMasterId;
				public int weaponMasterId;
				public int skinWeaponId;
				public int playerIndex;
				public int memberIndex;
				public ulong viewerId;
	
				// Constructors
				public PackedRoomCharacterStatusInfo();
			}
	
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Comparison<Player> __9__57_0;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal int _BuildPlayerList_b__57_0(Player p1, Player p2);
			}
	
			// Constructors
			public Room(MatchingService parent, ExitGames.Client.Photon.LoadBalancing.Room room);
			private Room(Room source);
			static Room();
	
			// Methods
			public Room CreateSnapshot();
			public void BuildPlayerList();
			public List<PackedRoomCharacterStatusInfo> PackEmptyRoom();
			private void PackTutorialRoom(ref List<PackedRoomCharacterStatusInfo> packedRoomInfo);
			public List<PackedRoomCharacterStatusInfo> PackRoom(bool initialEntry = false);
			public void SetAutoJoinPriority(AutoJoinPriorityValue value);
		}
	
		public class Player
		{
			// Fields
			private MatchingService parent;
			private ExitGames.Client.Photon.LoadBalancing.Player player;
			private bool snapshot;
			private int actorId;
			[CompilerGenerated]
			private int _CachedActorId_k__BackingField;
			private ulong viewerId;
			private MatchingReadyState readyState;
			private int[] usePartySlots;
			private bool isUseClearParty;
			private MatchingRoomPlayerData roomPlayerData;
			private string playerName;
			private bool isFirstClear;
	
			// Properties
			public int ActorId { get; }
			public int CachedActorId { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public ulong ViewerId { get; }
			public MatchingReadyState ReadyState { get; set; }
			private int[] UsePartySlots { get; set; }
			public bool IsUseClearParty { get; set; }
			public MatchingRoomPlayerData RoomPlayerData { get; set; }
			public string PlayerName { get; }
			public bool IsFirstClear { get; }
	
			// Constructors
			public Player(MatchingService parent, ExitGames.Client.Photon.LoadBalancing.Player player);
			private Player(Player source);
	
			// Methods
			public Player CreateSnapshot();
			public int GetUsePartySlot(int partyIndex);
			public void SetUsePartySlot(int partyIndex, int value);
			public void ClearRoomPlayerDataCache();
		}
	
		private enum MatchingModes
		{
			None = 0,
			CreateRoom = 1,
			JoinRoom = 2,
			AutoJoin = 3,
			BRAutoJoin = 4,
			RandomMatching = 5,
			Succeeding = 6,
			Rejoin = 7,
			SearchBestRegion = 8,
			DebugMatching = 9
		}
	
		public enum AutoJoinPriorityValue
		{
			Invalid = -1,
			Priority1 = 0,
			Priority2 = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass127_0
		{
			// Fields
			public int actorId;
	
			// Constructors
			public __c__DisplayClass127_0();
	
			// Methods
			internal bool _OnEvent_b__1(Player player);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__127_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnEvent_b__127_0();
		}
	
		// Constructors
		public MatchingService();
		static MatchingService();
	
		// Methods
		public static void Create();
		public static bool CreateAsSuccession();
		public static void Destroy();
		public static bool IsInstanceEmpty();
		public static bool IsHostConsumeMultiStamina();
		public void AddMatchingServiceStateChangedEventListener(UnityAction<StateType> action);
		public void RemoveMatchingServiceStateChangedEventListener(UnityAction<StateType> action);
		public void RemoveAllMatchingServiceStateChangedEventListener();
		private void Awake();
		private void Update();
		public void TrySearchBestRegion(Action<string> callback);
		public void TryCreatePublicRoom(int questId, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData);
		public void TryCreateIdPrivateRoom(int questId, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData);
		public void TryCreateLocationPrivateRoom(int questId, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData, Location location);
		public void TryCreateConditionalRoom(int questId, int[] usePartySlots, RoomEntryCondition condition, MatchingRoomPlayerData roomPlayerData);
		public void TryCreateGuildRoom(int questId, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData);
		public void TryCreateSoloPlayWithPhotonRoom(int questId, int[] usePartySlots, bool isUseClearParty);
		public void TryJoinRoom(string roomName, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData, string clusterName, int passCode = -1);
		public void TryAutoJoinRoom(int questId, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData);
		public void TryRandomMatching(int questId, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData, bool isUseClearParty);
		private void RetryRandomMatching();
		public void TryAutoJoinBRRoom(int questId, int skinId, int weaponSkinId, bool isTutorial, DebugAutoJoinRoomSetting brDebugSetting = null);
		private void CreateRandomMatchingRoom();
		private void TryCreateRoom(int questId, RoomType roomType, MatchingType matchingType, int[] usePartySlots, RoomEntryCondition condition, MatchingRoomPlayerData roomPlayerData, Location location, bool isSoloPlayWithPhoton, bool isUseClearParty);
		private void TryRejoinRoom(float rejoinIntervalTime);
		public void TryGameStart();
		public void TryGameSucceed();
		public bool CanCancel();
		public void Cancel();
		public void RaiseStampEvent(int iconId);
		public void SetAstralBetCount(int betCount);
		private void Error(MultiPlayError error);
		private void Disconnect(DisconnectCauseType disconnectCauseType, bool direct = false);
		private void CreateRoom();
		private void JoinRoom();
		private void RejoinRoom();
		private void JoinRoomRandom();
		private void OnEvent(EventData photonEvent);
		private void OnStatusChanged(StatusCode statusCode);
		private void OnOperationResponse(OperationResponse operationResponse);
		public void DebugJoinRandomRoom();
		private void DebugCreateRoom();
		private void OnDisconnected();
		private void OpenOnConnectCanvas();
		private void CloseOnConnectCanvas();
		private void CheckRoomPropertiesOnRejoin();
		private void SetCommonPlayerProperties(Hashtable properties, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData, int astralBetCount);
		private void StartInRoomTimeoutTimer();
		private void StopInRoomTimeoutTimer();
		private bool UpdateInRoomTimeout();
		private bool TrySetPlayerPropertySafe(string key, object value);
		private string GetLobbyName();
	}
}
