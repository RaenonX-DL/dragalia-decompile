/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSkillButton : QuestSkillButtonBase
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform _rootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _invalidRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _noUseRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _offsetRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _effectRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _shadowRt;
		[SerializeField]
		[Tooltip]
		private RectTransform[] _countRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _readyAnimFrameRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _changeAnimRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _changeAnimMaxLevelRt;
		[SerializeField]
		[Tooltip]
		private InGameAnimUI _changeAnimGlowUI;
		[SerializeField]
		[Tooltip]
		private InGameAnimUI _changeAnimFlareUI;
		[SerializeField]
		[Tooltip]
		private InGameAnimUI[] _changeAnimGlitterUI;
		[SerializeField]
		[Tooltip]
		private InGameAnimUI _changeAnimIconUI;
		[SerializeField]
		[Tooltip]
		private Button _button;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _iconImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _changeAnimIconImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _effectImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _readyAnimFrameImage;
		[Header]
		[SerializeField]
		[Tooltip]
		private float _expansionTime;
		[SerializeField]
		[Tooltip]
		private int _flashCount;
		[SerializeField]
		[Tooltip]
		private float _flashTime;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _maxFlashPower;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _readyAnimMaxFlashPower;
		[SerializeField]
		[Tooltip]
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
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public Action<QuestSkillButtonBase> onClick;
			public QuestSkillButton __4__this;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _Initialize_b__0();
		}
	
		// Constructors
		public QuestSkillButton();
	
		// Methods
		public static QuestSkillButton Create(GameObject parent, int index, Action<QuestSkillButtonBase> onClick, bool isLeft);
		public void Initialize(Action<QuestSkillButtonBase> onClick, bool isLeft);
		public void OnDestroy();
		public override void FastUpdate();
		public override bool ApplyIcon(InGameUIConst.QuestSkillType type);
		public bool LoadIcon(string[] iconNames);
		public override bool ChangeIcon(int iconIndex, bool isForce, bool isFlashAnim = true);
		public override int GetIconNum();
		public override int GetIconIndex();
		private void SetIconRate(float rate, bool isForce = false, bool isAnim = true);
		public override void SetIconRateManual(float rate, bool isForce = false);
		public override float GetIconRate();
		public override void Visible(bool b);
		public override bool IsVisible();
		public override void Validate(bool b, bool force = false);
		private void CheckInvalidObj();
		public override int GetCount();
		public override void SetCount(int n);
		public override int GetMaxCount();
		public override void SetUnlimited();
		public override bool IsUnlimited();
		public override void SetReadyAnim(ReadyAnimType type);
		public override bool IsReadyAnim();
		public override void SetupReadyAnim(Material frameMat);
		public override void SetVisibleReadyAnim(bool b);
		public override bool IsActiveReadyAnim();
		public override void OnUpdateReadyAnimFlash(float value);
		public override void SetChangeAnim();
		public override bool IsChangeAnim();
		private void PlayChangeAnim();
		private void StopChangeAnim();
		private void OnCompleteChangeAnim();
		private void PlayExpansionAnim();
		private void OnUpdateExpansion(float value);
		private void OnCompleteExpansion();
		private void OnUpdateButtonEffectFlash(float value);
		public override void SetOnClick(Action onClick);
		public override void CopyData(ManagementMultipleIconData data);
		public override void ApplyData(ManagementMultipleIconData data);
	}
}
