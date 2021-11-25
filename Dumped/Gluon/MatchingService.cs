using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExitGames.Client.Photon;
using ExitGames.Client.Photon.LoadBalancing;
using Gluon.Event;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class MatchingService : MonoBehaviour
	{
		public enum StateType
		{
			Initialized,
			SearchBestRegion,
			CreatingRoom,
			JoiningRoom,
			InRoom,
			GameStarting,
			GameStarted,
			GameCanSucceed,
			GameSucceeding,
			Disconnected,
			Error,
			DebugRandomRoom
		}

		public enum DisconnectCauseType
		{
			Unknown,
			Canceled,
			NetworkError,
			RoomBroken
		}

		public class StateTypeChangeCallback : UnityEvent<StateType>
		{
		}

		public class Room
		{
			public class PackedRoomCharacterStatusInfo
			{
				public int actorId;

				public int charaMasterId;

				public int weaponMasterId;

				public int skinWeaponId;

				public int playerIndex;

				public int memberIndex;

				public ulong viewerId;
			}

			private MatchingService parent;

			private ExitGames.Client.Photon.LoadBalancing.Room room;

			private bool snapshot;

			private string name;

			private int playerCount;

			private int maxPlayerCount;

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

			public string Name => null;

			public int PlayerCount => default(int);

			public int MaxPlayerCount => default(int);

			public Player[] Players
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int MyIndex => default(int);

			public int QuestId => default(int);

			public MatchingType MatchingType
			{
				get
				{
					return default(MatchingType);
				}
				set
				{
				}
			}

			public MatchingType InitialMatchingType => default(MatchingType);

			public RoomType RoomType => default(RoomType);

			public RoomEntryCondition RoomEntryCondition
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public int RoomId => default(int);

			public GoToIngameInfo GoToIngameInfo => null;

			public bool CutsceneDisabled
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public MultiPlayConst.RetryModeType RetryMode
			{
				get
				{
					return default(MultiPlayConst.RetryModeType);
				}
				set
				{
				}
			}

			public float BRMatchingWaitSec => default(float);

			public Room(MatchingService parent, ExitGames.Client.Photon.LoadBalancing.Room room)
			{
			}

			private Room(Room source)
			{
			}

			public Room CreateSnapshot()
			{
				return null;
			}

			public void BuildPlayerList()
			{
			}

			public List<PackedRoomCharacterStatusInfo> PackEmptyRoom()
			{
				return null;
			}

			private void PackTutorialRoom(ref List<PackedRoomCharacterStatusInfo> packedRoomInfo)
			{
			}

			public List<PackedRoomCharacterStatusInfo> PackRoom(bool initialEntry = false)
			{
				return null;
			}

			public void SetAutoJoinPriority(AutoJoinPriorityValue value)
			{
			}
		}

		public class Player
		{
			private MatchingService parent;

			private ExitGames.Client.Photon.LoadBalancing.Player player;

			private bool snapshot;

			private int actorId;

			private ulong viewerId;

			private MatchingReadyState readyState;

			private int[] usePartySlots;

			private bool isUseClearParty;

			private MatchingRoomPlayerData roomPlayerData;

			private string playerName;

			private bool isLowestGraphicsQuality;

			private bool isFirstClear;

			public int ActorId => default(int);

			public int CachedActorId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public ulong ViewerId => default(ulong);

			public MatchingReadyState ReadyState
			{
				get
				{
					return default(MatchingReadyState);
				}
				set
				{
				}
			}

			private int[] UsePartySlots
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool IsUseClearParty
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public MatchingRoomPlayerData RoomPlayerData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public string PlayerName => null;

			public bool IsLowestGraphicsQuality
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool IsFirstClear => default(bool);

			public Player(MatchingService parent, ExitGames.Client.Photon.LoadBalancing.Player player)
			{
			}

			private Player(Player source)
			{
			}

			public Player CreateSnapshot()
			{
				return null;
			}

			public int GetUsePartySlot(int partyIndex)
			{
				return default(int);
			}

			public void SetUsePartySlot(int partyIndex, int value)
			{
			}

			public void ClearRoomPlayerDataCache()
			{
			}
		}

		private enum MatchingModes
		{
			None,
			CreateRoom,
			JoinRoom,
			AutoJoin,
			BRAutoJoin,
			RandomMatching,
			Succeeding,
			Rejoin,
			SearchBestRegion,
			DebugMatching
		}

		public enum AutoJoinPriorityValue
		{
			Priority1 = 0,
			Priority2 = 1,
			Invalid = -1
		}

		private static PhotonClusterRttResult _rttCache;

		private MultiPlayErrorEventService _errorEventService;

		private StateTypeChangeCallback onMatchingServiceStateChanged;

		private StateType _state;

		private MultiPlayError _lastError;

		private Room _myRoom;

		private Room _myRoomOnGameStarted;

		private Player myPlayer;

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

		public static MatchingService instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static PhotonClusterRttResult RttCache => null;

		public static int reBattleCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public StateType State
		{
			get
			{
				return default(StateType);
			}
			private set
			{
			}
		}

		public MultiPlayError LastError
		{
			get
			{
				return default(MultiPlayError);
			}
			private set
			{
			}
		}

		public DisconnectCauseType LastDisconnectCause
		{
			[CompilerGenerated]
			get
			{
				return default(DisconnectCauseType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Room MyRoom => null;

		public Player MyPlayer => null;

		public int actorIdSelf
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isHost => default(bool);

		public bool IsBR => default(bool);

		public event Action JoinEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action LeaveEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int, int> StampEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action UpdateRoomPlayerDataEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void Create()
		{
		}

		public static bool CreateAsSuccession()
		{
			return default(bool);
		}

		public static void Destroy()
		{
		}

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		public static bool IsHostConsumeMultiStamina()
		{
			return default(bool);
		}

		public void AddMatchingServiceStateChangedEventListener(UnityAction<StateType> action)
		{
		}

		public void RemoveMatchingServiceStateChangedEventListener(UnityAction<StateType> action)
		{
		}

		public void RemoveAllMatchingServiceStateChangedEventListener()
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void TrySearchBestRegion(Action<string> callback)
		{
		}

		public void TryCreatePublicRoom(int questId, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData)
		{
		}

		public void TryCreateIdPrivateRoom(int questId, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData)
		{
		}

		public void TryCreateLocationPrivateRoom(int questId, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData, Location location)
		{
		}

		public void TryCreateConditionalRoom(int questId, int[] usePartySlots, RoomEntryCondition condition, MatchingRoomPlayerData roomPlayerData)
		{
		}

		public void TryCreateGuildRoom(int questId, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData)
		{
		}

		public void TryCreateSoloPlayWithPhotonRoom(int questId, int[] usePartySlots, bool isUseClearParty)
		{
		}

		public void TryJoinRoom(string roomName, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData, string clusterName, int passCode = -1)
		{
		}

		public void TryAutoJoinRoom(int questId, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData)
		{
		}

		public void TryRandomMatching(int questId, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData, bool isUseClearParty, bool is16Matching)
		{
		}

		private void RetryRandomMatching()
		{
		}

		public void TryAutoJoinBRRoom(int questId, int skinId, int weaponSkinId, bool isTutorial, [Optional] DebugAutoJoinRoomSetting brDebugSetting)
		{
		}

		private void CreateRandomMatchingRoom()
		{
		}

		private void TryCreateRoom(int questId, RoomType roomType, MatchingType matchingType, int[] usePartySlots, RoomEntryCondition condition, MatchingRoomPlayerData roomPlayerData, Location location, bool isSoloPlayWithPhoton, bool isUseClearParty)
		{
		}

		private void TryRejoinRoom(float rejoinIntervalTime)
		{
		}

		public void TryGameStart()
		{
		}

		public void TryGameSucceed()
		{
		}

		public bool CanCancel()
		{
			return default(bool);
		}

		public void Cancel()
		{
		}

		public void RaiseStampEvent(int iconId)
		{
		}

		public void SetAstralBetCount(int betCount)
		{
		}

		private void Error(MultiPlayError error)
		{
		}

		private void Disconnect(DisconnectCauseType disconnectCauseType, bool direct = false)
		{
		}

		private void CreateRoom()
		{
		}

		private void JoinRoom()
		{
		}

		private void RejoinRoom()
		{
		}

		private void JoinRoomRandom()
		{
		}

		private void OnEvent(EventData photonEvent)
		{
		}

		private void OnStatusChanged(StatusCode statusCode)
		{
		}

		private void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		public void DebugJoinRandomRoom()
		{
		}

		private void DebugCreateRoom()
		{
		}

		private void OnDisconnected()
		{
		}

		private void OpenOnConnectCanvas()
		{
		}

		private void CloseOnConnectCanvas()
		{
		}

		private void CheckRoomPropertiesOnRejoin()
		{
		}

		private void SetCommonPlayerProperties(Hashtable properties, int[] usePartySlots, MatchingRoomPlayerData roomPlayerData, int astralBetCount)
		{
		}

		private void StartInRoomTimeoutTimer()
		{
		}

		private void StopInRoomTimeoutTimer()
		{
		}

		private bool UpdateInRoomTimeout()
		{
			return default(bool);
		}

		private bool TrySetPlayerPropertySafe(string key, object value)
		{
			return default(bool);
		}

		private string GetLobbyName()
		{
			return null;
		}
	}
}
