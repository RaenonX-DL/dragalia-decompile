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
	public class WalkerQuestButton : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform offsetRt;
		[SerializeField]
		[Tooltip]
		private RectTransform outSideOffsetRt;
		[SerializeField]
		[Tooltip]
		private RectTransform playModeRt;
		[SerializeField]
		[Tooltip]
		private RectTransform photoModeRt;
		[SerializeField]
		[Tooltip]
		private RectTransform playModeInvalidRt;
		[SerializeField]
		[Tooltip]
		private RectTransform photoModeInvalidRt;
		[SerializeField]
		[Tooltip]
		private RectTransform offsetRt2;
		[SerializeField]
		[Tooltip]
		private RectTransform outSideOffsetRt2;
		[SerializeField]
		[Tooltip]
		private RectTransform photoModeRt2;
		[SerializeField]
		[Tooltip]
		private RectTransform stampButtonRt;
		[SerializeField]
		[Tooltip]
		private RectTransform photoModeInvalidRt2;
		[SerializeField]
		[Tooltip]
		private Button photoButton;
		[SerializeField]
		[Tooltip]
		private Button backButton;
		[SerializeField]
		[Tooltip]
		private Button hideButton;
		[Header]
		[SerializeField]
		[Tooltip]
		private CommonSliderSelection dofSlider;
		[SerializeField]
		[Tooltip]
		private Image dofSliderFillImage;
		[SerializeField]
		[Tooltip]
		private Image dofSliderHandleImage;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text dofSliderValueText;
		[SerializeField]
		[Tooltip]
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
		private Status _status;
		private bool _isLeft;
		private bool _inSide;
		private bool _isShow;
		private bool _isEnableDof;
		private Action<bool> _onChangeEnableDOF;
		private const long DOFMaxValue = 100;
		private const long DOFMinValue = 0;
	
		// Properties
		public RectTransform StampButtonRt { get; }
	
		// Nested types
		public enum Status
		{
			PlayMode = 0,
			PhotoMode = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0
		{
			// Fields
			public Action onClickPhotoMode;
			public WalkerQuestButton __4__this;
			public Action onClickBack;
			public Action onClickHide;
			public Action<float> onChangeDOF;
	
			// Constructors
			public __c__DisplayClass45_0();
	
			// Methods
			internal void _Initialize_b__0();
			internal void _Initialize_b__1();
			internal void _Initialize_b__2();
			internal void _Initialize_b__3(float val);
			internal void _Initialize_b__4();
		}
	
		// Constructors
		public WalkerQuestButton();
	
		// Methods
		public static WalkerQuestButton Create(GameObject parent, bool isLeft, Action onClickPhotoMode, Action onClickBack, Action onClickHide, Action<float> onChangeDOF, Action<bool> onChangeEnableDOF, int index = -1);
		private void SetDofSetting(bool enableDof);
		private void Initialize(bool isLeft, Action onClickPhotoMode, Action onClickBack, Action onClickHide, Action<float> onChangeDOF, Action<bool> onChangeEnableDOF);
		public void OnDestroy();
		public override void FastUpdate();
		private void UpdatePos();
		public void Visible(bool b);
		public bool IsVisible();
		public void Show(Status status, bool immediate = false, bool force = false);
		public void RedisplayForPhotoMode(bool immediate = false, bool force = false);
		public void HideForPhotoMode(bool immediate = false);
		private void ShowPlayMode(bool isShow, bool immediate);
		private void OnCompleteShowPlayModeIn();
		private void OnCompleteShowPlayModeOut();
		private void OnShowPlayMode(float rate);
		private void ShowPhotoMode(bool isShow, bool immediate);
		private void OnCompleteShowPhotoModeIn();
		private void OnCompleteShowPhotoModeOut();
		private void OnShowPhotoMode(float rate);
		public void SetLayout(bool isLeft, bool force = false);
		public void SetODFRate(float rate);
		public float GetDOFRate();
		public void OnClickScreen();
		[CompilerGenerated]
		private void _ShowPlayMode_b__54_0(float rate);
		[CompilerGenerated]
		private void _ShowPlayMode_b__54_1(float rate);
		[CompilerGenerated]
		private void _ShowPhotoMode_b__58_0(float rate);
		[CompilerGenerated]
		private void _ShowPhotoMode_b__58_1(float rate);
	}
}
