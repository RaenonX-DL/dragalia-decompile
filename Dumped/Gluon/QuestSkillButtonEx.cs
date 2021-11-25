using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSkillButtonEx : QuestSkillButtonBase
	{
		[Serializable]
		public class AnimData
		{
			[Tooltip("ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«")]
			public Vector3 scale;

			[Tooltip("ã\u0082¢ã\u0083\u008bã\u0083¡æ\u0099\u0082é\u0096\u0093")]
			public float animTime;

			[Tooltip("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0081\u008cçµ\u0082ã\u0082\u008fã\u0081£ã\u0081¦ã\u0081\u008bã\u0082\u0089ã\u0081®å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093")]
			public float afterWaitTime;

			[Tooltip("è£\u009cé\u0096\u0093ã\u0082¿ã\u0082¤ã\u0083\u0097")]
			public Ease ease;

			[HideInInspector]
			public Vector3 prevScale;
		}

		[Serializable]
		public class OffsetPosData
		{
			[Tooltip("ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088åº§æ\u00a8\u0099ï¼\u0088æ\u0097¥æ\u009c¬èª\u009eï¼\u0089")]
			public Vector3 offsetPos_JP;

			[Tooltip("ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088åº§æ\u00a8\u0099ï¼\u0088ã\u0082¢ã\u0083¡ã\u0083ªã\u0082«è\u008b±èª\u009eï¼\u0089")]
			public Vector3 offsetPos_EN_US;

			[Tooltip("ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088åº§æ\u00a8\u0099ï¼\u0088ç°¡ä½\u0093å­\u0097ï¼\u0089")]
			public Vector3 offsetPos_ZH_CN;

			[Tooltip("ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088åº§æ\u00a8\u0099ï¼\u0088ç¹\u0081ä½\u0093å­\u0097ï¼\u0089")]
			public Vector3 offsetPos_ZH_TW;

			[Tooltip("ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088åº§æ\u00a8\u0099ï¼\u0088ã\u0083\u00a8ã\u0083¼ã\u0083­ã\u0083\u0083ã\u0083\u0091è\u008b±èª\u009eï¼\u0089")]
			public Vector3 offsetPos_EN_EU;

			public Vector3 GetOffsetPos()
			{
				return default(Vector3);
			}
		}

		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _rootRt;

		[SerializeField]
		[Tooltip("ç\u0084¡å\u008a¹å\u008c\u0096ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _invalidRt;

		[SerializeField]
		[Tooltip("ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _offsetRt;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _iconImage;

		[SerializeField]
		[Tooltip("è\u0083\u008cæ\u0099\u00afç\u0094»å\u0083\u008f")]
		private SpriteRenderer _bgImage;

		[SerializeField]
		[Tooltip("ã\u0083\u009cã\u0082¿ã\u0083³")]
		private Button _button;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ç\u0094»é\u009d¢å¤\u0096ã\u0081®å\u0088\u009dæ\u009c\u009fåº§æ\u00a8\u0099")]
		private Vector3 _outsideInitialPos;

		[SerializeField]
		[Tooltip("ç§»å\u008b\u0095æ\u0099\u0082é\u0096\u0093")]
		private float _moveTime;

		[SerializeField]
		[Tooltip("è¡\u00a8ç¤ºã\u0082¢ã\u0083\u008bã\u0083¡è£\u009cé\u0096\u0093ã\u0082¿ã\u0082¤ã\u0083\u0097")]
		private Ease _showMoveEase;

		[SerializeField]
		[Tooltip("é\u009d\u009eè¡\u00a8ç¤ºã\u0082¢ã\u0083\u008bã\u0083¡è£\u009cé\u0096\u0093ã\u0082¿ã\u0082¤ã\u0083\u0097")]
		private Ease _hideMoveEase;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0082¢ã\u0083\u008bã\u0083¡æ\u0083\u0085å\u00a0±\n  â\u0080»è¦\u0081ç\u00b4\u00a0æ\u0095° 0 ã\u0081\u00afå\u0088\u009dæ\u009c\u009få\u0080¤ã\u0081\u00a8ã\u0081ªã\u0082\u008aã\u0081¾ã\u0081\u0099ã\u0080\u0082")]
		protected AnimData[] _iconAnimData;

		[SerializeField]
		[Tooltip("è\u0083\u008cæ\u0099\u00afã\u0082¢ã\u0083\u008bã\u0083¡æ\u0083\u0085å\u00a0±\n  â\u0080»è¦\u0081ç\u00b4\u00a0æ\u0095° 0 ã\u0081\u00afå\u0088\u009dæ\u009c\u009få\u0080¤ã\u0081\u00a8ã\u0081ªã\u0082\u008aã\u0081¾ã\u0081\u0099ã\u0080\u0082")]
		protected AnimData[] _bgAnimData;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0081®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088åº§æ\u00a8\u0099æ\u0083\u0085å\u00a0±")]
		protected OffsetPosData _iconOffsetPosData;

		private VisibleUIObject _rootVisible;

		private VisibleUIObject _invalidVisible;

		private RectTransform _iconImageRt;

		private RectTransform _bgImageRt;

		private Tweener _twAnim;

		private Sequence _seqButtonAnim;

		private ManagementMultipleIconData _data;

		private Vector3 _offsetInitialPos;

		private bool _isLeftFlag;

		private bool _isButtonValidate;

		private void Awake()
		{
		}

		public static QuestSkillButtonEx Create(GameObject parent, int index, Action<QuestSkillButtonBase> onClick, bool isLeft)
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

		public override bool ApplyIcon(InGameEventExtendAtlasManager eeAtlasManager)
		{
			return default(bool);
		}

		public override void Show(bool isForce = false, bool isImmediate = false)
		{
		}

		public override void Hide(bool isForce = false, bool isImmediate = false)
		{
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

		private void PlayShowAnim(bool isImmediate = false)
		{
		}

		private void PlayHideAnim(bool isImmediate = false)
		{
		}

		private void ApplyAnimData(AnimData data, RectTransform imageRt)
		{
		}

		private Sequence CreateButtonAnim()
		{
			return null;
		}

		protected virtual void OnUpdateIconImageScale(Vector3 scale)
		{
		}

		protected virtual void OnUpdateBgImageScale(Vector3 scale)
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
