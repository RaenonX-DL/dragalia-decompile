using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EnemyMarkUI : CharacterMarkUI
	{
		[SerializeField]
		[Header("component")]
		private RectTransform conditionRt;

		[SerializeField]
		[Tooltip("è¼\u009dã\u0081\u008dã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform hpGaugeShineRootRt;

		[SerializeField]
		[Tooltip("è¼\u009dã\u0081\u008dç\u0094»å\u0083\u008fèª¿æ\u0095\u00b4ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform hpGaugeShineImageAdjustRt;

		[SerializeField]
		private ElementIconUISpriteRenderer element;

		[SerializeField]
		private Text labelText;

		[SerializeField]
		private InGameGaugeUISpriteRenderer gauge;

		[SerializeField]
		private GameObject gobjLabel;

		[SerializeField]
		private GameObject rareLabel;

		[SerializeField]
		private SpriteRenderer emphasisBase;

		[SerializeField]
		private SpriteRenderer emphasisText;

		[SerializeField]
		[Tooltip("è¼\u009dã\u0081\u008dã\u0082²ã\u0083¼ã\u0082\u00b8ç\u0094»å\u0083\u008f")]
		private SpriteRenderer hpGaugeShineGaugeImage;

		[SerializeField]
		private EnemyRareTimerCtrl enemyRareTimerCtrl;

		[SerializeField]
		[Header("resource")]
		private Sprite[] emphasisBaseSprite;

		[SerializeField]
		private Sprite[] emphasisTextSprite;

		[SerializeField]
		[Header("parameter")]
		private float scaleTargetChara;

		[SerializeField]
		private float scaleMobEnemy;

		[SerializeField]
		[Tooltip("HPè¡\u00a8ç¤ºæ\u0099\u0082é\u0096\u0093(s)")]
		public float durationMarkHP;

		[SerializeField]
		private float hpGaugeShineAdjustStartPosX;

		[SerializeField]
		private float hpGaugeShineAdjustEndPosX;

		private InGameUICtrl inGameUI;

		private EnemyCharacter owner;

		private RectTransform rootRt;

		private RectTransform gaugeRt;

		private VisibleUIObject conditionVisible;

		private VisibleUIObject labelVisible;

		private VisibleUIObject hpGaugeShineVisible;

		private SpriteRenderer[] rareLabelSpriteRenderer;

		private CharaCircleGaugeUI circleGaugeUI;

		private HitCountUI hitCountUI;

		private EnemyAbilityHeadGaugeUI enemyAbilityHeadGaugeUI;

		private DisplayType currentType;

		private float displayDuration;

		private float correctPosY;

		private bool isVisibleEmphasisMark;

		private float untargetDuration;

		private const float UntargetTime = 0.5f;

		private const float CircleGaugeOffsetY = 55f;

		public void Initialize(EnemyCharacter enemy, InGameUICtrl inGameUI)
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateChara()
		{
		}

		private bool IsVisibleAttachUI()
		{
			return default(bool);
		}

		public void UpdateHpGaugeShine()
		{
		}

		private void Invisible()
		{
		}

		public override void Show(DisplayType type, [Optional] CharacterBase target)
		{
		}

		private void CharaHPRoutine(bool bTarget)
		{
		}

		public void CharaHpGaugeClear()
		{
		}

		public void ApplyCharaHpGauge(bool immediate = false)
		{
		}

		private void TargetChara(bool bTarget)
		{
		}

		public override void SetPlayerNo(int no, bool own)
		{
		}

		private void RareVisible(bool b)
		{
		}

		public override void UpdatePosition(bool interpolation = true)
		{
		}

		public override void SetVisible(bool visible)
		{
		}

		public override bool IsVisible()
		{
			return default(bool);
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
