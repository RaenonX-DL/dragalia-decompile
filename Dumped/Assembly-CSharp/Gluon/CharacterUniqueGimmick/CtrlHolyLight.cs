/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlHolyLight : CUGCtrlBase
	{
		// Fields
		private QuestSkillHolyLightElement variation;
		private CollisionHitAttribute hitAttribute;
		private PlayerCharacter currentChara;
		private float recastTimer;
		private int holyLightLevel;
		public const int MIN_LEVEL = 1;
		public const int MAX_LEVEL = 3;
		public bool selfHolyLightCanUse;
		[SerializeField]
		private string HOLYLIGHT_EFFECT_NAME;
		[SerializeField]
		private int NORMAL_EFFECT_TRIGGER;
		[SerializeField]
		private int LEVEN1_EFFECT_TRIGGER;
		private EnemyCharacter bossEnemy;
		private LastGaspUniqueCtrl lastGaspCtrl;
		private Gluon.QuestSkillTalk _talk;
		private bool lastAttackDown;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _PlayEffectCoroutine_d__39 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int holyLightLevel;
			public CtrlHolyLight __4__this;
			public Vector3 targetPosition;
			private int __holyLightLevel_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayEffectCoroutine_d__39(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CtrlHolyLight(CUGCtrl.Type type_);
	
		// Methods
		public void SetBossEnemy(EnemyCharacter enemy);
		public void Initialize(string skillDataLabel);
		public void QuestSkillButtonOnclick();
		public void HitTarget(CommonObjectStatus targetObject);
		public override void Update();
		public void ResetRecast();
		public void RecastRecover(int recoverValue);
		public void HolyLightLevelUp();
		public void FieldTalkMiasmaBegin();
		public int GetHolyLightLevel();
		private float GetCollisionSize(int level);
		private int GetDamage(int level);
		private float GetRecastTime(int level);
		private float GetMiasmaReduceValue(int level);
		public float GetRecastRecoveryValueByPillar(int level);
		public string GetSEName(int level);
		public float GetMarkerSize();
		public float GetMarkerChargeTime();
		public float GetInvincibleTime();
		public void SendLastGaspEvent(EnemyCharacter enemyChara);
		public void SendHolyLightUsedEvent();
		public void GetHolyLightUsedEvent(CharacterBase owner);
		public void LoadSkillSE();
		[IteratorStateMachine]
		private IEnumerator PlayEffectCoroutine(Vector3 targetPosition, int holyLightLevel);
		public void SetCurrentCharaAndLastGaspCtrl();
	}
}
