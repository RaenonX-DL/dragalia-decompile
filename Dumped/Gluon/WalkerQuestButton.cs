using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class WalkerQuestButton : FastUpdateMonoBehaviour
	{
		public enum StatusType
		{
			PlayMode,
			PhotoMode
		}

		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0ï¼\u0088ã\u0083¢ã\u0083¼ã\u0083\u0089å\u0088\u0087æ\u009b¿ã\u0080\u0081é\u009d\u009eè¡\u00a8ç¤ºï¼\u0089")]
		private RectTransform offsetRt;

		[SerializeField]
		[Tooltip("ç\u0094»é\u009d¢å¤\u0096ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform outSideOffsetRt;

		[SerializeField]
		[Tooltip("ã\u0083\u0097ã\u0083¬ã\u0082¤ã\u0083¢ã\u0083¼ã\u0083\u0089ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform playModeRt;

		[SerializeField]
		[Tooltip("æ\u0092®å½±ã\u0083¢ã\u0083¼ã\u0083\u0089ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform photoModeRt;

		[SerializeField]
		[Tooltip("ã\u0083\u0097ã\u0083¬ã\u0082¤ã\u0083¢ã\u0083¼ã\u0083\u0089ç\u0084¡å\u008a¹å\u008c\u0096ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform playModeInvalidRt;

		[SerializeField]
		[Tooltip("æ\u0092®å½±ã\u0083¢ã\u0083¼ã\u0083\u0089ç\u0084¡å\u008a¹å\u008c\u0096ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform photoModeInvalidRt;

		[SerializeField]
		[Tooltip("ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0ï¼\u0088è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ã\u0080\u0081ã\u0082¹ã\u0082¿ã\u0083³ã\u0083\u0097ï¼\u0089")]
		private RectTransform offsetRt2;

		[SerializeField]
		[Tooltip("ç\u0094»é\u009d¢å¤\u0096ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform outSideOffsetRt2;

		[SerializeField]
		[Tooltip("æ\u0092®å½±ã\u0083¢ã\u0083¼ã\u0083\u0089ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform photoModeRt2;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0082¿ã\u0083³ã\u0083\u0097ã\u0083\u009cã\u0082¿ã\u0083³ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform stampButtonRt;

		[SerializeField]
		[Tooltip("æ\u0092®å½±ã\u0083¢ã\u0083¼ã\u0083\u0089ç\u0084¡å\u008a¹å\u008c\u0096ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform photoModeInvalidRt2;

		[SerializeField]
		[Tooltip("æ\u0092®å½±ã\u0083\u009cã\u0082¿ã\u0083³")]
		private Button photoButton;

		[SerializeField]
		[Tooltip("æ\u0088»ã\u0082\u008bã\u0083\u009cã\u0082¿ã\u0083³")]
		private Button backButton;

		[SerializeField]
		[Tooltip("é\u009d\u009eè¡\u00a8ç¤ºã\u0083\u009cã\u0082¿ã\u0083³")]
		private Button hideButton;

		[SerializeField]
		[Header("ã\u0080\u0090è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ã\u0080\u0091")]
		[Tooltip("è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ã\u0082¹ã\u0083©ã\u0082¤ã\u0083\u0080ã\u0083¼")]
		private CommonSliderSelection dofSlider;

		[SerializeField]
		[Tooltip("è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ã\u0083\u0095ã\u0082£ã\u0083«ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8")]
		private Image dofSliderFillImage;

		[SerializeField]
		[Tooltip("è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ã\u0083\u008fã\u0083³ã\u0083\u0089ã\u0083«ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8")]
		private Image dofSliderHandleImage;

		[SerializeField]
		[Tooltip("è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦æ\u0095°å\u0080¤ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text dofSliderValueText;

		[SerializeField]
		[Tooltip("DOFã\u0083\u009cã\u0082¿ã\u0083³")]
		private Button dofButton;

		private VisibleUIObject rootVisible;

		private VisibleUIObject playModeVisible;

		private VisibleUIObject photoModeVisible;

		private VisibleUIObject photoModeVisible2;

		private VisibleUIObject playModeInvalidVisible;

		private VisibleUIObject photoModeInvalidVisible;

		private VisibleUIObject photoModeInvalidVisible2;

		private Tweener _playModeTweener;

		private Tweener _photoModeTweener;

		private Vector3 _originOffsetPos;

		private Vector3 _originOffsetPos2;

		private Vector3 _originHideButtonPos;

		private Vector3 _originStampButtonPos;

		private bool _isLeft;

		private bool _inSide;

		private bool _isShow;

		private bool _isEnableDof;

		private Action<bool> _onChangeEnableDOF;

		private const long DOFMaxValue = 100L;

		private const long DOFMinValue = 0L;

		public RectTransform StampButtonRt => null;

		public StatusType Status
		{
			[CompilerGenerated]
			get
			{
				return default(StatusType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static WalkerQuestButton Create(GameObject parent, bool isLeft, Action onClickPhotoMode, Action onClickBack, Action onClickHide, Action<float> onChangeDOF, Action<bool> onChangeEnableDOF, int index = -1)
		{
			return null;
		}

		private void SetDofSetting(bool enableDof)
		{
		}

		private void Initialize(bool isLeft, Action onClickPhotoMode, Action onClickBack, Action onClickHide, Action<float> onChangeDOF, Action<bool> onChangeEnableDOF)
		{
		}

		public void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		private void UpdatePos()
		{
		}

		public void Visible(bool b)
		{
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		public void Show(StatusType status, bool immediate = false, bool force = false)
		{
		}

		public void RedisplayForPhotoMode(bool immediate = false, bool force = false)
		{
		}

		public void HideForPhotoMode(bool immediate = false)
		{
		}

		private void ShowPlayMode(bool isShow, bool immediate)
		{
		}

		private void OnCompleteShowPlayModeIn()
		{
		}

		private void OnCompleteShowPlayModeOut()
		{
		}

		private void OnShowPlayMode(float rate)
		{
		}

		private void ShowPhotoMode(bool isShow, bool immediate, bool isApplyDofSetting)
		{
		}

		private void OnCompleteShowPhotoModeIn()
		{
		}

		private void OnCompleteShowPhotoModeOut()
		{
		}

		private void OnShowPhotoMode(float rate)
		{
		}

		public void SetLayout(bool isLeft, bool force = false)
		{
		}

		public void SetODFRate(float rate)
		{
		}

		public float GetDOFRate()
		{
			return default(float);
		}

		public void OnClickScreen()
		{
		}
	}
}
