/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon.Gimmick;
using Gluon.Event;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MultiPlayWarpCtrl
	{
		// Fields
		private Dictionary<WarpRoom.RoomGroup, int> lockedDic;
		private WarpEvent tmpWarpEvent;
		private WarpEvent warpEventOnRequest;
	
		// Constructors
		public MultiPlayWarpCtrl();
	
		// Methods
		public void Reset();
		public bool LockWarp(WarpRoom.RoomGroup roomGroup, int actorId);
		public bool UnlockWarp(WarpRoom.RoomGroup roomGroup, int actorId);
		public bool CanLock(WarpRoom.RoomGroup roomGroup);
		public bool IsLocked(WarpRoom.RoomGroup roomGroup, int actorId);
		public void OnDisconnectUser(int disconnectActorId);
		public void OnReceiveWarpEvent(WarpEvent recvEvent);
		public bool RequestLock(WarpRoom.RoomGroup roomGroup, WarpRoom.DoorKind doorKind, int actorId, CharacterBase chara, bool checkIsDead, bool isForceReturn);
		public bool RequestUnlock(WarpRoom.RoomGroup roomGroup, WarpRoom.DoorKind doorKind, int actorId, CharacterBase chara, bool checkIsDead, bool isForceReturn);
		public void OnSoloMode();
	}
}
