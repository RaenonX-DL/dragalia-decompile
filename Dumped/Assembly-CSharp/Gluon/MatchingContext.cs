/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public struct MatchingContext
	{
		// Fields
		[CompilerGenerated]
		private int _QuestId_k__BackingField;
		[CompilerGenerated]
		private bool _IsBR_k__BackingField;
		[CompilerGenerated]
		private bool _IsBRTutorial_k__BackingField;
		[CompilerGenerated]
		private DebugAutoJoinRoomSetting _DebugAutoJoinRoomSetting_k__BackingField;
		[CompilerGenerated]
		private DebugMatchingSetting _DebugMatchingSetting_k__BackingField;
		[CompilerGenerated]
		private bool _IsSoloPlayWithPhoton_k__BackingField;
		[CompilerGenerated]
		private bool _IsRandomMatching_k__BackingField;
	
		// Properties
		public int QuestId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsBR { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsBRTutorial { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DebugAutoJoinRoomSetting DebugAutoJoinRoomSetting { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DebugMatchingSetting DebugMatchingSetting { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsSoloPlayWithPhoton { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsRandomMatching { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int MaxPlayers { get; }
	
		// Constructors
		public MatchingContext(int questId, bool isBR = false, bool isBRTutorial = false, DebugAutoJoinRoomSetting brDebugSetting = null, bool isSoloPlayWithPhoton = false, bool isRandomMatching = false, DebugMatchingSetting debugMatchingSetting = null);
	}
}
