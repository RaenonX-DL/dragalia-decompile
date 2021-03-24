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
	public class LoadBalancingPeer : PhotonPeer
	{
		// Fields
		private readonly Dictionary<byte, object> opParameters;
	
		// Constructors
		public LoadBalancingPeer(ConnectionProtocol protocolType);
		public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType);
	
		// Methods
		[Conditional]
		private void ConfigUnitySockets();
		public virtual bool OpGetRegions(string appId);
		public virtual bool OpJoinLobby(TypedLobby lobby = null);
		public virtual bool OpLeaveLobby();
		private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions);
		public virtual bool OpCreateRoom(EnterRoomParams opParams);
		public virtual bool OpJoinRoom(EnterRoomParams opParams);
		public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams);
		public virtual bool OpLeaveRoom(bool becomeInactive);
		public virtual bool OpFindFriends(string[] friendsToFind);
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, Hashtable expectedProperties = null, WebFlags webflags = null);
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties = null, WebFlags webflags = null);
		public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics);
		public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol);
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd);
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions);
		public virtual bool OpSettings(bool receiveLobbyStats);
	}
}
