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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class WalkerQuestButton : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform rootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform offsetRt;
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
		private Button photoButton;
		[SerializeField]
		[Tooltip]
		private Button backButton;
		[SerializeField]
		[Tooltip]
		private Button hideButton;
		private VisibleUIObject rootVisible;
		private VisibleUIObject playModeVisible;
		private VisibleUIObject photoModeVisible;
		private VisibleUIObject playModeInvalidVisible;
		private VisibleUIObject photoModeInvalidVisible;
		private Tweener _playModeTweener;
		private Tweener _photoModeTweener;
		private Vector2 _originAnchoredPos;
		private Vector2 _originHideButtonPos;
		private Status _status;
		private bool _isLeft;
		private bool _inSide;
		private bool _isShow;
	
		// Nested types
		public delegate void ButtonDelegate(WalkerQuestButton sender);
	
		public enum Status
		{
			PlayMode = 0,
			PhotoMode = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public ButtonDelegate photoClick;
			public WalkerQuestButton __4__this;
			public ButtonDelegate backClick;
			public ButtonDelegate hideClick;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _Initialize_b__0();
			internal void _Initialize_b__1();
			internal void _Initialize_b__2();
		}
	
		// Constructors
		public WalkerQuestButton();
	
		// Methods
		public static WalkerQuestButton Create(GameObject parent, bool isLeft, ButtonDelegate photoClick, ButtonDelegate backClick, ButtonDelegate hideClick, int index = -1);
		private void Initialize(bool isLeft, ButtonDelegate photoClick, ButtonDelegate backClick, ButtonDelegate hideClick);
		public void OnDestroy();
		public override void FastUpdate();
		private void UpdatePos();
		public void Visible(bool b);
		public bool IsVisible();
		public void Show(Status status, bool immediate = false, bool force = false);
		public void Redisplay(bool immediate = false, bool force = false);
		public void Hide(bool immediate = false);
		private void ShowPlayMode(bool isShow, bool immediate);
		private void OnCompleteShowPlayModeIn();
		private void OnCompleteShowPlayModeOut();
		private void OnShowPlayMode(float rate);
		private void ShowPhotoMode(bool isShow, bool immediate);
		private void OnCompleteShowPhotoModeIn();
		private void OnCompleteShowPhotoModeOut();
		private void OnShowPhotoMode(float rate);
		public void SetLayout(bool isLeft, bool force = false);
		public void OnClickScreen();
		[CompilerGenerated]
		private void _ShowPlayMode_b__34_0(float rate);
		[CompilerGenerated]
		private void _ShowPlayMode_b__34_1(float rate);
		[CompilerGenerated]
		private void _ShowPhotoMode_b__38_0(float rate);
		[CompilerGenerated]
		private void _ShowPhotoMode_b__38_1(float rate);
	}
}
