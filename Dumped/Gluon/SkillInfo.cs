using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SkillInfo : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0083\u009cã\u0082¿ã\u0083³")]
		private Button _button;

		[SerializeField]
		[Tooltip("ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _offsetRt;

		[SerializeField]
		[Tooltip("æ\u008b¡å¤§æ¼\u0094å\u0087ºã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _effectRt;

		[SerializeField]
		[Tooltip("ä½¿ç\u0094\u00a8ä\u00b8\u008då\u008f\u00afã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _noUseRt;

		[SerializeField]
		[Tooltip("é\u0080£æ\u0090ºã\u0082¹ã\u0082­ã\u0083«ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _chainSkillFrameRt;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0082­ã\u0083«ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _skillIcon;

		[SerializeField]
		[Tooltip("ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _effectImage;

		[SerializeField]
		[Tooltip("é\u0080£æ\u0090ºã\u0082¹ã\u0082­ã\u0083«ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0ã\u0081®ã\u0083«ã\u0083¼ã\u0083\u0088")]
		private SpriteRenderer _chainSkillFrameImage;

		[SerializeField]
		[Tooltip("æ\u0083\u0085å\u00a0±ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _infoIconImage;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0082­ã\u0083«ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³å\u0088¶å¾¡")]
		private SkillIconCtrl _skillIconCtrl;

		[SerializeField]
		[Tooltip("ã\u0082«ã\u0082¦ã\u0083³ã\u0083\u0088UI")]
		private InGameCounterUI _counterUI;

		[SerializeField]
		[Tooltip("ã\u0082ªã\u0083¼ã\u0083\u0090ã\u0083¼ã\u0083\u0081ã\u0083£ã\u0083¼ã\u0082\u00b8ã\u0082²ã\u0083¼ã\u0082\u00b8UI")]
		private SkillOverChargeGaugeUI _overChargeGaugeUI;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("æ\u008b¡å¤§ã\u0082¢ã\u0083\u008bã\u0083¡æ\u0099\u0082é\u0096\u0093")]
		private float _expansionTime;

		[SerializeField]
		[Tooltip("ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081\u008cæ\u009c\u0080å¤§ã\u0081¾ã\u0081§æº\u009cã\u0081¾ã\u0081£ã\u0081\u009fé\u009a\u009bã\u0081®ã\u0083\u0095ã\u0083©ã\u0083\u0083ã\u0082·ã\u0083¥å\u0080¤")]
		private float _maxGaugeAnimFlashPower;

		private RectTransform _rootRt;

		private RectTransform _infoIconRt;

		private Tweener _twExpansion;

		private VisibleUIObject _effectVisible;

		private VisibleUIObject _noUseVisible;

		private VisibleUIObject _chainSkillVisible;

		private float _gaugeRate;

		private float _lastGaugeRate;

		private bool _isValidate;

		private bool _isExpansionEffect;

		private bool _isMaxEffect;

		private bool _isGaugeMax;

		private int _spGaugeCount;

		private bool _isDisableRequiredBuff;

		private bool _isCharaEnableSkill;

		private bool _isDisableUpdate;

		private bool _isCheckActive;

		private bool _isEnableChainSkill;

		private int _lastSkillId;

		private string _lastIconName;

		private const float TweenerExpansionEndValue = 1f;

		private const int EmptyItemSkillID = -1;

		[HideInInspector]
		public int skillIndex => default(int);

		[HideInInspector]
		public int skillSlot
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Initialize(Action<SkillInfo> onClick, int skillSlot, bool isLeft)
		{
		}

		public override void FastUpdate()
		{
		}

		public bool SetSkillIcon(CharacterBase chara, int skillId, bool isForce = false)
		{
			return default(bool);
		}

		public bool SetEmptyItemSkillIcon(CharacterBase chara, bool isDisable = true, bool isForce = false)
		{
			return default(bool);
		}

		public void DisableSkill(bool isDisable, bool isDisableGrayOut, bool isEnableReturnValue)
		{
		}

		private void SetSkillIcon(string iconName, Material material, Sprite sprite)
		{
		}

		public void SetItemSkillCount(int count)
		{
		}

		public void SetGaugeValue(float rate, bool isForce = false)
		{
		}

		public void SetOverChargeGaugeValue(int phase, int phaseSp, int phaseConsumeSp, bool isForce = false)
		{
		}

		public void SetOverChargeGaugeValueForConsumeCp(float rate, bool isForce = false)
		{
		}

		private void CheckInactive(bool bmax)
		{
		}

		public void Attach(RectTransform parentRT)
		{
		}

		public void Visible(bool b, bool force = false)
		{
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		public void Validate(bool b)
		{
		}

		public Vector2 GetButtonPosition()
		{
			return default(Vector2);
		}

		public Vector2 GetButtonSize()
		{
			return default(Vector2);
		}

		private void StartExpansionEffect()
		{
		}

		private void OnUpdateExpansion(float value)
		{
		}

		private void OnCompleteExpansion()
		{
		}

		public void PauseMaxEffect()
		{
		}

		public void SetEnabled(bool b)
		{
		}

		public void OnUpdateGaugeMax(float value)
		{
		}

		public void SetupChainSkill(Material frameMat)
		{
		}

		public void SetVisibleChainSkill(bool b)
		{
		}

		public void SetDisableSkillByRequiredBuff(bool v, int spGaugeCount)
		{
		}
	}
}
