/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class Party : EventBase<Party>
	{
		// Fields
		[Key]
		[Required]
		public Dictionary<int, int> memberCountTable;
		[Key]
		public int rankingType;
		[Key]
		public int reBattleCount;
		[Key]
		public bool isAutoFailTimeoutEnabled;
		[Key]
		public float forceAutoFailTime;
		[Key]
		public bool isDisableOnDamagedWhenLeave;
	
		// Constructors
		public Party();
	}
}
