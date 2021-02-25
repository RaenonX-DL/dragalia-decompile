/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MessagePack;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public struct RegenerationSyncData
	{
		// Fields
		[Key]
		public int multiPlayKey;
		[ActionConditionId]
		[Key]
		public int conditionId;
		[Key]
		public float healValue1;
		[Key]
		public float healValue2;
		[Key]
		public float healValue3;
		[Key]
		public float durationSec;
		[Key]
		public int abilityId;
		[Key]
		public CharacterId from;
		[Key]
		public int productId;
		[Key]
		public byte hitTargetGroup;
		[Key]
		public int skillId;
		[Key]
		public float healValue4;
		[Key]
		public int slipDamageGroup;
		[Key]
		public float rateIncreaseByTime;
		[Key]
		public float increaseRate;
	}
}
