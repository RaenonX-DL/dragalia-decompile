using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Dungeon.Gimmick;
using Gluon.Event;

namespace Gluon
{
	public class MultiPlayWarpCtrl
	{
		private Dictionary<WarpRoom.RoomGroup, int> lockedDic;

		private WarpEvent tmpWarpEvent;

		private WarpEvent warpEventOnRequest;

		public bool IsDisconnected
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Reset()
		{
		}

		public bool LockWarp(WarpRoom.RoomGroup roomGroup, int actorId)
		{
			return default(bool);
		}

		public bool UnlockWarp(WarpRoom.RoomGroup roomGroup, int actorId)
		{
			return default(bool);
		}

		public bool CanLock(WarpRoom.RoomGroup roomGroup)
		{
			return default(bool);
		}

		public bool IsLocked(WarpRoom.RoomGroup roomGroup, int actorId)
		{
			return default(bool);
		}

		public void OnDisconnectUser(int disconnectActorId)
		{
		}

		public void OnReceiveWarpEvent(WarpEvent recvEvent)
		{
		}

		public bool RequestLock(WarpRoom.RoomGroup roomGroup, WarpRoom.DoorKind doorKind, int actorId, CharacterBase chara, bool checkIsDead, bool isForceReturn)
		{
			return default(bool);
		}

		public bool RequestUnlock(WarpRoom.RoomGroup roomGroup, WarpRoom.DoorKind doorKind, int actorId, CharacterBase chara, bool checkIsDead, bool isForceReturn)
		{
			return default(bool);
		}

		public void OnSoloMode()
		{
		}
	}
}
