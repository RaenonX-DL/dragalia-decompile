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
	public class Room : RoomInfo
	{
		// Fields
		protected internal int PlayerTTL;
		protected internal int RoomTTL;
		[CompilerGenerated]
		private LoadBalancingClient _LoadBalancingClient_k__BackingField;
		private Dictionary<int, Player> players;
	
		// Properties
		protected internal LoadBalancingClient LoadBalancingClient { [CompilerGenerated] get; [CompilerGenerated] set; }
		public new string Name { get; internal set; }
		public new bool IsOpen { get; set; }
		public new bool IsVisible { get; set; }
		public new byte MaxPlayers { get; set; }
		public new byte PlayerCount { get; }
		public Dictionary<int, Player> Players { get; private set; }
		public string[] ExpectedUsers { get; }
		public int MasterClientId { get; }
		public string[] PropsListedInLobby { get; private set; }
	
		// Constructors
		protected internal Room();
		protected internal Room(string roomName);
		protected internal Room(string roomName, RoomOptions options);
	
		// Methods
		public virtual bool SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null);
		public void SetPropertiesListedInLobby(string[] propsToListInLobby);
		protected internal virtual void RemovePlayer(Player player);
		protected internal virtual void RemovePlayer(int id);
		protected internal virtual void MarkAsInactive(int id);
		private void UpdateMasterClientId();
		public bool SetMasterClient(Player masterClientPlayer);
		public virtual bool AddPlayer(Player player);
		public virtual Player StorePlayer(Player player);
		public virtual Player GetPlayer(int id);
		public void ClearExpectedUsers();
		public override string ToString();
		public new string ToStringFull();
	}
}
