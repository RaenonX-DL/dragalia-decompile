/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class BulletObjectSyncMove
	{
		// Fields
		private BulletObject bullet;
		private Vector3 syncMovePos;
		private Vector3 lastSyncMovePos;
		private float syncMovePosInterTimer;
		private float syncMovePosDelayTimer;
		private const float syncMovePosIntervalTime = 0.3f;
		private BulletSyncMoveEventParam syncMoveEventParam;
		private Func<bool> IsSyncMoveEnabled;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__9_0;
			public static Func<bool> __9__13_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Clear_b__9_0();
			internal bool _.ctor_b__13_0();
		}
	
		// Constructors
		public BulletObjectSyncMove();
	
		// Methods
		public void Initialize(BulletObject bullet, Func<bool> isSyncMoveEnabled);
		public void Clear();
		public void OnUpdate();
		private void SendBulletSyncMoveEvent();
		public void OnReceiveBulletEvent(BulletEvent recvEvent);
	}
}
