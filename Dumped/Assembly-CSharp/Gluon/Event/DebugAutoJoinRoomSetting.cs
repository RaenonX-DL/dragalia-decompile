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
	public class DebugAutoJoinRoomSetting
	{
		// Fields
		[Key]
		public bool disableBot;
		[Key]
		public int[] botBRSkinId;
		[Key]
		public bool isDebugMatching;
		[Key]
		public int minMatchingWithBotsPlayerCount;
		[Key]
		public float mathingWithBotsWaitSec;
		[Key]
		public int matchingWithoutBotsPlayerCount;
		[Key]
		public int locationPattern;
	
		// Constructors
		public DebugAutoJoinRoomSetting();
	}
}
