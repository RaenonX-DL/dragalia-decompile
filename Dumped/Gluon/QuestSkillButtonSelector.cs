using System;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class QuestSkillButtonSelector : QuestSkillButtonBase
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _rootRt;

		[SerializeField]
		[Tooltip("ã\u0083\u009cã\u0082¿ã\u0083³ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _buttonRootRt;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ç\u0094»é\u009d¢å¤\u0096ã\u0081®å\u0088\u009dæ\u009c\u009fXåº§æ\u00a8\u0099")]
		private float _outsideInitialPosX;

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
		[Tooltip("ã\u0083\u009cã\u0082¿ã\u0083³ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0083ªã\u0082¹ã\u0083\u0088")]
		private CreateButtonParam[] _buttonParams;

		private VisibleUIObject _rootVisible;

		private Tweener _twMove;

		private Tweener _twButtonMove;

		private QuestSkillButton[] _buttons;

		private Action<QuestSkillButtonBase> _onClick;

		private ManagementMultipleButtonData _data;

		private int _showTargetIndex;

		private int _hideTargetIndex;

		private bool _isLeft;

		private bool _isIconCreated;

		public static QuestSkillButtonSelector Create(GameObject parent, int index, Action<QuestSkillButtonBase> onClick, bool isLeft)
		{
			return null;
		}

		public void Initialize(Action<QuestSkillButtonBase> onClick, bool isLeft)
		{
		}

		public void OnDestroy()
		{
		}

		public override bool ApplyIcon(InGameUIConst.QuestSkillType type)
		{
			return default(bool);
		}

		public override bool ChangeIcon(int iconIndex, bool isForce, bool isFlashAnim = true)
		{
			return default(bool);
		}

		public override bool ChangeIcon(int buttonIndex, int iconIndex, bool isForce, bool isFlashAnim = true)
		{
			return default(bool);
		}

		public override void Show(bool isForce = false, bool isImmediate = false)
		{
		}

		public override void Hide(bool isForce = false, bool isImmediate = false)
		{
		}

		public override void SetIconRateManual(float rate, bool isForce = false)
		{
		}

		public override void SetIconRateManual(int buttonIndex, float rate, bool isForce = false)
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

		public override void SetCount(int buttonType, int n)
		{
		}

		public override void ChangeButton(int buttonType, bool isImmediate = false)
		{
		}

		public override int GetButtonType()
		{
			return default(int);
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

		public override void SetOnClick(int buttonType, Action onClick)
		{
		}

		public override void CopyDara(ManagementMultipleButtonData data)
		{
		}

		public override void ApplyData(ManagementMultipleButtonData data)
		{
		}
	}
}
