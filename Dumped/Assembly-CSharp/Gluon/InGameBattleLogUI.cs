/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		private RectTransform _infoRt;
		[SerializeField]
		private SpriteRenderer _bgImage;
		[SerializeField]
		private UnityEngine.UI.Text _simpleText;
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
		[Range]
		[SerializeField]
		[Tooltip]
		private float _fastAnimTimeScale;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _fastWaitTimeScale;
		private InGameBattleLogCtrl _logCtrl;
		private VisibleUIObject _rootVisible;
		private Sequence _seqShow;
		private Sequence _seqMove;
		private Sequence _seqHide;
		private int _displayIndex;
		private bool _isLeft;
		private float _waitTime;
		private const float LayoutBgPosX = 0f;
		private const float LayoutBgPosX_L = 422f;
		private const float LayoutInfoPosX = 150f;
		private const float LayoutInfoPosX_L = 300f;
		private const float LayoutSimpleTextAdjustPosX = -70f;
		private const float LayoutSimpleTextAdjustPosX_L = 35f;
	
		// Constructors
		public InGameBattleLogUI();
	
		// Methods
		public static InGameBattleLogUI Create(InGameBattleLogCtrl logCtrl, GameObject prefab, GameObject parent, int index, int siblingIndex = -1);
		private void Initialize(InGameBattleLogCtrl logCtrl, int index);
		private void OnDestroy();
		public override void FastUpdate();
		public bool Show([IsReadOnly] in InGameBattleLogCtrl.LogData data);
		public void Hide(bool force = false);
		public bool IsVisible();
		public bool IsShowAnim();
		public bool IsHideAnim();
		public void Move(int index);
		public void SetLayout(bool isLeft);
		private void SetFade(float fade);
		private void SetFade(ref SpriteRenderer sprite, float fade);
		private void SetFade(ref UnityEngine.UI.Text text, float fade);
		private void CreateActionShow();
		private void CreateActionMove(int index);
		private void CreateActionHide();
		[CompilerGenerated]
		private void _CreateActionShow_b__40_1(float a);
		[CompilerGenerated]
		private void _CreateActionShow_b__40_0();
		[CompilerGenerated]
		private void _CreateActionMove_b__41_0();
		[CompilerGenerated]
		private void _CreateActionHide_b__42_1(float a);
		[CompilerGenerated]
		private void _CreateActionHide_b__42_0();
	}
}
