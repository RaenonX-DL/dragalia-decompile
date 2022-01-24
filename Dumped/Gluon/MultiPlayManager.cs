using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class MultiPlayManager : MonoBehaviour
	{
		public enum MultiType
		{
			Quest,
			Raid,
			Field,
			Battle
		}

		public enum QuestState
		{
			None,
			MultiPlayPartyConfirmed,
			Waiting,
			InGame
		}

		public enum StoryState
		{
			None,
			Waiting,
			AllFinished
		}

		public enum QuestRetireReasons
		{
			None,
			ByDisconnection,
			ByLeaveAlone
		}

		public class PlayerInfo
		{
			public string Name;

			public WillLeave.Reasons WillLeaveReason;

			public bool IsAllDeadConfirmed;

			public bool IsLowestGraphicsQuality;
		}

		public delegate void OnStamp(int playerIndex, int iconId);

		public delegate void OnTargetParts(int playerIndex, int partsId);

		private Dictionary<int, int> _memberCountTable;

		public List<int> actorIds;

		private PlayerInfo[] playerInfos;

		private List<EventSenderBase> moveEventSenders;

		private MoveBundle moveBundle;

		private float sendTimer;

		private float idleTimer;

		public Queue<EventD00562> eventD00562ReceiveBuffer;

		public List<EventE02660> eventE02660ReceiveBuffer;

		private WillLeave tmpWillLeaveEvent;

		private MultiPlayTemporaries _temporaries;

		private MultiPlayErrorEventService _errorEventService;

		private WillLeave.Reasons _willLeaveReason;

		private PhotonAck _ack;

		private PhotonStatistics _statistics;

		private PhotonSuspendCheatChecker _suspendCheatCheck;

		private MultiPlayRebornCtrl _rebornCtrl;

		private MultiPlayBRCtrl _brCtrl;

		private MultiPlayBuffFieldCtrl _buffFieldCtrl;

		private CollisionHitAttribute _hitAttr;

		private bool _isOtherPlayerDisconnected;

		private MultiPlaySystemMessageCtrl _systemMessageCtrl;

		private bool _isLeaveAloneDetected;

		private MultiPlaySettings settings;

		private MultiPlayRetryVoteCtrl _retryVoteCtrl;

		private List<EnemyAbilityProcBase> _enemyAbilityCallbackList;

		private bool _isRankingQuest;

		private bool _isSuccessiveGameTimerSent;

		private GoToIngameInfo _gotoIngameInfo;

		public static readonly int MaxPlayer;

		private MultiPlayReceiveEventBuffering _recvEventBuffering;

		public static MultiPlayManager instance
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

		public MultiType multiType
		{
			[CompilerGenerated]
			get
			{
				return default(MultiType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public QuestState questState
		{
			[CompilerGenerated]
			get
			{
				return default(QuestState);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsCoopMultiPlay => default(bool);

		public bool IsSoloPlayWithPhoton
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

		public Dictionary<int, List<Gluon.Event.CharacterData>> otherCharacters
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

		public Gluon.Event.CharacterData ownCharacters
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

		public GoToIngameInfo.BRInitData brInitData => null;

		public int actorCount => default(int);

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

		public bool IsMultiPlayHost => default(bool);

		public bool IsMultiPlayGuest => default(bool);

		public bool IsMultiPlayHostOrSolo => default(bool);

		public int CurrentHostActorId
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

		public MultiPlayTemporaries Temporaries => null;

		public MultiPlayErrorEventService ErrorEventService => null;

		public SleepTimeoutCtrl SleepTimeoutCtrl
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

		public MultiPlaySettings MultiPlaySettings => null;

		public MultiPlayRetryVoteModel RetryVoteModel => null;

		public bool IsAutoFailTimeoutEnabled
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

		public float ForceAutoFailTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MultiPlayWarpCtrl WarpCtrl
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

		public bool IsDisableOnDamagedWhenLeave
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

		public MultiPlayAuraCtrl MultiPlayAuraCtrl
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

		public ulong[] RoomPlayers => null;

		public event OnStamp onStamp
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

		public event OnTargetParts onTargetParts
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

		public static bool IsDisconnected()
		{
			return default(bool);
		}

		public static bool WillBeDisconnected()
		{
			return default(bool);
		}

		public static void Create()
		{
		}

		private void Awake()
		{
		}

		public void PostInitialize(GoToIngameInfo gotoIngameInfo, MatchingService.Room snapshot, SleepTimeoutCtrl sleepTimeoutCtrl)
		{
		}

		public int GetActorIndex(int actorId)
		{
			return default(int);
		}

		public string GetActorLabel(int actorId)
		{
			return null;
		}

		public int GetActorIdFromIndex(int index)
		{
			return default(int);
		}

		public ulong GetViewerIdFromActorId(int actorId)
		{
			return default(ulong);
		}

		public void TryCheckParty()
		{
		}

		public bool HasMultiPlayParty()
		{
			return default(bool);
		}

		private void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		private void OnEvent(EventData photonEvent)
		{
		}

		public int GetMyPartyUnitCount()
		{
			return default(int);
		}

		private void OnDisconnected()
		{
		}

		private void Error(MultiPlayError error)
		{
		}

		private void PostDisconnected()
		{
		}

		public static EventReceiverBase FindEventReceiverFromCharacterId(CharacterId id)
		{
			return null;
		}

		public static CharacterBase FindCharacterFromCharacterId(CharacterId id, bool ignoreEnemyPool = false)
		{
			return null;
		}

		public static List<CharacterBase> FindCharacterFromCharacterIds(List<CharacterId> ids)
		{
			return null;
		}

		public void InitializeOtherControls()
		{
		}

		public void ReadyToStartQuest()
		{
		}

		public void SetControlPlayer(CharacterSelector player)
		{
		}

		public string GetOtherPlayerName(int index)
		{
			return null;
		}

		public void SetOtherPlayerName(int index, string name)
		{
		}

		public bool[] GetIsLowestGraphicsQuarities()
		{
			return null;
		}

		public void SendWillLeave(WillLeave.Reasons reason)
		{
		}

		public void Continue()
		{
		}

		public void SendWaitReborn(List<CharacterBase> targetCharas, bool isAbilityReborn)
		{
		}

		public void SendReborn(List<Tuple<CharacterBase, float>> rebornCharaInfos, bool isAbilityReborn, bool withSpCharge)
		{
		}

		public void SetAllDeadConfirmed(bool flag)
		{
		}

		public bool IsAllOtherPlayerAllDeadConfirmed()
		{
			return default(bool);
		}

		public void AddMoveEventSender(EventSenderBase eventSender)
		{
		}

		public void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public static void Destroy()
		{
		}

		public bool HasMultiPlayOwner(CharacterBase chara)
		{
			return default(bool);
		}

		public bool HasMultiPlayInitialOwner(CharacterBase chara)
		{
			return default(bool);
		}

		public bool HasMultiPlayOwner(CharacterBase chara, bool bCheckProxyActor, int actorIdOwner)
		{
			return default(bool);
		}

		public static bool IsMultiPlayEventReceiver(CharacterBase target)
		{
			return default(bool);
		}

		public static bool IsMultiPlayEventSender(CharacterBase target)
		{
			return default(bool);
		}

		public static void SetMoveSyncDisabled(CharacterBase target, bool isDisabled)
		{
		}

		public List<int> GetCurrentPlayersActorId()
		{
			return null;
		}

		public int GetOtherPlayerRebornCharacterCount(int actorId)
		{
			return default(int);
		}

		public int GetOtherPlayerRebornProcessCount(int actorId)
		{
			return default(int);
		}

		public bool IsAnyOtherPlayerRemainContinueCount(int limit)
		{
			return default(bool);
		}

		public bool IsRoomPlayerActorId(int actorId)
		{
			return default(bool);
		}

		public void EnterStrictCheckSection()
		{
		}

		public void LeaveStrictCheckSection()
		{
		}

		public void DisconnectWithError(MultiPlayError error)
		{
		}

		public void Disconnect(string reason)
		{
		}

		public bool IsQuestRetireConditionSatisfied()
		{
			return default(bool);
		}

		public QuestRetireReasons GetQuestRetireReason()
		{
			return default(QuestRetireReasons);
		}

		public bool IsOtherPlayerDisconnected()
		{
			return default(bool);
		}

		public bool IsLonelyMultiPlay()
		{
			return default(bool);
		}

		public void SetLeaveAlone()
		{
		}

		public bool IsLeaveAloneEnabled()
		{
			return default(bool);
		}

		public bool CanSoloPlayAfterDisconnection()
		{
			return default(bool);
		}

		public bool IsRankingQuest()
		{
			return default(bool);
		}

		public int GetLeaveAloneFlag()
		{
			return default(int);
		}

		public void RegisterEnemyAbilityEventCallback(EnemyAbilityProcBase callback)
		{
		}

		public void SendClearTimerEvent(ClearTimerEvent.EventTypes eventType)
		{
		}

		public void StartSuccessiveGameTimer()
		{
		}

		public static void RequestResetBuffDebuffByConditionId(CharacterBase character, int conditionId, int abilityId, int productId)
		{
		}

		private void ProcessDisconnectOwnEvent(MultiPlayErrorEventService.Event e)
		{
		}

		private void ProcessDisconnectOtherPlayerEvent(MultiPlayErrorEventService.Event e)
		{
		}

		private void ProcessDisableRankingEvent(MultiPlayErrorEventService.Event e)
		{
		}

		private void ProcessDisableInstructorBonusEvent(MultiPlayErrorEventService.Event e)
		{
		}

		public void SetupInstructorBonusViewerList()
		{
		}

		public bool CheckInstructorBonusOtherPlayer()
		{
			return default(bool);
		}

		public void DisplayDisableInstructorBonusMessage()
		{
		}

		public void ClearOldEvents()
		{
		}

		public void OnClearQuest()
		{
		}

		private void OnApplicationPause(bool paused)
		{
		}

		public void SetBRPulse(BRPulse pulse)
		{
		}

		public bool IsBRTutorial()
		{
			return default(bool);
		}

		public void NotifyChangeLookingCharacter(CharacterBase chara)
		{
		}

		public void RequestCreateBuffField(long buffFieldId, long actionPartsResourceId, string hitAttrLabel, Vector3 position, Quaternion rotation, CharacterBase owner, int actionId, int skillId, int actionProductId, ActionStartParameter actionStartParam, bool isHostRequest)
		{
		}

		private bool TryReceiveAttackHitEvent(AttackHit recvEvent)
		{
			return default(bool);
		}
	}
}
