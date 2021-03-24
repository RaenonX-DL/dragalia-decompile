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
	public class ShikigamiBulletObject : StockBulletObject
	{
		// Fields
		[CompilerGenerated]
		private ShikigamiData.LevelIndex _level_k__BackingField;
		private int hitCount;
		private const int usingCpIndex = 0;
		private bool isFireTriggerKicked;
		private static readonly float _shikigamiDurationEventSendIntervalTime;
		private float _shikigamiDurationEventSendDelayTimer;
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
			public string headTextLv2;
			public int headIconLv2;
	
			// Constructors
			public ShikigamiBulletDataCopy();
		}
	
		// Constructors
		public ShikigamiBulletObject();
		static ShikigamiBulletObject();
	
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
		private void ApplyShikigamiBuff(bool applyActionId = true);
		private void SendShikigamiLevelUpEvent();
		private void SendShikigamiRemoveEvent();
		private void SendShikigamiDurationEvent();
		public override void OnReceiveBulletEvent(BulletEvent recvEvent);
		public override void Restart();
		[CompilerGenerated]
		private void _ApplyShikigamiBuff_b__27_0(CharacterBuffType type, CharacterBuff.Parameter buffDebuff);
	}
}
