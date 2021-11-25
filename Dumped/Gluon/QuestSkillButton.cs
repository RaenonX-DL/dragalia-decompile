using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSkillButton : QuestSkillButtonBase
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _rootRt;

		[SerializeField]
		[Tooltip("ç\u0084¡å\u008a¹å\u008c\u0096ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _invalidRt;

		[SerializeField]
		[Tooltip("ä½¿ç\u0094\u00a8ä\u00b8\u008då\u008f\u00afã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _noUseRt;

		[SerializeField]
		[Tooltip("ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _offsetRt;

		[SerializeField]
		[Tooltip("ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _effectRt;

		[SerializeField]
		[Tooltip("å½±ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _shadowRt;

		[SerializeField]
		[Tooltip("å\u009b\u009eæ\u0095°ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform[] _countRt;

		[SerializeField]
		[Tooltip("æº\u0096å\u0082\u0099å®\u008cäº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0081®ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _readyAnimFrameRt;

		[SerializeField]
		[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0081®ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _changeAnimRt;

		[SerializeField]
		[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082¢ã\u0083\u008bã\u0083¡ï¼\u0088æ\u009c\u0080å¤§ã\u0083¬ã\u0083\u0099ã\u0083«ï¼\u0089ã\u0081®ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _changeAnimMaxLevelRt;

		[SerializeField]
		[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082¢ã\u0083\u008bã\u0083¡ å\u0085\u0089å\u0088¶å¾¡")]
		private InGameAnimUI _changeAnimGlowUI;

		[SerializeField]
		[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082¢ã\u0083\u008bã\u0083¡ ã\u0083\u0095ã\u0083¬ã\u0082¢å\u0088¶å¾¡")]
		private InGameAnimUI _changeAnimFlareUI;

		[SerializeField]
		[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082¢ã\u0083\u008bã\u0083¡ ã\u0082­ã\u0083©ã\u0082­ã\u0083©å\u0088¶å¾¡")]
		private InGameAnimUI[] _changeAnimGlitterUI;

		[SerializeField]
		[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082¢ã\u0083\u008bã\u0083¡ ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³å\u0088¶å¾¡")]
		private InGameAnimUI _changeAnimIconUI;

		[SerializeField]
		[Tooltip("ã\u0083\u009cã\u0082¿ã\u0083³")]
		private Button _button;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _iconImage;

		[SerializeField]
		[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _changeAnimIconImage;

		[SerializeField]
		[Tooltip("ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _effectImage;

		[SerializeField]
		[Tooltip("æº\u0096å\u0082\u0099å®\u008cäº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0081®ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _readyAnimFrameImage;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("æ\u008b¡å¤§ã\u0082¢ã\u0083\u008bã\u0083¡æ\u0099\u0082é\u0096\u0093")]
		private float _expansionTime;

		[SerializeField]
		[Tooltip("ã\u0083\u0095ã\u0083©ã\u0083\u0083ã\u0082·ã\u0083¥ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0081®å\u009b\u009eæ\u0095°")]
		private int _flashCount;

		[SerializeField]
		[Tooltip("ã\u0083\u0095ã\u0083©ã\u0083\u0083ã\u0082·ã\u0083¥ã\u0082¢ã\u0083\u008bã\u0083¡æ\u0099\u0082é\u0096\u0093")]
		private float _flashTime;

		[SerializeField]
		[Tooltip("ã\u0083\u0095ã\u0083©ã\u0083\u0083ã\u0082·ã\u0083¥ã\u0082¢ã\u0083\u008bã\u0083¡æ\u009c\u0080å¤§å\u0080¤")]
		private float _maxFlashPower;

		[SerializeField]
		[Tooltip("æº\u0096å\u0082\u0099å®\u008cäº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0081®ã\u0083\u0095ã\u0083©ã\u0083\u0083ã\u0082·ã\u0083¥ã\u0082¢ã\u0083\u008bã\u0083¡æ\u009c\u0080å¤§å\u0080¤")]
		private float _readyAnimMaxFlashPower;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0083¼ã\u0083ªã\u0082¹ã\u0083\u0088")]
		private CreateIconParam[] _iconParams;

		private VisibleUIObject _rootVisible;

		private VisibleUIObject _invalidVisible;

		private VisibleUIObject _noUseVisible;

		private VisibleUIObject _readyAnimFrameVisible;

		private VisibleUIObject _changeAnimVisible;

		private VisibleUIObject _changeAnimMaxLevelVisible;

		private ManagementMultipleIconData _data;

		private ManagementIconData _iconData;

		private Tweener _twExpansion;

		private Tweener _twEffectFlash;

		private bool _isLeft;

		private bool _isIconCreated;

		private const float TweenerExpansionEndValue = 1f;

		public static QuestSkillButton Create(GameObject parent, int index, Action<QuestSkillButtonBase> onClick, bool isLeft)
		{
			return null;
		}

		public void Initialize(Action<QuestSkillButtonBase> onClick, bool isLeft)
		{
		}

		public void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		public override bool ApplyIcon(InGameUIConst.QuestSkillType type)
		{
			return default(bool);
		}

		public bool LoadIcon(string[] iconNames)
		{
			return default(bool);
		}

		public override bool ChangeIcon(int iconIndex, bool isForce, bool isFlashAnim = true)
		{
			return default(bool);
		}

		public override int GetIconNum()
		{
			return default(int);
		}

		public override int GetIconIndex()
		{
			return default(int);
		}

		private void SetIconRate(float rate, bool isForce = false, bool isAnim = true)
		{
		}

		public override void SetIconRateManual(float rate, bool isForce = false)
		{
		}

		public override float GetIconRate()
		{
			return default(float);
		}

		public override void Visible(bool b)
		{
		}

		public override bool IsVisible()
		{
			return default(bool);
		}

		public override void Validate(bool b, bool force = false)
		{
		}

		private void CheckInvalidObj()
		{
		}

		public override int GetCount()
		{
			return default(int);
		}

		public override void SetCount(int n)
		{
		}

		public override int GetMaxCount()
		{
			return default(int);
		}

		public override void SetUnlimited()
		{
		}

		public override bool IsUnlimited()
		{
			return default(bool);
		}

		public override void SetReadyAnim(ReadyAnimType type)
		{
		}

		public override bool IsReadyAnim()
		{
			return default(bool);
		}

		public override void SetupReadyAnim(Material frameMat)
		{
		}

		public override void SetVisibleReadyAnim(bool b)
		{
		}

		public override bool IsActiveReadyAnim()
		{
			return default(bool);
		}

		public override void OnUpdateReadyAnimFlash(float value)
		{
		}

		public override void SetChangeAnim()
		{
		}

		public override bool IsChangeAnim()
		{
			return default(bool);
		}

		private void PlayChangeAnim()
		{
		}

		private void StopChangeAnim()
		{
		}

		private void OnCompleteChangeAnim()
		{
		}

		private void PlayExpansionAnim()
		{
		}

		private void OnUpdateExpansion(float value)
		{
		}

		private void OnCompleteExpansion()
		{
		}

		private void OnUpdateButtonEffectFlash(float value)
		{
		}

		public override void SetOnClick(Action onClick)
		{
		}

		public override void CopyData(ManagementMultipleIconData data)
		{
		}

		public override void ApplyData(ManagementMultipleIconData data)
		{
		}
	}
}
