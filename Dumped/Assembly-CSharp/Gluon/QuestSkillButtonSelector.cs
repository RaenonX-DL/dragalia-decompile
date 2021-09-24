/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSkillButtonSelector : QuestSkillButtonBase
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform _rootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _buttonRootRt;
		[Header]
		[SerializeField]
		[Tooltip]
		private float _outsideInitialPosX;
		[SerializeField]
		[Tooltip]
		private float _moveTime;
		[SerializeField]
		[Tooltip]
		private Ease _showMoveEase;
		[SerializeField]
		[Tooltip]
		private Ease _hideMoveEase;
		[SerializeField]
		[Tooltip]
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
	
		// Constructors
		public QuestSkillButtonSelector();
	
		// Methods
		public static QuestSkillButtonSelector Create(GameObject parent, int index, Action<QuestSkillButtonBase> onClick, bool isLeft);
		public void Initialize(Action<QuestSkillButtonBase> onClick, bool isLeft);
		public void OnDestroy();
		public override bool ApplyIcon(InGameUIConst.QuestSkillType type);
		public override bool ChangeIcon(int iconIndex, bool isForce, bool isFlashAnim = true);
		public override bool ChangeIcon(int buttonIndex, int iconIndex, bool isForce, bool isFlashAnim = true);
		public override void Show(bool isForce = false, bool isImmediate = false);
		public override void Hide(bool isForce = false, bool isImmediate = false);
		public override void SetIconRateManual(float rate, bool isForce = false);
		public override void SetIconRateManual(int buttonIndex, float rate, bool isForce = false);
		public override float GetIconRate();
		public override void Visible(bool b);
		public override bool IsVisible();
		public override void Validate(bool b, bool force = false);
		public override void SetCount(int buttonType, int n);
		public override void ChangeButton(int buttonType, bool isImmediate = false);
		public override int GetButtonType();
		public override bool IsReadyAnim();
		public override void SetupReadyAnim(Material frameMat);
		public override void SetVisibleReadyAnim(bool b);
		public override bool IsActiveReadyAnim();
		public override void OnUpdateReadyAnimFlash(float value);
		public override void SetChangeAnim();
		public override bool IsChangeAnim();
		public override void SetOnClick(int buttonType, Action onClick);
		public override void CopyDara(ManagementMultipleButtonData data);
		public override void ApplyData(ManagementMultipleButtonData data);
		[CompilerGenerated]
		private void _Show_b__23_0(float t);
		[CompilerGenerated]
		private void _Show_b__23_1();
		[CompilerGenerated]
		private void _Hide_b__24_0(float t);
		[CompilerGenerated]
		private void _Hide_b__24_1();
		[CompilerGenerated]
		private void _ChangeButton_b__32_0(float t);
		[CompilerGenerated]
		private void _ChangeButton_b__32_1();
	}
}
