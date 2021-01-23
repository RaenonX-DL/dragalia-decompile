/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon.LoadBalancing
{
	public class RoomInfo
	{
		// Fields
		protected internal bool removedFromList;
		private Hashtable customProperties;
		protected byte maxPlayers;
		protected string[] expectedUsersField;
		protected bool isOpen;
		protected bool isVisible;
		protected string name;
		protected internal int masterClientIdField;
		[CompilerGenerated]
		private bool _serverSideMasterClient_k__BackingField;
		protected string[] propsListedInLobby;
		[CompilerGenerated]
		private int _PlayerCount_k__BackingField;
		[CompilerGenerated]
		private bool _IsLocalClientInside_k__BackingField;
	
		// Properties
		protected internal bool serverSideMasterClient { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Hashtable CustomProperties { get; }
		public string Name { get; }
		public int PlayerCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsLocalClientInside { [CompilerGenerated] get; [CompilerGenerated] set; }
		public byte MaxPlayers { get; }
		public bool IsOpen { get; }
		public bool IsVisible { get; }
	
		// Constructors
		protected internal RoomInfo(string roomName, Hashtable roomProperties);
	
		// Methods
		public override bool Equals(object other);
		public override int GetHashCode();
		public override string ToString();
		public string ToStringFull();
		protected internal virtual void CacheProperties(Hashtable propertiesToCache);
	}
}
