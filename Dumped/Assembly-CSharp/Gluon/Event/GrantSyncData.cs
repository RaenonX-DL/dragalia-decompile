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
	public struct GrantSyncData
	{
		// Fields
		[Key]
		public int multiPlayKey;
		[Key]
		public byte trigger;
		[ActionConditionId]
		[Key]
		public int conditionId;
		[Key]
		public float durationSec;
		[Key]
		public int attribute;
	}
}
