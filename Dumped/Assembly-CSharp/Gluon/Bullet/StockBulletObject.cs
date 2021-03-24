/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class StockBulletObject : BulletObject
	{
		// Fields
		protected Phase phase;
		protected float timer;
		protected Vector3 directionRotation;
		protected int alignIndex;
		protected float autoFireTimer;
		protected float autoFireEffectTriggerResetTimer;
		private StockBulletDataCopy copyData;
	
		// Nested types
		protected enum Phase
		{
			None = 0,
			Start = 1,
			Rotate = 2,
			Fire = 3,
			Hiding = 4,
			Release = 5,
			Restart = 6
		}
	
		public class StockBulletDataCopy
		{
			// Fields
			public float aroundWaitTime;
			public float aroundDurationTime;
			public BulletData.AlignAxis alignAxis;
			public Vector3 alignmentOriginOffset;
			public bool shouldDistributeEvenNumbers;
			public bool syncRotationWithOwner;
			public bool facingToTarget;
			public float autoFireInterval;
			public int autoFireActionId;
			public int autoFireEffectTrigger;
			public float autoFireEffectTriggerResetTime;
			public float autoFireAutoSearchEnemyRadius;
	
			// Constructors
			public StockBulletDataCopy();
	
			// Methods
			public void Clear();
		}
	
		// Constructors
		public StockBulletObject();
	
		// Methods
		public void SetStockBulletData(StockBulletData data, StockBulletDataCopy copyData = null);
		protected override void Clear();
		public override bool Initialize(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, Vector3 position, Quaternion rotation);
		protected override bool OnUpdate();
		protected virtual void ProcessAutoFire();
		public override void PlayEffect();
		public void SetInitRotation(Quaternion rot);
		public void Reset(int index, int maxCount, Quaternion initRot);
		public void Fire();
		public void Release();
		public virtual void Restart();
		public void Hide();
		private void ChangeTarget(CommonObjectStatus target);
		public override void OnReceiveBulletEvent(BulletEvent recvEvent);
	}
}
