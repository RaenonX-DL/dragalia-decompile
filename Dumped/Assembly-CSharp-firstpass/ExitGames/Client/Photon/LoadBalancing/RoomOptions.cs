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
	public class RoomOptions
	{
		// Fields
		private bool isVisible;
		private bool isOpen;
		public byte MaxPlayers;
		public int PlayerTtl;
		public int EmptyRoomTtl;
		[CompilerGenerated]
		private bool _CheckUserOnJoin_k__BackingField;
		private bool cleanupCacheOnLeave;
		public Hashtable CustomRoomProperties;
		public string[] CustomRoomPropertiesForLobby;
		public string[] Plugins;
		[CompilerGenerated]
		private bool _SuppressRoomEvents_k__BackingField;
		[CompilerGenerated]
		private bool _PublishUserId_k__BackingField;
	
		// Properties
		public bool IsVisible { get; set; }
		public bool IsOpen { get; set; }
		public bool CheckUserOnJoin { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool CleanupCacheOnLeave { get; set; }
		public bool SuppressRoomEvents { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool PublishUserId { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public RoomOptions();
	}
}
