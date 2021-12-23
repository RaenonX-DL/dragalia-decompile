using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EnemyMarkUI : EnemyMarkSimpleUI
	{
		[SerializeField]
		[Header("component")]
		protected RectTransform conditionRt;

		[SerializeField]
		protected RectTransform nameRt;

		[SerializeField]
		protected RectTransform rateRt;

		[SerializeField]
		[Tooltip("è¼\u009dã\u0081\u008dã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		protected RectTransform hpGaugeShineRootRt;

		[SerializeField]
		[Tooltip("è¼\u009dã\u0081\u008dç\u0094»å\u0083\u008fèª¿æ\u0095\u00b4ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		protected RectTransform hpGaugeShineImageAdjustRt;

		[SerializeField]
		protected ElementIconUISpriteRenderer elementIcon;

		[SerializeField]
		protected Text nameText;

		[SerializeField]
		protected InGameGaugeUISpriteRenderer gauge;

		[SerializeField]
		[Tooltip("å±\u009eæ\u0080§ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8")]
		protected SpriteRenderer elementIconImage;

		[SerializeField]
		protected SpriteRenderer emphasisBase;

		[SerializeField]
		protected SpriteRenderer emphasisText;

		[SerializeField]
		[Tooltip("è¼\u009dã\u0081\u008dã\u0082²ã\u0083¼ã\u0082\u00b8ç\u0094»å\u0083\u008f")]
		protected SpriteRenderer hpGaugeShineGaugeImage;

		[SerializeField]
		protected EnemyRareTimerCtrl enemyRareTimerCtrl;

		[SerializeField]
		[Header("resource")]
		protected Sprite[] emphasisBaseSprite;

		[SerializeField]
		protected Sprite[] emphasisTextSprite;

		[SerializeField]
		[Header("parameter")]
		protected float scaleTargetChara;

		[SerializeField]
		protected float scaleMobEnemy;

		[SerializeField]
		[Tooltip("HPè¡\u00a8ç¤ºæ\u0099\u0082é\u0096\u0093(s)")]
		public float durationMarkHP;

		[SerializeField]
		protected float hpGaugeShineAdjustStartPosX;

		[SerializeField]
		protected float hpGaugeShineAdjustEndPosX;

		[SerializeField]
		protected float rareInfoDmodeAdjustPosY;

		protected RectTransform gaugeRt;

		protected VisibleUIObject conditionVisible;

		protected VisibleUIObject labelVisible;

		protected VisibleUIObject hpGaugeShineVisible;

		protected SpriteRenderer[] rareLabelSpriteRenderers;

		protected CharaCircleGaugeUI circleGaugeUI;

		protected HitCountUI hitCountUI;

		protected EnemyAbilityHeadGaugeUI enemyAbilityHeadGaugeUI;

		protected DisplayType currentType;

		protected float displayDuration;

		protected bool isVisibleEmphasisMark;

		protected float untargetDuration;

		protected const float untargetTime = 0.5f;

		protected const float circleGaugeOffsetY = 55f;

		public override void Initialize(EnemyCharacter enemy, InGameUICtrl inGameUI)
		{
		}

		protected override void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		protected void UpdateChara()
		{
		}

		protected bool IsVisibleAttachUI()
		{
			return default(bool);
		}

		public void UpdateHpGaugeShine()
		{
		}

		protected void Invisible()
		{
		}

		public override void Show(DisplayType type, [Optional] CharacterBase target)
		{
		}

		protected void CharaHPRoutine(bool bTarget)
		{
		}

		public void CharaHpGaugeClear()
		{
		}

		public void ApplyCharaHpGauge(bool immediate = false)
		{
		}

		protected void ApplyInfoIcon(CharacterBase chara, bool isForce = false)
		{
		}

		protected bool ApplyElementIcon(ElementalType elementType, bool isForce = false)
		{
			return default(bool);
		}

		protected bool ApplyTribeIcon(TribeType tribeType, bool isForce = false)
		{
			return default(bool);
		}

		protected void TargetChara(bool bTarget)
		{
		}

		protected void RareVisible(bool b)
		{
		}

		public override void CreateCircleGaugeUI(CharaCircleGaugeUI.Type type)
		{
		}

		public override void ShowCircleGaugeUI(CharaCircleGaugeUI.Type type)
		{
		}

		public override void HideCircleGaugeUI(CharaCircleGaugeUI.Type type)
		{
		}

		public override void SetCircleGaugeUIGaugeTimer(CharaCircleGaugeUI.Type type, float time, float initialTime)
		{
		}

		public override void SetCircleGaugeUICount(CharaCircleGaugeUI.Type type, int count)
		{
		}

		public override void SetCircleGaugeUIAdjustPos(CharaCircleGaugeUI.Type type, Vector3 pos)
		{
		}

		public override void SetCircleGaugeUIAdjustScale(CharaCircleGaugeUI.Type type, float scale)
		{
		}

		public override bool IsVisibleCircleGauge()
		{
			return default(bool);
		}

		public override EnemyAbilityHeadGaugeUI CreateEnemyAbilityHeadGaugeUI(EnemyAbilityHeadGaugeUI.IconType type)
		{
			return null;
		}

		public override void OnUpdateHpGaugeShineGaugeFade(float value)
		{
		}

		public override void OnUpdateHpGaugeShineLocalPosX(float value)
		{
		}
	}
}
