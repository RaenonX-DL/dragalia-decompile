using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class CharaStatusInfoUI : FastUpdateMonoBehaviour
	{
		[Serializable]
		public class DigitLayoutData
		{
			[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0081®ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«")]
			public float digitScale;

			[Tooltip("æ\u0095°å\u0080¤ã\u0081®Xè»\u00b8ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088å\u0080¤")]
			public float digitOffsetX;

			[Tooltip("è\u00a8\u0098å\u008f·ã\u0081®Xè»\u00b8ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088å\u0080¤")]
			public float signOffsetX;

			[Tooltip("è\u00a8\u0098å\u008f·ã\u0081®Yè»\u00b8ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088å\u0080¤")]
			public float signOffsetY;

			[Tooltip("è\u00a8\u0098å\u008f·ã\u0081®ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«å\u0080¤")]
			public float signScale;
		}

		public enum ValueDisplayPositionType
		{
			Outside,
			Inside
		}

		[SerializeField]
		[Header("component")]
		private RectTransform _rootRt;

		[SerializeField]
		private RectTransform _digitRootRt;

		[SerializeField]
		private RectTransform _signRt;

		[SerializeField]
		private SpriteRenderer _bgImage;

		[SerializeField]
		private SpriteRenderer _iconImage;

		[SerializeField]
		private SpriteRenderer _blinkIconImage;

		[SerializeField]
		private SpriteRenderer _gaugeImage;

		[SerializeField]
		private SpriteRenderer[] _digitImageList;

		[SerializeField]
		private SpriteRenderer _signImage;

		[SerializeField]
		private CircleGauge _gaugeCtrl;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0082\u00afã\u0083¼ã\u0083«ã\u0083\u0080ã\u0082¦ã\u0083³æ\u0099\u0082ã\u0081®ã\u0082¢ã\u0083«ã\u0083\u0095ã\u0082¡")]
		private float _coolDownAlpha;

		[SerializeField]
		[Tooltip("ã\u0083\u0097ã\u0083¬ã\u0082¤ã\u0083¤ã\u0083¼ã\u0081®æ\u008f\u008fç\u0094»é\u00a0\u0086")]
		private int _playerSortingOrder;

		[SerializeField]
		[Tooltip("ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼ã\u0081®æ\u008f\u008fç\u0094»é\u00a0\u0086")]
		private int _enemySortingOrder;

		[SerializeField]
		[Tooltip("ã\u0083\u0091ã\u0083¼ã\u0082»ã\u0083³ã\u0083\u0088ã\u0081®ã\u0083¬ã\u0082¤ã\u0082¢ã\u0082¦ã\u0083\u0088æ\u0083\u0085å\u00a0±ã\u0083ªã\u0082¹ã\u0083\u0088\n  â\u0080»è\u00a8­å®\u009aæ\u0095°ã\u0081\u008cã\u0081\u009dã\u0081®ã\u0081¾ã\u0081¾æ\u009c\u0080å¤§æ¡\u0081æ\u0095°ã\u0081\u00a8ã\u0081ªã\u0082\u008b")]
		private DigitLayoutData[] _percentDigiLayoutDataArray;

		[SerializeField]
		[Tooltip("ã\u0082«ã\u0082¦ã\u0083³ã\u0083\u0088ã\u0081®ã\u0083¬ã\u0082¤ã\u0082¢ã\u0082¦ã\u0083\u0088æ\u0083\u0085å\u00a0±ã\u0083ªã\u0082¹ã\u0083\u0088\n  â\u0080»è\u00a8­å®\u009aæ\u0095°ã\u0081\u008cã\u0081\u009dã\u0081®ã\u0081¾ã\u0081¾æ\u009c\u0080å¤§æ¡\u0081æ\u0095°ã\u0081\u00a8ã\u0081ªã\u0082\u008b")]
		private DigitLayoutData[] _countDigiLayoutDataArray;

		[SerializeField]
		[Tooltip("æ\u0095°é\u0087\u008fã\u0081®ã\u0083¬ã\u0082¤ã\u0082¢ã\u0082¦ã\u0083\u0088æ\u0083\u0085å\u00a0±ã\u0083ªã\u0082¹ã\u0083\u0088\n  â\u0080»è\u00a8­å®\u009aæ\u0095°ã\u0081\u008cã\u0081\u009dã\u0081®ã\u0081¾ã\u0081¾æ\u009c\u0080å¤§æ¡\u0081æ\u0095°ã\u0081\u00a8ã\u0081ªã\u0082\u008b")]
		private DigitLayoutData[] _quantityDigiLayoutDataArray;

		[SerializeField]
		[Tooltip("ã\u0083¬ã\u0083\u0099ã\u0083«ã\u0081®ã\u0083¬ã\u0082¤ã\u0082¢ã\u0082¦ã\u0083\u0088æ\u0083\u0085å\u00a0±ã\u0083ªã\u0082¹ã\u0083\u0088\n  â\u0080»è\u00a8­å®\u009aæ\u0095°ã\u0081\u008cã\u0081\u009dã\u0081®ã\u0081¾ã\u0081¾æ\u009c\u0080å¤§æ¡\u0081æ\u0095°ã\u0081\u00a8ã\u0081ªã\u0082\u008b")]
		private DigitLayoutData[] _levelDigiLayoutDataArray;

		[SerializeField]
		[Tooltip("ã\u0083¬ã\u0083\u0099ã\u0083«ã\u0081®ã\u0083¬ã\u0082¤ã\u0082¢ã\u0082¦ã\u0083\u0088æ\u0083\u0085å\u00a0±ã\u0083ªã\u0082¹ã\u0083\u0088ï¼\u0088EN_USï¼\u0089\n  â\u0080»è\u00a8­å®\u009aæ\u0095°ã\u0081\u008cã\u0081\u009dã\u0081®ã\u0081¾ã\u0081¾æ\u009c\u0080å¤§æ¡\u0081æ\u0095°ã\u0081\u00a8ã\u0081ªã\u0082\u008b")]
		private DigitLayoutData[] _levelDigiLayoutDataArrayEN_US;

		[SerializeField]
		[Tooltip("ã\u0083\u0090ã\u0083\u0095ã\u0082«ã\u0083©ã\u0083¼")]
		private Color _buffColor;

		[SerializeField]
		[Tooltip("ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0082«ã\u0083©ã\u0083¼")]
		private Color _debuffColor;

		[SerializeField]
		[Tooltip("ã\u0082ªã\u0083¼ã\u0083©ã\u0082«ã\u0083©ã\u0083¼")]
		private Color _auraColor;

		[SerializeField]
		[Tooltip("å\u0085\u00a8ä½\u0093ã\u0082ªã\u0083¼ã\u0083©ã\u0082«ã\u0083©ã\u0083¼")]
		private Color _partyAuraColor;

		private VisibleUIObject _rootVisible;

		private VisibleUIObject _digitRootVisible;

		private VisibleUIObject _signVisible;

		private VisibleUIObject[] _digitVisibleList;

		private VisibleUIObject _blinkIconVisible;

		private int _maxDigitNum;

		private int[] _maxNumList;

		private int _horizontalNum;

		private ValueDisplayPositionType _valueDispPosType;

		private int _index;

		private int _buffIconId;

		private AuraConst.TargetType _auraTargetType;

		private AuraType _auraType;

		private AbnormalStatusType _abnormalType;

		private EnemyAbilityType _enemyAbilityType;

		private int _productId;

		private int _value;

		private float _gaugeRate;

		private readonly float[] DigitAdjustRootPositionList;

		private const float IconMerginX = 45f;

		private const float IconMerginXForInside = 42f;

		private const float IconMerginY = 60f;

		public bool IsCoolDown
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsEnable
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsDirty
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static CharaStatusInfoUI Create(GameObject parent, GameObject pobj, ValueDisplayPositionType type, int horizontalNum, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(ValueDisplayPositionType type, int horizontalNum)
		{
		}

		private void SetMaxNum(InGameBuffUI.ValueDisplayType type, int digitNum)
		{
		}

		public void ResetData()
		{
		}

		public void Visible(bool b)
		{
		}

		public void ShowByBuff(int buffIconId, bool isBuff, InGameBuffUI.ValueDisplayType valueDispType, InGameBuffUI.GaugeDisplayType gaugeDispType, int productId, EnemyAbilityType enemyAbilityType, Sprite sprite, int count, int value, int level, int index, int quantity, bool coolDown, int durationTimeScale)
		{
		}

		public void ShowByAbnormal(AbnormalStatusType type, Sprite sprite, int value, int index)
		{
		}

		public void ShowByAura(CharacterAuraCtrl.Parameter param, Sprite sprite, int index)
		{
		}

		private void SetEffectValue(InGameBuffUI.ValueDisplayType type, int value, Color color)
		{
		}

		public void SetGaugeRate(float rate, bool force = false)
		{
		}

		public void SetDirty(bool b)
		{
		}

		public bool IsMatch(int buffIconId, int productId)
		{
			return default(bool);
		}

		public bool IsMatch(AbnormalStatusType type)
		{
			return default(bool);
		}

		public bool IsMatch(EnemyAbilityType type)
		{
			return default(bool);
		}

		public bool IsMatch(AuraConst.TargetType targetType, AuraType type, int productId)
		{
			return default(bool);
		}

		public void AdjustRootPosition(int index)
		{
		}

		public void SetCoolDown(bool b, bool force = false)
		{
		}

		private void ApplyColorAlpha()
		{
		}

		private void ApplyColorAlpha(ref SpriteRenderer sprite)
		{
		}

		private DigitLayoutData[] GetLevelDigiLayoutDataArray()
		{
			return null;
		}

		public void SetVisibleBlinkIcon(bool b)
		{
		}

		public void OnUpdateBlinkAnim(float value)
		{
		}
	}
}
