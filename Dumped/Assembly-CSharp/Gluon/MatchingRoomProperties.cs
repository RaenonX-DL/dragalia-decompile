/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Gluon.Event;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingRoomProperties
	{
		// Fields
		[CompilerGenerated]
		private int _QuestId_k__BackingField;
		[CompilerGenerated]
		private MatchingType _MatchingType_k__BackingField;
		[CompilerGenerated]
		private RoomType _RoomType_k__BackingField;
		[CompilerGenerated]
		private MatchingContext _MatchingContext_k__BackingField;
		private string _region;
		private string _clusterName;
		private string _language;
		private RoomEntryCondition _condition;
		private Location _location;
	
		// Properties
		public int QuestId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public MatchingType MatchingType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public RoomType RoomType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public MatchingContext MatchingContext { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string Region { get; set; }
		public string ClusterName { get; set; }
		public string Language { get; set; }
		public RoomEntryCondition RoomEntryCondition { get; set; }
		public Location Location { get; set; }
	
		// Constructors
		public MatchingRoomProperties();
	
		// Methods
		public Hashtable GetCustomRoomProperties();
		public string[] GetCustomRoomPropertiesForLobby();
		public static bool IsAutoJoinEnabled(MatchingType matchingType, RoomEntryCondition condition);
	}
}
