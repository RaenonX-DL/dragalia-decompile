/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public struct AuraEventCommandData
	{
		// Fields
		[Key]
		[Required]
		public CharacterId to;
		[Key]
		[Required]
		public AuraEventCommandType commandType;
		[Key]
		public int multiPlayKey;
		[Key]
		public int auraId;
		[Key]
		public int auraType;
		[Key]
		public int targetType;
		[Key]
		public int level;
		[Key]
		public float rate;
		[Key]
		public float duration;
		[Key]
		public CharacterId from;
		[Key]
		public int actionId;
		[Key]
		public int skillId;
		[Key]
		public int productId;
		[Key]
		public int publishLevel;
		[Key]
		public Dictionary<int, int> maxLimitLevelDict;
		[Key]
		public RemoveBuffReason reason;
		[Key]
		public bool durationUpdate;
	}
}
