/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameBattleLogUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _rootRt;
		[SerializeField]
		private RectTransform _bgRt;
		[SerializeField]
		private RectTransform _charaRt;
		[SerializeField]
		private RectTransform _infoRt;
		[SerializeField]
		private RectTransform _detailTextRt;
		[SerializeField]
		private RectTransform _detailIconRt;
		[SerializeField]
		private RectTransform _detailIconAdjustRt;
		[SerializeField]
		private SpriteRenderer _bgImage;
		[SerializeField]
		private SpriteRenderer _charaImage;
		[SerializeField]
		private SpriteRenderer _charaBgImage;
		[SerializeField]
		private SpriteRenderer _charaFrameImage;
		[SerializeField]
		private SpriteRenderer _charaNumberImage;
		[SerializeField]
		private SpriteRenderer _enemyImage;
		[SerializeField]
		private UnityEngine.UI.Text _titleText;
		[SerializeField]
		private UnityEngine.UI.Text _detailText;
		[SerializeField]
		private UnityEngine.UI.Text _simpleText;
		[SerializeField]
		private SpriteRenderer _detailIcon;
		[SerializeField]
		[Tooltip]
		private float _windowHeight;
		[SerializeField]
		[Tooltip]
		private float _showDuration;
		[SerializeField]
		[Tooltip]
		private float _moveDuration;
		[SerializeField]
		[Tooltip]
		private float _hideDuration;
		[SerializeField]
		[Tooltip]
		private float _waitDuration;
		[SerializeField]
		[Tooltip]
		private float _showDurationBR;
		[SerializeField]
		[Tooltip]
		private float _moveDurationBR;
		[SerializeField]
		[Tooltip]
		private float _hideDurationBR;
		[SerializeField]
		[Tooltip]
		private float _waitDurationBR;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _fastAnimTimeScale;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _fastWaitTimeScale;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _optionWaitTimeScaleFast;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _optionWaitTimeScaleSlow;
		private InGameBattleLogCtrl _logCtrl;
		private VisibleUIObject _rootVisible;
		private VisibleUIObject _detailIconVisible;
		private Sequence _seqShow;
		private Sequence _seqMove;
		private Sequence _seqHide;
		private int _displayIndex;
		private bool _isLeft;
		private float _waitTime;
		private bool isPlayingBR;
		private static readonly Color BuffTextColor;
		private static readonly Color DebuffTextColor;
		private const float LayoutBgPosX = 0f;
		private const float LayoutBgPosX_L = 422f;
		private const float LayoutCharaPosX = 46f;
		private const float LayoutCharaPosX_L = 376f;
		private const float LayoutInfoPosX = 150f;
		private const float LayoutInfoPosX_L = 300f;
		private const float LayoutSimpleTextAdjustPosX = -70f;
		private const float LayoutSimpleTextAdjustPosX_L = 35f;
		private const float LayoutDetailIconAdjustPosX = -37f;
		private const float LayoutDetailIconAdjustPosX_L = 37f;
		private const string FormatIconTagText = "{battlelog_icon}";
		private const string FormatIconTagReplaceText = "    ";
		private const string FormatIconTagReplaceText_ZH_TW = "     ";
		private const string FormatPercentTagText = "{0:P0}";
		private const string FormatDefaultTagText = "{0}";
		private static readonly Dictionary<ActionTargetGroup, string[]> FormatBuffLabelList;
		private static readonly Dictionary<ActionTargetGroup, string[]> FormatDebuffLabelList;
		private static readonly Dictionary<ActionTargetGroup, string[]> FormatAbilityPlusLabelList;
		private static readonly Dictionary<ActionTargetGroup, string[]> FormatAbilityMinusLabelList;
		private static readonly Dictionary<AbnormalStatusType, string> FormatAbnormalLabelList;
	
		// Nested types
		private enum FormatLabelType
		{
			Percent = 0,
			Text = 1,
			Num = 2
		}
	
		// Constructors
		public InGameBattleLogUI();
		static InGameBattleLogUI();
	
		// Methods
		public static InGameBattleLogUI Create(InGameBattleLogCtrl logCtrl, GameObject prefab, GameObject parent, int index, int siblingIndex = -1);
		private void Initialize(InGameBattleLogCtrl logCtrl, int index);
		private void OnDestroy();
		public override void FastUpdate();
		public bool Show([IsReadOnly] in InGameBattleLogCtrl.LogData data);
		private string GetDetailFormatText([IsReadOnly] in InGameBattleLogCtrl.LogData data, out Color color, out bool isDisplayText);
		public void Hide(bool force = false);
		public bool IsVisible();
		public bool IsShowAnim();
		public bool IsHideAnim();
		public void Move(int index);
		public void SetLayout(bool isLeft);
		private void SetFade(float fade);
		private void SetFade(ref SpriteRenderer sprite, float fade);
		private void SetFade(ref UnityEngine.UI.Text text, float fade);
		private void VisibleCharaImages(bool visible);
		private void VisibleCharaNumberImages(bool visible);
		private void VisibleEnemyImages(bool visible);
		private void CreateActionShow();
		private void CreateActionMove(int index);
		private void CreateActionHide();
		[CompilerGenerated]
		private void _CreateActionShow_b__81_1(float a);
		[CompilerGenerated]
		private void _CreateActionShow_b__81_0();
		[CompilerGenerated]
		private void _CreateActionMove_b__82_0();
		[CompilerGenerated]
		private void _CreateActionHide_b__83_1(float a);
		[CompilerGenerated]
		private void _CreateActionHide_b__83_0();
	}
}
