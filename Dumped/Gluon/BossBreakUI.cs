using System;
using System.Runtime.InteropServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BossBreakUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private ElementIconUISpriteRenderer elementIcon;

		[SerializeField]
		private Text nameText;

		[SerializeField]
		private InGameGaugeUISpriteRenderer hpGauge;

		[SerializeField]
		private InGameGaugeUISpriteRenderer breakGauge;

		[SerializeField]
		[Tooltip("èª¿æ\u0095\u00b4ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform adjustRt;

		[SerializeField]
		[Tooltip("ã\u0083\u0096ã\u0083¬ã\u0082¤ã\u0082\u00afã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform breakGaugeRt;

		[SerializeField]
		[Tooltip("è¼\u009dã\u0081\u008dã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform hpGaugeShineRootRt;

		[SerializeField]
		[Tooltip("è¼\u009dã\u0081\u008dã\u0082µã\u0083\u0096ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform hpGaugeShineSubRootRt;

		[SerializeField]
		[Tooltip("è¼\u009dã\u0081\u008dç\u0094»å\u0083\u008fèª¿æ\u0095\u00b4ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform hpGaugeShineImageAdjustRt;

		[SerializeField]
		[Tooltip("è¼\u009dã\u0081\u008dã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform hpGaugeShineIconRt;

		[SerializeField]
		[Tooltip("ç\u0084¡é\u0099\u0090ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform unlimitIconRt;

		[SerializeField]
		[Tooltip("ã\u0083\u0096ã\u0083¬ã\u0082¤ã\u0082\u00afã\u0082²ã\u0083¼ã\u0082\u00b8æ¼\u0094å\u0087ºç\u0094\u00a8ã\u0081®HPã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8")]
		private SpriteRenderer bgHpRtModSprite;

		[SerializeField]
		[Tooltip("ã\u0083\u0096ã\u0083¬ã\u0082¤ã\u0082\u00afã\u0082²ã\u0083¼ã\u0082\u00b8æ¼\u0094å\u0087ºç\u0094\u00a8ã\u0081®ã\u0083\u0096ã\u0083¬ã\u0082¤ã\u0082\u00afã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8")]
		private SpriteRenderer bgBreakModSprite;

		[SerializeField]
		[Tooltip("ã\u0083\u0096ã\u0083¬ã\u0082¤ã\u0082\u00afã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³")]
		private SpriteRenderer breakGaugeIcon;

		[SerializeField]
		[Tooltip("è¼\u009dã\u0081\u008dè\u0083\u008cæ\u0099\u00afç\u0094»å\u0083\u008f")]
		private SpriteRenderer hpGaugeShineBgImage;

		[SerializeField]
		[Tooltip("è¼\u009dã\u0081\u008dã\u0082²ã\u0083¼ã\u0082\u00b8ç\u0094»å\u0083\u008f")]
		private SpriteRenderer hpGaugeShineGaugeImage;

		[SerializeField]
		[Tooltip("è¼\u009dã\u0081\u008dã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ç\u0094»å\u0083\u008f")]
		private SpriteRenderer hpGaugeShineIconImage;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0083\u0086ã\u0083¼ã\u0082¿ã\u0082¹æ\u0083\u0085å\u00a0±UI")]
		private BossStatusInfoUI statusInfoUI;

		[SerializeField]
		[Tooltip("ã\u0082²ã\u0083¼ã\u0082\u00b8æ¼\u0094å\u0087ºç\u0094\u00a8ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform gaugeEffectRt;

		[SerializeField]
		[Tooltip("ã\u0083¬ã\u0082¤ã\u0083\u0089æ¼\u0094å\u0087ºç\u0094\u00a8ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform raidEffectRt;

		[SerializeField]
		[Header("parameter")]
		private float hpGaugeShineAdjustStartPosX;

		[SerializeField]
		private float hpGaugeShineAdjustEndPosX;

		private EnemyCharacter owner;

		private VisibleUIObject rootVisible;

		private VisibleUIObject breakGaugeVisible;

		private VisibleUIObject breakGaugeIconVisible;

		private VisibleUIObject hpGaugeShineRootVisible;

		private VisibleUIObject hpGaugeShineSubRootVisible;

		private CharaCircleGaugeMiasmaUI miasmaGaugeUI;

		private InGameFollowLayout followLayout;

		private Sequence seqGaugeMove;

		private Sequence seqGaugeMod;

		private Sequence seqHpGaugeShineIcon;

		private int lastFishGrade;

		public static BossBreakUI Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		public void UpdateHpGaugeShine()
		{
		}

		public void Open(CharacterBase chara, ElementalType element, string name, bool hasBreak, float initialHpValue, InGameEventExtendAtlasManager eeAtlasManager)
		{
		}

		private void OpenBreakGauge(float rate)
		{
		}

		public void Close()
		{
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		public void SetHPValue(float value)
		{
		}

		public void SetBreakValue(float value, bool immediate = false)
		{
		}

		public void GetRaidEffectPosition(ref Vector3 pos)
		{
		}

		public void GetGaugeEffectPosition(ref Vector3 pos)
		{
		}

		public InGameGaugeUISpriteRenderer GetBreakGauge()
		{
			return null;
		}

		public void OnStatusInfoUIChangePage()
		{
		}

		public CharaCircleGaugeMiasmaUI CreateBossMiasmaGaugeUI(CharacterBase boss)
		{
			return null;
		}

		public void PlayQuestEffectBreak(float durationTime)
		{
		}

		private void PlayQuestEffectBreakGauge(bool playFromBeginning = true)
		{
		}

		public void StopQuestEffectBreak()
		{
		}

		private void StopQuestEffectBreakGauge(bool isImmediate = false)
		{
		}

		public void PlayQuestEffectOverdrive()
		{
		}

		private void PlayQuestEffectOverdriveGauge(bool playFromBeginning = true)
		{
		}

		public void StopQuestEffectOverdrive()
		{
		}

		private void StopQuestEffectOverdriveGauge(bool isImmediate = false)
		{
		}

		public void PlayQuestEffectBerserk()
		{
		}

		public void StopQuestEffectBerserk()
		{
		}

		public void PlayQuestEffectRaidFishGrade(int grade, [Optional] Action<PlayFTU> endFunc)
		{
		}

		public void StopQuestEffectRaidFishGrade()
		{
		}

		private void StopQuestEffectGauge(PlayFTU.Type type, bool isImmediate)
		{
		}

		public void OnUpdateHpGaugeShineBgFade(float value)
		{
		}

		public void OnUpdateHpGaugeShineGaugeFade(float value)
		{
		}

		public void OnUpdateHpGaugeShineLocalPosX(float value)
		{
		}
	}
}
