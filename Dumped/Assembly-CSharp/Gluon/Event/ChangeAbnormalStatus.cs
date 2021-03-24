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
	public class ChangeAbnormalStatus : EventBase<ChangeAbnormalStatus>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId character;
		[Key]
		[Required]
		public List<AbnormalStatusSyncData> abnormalStatus;
		[Key]
		public byte[] dummy;
		[Key]
		public short[] abnormalResists;
	
		// Constructors
		public ChangeAbnormalStatus();
	}
}
