/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon.LoadBalancing
{
	public class LoadBalancingClient : IPhotonPeerListener
	{
		// Fields
		public LoadBalancingPeer loadBalancingPeer;
		[CompilerGenerated]
		private string _AppVersion_k__BackingField;
		[CompilerGenerated]
		private string _AppId_k__BackingField;
		[CompilerGenerated]
		private AuthenticationValues _AuthValues_k__BackingField;
		public AuthModeOption AuthMode;
		public EncryptionMode EncryptionMode;
		public ConnectionProtocol ExpectedProtocol;
		[CompilerGenerated]
		private bool _IsUsingNameServer_k__BackingField;
		public string NameServerHost;
		public string NameServerHttp;
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;
		[CompilerGenerated]
		private string _MasterServerAddress_k__BackingField;
		[CompilerGenerated]
		private string _GameServerAddress_k__BackingField;
		[CompilerGenerated]
		private ServerConnection _Server_k__BackingField;
		private ClientState state;
		[CompilerGenerated]
		private Action<ClientState> OnStateChangeAction;
		[CompilerGenerated]
		private Action<EventData> OnEventAction;
		[CompilerGenerated]
		private Action<OperationResponse> OnOpResponseAction;
		[CompilerGenerated]
		private DisconnectCause _DisconnectedCause_k__BackingField;
		private bool inLobby;
		[CompilerGenerated]
		private TypedLobby _CurrentLobby_k__BackingField;
		private bool autoJoinLobby;
		public bool EnableLobbyStatistics;
		private List<TypedLobbyInfo> lobbyStatistics;
		public Dictionary<string, RoomInfo> RoomInfoList;
		public Room CurrentRoom;
		private Player localPlayer;
		[CompilerGenerated]
		private int _PlayersOnMasterCount_k__BackingField;
		[CompilerGenerated]
		private int _PlayersInRoomsCount_k__BackingField;
		[CompilerGenerated]
		private int _RoomsCount_k__BackingField;
		private JoinType lastJoinType;
		private EnterRoomParams enterRoomParamsCache;
		private bool didAuthenticate;
		[CompilerGenerated]
		private List<FriendInfo> _FriendList_k__BackingField;
		private string[] friendListRequested;
		private int friendListTimestamp;
		private bool isFetchingFriendList;
		[CompilerGenerated]
		private string[] _AvailableRegions_k__BackingField;
		[CompilerGenerated]
		private string[] _AvailableRegionsServers_k__BackingField;
		[CompilerGenerated]
		private string _CloudRegion_k__BackingField;
		private byte[] encryptionSecret;
	
		// Properties
		public string AppVersion { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string AppId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public AuthenticationValues AuthValues { [CompilerGenerated] get; [CompilerGenerated] set; }
		private string TokenForInit { get; }
		public bool IsUsingNameServer { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string NameServerAddress { get; }
		public string CurrentServerAddress { get; }
		public string MasterServerAddress { [CompilerGenerated] get; [CompilerGenerated] protected internal set; }
		public string GameServerAddress { [CompilerGenerated] get; [CompilerGenerated] protected internal set; }
		public ServerConnection Server { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ClientState State { get; protected internal set; }
		public bool IsConnected { get; }
		public bool IsConnectedAndReady { get; }
		public DisconnectCause DisconnectedCause { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public TypedLobby CurrentLobby { [CompilerGenerated] get; [CompilerGenerated] protected internal set; }
		public bool AutoJoinLobby { get; set; }
		public List<TypedLobbyInfo> LobbyStatistics { get; private set; }
		public string NickName { get; set; }
		public string UserId { get; set; }
		public Player LocalPlayer { get; set; }
		public int PlayersOnMasterCount { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public int PlayersInRoomsCount { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public int RoomsCount { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public List<FriendInfo> FriendList { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int FriendListAge { get; }
		protected bool IsAuthorizeSecretAvailable { get; }
		public string[] AvailableRegions { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string[] AvailableRegionsServers { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string CloudRegion { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Events
		public event Action<ClientState> OnStateChangeAction {
			add;
			remove;
		}
		public event Action<EventData> OnEventAction {
			add;
			remove;
		}
		public event Action<OperationResponse> OnOpResponseAction {
			add;
			remove;
		}
	
		// Constructors
		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp);
		public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp);
		static LoadBalancingClient();
	
		// Methods
		private string GetNameServerAddress();
		public bool Connect(string masterServerAddress, string appId, string appVersion, string nickName, AuthenticationValues authValues);
		public virtual bool Connect();
		public bool ConnectToNameServer();
		public bool ConnectToRegionMaster(string region);
		public void Disconnect();
		private bool CallAuthenticate();
		public void Service();
		private void DisconnectToReconnect();
		private bool ConnectToGameServer();
		public bool OpGetRegions();
		public bool OpFindFriends(string[] friendsToFind);
		public bool OpJoinLobby(TypedLobby lobby);
		public bool OpLeaveLobby();
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, string[] expectedUsers = null);
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode);
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode, TypedLobby lobby, string sqlLobbyFilter, string[] expectedUsers = null);
		public bool OpJoinRoom(string roomName, string[] expectedUsers = null);
		public bool OpReJoinRoom(string roomName);
		public bool OpJoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, string[] expectedUsers = null);
		public bool OpCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, string[] expectedUsers = null);
		public bool OpLeaveRoom();
		public bool OpLeaveRoom(bool becomeInactive);
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null);
		[Obsolete]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward);
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, Hashtable expectedProperties = null, WebFlags webFlags = null);
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null);
		[Obsolete]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward);
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties = null, WebFlags webFlags = null);
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions);
		public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = false);
		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr);
		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr);
		protected internal void ChangeLocalID(int newID);
		private void CleanCachedValues();
		private void GameEnteredOnGameServer(OperationResponse operationResponse);
		private void UpdatedActorList(int[] actorsInGame);
		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties);
		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt);
		private void SetupEncryption(Dictionary<byte, object> encryptionData);
		public virtual void DebugReturn(DebugLevel level, string message);
		public virtual void OnOperationResponse(OperationResponse operationResponse);
		public virtual void OnStatusChanged(StatusCode statusCode);
		public virtual void OnEvent(EventData photonEvent);
		public virtual void OnMessage(object message);
	}
}
