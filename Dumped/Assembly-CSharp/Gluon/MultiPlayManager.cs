/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MultiPlayManager : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private static MultiPlayManager _instance_k__BackingField;
		[CompilerGenerated]
		private MultiType _multiType_k__BackingField;
		[CompilerGenerated]
		private QuestState _questState_k__BackingField;
		[CompilerGenerated]
		private bool _IsSoloPlayWithPhoton_k__BackingField;
		[CompilerGenerated]
		private Dictionary<int, List<CharacterData>> _otherCharacters_k__BackingField;
		[CompilerGenerated]
		private CharacterData _ownCharacters_k__BackingField;
		private Dictionary<int, int> _memberCountTable;
		public List<int> actorIds;
		private PlayerInfo[] playerInfos;
		[CompilerGenerated]
		private OnStamp onStamp;
		[CompilerGenerated]
		private OnTargetParts onTargetParts;
		[CompilerGenerated]
		private int _actorIdSelf_k__BackingField;
		private List<EventSenderBase> moveEventSenders;
		private MoveBundle moveBundle;
		private float sendTimer;
		private float idleTimer;
		public Queue<EventD00562> eventD00562ReceiveBuffer;
		public List<EventE02660> eventE02660ReceiveBuffer;
		private WillLeave tmpWillLeaveEvent;
		[CompilerGenerated]
		private int _CurrentHostActorId_k__BackingField;
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
		[CompilerGenerated]
		private SleepTimeoutCtrl _SleepTimeoutCtrl_k__BackingField;
		private MultiPlaySettings settings;
		private MultiPlayRetryVoteCtrl _retryVoteCtrl;
		private List<EnemyAbilityProcBase> _enemyAbilityCallbackList;
		private bool _isRankingQuest;
		private bool _isSuccessiveGameTimerSent;
		private GoToIngameInfo _gotoIngameInfo;
		[CompilerGenerated]
		private bool _IsAutoFailTimeoutEnabled_k__BackingField;
		[CompilerGenerated]
		private float _ForceAutoFailTime_k__BackingField;
		public static readonly int MaxPlayer;
		private MultiPlayReceiveEventBuffering _recvEventBuffering;
		[CompilerGenerated]
		private MultiPlayWarpCtrl _WarpCtrl_k__BackingField;
		[CompilerGenerated]
		private bool _IsDisableOnDamagedWhenLeave_k__BackingField;
		[CompilerGenerated]
		private MultiPlayAuraCtrl _MultiPlayAuraCtrl_k__BackingField;
	
		// Properties
		public static MultiPlayManager instance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public MultiType multiType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public QuestState questState { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsCoopMultiPlay { get; }
		public bool IsSoloPlayWithPhoton { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Dictionary<int, List<CharacterData>> otherCharacters { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CharacterData ownCharacters { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public GoToIngameInfo.BRInitData brInitData { get; }
		public int actorCount { get; }
		public int actorIdSelf { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsMultiPlayHost { get; }
		public bool IsMultiPlayGuest { get; }
		public bool IsMultiPlayHostOrSolo { get; }
		public int CurrentHostActorId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public MultiPlayTemporaries Temporaries { get; }
		public MultiPlayErrorEventService ErrorEventService { get; }
		public SleepTimeoutCtrl SleepTimeoutCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public MultiPlaySettings MultiPlaySettings { get; }
		public MultiPlayRetryVoteModel RetryVoteModel { get; }
		public bool IsAutoFailTimeoutEnabled { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float ForceAutoFailTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public MultiPlayWarpCtrl WarpCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsDisableOnDamagedWhenLeave { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public MultiPlayAuraCtrl MultiPlayAuraCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ulong[] RoomPlayers { get; }
	
		// Events
		public event OnStamp onStamp {
			add;
			remove;
		}
		public event OnTargetParts onTargetParts {
			add;
			remove;
		}
	
		// Nested types
		public enum MultiType
		{
			Quest = 0,
			Raid = 1,
			Field = 2,
			Battle = 3
		}
	
		public enum QuestState
		{
			None = 0,
			MultiPlayPartyConfirmed = 1,
			Waiting = 2,
			InGame = 3
		}
	
		public enum StoryState
		{
			None = 0,
			Waiting = 1,
			AllFinished = 2
		}
	
		public enum QuestRetireReasons
		{
			None = 0,
			ByDisconnection = 1,
			ByLeaveAlone = 2
		}
	
		public class PlayerInfo
		{
			// Fields
			public string Name;
			public WillLeave.Reasons WillLeaveReason;
			public bool IsAllDeadConfirmed;
	
			// Constructors
			public PlayerInfo();
		}
	
		public delegate void OnStamp(int playerIndex, int iconId);
	
		public delegate void OnTargetParts(int playerIndex, int partsId);
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<GoToIngameInfo.ActorData> __9__124_0;
			public static Func<GoToIngameInfo.ActorData, int> __9__124_1;
			public static Action __9__132_0;
			public static Action __9__136_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _PostInitialize_b__124_0(GoToIngameInfo.ActorData a, GoToIngameInfo.ActorData b);
			internal int _PostInitialize_b__124_1(GoToIngameInfo.ActorData v);
			internal void _OnEvent_b__132_0();
			internal void _PostDisconnected_b__136_0();
		}
	
		// Constructors
		public MultiPlayManager();
		static MultiPlayManager();
	
		// Methods
		public static bool IsDisconnected();
		public static bool WillBeDisconnected();
		public static void Create();
		private void Awake();
		public void PostInitialize(GoToIngameInfo gotoIngameInfo, MatchingService.Room snapshot, SleepTimeoutCtrl sleepTimeoutCtrl);
		public int GetActorIndex(int actorId);
		public string GetActorLabel(int actorId);
		public int GetActorIdFromIndex(int index);
		public ulong GetViewerIdFromActorId(int actorId);
		public void TryCheckParty();
		public bool HasMultiPlayParty();
		private void OnOperationResponse(OperationResponse operationResponse);
		private void OnEvent(EventData photonEvent);
		public int GetMyPartyUnitCount();
		private void OnDisconnected();
		private void Error(MultiPlayError error);
		private void PostDisconnected();
		public static EventReceiverBase FindEventReceiverFromCharacterId(CharacterId id);
		public static CharacterBase FindCharacterFromCharacterId(CharacterId id, bool ignoreEnemyPool = false);
		public static List<CharacterBase> FindCharacterFromCharacterIds(List<CharacterId> ids);
		public void InitializeOtherControls();
		public void ReadyToStartQuest();
		public void SetControlPlayer(CharacterSelector player);
		public string GetOtherPlayerName(int index);
		public void SetOtherPlayerName(int index, string name);
		public void SendWillLeave(WillLeave.Reasons reason);
		public void Continue();
		public void SendWaitReborn(List<CharacterBase> targetCharas, bool isAbilityReborn);
		public void SendReborn(List<Tuple<CharacterBase, float>> rebornCharaInfos, bool isAbilityReborn);
		public void SetAllDeadConfirmed(bool flag);
		public bool IsAllOtherPlayerAllDeadConfirmed();
		public void AddMoveEventSender(EventSenderBase eventSender);
		public void Update();
		private void LateUpdate();
		public static void Destroy();
		public bool HasMultiPlayOwner(CharacterBase chara);
		public bool HasMultiPlayInitialOwner(CharacterBase chara);
		public bool HasMultiPlayOwner(CharacterBase chara, bool bCheckProxyActor, int actorIdOwner);
		public static bool IsMultiPlayEventReceiver(CharacterBase target);
		public static bool IsMultiPlayEventSender(CharacterBase target);
		public static void SetMoveSyncDisabled(CharacterBase target, bool isDisabled);
		public List<int> GetCurrentPlayersActorId();
		public int GetOtherPlayerRebornCharacterCount(int actorId);
		public int GetOtherPlayerRebornProcessCount(int actorId);
		public bool IsAnyOtherPlayerRemainContinueCount(int limit);
		public bool IsRoomPlayerActorId(int actorId);
		public void EnterStrictCheckSection();
		public void LeaveStrictCheckSection();
		public void DisconnectWithError(MultiPlayError error);
		public void Disconnect(string reason);
		public bool IsQuestRetireConditionSatisfied();
		public QuestRetireReasons GetQuestRetireReason();
		public bool IsOtherPlayerDisconnected();
		public bool IsLonelyMultiPlay();
		public void SetLeaveAlone();
		public bool IsLeaveAloneEnabled();
		public bool CanSoloPlayAfterDisconnection();
		public bool IsRankingQuest();
		public int GetLeaveAloneFlag();
		public void RegisterEnemyAbilityEventCallback(EnemyAbilityProcBase callback);
		public void SendClearTimerEvent(ClearTimerEvent.EventTypes eventType);
		public void StartSuccessiveGameTimer();
		public static void RequestResetBuffDebuffByConditionId(CharacterBase character, int conditionId, int abilityId, int productId);
		private void ProcessDisconnectOwnEvent(MultiPlayErrorEventService.Event e);
		private void ProcessDisconnectOtherPlayerEvent(MultiPlayErrorEventService.Event e);
		private void ProcessDisableRankingEvent(MultiPlayErrorEventService.Event e);
		private void ProcessDisableInstructorBonusEvent(MultiPlayErrorEventService.Event e);
		public void SetupInstructorBonusViewerList();
		public bool CheckInstructorBonusOtherPlayer();
		public void DisplayDisableInstructorBonusMessage();
		public void ClearOldEvents();
		public void OnClearQuest();
		private void OnApplicationPause(bool paused);
		public void SetBRPulse(BRPulse pulse);
		public bool IsBRTutorial();
		public void NotifyChangeLookingCharacter(CharacterBase chara);
		public void RequestCreateBuffField(long buffFieldId, long actionPartsResourceId, string hitAttrLabel, Vector3 position, Quaternion rotation, CharacterBase owner, int actionId, int skillId, int actionProductId, ActionStartParameter actionStartParam, bool isHostRequest);
		private bool TryReceiveAttackHitEvent(AttackHit recvEvent);
		[CompilerGenerated]
		private bool _Awake_b__123_0(object recvEvent);
	}
}
