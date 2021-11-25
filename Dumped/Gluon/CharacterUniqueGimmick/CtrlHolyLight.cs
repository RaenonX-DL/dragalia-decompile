using System.Collections;
using Gluon.Master;
using UnityEngine;

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlHolyLight : CUGCtrlBase
	{
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

		private QuestSkillTalk _talk;

		private bool lastAttackDown;

		public void SetBossEnemy(EnemyCharacter enemy)
		{
		}

		public void Initialize(string skillDataLabel)
		{
		}

		public void QuestSkillButtonOnclick()
		{
		}

		public void HitTarget(CommonObjectStatus targetObject)
		{
		}

		public override void Update(CharacterBase src)
		{
		}

		public void ResetRecast()
		{
		}

		public void RecastRecover(int recoverValue)
		{
		}

		public void HolyLightLevelUp()
		{
		}

		public void FieldTalkMiasmaBegin()
		{
		}

		public int GetHolyLightLevel()
		{
			return default(int);
		}

		private float GetCollisionSize(int level)
		{
			return default(float);
		}

		private int GetDamage(int level)
		{
			return default(int);
		}

		private float GetRecastTime(int level)
		{
			return default(float);
		}

		private float GetMiasmaReduceValue(int level)
		{
			return default(float);
		}

		public float GetRecastRecoveryValueByPillar(int level)
		{
			return default(float);
		}

		public string GetSEName(int level)
		{
			return null;
		}

		public float GetMarkerSize()
		{
			return default(float);
		}

		public float GetMarkerChargeTime()
		{
			return default(float);
		}

		public float GetInvincibleTime()
		{
			return default(float);
		}

		public void SendLastGaspEvent(EnemyCharacter enemyChara)
		{
		}

		public void SendHolyLightUsedEvent()
		{
		}

		public void GetHolyLightUsedEvent(CharacterBase owner)
		{
		}

		public void LoadSkillSE()
		{
		}

		private IEnumerator PlayEffectCoroutine(Vector3 targetPosition, int holyLightLevel)
		{
			return null;
		}

		public void SetCurrentCharaAndLastGaspCtrl()
		{
		}
	}
}
