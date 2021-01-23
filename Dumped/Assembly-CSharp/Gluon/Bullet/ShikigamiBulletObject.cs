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
	public class ShikigamiBulletObject : StockBulletObject
	{
		// Fields
		[CompilerGenerated]
		private ShikigamiData.LevelIndex _level_k__BackingField;
		private int hitCount;
		private const int usingCpIndex = 0;
		private bool isFireTriggerKicked;
		[CompilerGenerated]
		private CharacterBuff.Parameter _associatedBuff_k__BackingField;
		private ShikigamiBulletDataCopy copyData;
	
		// Properties
		public ShikigamiData.LevelIndex level { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CharacterBuff.Parameter associatedBuff { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int CpCostOnAttack { get; }
	
		// Nested types
		protected class ShikigamiBulletDataCopy : StockBulletObject.StockBulletDataCopy
		{
			// Fields
			public int cpCostOnAttack;
			public int cpCostOnAttackLv2;
			public int hitCountForLevelUp;
			public int effectTriggerLv2;
			public int autoFireEffectTriggerLv2;
			public int[] autoFireActionIdList;
			public int actionConditionId;
			public int fireTrigger;
	
			// Constructors
			public ShikigamiBulletDataCopy();
		}
	
		// Constructors
		public ShikigamiBulletObject();
	
		// Methods
		public void SetShikigamiBulletData(ShikigamiData data);
		protected override void Clear();
		protected void GetQuantityAndPositionIndex(out ShikigamiData.QuantityIndex q, out ShikigamiData.PositionIndex p);
		public void OnRemoved();
		protected override bool OnUpdate();
		public override void PlayEffect();
		public override void StopEffect(bool immediately = false);
		protected override void ProcessAutoFire();
		public void OnHitCountAdded(int count);
		public override bool Initialize(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, Vector3 position, Quaternion rotation);
		private void SendShikigamiLevelUpEvent();
		private void SendShikigamiRemoveEvent();
		public override void OnReceiveBulletEvent(BulletEvent recvEvent);
		[CompilerGenerated]
		private void _Initialize_b__24_0(CharacterBuffType type, CharacterBuff.Parameter buffDebuff);
	}
}
