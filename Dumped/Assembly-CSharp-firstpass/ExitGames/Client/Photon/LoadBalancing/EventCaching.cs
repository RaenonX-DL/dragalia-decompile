/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon.LoadBalancing
{
	public enum EventCaching : byte
	{
		DoNotCache = 0,
		MergeCache = 1,
		ReplaceCache = 2,
		RemoveCache = 3,
		AddToRoomCache = 4,
		AddToRoomCacheGlobal = 5,
		RemoveFromRoomCache = 6,
		RemoveFromRoomCacheForActorsLeft = 7,
		SliceIncreaseIndex = 10,
		SliceSetIndex = 11,
		SlicePurgeIndex = 12,
		SlicePurgeUpToIndex = 13
	}
}
