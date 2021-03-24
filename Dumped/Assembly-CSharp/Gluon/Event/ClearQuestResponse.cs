/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class ClearQuestResponse : EventBase<ClearQuestResponse>
	{
		// Fields
		[Key]
		[Required]
		public byte[] recordMultiResponse;
		[Key]
		[Required]
		public int clearTime;
		[Key]
		public bool isIgnoreRanking;
	
		// Constructors
		public ClearQuestResponse();
	}
}
