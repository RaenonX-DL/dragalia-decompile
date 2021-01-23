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
	public class Player
	{
		// Fields
		[CompilerGenerated]
		private Room _RoomReference_k__BackingField;
		private int actorID;
		public readonly bool IsLocal;
		private string nickName;
		[CompilerGenerated]
		private bool _IsInactive_k__BackingField;
		[CompilerGenerated]
		private Hashtable _CustomProperties_k__BackingField;
		public object Tag;
	
		// Properties
		protected internal Room RoomReference { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int ID { get; }
		public string NickName { get; set; }
		public bool IsMasterClient { get; }
		public bool IsInactive { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Hashtable CustomProperties { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Hashtable AllProperties { get; }
	
		// Constructors
		protected internal Player(string nickName, int actorID, bool isLocal);
		protected internal Player(string nickName, int actorID, bool isLocal, Hashtable playerProperties);
	
		// Methods
		public Player Get(int id);
		public Player GetNext();
		public Player GetNextFor(Player currentPlayer);
		public Player GetNextFor(int currentPlayerId);
		public virtual void CacheProperties(Hashtable properties);
		public override string ToString();
		public override bool Equals(object p);
		public override int GetHashCode();
		protected internal void ChangeLocalID(int newID);
		public bool SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null);
		private void SetPlayerNameProperty();
	}
}
