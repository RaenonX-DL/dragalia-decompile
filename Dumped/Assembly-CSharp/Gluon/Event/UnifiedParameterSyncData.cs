/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public struct UnifiedParameterSyncData
	{
		// Fields
		[Key]
		public int multiPlayKey;
		[ActionConditionId]
		[Key]
		public int conditionId;
		[Key]
		public float durationSec;
		[Key]
		public short durationNum;
		[Key]
		public int skillId;
		[Key]
		public int actionId;
		[Key]
		public int abilityId;
		[Key]
		public int productId;
		[Key]
		public byte hitTargetGroup;
		[Key]
		public CharacterId from;
		[Key]
		public float sacrificeShieldConsumeHp;
	}
}
