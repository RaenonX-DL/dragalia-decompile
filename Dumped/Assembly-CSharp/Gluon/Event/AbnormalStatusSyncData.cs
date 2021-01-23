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
	public struct AbnormalStatusSyncData
	{
		// Fields
		[ActionConditionId]
		[Key]
		public int elemId;
		[Key]
		public ushort durationNum;
		[Key]
		public float durationTime;
		[Key]
		public float baseSlipDamage;
		[Key]
		public float lifeSec;
		[Key]
		public CharacterId from;
	}
}
