using System;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Bullet
{
	public class BulletObjectSyncMove
	{
		private BulletObject bullet;

		private Vector3 syncMovePos;

		private Vector3 lastSyncMovePos;

		private float syncMovePosInterTimer;

		private float syncMovePosDelayTimer;

		private const float syncMovePosIntervalTime = 0.3f;

		private BulletSyncMoveEventParam syncMoveEventParam;

		private Func<bool> IsSyncMoveEnabled;

		public void Initialize(BulletObject bullet, Func<bool> isSyncMoveEnabled)
		{
		}

		public void Clear()
		{
		}

		public void OnUpdate()
		{
		}

		private void SendBulletSyncMoveEvent()
		{
		}

		public void OnReceiveBulletEvent(BulletEvent recvEvent)
		{
		}
	}
}
