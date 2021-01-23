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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class StockBulletObject : BulletObject
	{
		// Fields
		private Phase phase;
		private float timer;
		private Vector3 directionRotation;
		private int alignIndex;
		private float autoFireTimer;
		private float autoFireEffectTriggerResetTimer;
		private StockBulletDataCopy copyData;
	
		// Nested types
		private enum Phase
		{
			None = 0,
			Start = 1,
			Rotate = 2,
			Fire = 3,
			Hiding = 4,
			Release = 5
		}
	
		private class StockBulletDataCopy
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
		public void SetBulletData(StockBulletData data);
		protected override void Clear();
		public override bool Initialize(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, Vector3 position, Quaternion rotation);
		protected override bool OnUpdate();
		public override void PlayEffect();
		public void SetInitRotation(Quaternion rot);
		public void Reset(int index, int maxCount, Quaternion initRot);
		public void Fire();
		public void Release();
		public void Restart();
		public void Hide();
		private void ChangeTarget(CommonObjectStatus target);
		public override void OnReceiveBulletEvent(BulletEvent recvEvent);
	}
}
